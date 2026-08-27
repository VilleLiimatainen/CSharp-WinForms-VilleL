using System;
using System.Collections.Generic;
using System.Text;
using _110.Model;
using _110.View;
using _110.Presenter;

namespace _110.Model
{
    public class InputValidation
    {
        public bool CheckAllTextboxInputs(string name, string weight, string amount)
        {
            if (NameInputCheck(name) && WeightInputCheck(weight) && AmountInputCheck(amount))
                return true;
            return false;
        }

        public bool NameInputCheck(string name)
        {
            if (string.IsNullOrEmpty(name) == false)
                return true;
            return false;
        }

        public bool WeightInputCheck(string weightKg)
        {
            if (string.IsNullOrEmpty(weightKg) == false && decimal.TryParse(weightKg, out decimal weight) && weight > 0)
                return true;
            return false;
        }

        public bool AmountInputCheck(string amount)
        {
            if (string.IsNullOrEmpty(amount) == false && int.TryParse(amount, out int amountInt) && amountInt >= 0)
                return true;
            return false;
        }
    }
}
