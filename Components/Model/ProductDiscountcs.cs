namespace BanSach.Components.Model
{
    public class ProductDiscountcs
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Discount {  get; set; }
        public int PriceAfterDiscount { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }

    }
}
