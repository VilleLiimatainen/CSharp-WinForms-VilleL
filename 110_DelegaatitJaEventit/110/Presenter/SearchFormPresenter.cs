using _110.Model;
using _110.View;

namespace _110.Presenter
{
    internal class SearchFormPresenter
    {
        readonly View.ISearchFormView _view;
        public readonly Model.IDelegaatitJaEventitModel _model;

        private StorageService _storage;
        private InputValidation _inputValidation;

        public SearchFormPresenter(View.ISearchFormView view, Model.IDelegaatitJaEventitModel model)
        {
            _view = view;
            _model = model;

            _inputValidation = new InputValidation();

            // Buttons
            _view.Add += Add;
            _view.Cancel += Cancel;
            _view.ConfirmAdd += ConfirmAdd;
            _view.Edit += Edit;
            _view.ConfirmEdit += ConfirmEdit;
            _view.Remove += Remove;
            _view.CheckLastFetchDay += CheckLastFetchDay;

            // Selector for combobox
            _view.SelectionChanged += OnSelectionChanged;

            // Establishes storage
            _storage = new StorageService();
            _storage.AddToProductList(new Product("Nuclear weapon (example)", 20000.00m, 15, DateTime.MinValue));

            // Sets the bindinglist for combobox with the values given from storage
            _view.Products = _storage.ToBindingList();
        }


        // Button methods
        public void Add(object sender, EventArgs e)
        {
            _view.EnableAddingProducts();
        }

        public void Cancel(object sender, EventArgs e)
        {
            _view.CancelInput();
        }

        public void ConfirmAdd(object sender, EventArgs e)
        {
            if (_inputValidation.CheckAllTextboxInputs(_view.NameInput, _view.WeightInput, _view.AmountInput))
            {
                _storage.AddToProductList(new Product(_view.NameInput, decimal.Parse(_view.WeightInput), int.Parse(_view.AmountInput), _view.LastFetchDateInput));
                _view.Products = _storage.ToBindingList();

                _view.ConfirmAdded();
            }
            else
                _view.SendErrorAdd();
        }

        public void Edit(object sender, EventArgs e)
        {
            Product selected = GetSelected();
            if (selected.Id > 0)
            {
                _view.EditProduct();

                _view.NameInput = selected.Name;
                _view.WeightInput = selected.WeightKG.ToString();
                _view.AmountInput = selected.Amount.ToString();
                _view.LastFetchDateInput = selected.LastFetchDate;
            }
            else
                _view.SendBlankError();
        }

        public void ConfirmEdit(object sender, EventArgs e)
        {
            Product selected = GetSelected();
            if (_inputValidation.CheckAllTextboxInputs(_view.NameInput, _view.WeightInput, _view.AmountInput))
            {
                selected.Name = _view.NameInput;
                selected.WeightKG = decimal.Parse(_view.WeightInput);
                selected.Amount = int.Parse(_view.AmountInput);
                selected.LastFetchDate = _view.LastFetchDateInput;
                _view.Products = _storage.ToBindingList();

                _view.ConfirmEdited();
            }
            else
                _view.SendErrorEdit();
        }

        public void Remove(object sender, EventArgs e)
        {
            Product selected = GetSelected();
            if (selected.Id > 0)
            {
                _storage.RemoveProductFromStorage(selected);
                _view.Products = _storage.ToBindingList();
                _view.RemoveUsed();
            }
            else
                _view.SendBlankError();
        }

        public void CheckLastFetchDay(object sender, EventArgs e)
        {
            if (_storage.CheckIfProductsExist())
            {
                _view.DateTimeProductList = _storage.ListInDateTimeOrder();
                _view.DataBindSource = new BindingSource { DataSource = _view.DateTimeProductList };
                _view.CheckLastFetchDatePressed();
            }
        }


        // Puts the selected person's values to displaytext 
        private void OnSelectionChanged(object sender, EventArgs e)
        {
            var selected = _view.SelectedProduct;
            _view.DisplayInfo = selected?.ToString();
        }
        
        // Gets selected person in searchform from storage
        private Product GetSelected()
        {
            // Var is faster to type
            var selectedView = _view.SelectedProduct;
            var selected = _storage.GetSelected(selectedView.Id);
            return selected;
        }
    }
}
