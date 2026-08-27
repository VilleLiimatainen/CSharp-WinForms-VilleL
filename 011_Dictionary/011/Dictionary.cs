namespace _011
{
    public partial class Dictionary : Form
    {
        private Dictionary<string, string> _kirjasto = new Dictionary<string, string>();

        public Dictionary()
        {
            InitializeComponent();
        }
        
        private void btnLuoDictionary_Click(object sender, EventArgs e)
        {
            CreateDictionary();
        }

        private void CreateDictionary()
        {
            _kirjasto["t"] = "Dictionary luotu";
            System.Windows.Forms.MessageBox.Show(_kirjasto["t"], "Dictionary testi");
            _kirjasto.Clear();
        }
        
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            AddDictionaryEntry();
        }

        private void AddDictionaryEntry()
        {
            if (CheckTextboxInput(tbKey) && CheckTextboxInput(tbValue))
            {
                string key = tbKey.Text;
                string value = tbValue.Text;
                _kirjasto[key] = value;
                foreach (TextBox tb in gbLisataanElementteja.Controls.OfType<TextBox>())
                {
                    tb.Clear();
                }
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            SearchValueByKey();
        }

        private void SearchValueByKey()
        {
            if (CheckTextboxInput(tbKeyHae))
            {
                string key = tbKeyHae.Text;
                if (_kirjasto.ContainsKey(key))
                {
                    labelAuto.Text = _kirjasto[key];
                    labelAuto.Update();
                    tbKeyHae.Clear();
                }
                else 
                {
                    VirheSyotteessa("ei sisällä kirjastosta löytyviä arvoja");
                }
            }
        }

        private bool CheckTextboxInput(TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                VirheSyotteessa("on tyhjä");
                return false;
            }
            else
            {
                return true;
            }
        }

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
