Warehouse Pickup Notification

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
