# Yksinkertainen laskin

## Oppimistavoitteet

- Osaat toteuttaa peruslaskimen Windows Forms -sovelluksena.
- Osaat käsitellä napin painalluksia yhdellä tapahtumankäsittelijällä.
- Osaat siirtää laskentaa erilliseen luokkaan.
- Osaat huomioida yksinkertaisia virhetilanteita.

## Tavoite

Tee peruslaskinsovellus Windows Forms -ympäristössä. Toteuta sovellus huolellisesti ja testaa perustoiminnot.

## Vaihe 1: käyttöliittymä

- Lisää napit numeroille (0–9), operaatioille (+, -, *, /), yhtäsuuruudelle (=) ja tyhjennykselle.
- Järjestä komponentit selkeään ruudukkoon.
- Voit katsoa mallia Windowsin Laskin-sovelluksesta.

## Vaihe 2: komponenttien ominaisuudet

- Aseta Nimi-ominaisuus jokaiselle napille, jotta niitä on helpompi viitata koodissa (esim. btn1, btnPlus, btnEquals).
- Aseta Teksti-ominaisuus napeille näyttääksesi sopivat symbolit tai numerot.
- Aseta TekstinTasaus-ominaisuus Tekstilaatikolle jotta teksti istuu hyvin nappiin

## Vaihe 3: Toteuta tapahtumankäsittelijät

- Liitä joka napille sama event.
- Tapahtumankäsittelijässä kirjoita koodi päivittääksesi Tekstilaatikon sisältöä napin perusteella.
- Numero-napeille liitä luku nykyiseen syötteeseen.
- Operaatio-napeille tallenna nykyinen syöte ensimmäisenä operandina ja aseta nykyinen operaatio.
- Tee varsinaninen laskenta erillisessä Laskuri -luokassa. Mieti miten välität sille tarvittavat tiedot. Yhtäsuuruusnappi syöttää tiedot Laskurille ja ottaa vastaan tuloksen. Näytä tulos tekstilaatikossa.

## Vaihe 4: Käsittele erityistapaukset

- Toteuta virheenkäsittely kuten nollalla jakaminen.
- Tyhjennä näyttö laskennan jälkeen.
- Harkitse nollausnappulan lisäämistä laskimen nollaamiseksi.

## Vaihe 5: Testaa laskinta

- Testaa jokaisen napin toiminnallisuus ja varmista, että laskin suorittaa perusaritmeettiset operaatiot oikein.
- Tarkista mahdolliset odottamattomat toiminnot tai virheet.

Tämä tehtävä antaa sinulle käytännön kokemusta yksinkertaisen Windows Forms -sovelluksen luomisesta, tapahtumien käsittelystä ja perusaritmeettisten operaatioiden toteuttamisesta. Hauskaa koodausta!
