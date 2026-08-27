using Accessibility;

namespace _008
{
    public partial class ArrayLotto : Form
    {
        private int[] _lottoRivi = new int [7];
        private int[] _lisaNumerot = new int [2];
        private List<int> _mahdollisetNumerot = new List<int> ();
        private Random _rnd = new Random ();
        private int[] _omatNumerot = new int [7];
        private bool _riviValidointi = false;
        private string _virheViesti;
        public ArrayLotto()
        {
            InitializeComponent();
        }
        // Olen tietoinen että erillisillä luokilla tämä olisi siistimpi mutta en jaksanut siirrellä methodeja
        private void btnArpaNappula_Click(object sender, EventArgs e)
        {
            labelNumerot.Text = "Ei vielä numeroita";
            OmatNumerot();
            if (_riviValidointi == true)
            {
                RivinLuoti();
                KirjoitaLabelLottoRivi();
                Tulokset();
            }
        }

        private void KirjoitaLabelLottoRivi()
        {
            labelNumerot.Text = "";
            int lastNumber = _lottoRivi[6];
            foreach (int i in _lottoRivi)
            {
                labelNumerot.Update();
                Thread.Sleep(100);
                if (i != lastNumber)
                {
                    labelNumerot.Text += i + ", ";
                }
                else
                {
                    labelNumerot.Text += i;
                }
            }
            labelNumerot.Text += "\n";
            lastNumber = _lisaNumerot[1];
            foreach (int i in _lisaNumerot)
            {
                labelNumerot.Update();
                Thread.Sleep(100);
                if (i != lastNumber)
                {
                    labelNumerot.Text += i + ", ";
                }
                else
                {
                    labelNumerot.Text += i;
                }
            }
        }

        private void RivinLuoti()
        {
            labelNumerot.Text = "";
            _mahdollisetNumerot = Enumerable.Range(1, 40).ToList();
            IEnumerable<int> lottoRivi = ArpaKone(9, 40);

            List<int> valiLista = lottoRivi.ToList();
            for (int i = 0; i < 2; i++)
            {
                int siirrettaNumero = valiLista.Count() - 1;
                _lisaNumerot[i] = valiLista[siirrettaNumero];
                valiLista.RemoveAt(siirrettaNumero);
            }
            _lottoRivi = valiLista.ToArray();

            _lottoRivi.Sort();
            _lisaNumerot.Sort();
        }

        // Fisher-yates shuffle arpakone
        private IEnumerable<int> ArpaKone(int maara, int maxValue)
        {
            for (int i = 0; i < maara; i++)
            {
                var index = _rnd.Next(i, 40);
                yield return _mahdollisetNumerot[index];
                _mahdollisetNumerot[index] = _mahdollisetNumerot[i];
            }
        }

        // Katsoo omat numerot ja validoi ne
        // Jos syöte jossain textboxissa ei ole validi ohjelma ei jatku ja laittaa message boxin
        private void OmatNumerot()
        {
            int omaNumero;
            int i = 0;
            List<int> valiLista = new List<int>();
            _riviValidointi = true;
            foreach (TextBox tb in groupBoxOmatNumerot.Controls.OfType<TextBox>())
            {
                if (IsValidTest(tb.Text))
                {
                    omaNumero = int.Parse(tb.Text);
                    _omatNumerot[i] = omaNumero;
                    i++;
                }
                else
                {
                    _riviValidointi = false;
                }
            }
            if (_riviValidointi == false)
            {
                // Ohjelma antaa vain yhden virhe viestin ensimmäisestä huomatusta virheestä
                // koska 7 message boxia on hieman rasittavaa sulkea
                // Tiedän että olisi voinut listata kaikki löydetyt virheet jos käyttäisi enemmän aikaa
                VirheSyotteessa(_virheViesti);
            }
        }

        private void Tulokset()
        {
            int oikein = 0;
            int oikeinLisa = 0;
            foreach (int i in _omatNumerot)
            {
                // Käyttää alla olevaa methodia
                if (IsInArray(_lottoRivi, i))
                { oikein++; }
                if (IsInArray(_lottoRivi, i))
                {  oikeinLisa++;}
            }
            if (oikein == 0 && oikeinLisa == 0)
            {
                labelTulokset.Text = $"Et saanut oikein yhtään numeroa!";
            }
            else if (oikeinLisa == 0)
            {
                labelTulokset.Text = $"Sait oikein {oikein} numeroa!";
            }
            else
            {
                labelTulokset.Text = $"Sait oikein {oikein} numeroa \n" +
                    $"ja {oikeinLisa} lisänumeroa!";
            }
            
        }

        // Katsoo onko annetussa taulukossa annettua arvoa, 
        // jos löytyy return on true
        private bool IsInArray(int[] values, int value)
        {
            var index = Array.BinarySearch(values, value);
            return (index >= 0);
        }

        // Testaa onko käyttäjän antama syöte hyväksyttävä
        // Testaa onko tyhjä, numerinen, positiivinen(ainakin 1) ja alle 40
        private bool IsValidTest(string syote)
        {
            if (string.IsNullOrEmpty(syote) == false)
            {
                if (IsPositive(syote))
                {
                    if (IsUnderForty(syote)) { return true; }
                    else { return false; }
                }
                else { return false; }
            }
            else { _virheViesti = "on tyhjä"; return false; }
        }

        // Testaa onko numerinen
        private bool IsNumeric(string syote)
        {
            var IsNumeric = int.TryParse(syote, out int _);
            if (IsNumeric == true) { return true; }
            else
            {
                _virheViesti = "ei ole kokonaisluku";
                return false;
            }
        }

        // Testaa onko annettu luku alle 40
        private bool IsUnderForty(string syote)
        {
            int IsUnder = int.Parse(syote);
            if (IsUnder <= 40)
            {
                return true;
            }
            else
            {
                _virheViesti = "on yli 40";
                return false;
            }
        }

        // Testaa onko positiivinen
        private bool IsPositive(string syote)
        {
            if (IsNumeric(syote))
            {
                int positiveTest = int.Parse(syote);
                if (positiveTest > 0)
                {
                    return true;
                }
                else
                {
                    _virheViesti = "ei ole positiivinen";
                    return false;
                }
            }
            else
            { return false; }
        }

        // Lähettä message boxin käyttäjän naamalle jos syöte ei toimi
        private void VirheSyotteessa(string tyyppi)
        {
            string captionVirhe = "Virhe syötteessä";
            System.Windows.Forms.MessageBox.Show($"Virhe: Syöte {tyyppi}.", captionVirhe,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
        }
    }
}
