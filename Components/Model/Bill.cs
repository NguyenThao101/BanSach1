﻿namespace BanSach.Components.Model
{
    public class Bill
    {
        public int BillId { get; set; } 
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public int DeliveryId { get; set; }
        public int PayStatus { get; set; }
        public int TotalPrice { get; set; }
        public string? Note { get; set; }
        public DateTime? Created_at { get; set; }
        public int Status { get; set; }
        
        //public User User { get; set; } = new User();
        //public Address Address { get; set; } = new Address();
        //public Delivery Delivery { get; set; } = new Delivery();
    }
}
