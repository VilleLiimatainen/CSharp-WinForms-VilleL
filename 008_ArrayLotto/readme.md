# ArrayLotto

## Tarvittavat komponentit ja tapahtumat

- `Button` (`Arvo`): käynnistää arvonnan `Click`-eventissä
- `Label`: arvottujen numeroiden tulostus
- 7 x `TextBox`: käyttäjän omat numerot
- `Label`: montako numeroa osui oikein

Keskeiset asiat:

- `Random` satunnaislukuihin
- `int[]` päänumeroille ja lisänumeroille
- duplikaattien esto ilman valmista `Contains`-polkua (ensisijaisesti silmukalla)
- numerot järjestykseen ennen tulostusta

## Vaihe 1: Arvo lottonumerot

- Tee lomake jolle arvot lottorivin rivin napin painalluksella.
- Arvo numerot kokonaislukutaulukkoon (int[]) käyttämällä Random luokkaa ja tulostamalla taulukko lomakkeelle yhdelle label –elementille.
- Lotossa arvotaan 7 numeroa ja 2 lisänumeroa numeroiden 1-40 joukosta.
- Kuinka huomioit ettei sama numero voi tulla kahdesti? Ts. kun pallo on arvottu, sitä ei voi arpoa uudestaan.
- **Älä käytä Contains –metodia** ratkaisussasi ellet lainkaan pääse eteenpäin ilman sitä.


## Vaihe 2: Näytä numerot graafisessa muodossa

Näytä numerot pilkulla eroteltuna pienimmästä suurimpaan jossain graafisessa komponentissa esim. yhdessä tai useammassa labelissa. Huomaa että lisänumerot arvotaan erikseen. Älä siis vain luettele kahta suurinta numeroa lisänumeroina.

## Vaihe 3: Tarkista käyttäjän numerot

Lisää 7 tekstikenttää mihin käyttäjä voi lisätä omat numerot ja ohjelma tarkistaa kuinka monta numeroa vastaa arvottua riviä.

**HUOM!** Tämä tehtävä on haastava johtuen siitä että siinä käytetään vain taulukoita.
numeroiden tallentamiseen. Mieti mitä taulukoita tarvitset, jotta samoja palloja
ei arvota uudestaan. Älä pelkää tehdä uusia taulukoita tarvittaessa.
