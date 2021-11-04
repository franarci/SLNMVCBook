using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBook.Validations
{
    public class PriceConfirmValidation : CompareAttribute
    {

        public PriceConfirmValidation(string price) :base(price)
        {
            ErrorMessage = "'PriceConfirm' and 'Price' do not match.";
        }
        public override bool IsValid(object value)
        {
            decimal priceConfirm = Convert.ToDecimal(value);
            return priceConfirm == Convert.ToDecimal(OtherProperty);
        }
    }
}