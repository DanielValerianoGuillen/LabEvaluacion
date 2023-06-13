namespace APIDemo2.Models
{
    public class Detail
    {
        public int DetailID { get; set; }
        public int Price { get; set; }

        public int Amount { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }


        public int InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
    }
}
