using System;
using System.ComponentModel.DataAnnotations;
namespace Valdez_Jesse_HW2.Models
{
    public class WalkupOrder : Order
    {
        //Constants for Sales Tax
        const Decimal SALES_TAX_RATE = 8.75m;

        //Auto-implemented properties
        [Display(Name = "Customer Name:")]
        public String CustomerName { get; set; }

        private Decimal _decSalesTax

        [Display(Name = "Sales Tax:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal SalesTax
        {
            get { return _decSalesTax; }
        }

        //method to calculate total pay; no inputs needed - they are already stored in the class
        public void CalculateTotals()
        {
            CalculateSubtotals();
            //calculate pay
            _decSalesTax = Subtotal * SALES_TAX_RATE ;
            Total = Subtotal + _decSalesTax;

        }
    }
}