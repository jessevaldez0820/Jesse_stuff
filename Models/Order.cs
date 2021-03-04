using System;
using System.ComponentModel.DataAnnotations;
namespace Valdez_Jesse_HW2.Models
{
    public class Order
    {
        //Constants for Hardback and Paperback Price
        const Decimal HARDBACK_PRICE = 19.0m;
        const Decimal PAPERBACK_PRICE = 7.0m;  

        //Auto-implemented properties
        public CustomerTypes CustomerType { get; set; }

        [Display(Name = "Number of Hardbacks:")]
        public Int32 NumberOfHardbacks { get; set; }

        [Display(Name = "Number of Paperbacks:")]
        public Int32 NumberOfPaperbacks { get; set; }

        //READ ONLY PROPERTY METHOD #1
        //read-only property for Total Pay; private backing variable needed to manipulate value 
        private Decimal _decHardbackSubtotal;

        [Display(Name = "Hardback Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal HardbackSubtotal
        {
            get { return _decHardbackSubtotal; }
        }

        private Decimal _decPaperbackSubtotal;

        [Display(Name = "Paperback Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal PaperbackSubtotal
        {
            get { return _decPaperbackSubtotal; }
        }

        private Decimal _decSubtotal;

        [Display(Name = "Subtotal:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Subtotal
        {
            get { return _decSubtotal; }
        }

        private Decimal _decTotal;

        [Display(Name = "Total:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Total
        {
            get { return _decTotal; }
        }

        private Int32 _intTotalItems;

        [Display(Name = "Total Items:")]
        [DisplayFormat(DataFormatString = "{0:}")]
        public Int32 TotalItems
        {
            get { return _intTotalItems; }
        }

        //method to calculate total pay; no inputs needed - they are already stored in the class
        public void CalculateSubtotals()
        {
            //calculate pay
            _decHardbackSubtotal = NumberOfHardbacks * HARDBACK_PRICE;
            _decPaperbackSubtotal = NumberOfPaperbacks * PAPERBACK_PRICE;
            _decSubtotal = _decHardbackSubtotal + _decPaperbackSubtotal;
            _intTotalItems = NumberOfHardbacks + NumberOfPaperbacks;
        }
    }
}
