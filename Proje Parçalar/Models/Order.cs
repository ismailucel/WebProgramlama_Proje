using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public ApplicationUser ApplicationUser { get; set; }

        public double TotalPrice { get; set; }

        public double Discount { get; set; }

        public double ShippingPrice { get; set; }

        public string ShippingCompany { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippingDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public PaymentStatus PaymentStatus { get; set; }

        public string OrderCode { get; set; }

        public string Description { get; set; }
    }

    public enum OrderStatus
    {
        GettingReady,
        HasBeenShipped,
        Delivered,
        HasBeenReturned
    }

    public enum PaymentStatus
    {
        CreditCard,
        EFT,
        Transfer,
        CashOnDelivery,
        NotApproved
    }
}
