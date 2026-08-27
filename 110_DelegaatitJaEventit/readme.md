# Delegaatit ja eventit

Olemme tähän asti käyttäneet Winformsin omia tapahtumia (eventtejä) ja tapahtumien käsittelijöitä (event handlers), jotka toimivat ohjelmamme taustalla. Tapahtumat pohjautuvat .NETin delegaattisysteemiin, joka on osa ns. [observer design patternia](https://learn.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern). Hyvänä analogiana voisi olla Youtuben kanava, jota voit seurata (hit that subscribe button). Seuraajia voi olla 0-N kappaletta ja kaikkia saavat ilmoituksen kun kanavalle tulee uutta sisältöä.

Seuraavaksi pääset harjoittelemaan omien delegaattien ja eventtien luomista. Sinulla on kaksi vaihtoehtoista tehtävää: Warehouse Notification System tai Game Scoring System. Molemmat opettavat samoja konsepteja, mutta eri kontekstissa.

## Teoria

# Teoriaa: omat delegaatit ja eventit

## Oppimistavoitteet

- Ymmärrät, mikä delegaatti on ja mihin sitä käytetään.
- Osaat luoda oman delegaatin ja liittää siihen metodeja.
- Ymmärrät, miten eventit perustuvat delegaatteihin.
- Osaat julkaista eventin ja kuunnella sitä.
- Tunnistat yleiset virheet tapahtumankäsittelijöiden kanssa.

## Miksi delegaatti?

Delegaatti on muuttuja, joka viittaa metodiin. Se mahdollistaa sen, että metodia voidaan käsitellä datana: siirtää, tallentaa ja kutsua myöhemmin. Tämä on hyödyllistä esimerkiksi silloin, kun haluat antaa jonkin toisen osan ohjelmasta päättää, mitä tehdään, mutta itse et tiedä vielä valmiiksi mitä metodia kutsutaan.

## Perustyypit ja viitetyypit

Arvotyypit kopioidaan metodikutsussa, viitetyypit välitetään viittauksena samaan olioon.

| Perustyyppi (built-in type) | Vastaavan olion luokka |
| --------------------------- | ---------------------- |
| bool                        | System.Boolean         |
| byte                        | System.Byte            |
| sbyte                       | System.SByte           |
| char                        | System.Char            |
| decimal                     | System.Decimal         |
| double                      | System.Double          |
| float                       | System.Single          |
| int                         | System.Int32           |
| uint                        | System.UInt32          |
| nint                        | System.IntPtr          |
| nuint                       | System.UIntPtr         |
| long                        | System.Int64           |
| ulong                       | System.UInt64          |
| short                       | System.Int16           |
| ushort                      | System.UInt16          |

Viitetyyppejä ovat esimerkiksi:

| Perustyyppi (referenssi) | Vastaavan olion luokka |
| ------------------------- | ---------------------- |
| object                   | System.Object          |
| string                   | System.String          |
| dynamic                  | System.Object          |

## Delegaatin rakenne

Delegaatin allekirjoitus kertoo, millaisen metodin siihen voi liittää.

```csharp
// Delegaatti, joka viittaa metodiin: void Metodi(string viesti)
public delegate void ViestiKasittelija(string viesti);
```

Metodi, joka sopii delegaattiin, koska se on `void` ja ottaa yhden `string`-parametrin:

```csharp
public static void Tulosta(string viesti)
{
    Console.WriteLine(viesti);
}
```

Käyttö:

Tässä luodaan delegaatti-objekti ja liitetään siihen metodi `Tulosta`. Nyt `kasittelija`-muuttuja toimii ikään kuin "osoittimena" `Tulosta`-metodiin, ja voimme kutsua sitä kuten metodia. Tämä on delegaattien perusidea. Ne antavat mahdollisuuden kutsua metodia, joka määritellään myöhemmin.

```csharp
ViestiKasittelija kasittelija = Tulosta;
kasittelija("Hei maailma");
```

### Useampi metodi samaan delegaattiin (multicast)

Delegeaatti voi viitata useampaan metodiin. Tällöin kaikki metodit kutsutaan peräkkäin, kun delegaattia käytetään.

```csharp
public static void TallennaLokiin(string viesti)
{
    Console.WriteLine($"Loki: {viesti}");
}

// Luodaan delegaatti ja liitetään siihen yllä olevan esimerkin Tulosta-metodi
ViestiKasittelija kasittelija = Tulosta;

kasittelija += TallennaLokiin; // Toisen metodin lisäämiseen tarvitaan +=-operaattoria, joka lisää uuden metodin delegaattiin ilman, että edellinen menetetään.

// Nyt käsittelija kutsuu molempia metodeja peräkkäin
kasittelija("Tallennus valmis");
```


### Action ja Func

Sinun ei tarvitse aina määritellä omaa delegaattityyppiä. .NET tarjoaa valmiiksi määritellyt `Action` ja `Func`-delegaatit, jotka kattavat yleisimmät tapaukset ja tekevät koodista selkeämpää.

- `Action` palauttaa `void`
- `Func` palauttaa arvon

```csharp
// Action<string> tarkoittaa delegaattia, joka viittaa metodiin, jotka ottavat yhden string-parametrin ja palauttavat void.
Action<string> tulostus = Tulosta;
tulostus("Action toimii");

// Alla olevan syntaksi voi olla hieman vaikea ymmärtää, mutta se tarkoittaa delegaattia, joka viittaa metodiin, jotka ottavat kaksi int-parametria ja palauttavat int-arvon. =>-operaattori korvaa return-lauseen, joka palauttaa a + b:n summan.
Func<int, int, int> summa = (a, b) => a + b; 
Console.WriteLine(summa(2, 3));
```

## Eventit

Eventit eli tapahtumat perustuvat delegaattien päälle. Eventti on eräänlainen "turvallisempi" delegaatti, joka rajoittaa sitä, kuka voi laukaista tapahtuman. Eventin voi julkaista (invoke) vain luokka, joka määrittelee sen, mutta kuka tahansa voi tilata kyseisen tapahtuman (subscribe) ja kuunnella tapahtumia, jos tapahtuman näkyvyysmääre on julkinen (public).

```csharp

### Yksinkertainen event

```csharp
public class LampotilaVahti
{
    // Eventti, joka ilmoittaa lämpötilan muutoksesta. Action<int> tarkoittaa, että tapahtuma viittaa metodiin, jotka ottavat yhden int-parametrin (uusi lämpötila) ja palauttavat void.
    public event Action<int> LampotilaMuuttui;

    private int lampotila;

    public void AsetaLampotila(int uusiLampotila)
    {
        lampotila = uusiLampotila;
        // Laukaistaan eventti, jos lampotilaMuuttui ei ole null, eli jos joku kuuntelee sitä.
        LampotilaMuuttui?.Invoke(lampotila); 
    }
}
```

Käyttö koodissa:

```csharp
LampotilaVahti vahti = new LampotilaVahti();

void NaytaLampotila(int lampotila)
{
    Console.WriteLine($"Uusi lämpötila: {lampotila}");
}

// NaytaLampotila-metodi kuuntelee tapahtumaa
vahti.LampotilaMuuttui += NaytaLampotila; 

// Aseta uusi lampotila, joka laukaisee tapahtuman käyttäen LampotilaMuuttui eventin Invoke-metodia. Action ei palauta arvoa, joten se on void.
vahti.AsetaLampotila(22);

// Lopetetaan kuuntelu
vahti.LampotilaMuuttui -= NaytaLampotila;
vahti.AsetaLampotila(25); // Ei tulostusta, koska kuuntelu poistettiin
```

### EventHandler ja omat EventArgs-luokat

Joskus voi olla hyödyllistä luoda oma EventArgs-luokka, joka sisältää tietoa tapahtumasta. Tällöin eventti määritellään tyyppinä `EventHandler<TEventArgs>`. Oikean elämä esimerkki voisi olla seuraavanlainen, jossa tapahtuma kertoo tilamuutoksesta vanhan ja uuden tilan. Oikeasti tämä voisi olla vaikkapa "PelaajaTilastoMuuttuiEventArgs", joka sisältää vanhan ja uuden tilaston, joita tilamuutoksen yhteydessä halutaan välittää.

```csharp
public class TilaMuuttuiEventArgs : EventArgs
{
    public string VanhaTila { get; }
    public string UusiTila { get; }

    public TilaMuuttuiEventArgs(string vanha, string uusi)
    {
        VanhaTila = vanha;
        UusiTila = uusi;
    }
}

public class TilaVahti
{
    public event EventHandler<TilaMuuttuiEventArgs> TilaMuuttui;

    public void PaivitaTila(string vanha, string uusi)
    {
        // Lähetetään tapahtuma, jossa this on lähettäjä ja uusi EventArgs-olio sisältää vanhan ja uuden tilan.
        TilaMuuttui?.Invoke(this, new TilaMuuttuiEventArgs(vanha, uusi));
    }
}
```

### Eventtien irrottaminen ja muistinhallinta

Jos lomake tai objekti tilaa tapahtuman, on erittäin tärkeää, että se myös peruu tilauksen, kun sitä ei enää tarvita. Tämä tapahtuu käyttämällä `-=`-operaattoria. Jos et peru tilauksia, tapahtuman julkaiseva objekti pitää viittauksen kuuntelijaan muistissa, mikä voi johtaa muistivuotoon.

```csharp
// Oletetaan, että vahti on pitkäikäinen objekti ja kasittelija on lomake, joka suljetaan.
vahti.LampotilaMuuttui -= kasittelija;
```


**Muistivuoto käytännössä:**

```csharp
public class Pelaaja
{
    public event Action<int> PisteetMuuttuivat;
    public void AnnaPiste() => PisteetMuuttuivat?.Invoke(10);
}

public class PistetauluLomake : Form
{
    private Pelaaja pelaaja;
    
    public PistetauluLomake(Pelaaja jaettuPelaaja)
    {
        pelaaja = jaettuPelaaja;
        // Tilataan pisteet muuttuivat eventti
        pelaaja.PisteetMuuttuivat += PaivitaPisteet;
    }
    
    private void PaivitaPisteet(int pisteet)
    {
        labelPisteet.Text = pisteet.ToString();
    }
    
    // perutaan tilaus, muuten pelaaja kutsuu tätä metodia ikuisesti, vaikka lomake on suljettu -> muistivuoto
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        
        pelaaja.PisteetMuuttuivat -= PaivitaPisteet;
        base.OnFormClosing(e);
    }
}
```

Jos unohtaisit `-=` rivin, niin pelaaja kutsuu vielä "kuolleen" lomakkeen metodia joka kerta, joka voi johtaa muistivuotoon.

## Windows Forms ja eventit

Kun lisäät tapahtumankäsittelijän Designerissä, Visual Studio luo kaksi asiaa:

1. Metodin `Form1.cs`-tiedostoon
2. Tilauksen `Form1.Designer.cs`-tiedostoon

**Tärkeää:** Jos poistat event handler -metodin, poista myös sen tilaus. Muuten Designer ei käynnisty (tämä on varmasti tullut jo tutuksi, jos olet päässyt tänne asti :) ).

## Lomakkeiden välinen kommunikaatio eventtien avulla

Kun sinulla on useita lomakkeita, joiden pitää kommunikoida keskenään, hyvä käytäntö on **jakaa yhteinen objekti** (esim. Pelaaja, Peli tai Varasto) joka lähettää eventtejä, joita lomakkeet kuuntelevat. Näin lomakkeet eivät ole suoraan yhteydessä toisiinsa, vaan kommunikoivat tapahtumien kautta. Tämä tekee koodista joustavampaa ja helpommin ylläpidettävää. 

Alla olevassa esimerkissä `Peli`-luokka julkaisee tapahtuman, jota `SaavutusLomake`-luokka kuuntelee. `PaaLomake`-luokka voi tehdä muutoksia peliin, jotka laukaisevat tapahtuman, mutta se ei tiedä, kuka kuuntelee tapahtumia.

```csharp

public class Peli
{
    public event Action<string> SaavutusUnlocked;
    
    public void PeliEtenee()
    {
        SaavutusUnlocked?.Invoke("Ensimmäinen piste!");
    }
}

// Päälomake avaa muita lomakkeita
public class PaaLomake : Form
{
    private Peli peli = new Peli();
    
    private void buttonAvaaLomake_Click(object sender, EventArgs e)
    {
        // Jaa peli-objekti toiselle lomakkeelle!
        SaavutusLomake saavutus = new SaavutusLomake(peli);
        saavutus.Show();

        peli.PeliEtenee(); // Tämä laukaisee tapahtuman, joka saa SaavutusLomakkeen näyttämään notifikaation
    }
}

// Saavutuslomake saa jaetun peli-objektin
public class SaavutusLomake : Form
{
    private Peli peli;
    
    public SaavutusLomake(Peli jaettuPeli)  // Vastaanota jaettu objekti
    {
        peli = jaettuPeli;
        peli.SaavutusUnlocked += NaytaSaavutus;  // Kuuntele tapahtumia
    }
    
    private void NaytaSaavutus(string saavutus)
    {
        label.Text = saavutus;
    }
    
    // Lopetetaan tapahtuman kuuntelu kun lomake suljetaan
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        peli.SaavutusUnlocked -= NaytaSaavutus;  
        base.OnFormClosing(e);
    }
}
```

## Delegaatit parametrin väittämiseksi

Delegaatteja voidaan käyttää parametrien välittämiseen. Esimerkiksi "etsi paras pelaaja" -logiikka on sama riippumatta siitä etsitäänkö pisteet, kuolemat vai saavutukset. 

```csharp
public class PelaajanTilastojenAnalysoija
{
    public delegate int PelaajanTilasto(Pelaaja pelaaja);
    
    public Pelaaja? EtsiTilastonParas(List<Pelaaja> pelaajat, PelaajanTilasto tilasto)
    {
        Pelaaja? parasPelaaja = null; // paras pelaaja alustetaan nulliksi, koska emme vielä tiedä, kuka se on
        int parhaatPisteet = int.MinValue;
        
        foreach (Pelaaja pelaaja in pelaajat)
        {
            // kutsutaan parametrina annettua delegaattia, joka laskee tilaston pelaajalle. Tämä on se kohta, jossa delegaatti todella hyödyllinen, koska sama metodi toimii eri tilastoille.
            int pisteet = tilasto(pelaaja);  
            if (pisteet > parhaatPisteet)
            {
                parhaatPisteet = pisteet;
                parasPelaaja = pelaaja;
            }
        }
        return parasPelaaja;
    }
}

// Käyttö - sama metodi, eri mittareilla
var analysoija = new PelaajanTilastojenAnalysoija();
Pelaaja? parhaatPisteet = analysoija.EtsiTilastonParas(lista, p => p.Pisteet);
Pelaaja? enitenKuolemia = analysoija.EtsiTilastonParas(lista, p => p.Kuolemat);
Pelaaja? enitenSaavutuksia = analysoija.EtsiTilastonParas(lista, p => p.Saavutukset.Count);
```

Jos yllä oleva esimerkki tuntuu monimutkaiselta, se on täysin normaalia. Delegaatit ja eventit ovat abstrakteja konsepteja, jotka vaativat harjoittelua ja aikaa, ennen kuin ne tuntuvat luonnollisilta. Älä huoli, jos et ymmärrä kaikkea heti. Tärkeintä on, että ymmärrät perusidean: delegaatit ovat kuin "osoittimia" metodeihin, ja eventit ovat turvallisempia delegaatteja, joita käytetään tapahtumien julkaisemiseen ja kuuntelemiseen.

## Yleisiä virheitä ja vinkkejä

- Jos eventin kutsu aiheuttaa `NullReferenceException`, käytä aina `?.Invoke(...)`.
- **KRIITTINEN:** Muista aina perua event-tilaukset (`-=`), erityisesti `Form.OnFormClosing` metodissa. Tämä estää muistivuodot.
- Älä sekoita `delegate`-avainsanaa (tyyppi) ja `event`-avainsanaa (kenttä).
- Pidä eventit yksinkertaisina: yksi tapahtuma, yksi tarkoitus.
- [Video delegates](https://www.youtube.com/watch?v=jQgwEsJISy0&ab_channel=ProgrammingwithMosh)
- [Code Project](https://www.codeproject.com/Articles/27898/Delegates-events-and-namespaces-using-C)
- [MS how-to-add-an-event-handler](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines)

## Valitse yksi tehtävistä

### Vaihtoehto 1: Warehouse Pickup Notification

Tehtävänäsi on suunnitella sovellus, jolla merkitään varastolta haettavia tuotteita ja niiden viimeinen hakupäivä. Kun tuotteen hakupäivää edeltävä päivä koittaa, sovelluksessa on toinen lomake, johon tulee ilmoitus haettavasta paketista ja sen sisällöstä. Toteuta sovelluksen päivä-ilmoitus eventti ja sen hallinta itse. ÄLÄ käytä Windows Formsin valmiita eventtejä, vaan luo ne itse.

**Mieti seuraavia asioita:**
* Miten teet päivämäärän valinnan ja manuaalisen testaamisen ilman, että sinun tarvitsee odottaa oikeaa päivää?
* Luo erillinen `Tuote`-luokka (lisäksi HakuForm, NotifikaatioForm), joka kuvastaa varaston tuotetta. Tuotteen ominaisuuksia: nimi, paino, määrä, viimeinen hakupäivä.
* Millä tavalla kaksi lomaketta kommunikoi? NotifikaatioFormissa pitää näkyä notifikaatio kun tuote pitää hakea.

**Vinkki:** Delegaatit ja eventit sopivat tähän ongelmaan hyvin. HakuForm kertoo tuotteen tiedot ja NotifikaatioForm kuuntelee muutoksia ja näytää notifikaatiot.

#### Luokkarakenne (selkeä vastuunjako)

| Luokka | Tyyppi | Vastuu | Tapahtumat | Yhteydet |
| --- | --- | --- | --- | --- |
| `Tuote` | Tietomalli | Säilyttää tuotteen tiedot (nimi, paino, määrä, viimeinen hakupäivä). | Ei omia tapahtumia. | `VarastoPalvelu` käyttää tuotetta datana. |
| `VarastoPalvelu` | Sovelluslogiikka / palvelu | Lisää tuotteita ja tarkistaa, pitääkö noudosta ilmoittaa. | `NoutoIlmoitus : Action<string>` | Omistaa `List<Tuote>`, julkaisee ilmoituksen kuuntelijoille. |
| `HakuForm` | UI (Form) | Lukee käyttäjän syötteet ja kutsuu palvelun metodeja. | Ei julkaise domain-tapahtumia. | Kutsuu `VarastoPalvelu`-olion metodeja. |
| `NotifikaatioForm` | UI (Form) | Tilaa ilmoitukset ja näyttää viestit käyttöliittymässä. | Kuuntelee `NoutoIlmoitus`. | Tilaa alussa, peruu tilauksen suljettaessa (`-=`). |

```text
Miten tapahtuma kulkee? (vaiheittain)

1) Käyttäjä lisää tuotteen HakuFormissa.
2) HakuForm kutsuu VarastoPalvelu.LisaaTuote(...).
3) Käyttäjä testaa päivän (esim. "Seuraava päivä").
4) HakuForm kutsuu VarastoPalvelu.TarkistaNoudot(paiva).
5) VarastoPalvelu käy tuotteet läpi ja laukaisee NoutoIlmoitus-eventin.
6) NotifikaatioForm vastaanottaa viestin ja päivittää UI:n.
```

**Älä tee näin (yleinen virhe):**
- Älä laita noutopäivän laskentaa `HakuForm`iin tai `NotifikaatioForm`iin.
- Älä laukaise domain-eventtejä suoraan Formista ilman palveluluokkaa.

**Yhteenveto:**
- `Tuote` = data.
- `VarastoPalvelu` = säännöt + eventin julkaisu.
- `HakuForm` = syöte + palvelun kutsuminen.
- `NotifikaatioForm` = ilmoituksen näyttö.

### Vaihtoehto 2: Game Scoring System with Delegates

Tämä tehtävä opettaa samoja konsepteja kuin Warehouse, mutta peliympäristössä. Sinulla on `Pelaaja`-luokka joka omistaa delegaatteja eri statistiikoille (pisteet, kuolemat, saavutukset). Sinun tulee ratkaista ongelma siitä, miten useat lomakkeet voivat kuunnella näitä tapahtumia ja reagoida niihin. Esimerkiksi, kun pelaaja saa pisteitä, haluat päivittää tilastolomakkeen ja ehkä näyttää jotain muutakin tietoa.

**Perusversio:**

Luo sovellus jossa:
1. Luodaan 10 pelaajaa satunnaisilla tilastoilla (pisteet, kuolemat, objektiivit)
2. Käyttäjä voi valita "Etsi paras pelaaja" ja valita mittarin (pisteet / kuolemat / objektiivit)
3. Sovellus näyttää parhaan pelaajan kyseisellä mittarilla

**Laajennettu versio (KIITETTÄVÄ):**

Toteuta ratkaisu niin, että `Peli` toimii tapahtumien välittäjänä:

- `Peli` omistaa pelaajalistan.
- `Peli` kuuntelee jokaisen `Pelaaja`-olion muutoksia.
- `Peli` julkaisee sovellustason eventit:
  - `PelaajaSaavutus` (esim. kun pisteet ylittävät 50)
  - `PelaajaTilastoMuuttui`

Luo kaksi lomaketta:

- **PaaLomaKe**: näyttää pelaajat ja tilastot, mahdollistaa pelaajien lisäyksen.
- **SaavutusLomaKe**: kuuntelee vain `Peli`-objektin eventtejä ja näyttää notifikaatiot.

**Huom!:** Lomakkeet eivät kuuntele suoraan yksittäisiä `Pelaaja`-olioita.

**Muistutus:** Tilaa eventit lomakkeen alustuksessa ja peru tilaukset `OnFormClosing`/`Dispose`-metodissa käyttäen `-=`.

**Suositus:** Käytä .NET-mallia `event EventHandler<TEventArgs>`.

#### Luokkarakenne (selkeä vastuunjako)

| Luokka | Tyyppi | Vastuu | Tapahtumat | Yhteydet |
| --- | --- | --- | --- | --- |
| `Pelaaja` | Tietomalli | Ylläpitää yhden pelaajan tilastoja (pisteet, kuolemat, objektiivit). | `TilastoMuuttui : Action<string>` | `Peli` kuuntelee pelaajan muutoksia. |
| `Peli` | Sovelluslogiikka / välittäjä | Omistaa pelaajalistan, kuuntelee pelaajia ja julkaisee sovellustason tapahtumia. | `PelaajaTilastoMuuttui : Action<string>`, `PelaajaSaavutus : Action<string>` | Omistaa `List<Pelaaja>`, toimii välikerroksena lomakkeille. |
| `PaaLomaKe` | UI (Form) | Näyttää pelaajat ja välittää käyttäjän komennot pelille. | Ei julkaise domain-tapahtumia. | Kutsuu `Peli`-olion metodeja. |
| `SaavutusLomaKe` | UI (Form) | Kuuntelee pelin tapahtumia ja näyttää notifikaatiot. | Kuuntelee `PelaajaSaavutus` ja `PelaajaTilastoMuuttui`. | Tilaa alussa, peruu tilauksen suljettaessa (`-=`). |

```text
Miten tapahtuma kulkee? (vaiheittain)

1) Käyttäjä tekee toiminnon `PaaLomaKe`-luokassa (esim. lisää pisteitä).
2) `PaaLomaKe` kutsuu `Peli`-olion metodia.
3) `Peli` päivittää oikean `Pelaaja`-olion tilaa.
4) `Pelaaja` laukaisee oman muutostapahtuman.
5) `Peli` kuuntelee muutoksen ja julkaisee sovellustason eventin.
6) `SaavutusLomaKe` vastaanottaa eventin ja päivittää UI:n.
```

**Älä tee näin (yleinen virhe):**

- Älä päivitä `SaavutusLomaKe`-UI:ta suoraan `PaaLomaKe`-luokasta.
- Älä laita saavutuslogiikkaa (esim. "yli 50 pistettä") Form-luokkiin.

**Yhteenveto:**

- `Pelaaja` = yhden pelaajan tila ja muutokset.
- `Peli` = sovellustason logiikka ja eventtien välitys.
- `PaaLomaKe` = käyttäjän toiminnot + pelin komentaminen.
- `SaavutusLomaKe` = notifikaatioiden näyttö.
