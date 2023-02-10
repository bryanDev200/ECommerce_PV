using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public bool OrderState { get; set; }
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Address { get; set; }
        public int DistrictId { get; set; }
        public decimal TotalAmount { get; set; }
        public Transaction Transaction { get; set; }
        public User User { get; set; }
    }
}