using _110.Model;
using _110.Presenter;
using _110.View;
using System.Threading.Channels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _110
{
    public partial class SearchForm : Form, ISearchFormView
    {
        // Button events
        public event EventHandler Add;
        public event EventHandler Cancel;
        public event EventHandler ConfirmAdd;
        public event EventHandler Edit;
        public event EventHandler ConfirmEdit;
        public event EventHandler Remove;
        public event EventHandler CheckLastFetchDay;

        // Selector for combobox
        public event EventHandler SelectionChanged;

        private ISearchFormView _view;
        private Presenter.SearchFormPresenter _presenter;

        private string _errorMessage;
        private string _caption;

        public SearchForm()
        {
            InitializeComponent();

            // Buttons in physical order from top to bottom 
            btnAdd.Click += delegate
            {
                Add?.Invoke(this, EventArgs.Empty);
            };

            btnCancel.Click += delegate
            {
                Cancel?.Invoke(this, EventArgs.Empty);
            };

            btnConfirmAdd.Click += delegate
            {
                ConfirmAdd?.Invoke(this, EventArgs.Empty);
            };

            btnEdit.Click += delegate
            {
                Edit?.Invoke(this, EventArgs.Empty);
            };

            btnConfirmEdit.Click += delegate
            {
                ConfirmEdit?.Invoke(this, EventArgs.Empty);
            };

            btnRemove.Click += delegate
            {
                Remove?.Invoke(this, EventArgs.Empty);
            };

            btnCheckLastFetchDay.Click += delegate
            {
                CheckLastFetchDay?.Invoke(this, EventArgs.Empty);
            };

            // Selector for combobox
            cbProducts.SelectedIndexChanged += delegate
            {
                SelectionChanged?.Invoke(this, EventArgs.Empty);
            };

            DateFormatedGrid.AutoGenerateColumns = false;
            DateFormatedGrid.Columns["ColumnID"].DataPropertyName = "Id";
            DateFormatedGrid.Columns["ColumnProductName"].DataPropertyName = "Name";
            DateFormatedGrid.Columns["ColumnLastFetchDate"].DataPropertyName = "LastFetchDate";
            DateFormatedGrid.Columns["ColumnLastFetchDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Boots presenter
            _presenter = new Presenter.SearchFormPresenter(this, new DelegaatitJaEventitModel());
        }



        // Add button
        public void EnableAddingProducts()
        {
            AddingConfiguration();
        }


        // ConfirmAdd button
        public void ConfirmAdded()
        {
            DefaultConfiguration();
        }


        // Cancel button
        public void CancelInput()
        {
            DefaultConfiguration();
        }


        // Edit button
        public void EditProduct()
        {
            EditingConfiguration();
        }


        // ConfirmEdit button
        public void ConfirmEdited()
        {
            DefaultConfiguration();
        }


        // Remove button
        public void RemoveUsed()
        {
            cbProducts.SelectedIndex = 0;
        }


        // Last fetch day button
        public void CheckLastFetchDatePressed()
        {
            CheckIfFetchTodayTomorrow();
        }



        // Checks if a fetch notification needs to be sent
        private void CheckIfFetchTodayTomorrow()
        {
            foreach (Product product in DateTimeProductList)
            {
                if (product.FetchToday == true)
                {
                    MessageBox.Show($"Product {product.Name} last fetch day is today!", "Fetch Alert!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                if (product.FetchTomorrow == true)
                {
                    MessageBox.Show($"Product {product.Name} last fetch day is tomorrow!", "Fetch Alert!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
            }
        }



        // Configurations
        private void DefaultConfiguration()
        {
            btnAdd.Enabled = true;
            btnCancel.Enabled = false;
            btnConfirmAdd.Enabled = false;

            btnEdit.Enabled = true;
            btnConfirmEdit.Enabled = false;
            btnRemove.Enabled = true;
            btnCheckLastFetchDay.Enabled = true;

            cbProducts.Enabled = true;
            DisableTextboxInputs();
        }


        private void AddingConfiguration()
        {
            btnAdd.Enabled = false;
            btnCancel.Enabled = true;
            btnConfirmAdd.Enabled = true;

            btnEdit.Enabled = false;
            btnConfirmEdit.Enabled = false;
            btnRemove.Enabled = false;
            btnCheckLastFetchDay.Enabled = false;

            cbProducts.Enabled = false;
            EnableTextboxInputs();
        }


        private void EditingConfiguration()
        {
            btnAdd.Enabled = false;
            btnCancel.Enabled = true;
            btnConfirmAdd.Enabled = false;

            btnEdit.Enabled = false;
            btnConfirmEdit.Enabled = true;
            btnRemove.Enabled = false;
            btnCheckLastFetchDay.Enabled = false;

            cbProducts.Enabled = false;
            EnableTextboxInputs();

        }



        // Textbox methods
        private void EnableTextboxInputs()
        {
            ClearTextBoxes();
            foreach (TextBox tb in tblpInputPanel.Controls.OfType<TextBox>())
                tb.Enabled = true;
            dtpInput.Enabled = true;
        }

        private void DisableTextboxInputs()
        {
            ClearTextBoxes();
            foreach (TextBox tb in tblpInputPanel.Controls.OfType<TextBox>())
                tb.Enabled = false;
            dtpInput.Enabled = false;
        }

        private void ClearTextBoxes()
        {
            foreach (TextBox tb in tblpInputPanel.Controls.OfType<TextBox>())
                tb.ResetText();
            dtpInput.ResetText();
        }



        # region Error messages
        public void SendErrorAdd()
        {
            _caption = "Error in adding person";
            _errorMessage = "Given values either empty or invalid";
            SendError();
        }


        public void SendErrorEdit()
        {
            _caption = "Error in edit";
            _errorMessage = "Edited values either empty or invalid";
            SendError();
        }


        public void SendErrorRemove()
        {
            _caption = "Error in removing";
            _errorMessage = "Can't remove selected person";
            SendError();
        }


        public void SendBlankError()
        {
            _caption = "Can't touch example";
            _errorMessage = "Can't touch example value";
            SendError();
        }


        private void SendError()
        {
            MessageBox.Show($"Error: {_errorMessage}.", _caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
            _caption = string.Empty;
            _errorMessage = string.Empty;
        }

        // End of error messages //
        #endregion



        // Input strings
        string ISearchFormView.NameInput
        {
            get => tbNameInput.Text;
            set => tbNameInput.Text = value;
        }

        string ISearchFormView.WeightInput
        {
            get => tbWeightInput.Text;
            set => tbWeightInput.Text = value;
        }

        string ISearchFormView.AmountInput
        {
            get => tbAmountInput.Text;
            set => tbAmountInput.Text = value;
        }

        DateTime ISearchFormView.LastFetchDateInput
        {
            get => dtpInput.Value;
            set => dtpInput.Value = value;
        }



        // Product selection

        // Below line is purely for convenience I have no idea what would be the actual solution
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public BindingList<Product> Products
        {
            set
            {
                cbProducts.DataSource = value;
                cbProducts.DisplayMember = "Name";
            }
        }

        // Current active product in combobox
        public Product SelectedProduct => cbProducts.SelectedItem as Product;

        // Displays values of the product to richtextbox
        string ISearchFormView.DisplayInfo
        { set => rtbProductInfo.Text = value; }


        // Datetime sorted list
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Product> DateTimeProductList { get; set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingSource DataBindSource 
        {
            get => DataBindSource;
            
            set => DateFormatedGrid.DataSource = value;
        }
    }
}
