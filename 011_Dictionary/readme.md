# Dictionary

## Oppimistavoitteet

- Osaat luoda `Dictionary`-tietorakenteen Windows Forms -sovelluksessa.
- Osaat lisätä Key/Value-pareja käyttöliittymän kautta.
- Osaat hakea arvoja avaimen (Key) perusteella ja näyttää ne lomakkeessa.

## Tehtävä

Tee Windows Forms -ohjelma, jossa on toiminnot dictionaryn luontiin, Key/Value-parien lisäämiseen sekä haettujen arvojen näyttämiseen (Kuva 1).

## Tarvittavat komponentit ja tapahtumat

- `Button`:
	- `Luo Dictionary`
	- `Lisää`
	- `Hae`
- `TextBox`:
	- Key ja Value lisäystä varten
	- Key hakua varten
- `Label`: haetun arvon näyttäminen

Keskeiset asiat:

- `Dictionary<string, string>` formin kenttänä
- `Add(...)` tai indeksointi lisäykseen
- `TryGetValue(...)` turvalliseen hakuun ilman poikkeusta

![kuva](kuvat/dictionary01.png)

Kuva 1. Pääformi

## Vaiheet

### a) Dictionaryn luonti

- Luo dictionary, kun käyttäjä painaa **Luo Dictionary** -painiketta.
- Tallenna sinne `string`-tyyppisiä Key/Value-pareja.
- Testaa debuggerilla, että dictionary syntyy oikein.

### b) Key/Value-parien lisääminen

- Kun käyttäjä syöttää Key- ja Value-kenttiin arvot ja painaa **Lisää**, lisää pari dictionaryyn.
- Varmista debuggerilla, että pari tallentuu oikein.

### c) Haku Key-arvolla

- Tee toiminto, jolla käyttäjä voi hakea arvon kirjoittamalla Key:n.
- Tulosta löytynyt Value lomakkeen `Label`-komponenttiin.
