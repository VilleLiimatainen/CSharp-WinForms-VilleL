using _110.Presenter;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Text;

namespace _110.Model
{
    public class StorageService
    {
        List<Product> ListOfProducts = new List<Product>();
        BindingSource BindingTimeSort = new BindingSource(); 
        public void AddToProductList(Product newProduct)
        {
             ListOfProducts.Add(newProduct);
        }

        public void RemoveProductFromStorage(Product product)
        {
            ListOfProducts.Remove(product);
        }

        public BindingList<Product> ToBindingList()
        {
            var bindingList = new BindingList<Product>(ListOfProducts);
            return bindingList;
        }

        public Product GetSelected(int id)
        {
            return ListOfProducts[id];
        }

        public bool CheckIfProductsExist()
        {
            if (ListOfProducts.Count > 1)
                return true;
            return false;
        }
            

        public List<Product> ListInDateTimeOrder()
        {
            List<Product> productsTimeSorted = new List<Product>();
            foreach (Product product in ListOfProducts)
            {
                if (product.LastFetchDate.Date >= DateTime.Today)
                {
                    CheckIfFetchTodayTomorrow(product);
                    productsTimeSorted.Add(product);
                }
            }
            productsTimeSorted.Sort((x, y) => DateTime.Compare(x.LastFetchDate, y.LastFetchDate));
            return productsTimeSorted;
        }

        private static void CheckIfFetchTodayTomorrow(Product product)
        {
            if (product.LastFetchDate.Date == DateTime.Today)
            {
                product.FetchToday = true;
                product.FetchTomorrow = false;
            }
            if (product.LastFetchDate.Date == DateTime.Today.AddDays(+1))
            {
                product.FetchTomorrow = true;
                product.FetchToday = false;
            }
        }
    }
}
