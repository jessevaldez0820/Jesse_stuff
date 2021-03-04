using System;
using System.ComponentModel.DataAnnotations;
namespace Valdez_Jesse_HW2.Models
{
    public class WholesaleOrder : Order
    {
        //Auto-implemented properties
        [Display(Name = "Customer Code:")]
        [StringLength(4, MinimumLength = 2, ErrorMessage = "whatever your error message is")]
        public String CustomerCode { get; set; }

        [Display(Name = "Delivery Fee:")]
        [Range(minimum: 0, maximum: 175)]
        public Decimal DeliveryFee { get; set; }

        [Display(Name = "Is this a preffered customer?")]
        public bool PrefferedCustomer { get; set; }

        //method to calculate total pay; no inputs needed - they are already stored in the class
        public void CalculateTotals(decDeliveryFee)
        {
            CalculateSubtotals();
            //calculate pay
            if (PreferredCustomer == true)
            {
                DeliveryFee = 0;
            }
            else
            {
                DeliveryFee = decDeliveryFee;
            }

            Total = Subtotal + DeliveryFee;

        }
    }
}