using _110.Model;
using System.ComponentModel;


namespace _110.View
{
    internal interface ISearchFormView
    {
        // Button events
        event EventHandler Add;
        event EventHandler Cancel;
        event EventHandler ConfirmAdd;
        event EventHandler Edit;
        event EventHandler ConfirmEdit;
        event EventHandler Remove;
        event EventHandler CheckLastFetchDay;

        // Selector for combobox
        event EventHandler SelectionChanged;

        // Textbox inputs
        string NameInput { get; set; }
        string WeightInput { get; set; }
        string AmountInput { get; set; }
        DateTime LastFetchDateInput { get; set; }

        // Product selection and list
        BindingList<Product> Products { set; }
        Product SelectedProduct { get; }
        string DisplayInfo { set; }

        // For datagridview for fetch date
        List<Product> DateTimeProductList { get; set; }
        BindingSource DataBindSource { get; set; }

        // Methods for buttons in physical order
        void EnableAddingProducts();
        void CancelInput();
        void ConfirmAdded();
        void EditProduct();
        void ConfirmEdited();
        void RemoveUsed();
        void CheckLastFetchDatePressed();

        // Error messages
        void SendErrorAdd();
        void SendErrorEdit();
        void SendErrorRemove();
        void SendBlankError();
    }
}
