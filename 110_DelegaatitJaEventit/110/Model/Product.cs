using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Threading;


namespace _110.Model
{
    public class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private static int _id = 0;
        public int Id { get; private set; }
        

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        private decimal _weightKG;
        public decimal WeightKG
        {
            get => _weightKG;
            set
            {
                _weightKG = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WeightKG)));
            }
        }

        private int _amount;
        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Amount)));
            }
        }

        private DateTime _lastFetchDate;
        public DateTime LastFetchDate
        {
            get => _lastFetchDate;
            set
            {
                _lastFetchDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastFetchDate)));
            }
        }

        public bool FetchToday = false;
        public bool FetchTomorrow = false;

        public Product(string name, decimal weightKg, int amount, DateTime lastFetchDate)
        {
            Id = _id++;
            _name = name;
            _weightKG = weightKg;
            _amount = amount;
            _lastFetchDate = lastFetchDate;
        }

        public override string ToString()
        {
            return
                $"Id: {Id}\n" +
                $"Name: {Name}\n" +
                $"Weight (kg): {WeightKG}\n" +
                $"Amount: {Amount}\n" +
                $"Last fetch date: {LastFetchDate.ToShortDateString()}";
        }
    }
}
