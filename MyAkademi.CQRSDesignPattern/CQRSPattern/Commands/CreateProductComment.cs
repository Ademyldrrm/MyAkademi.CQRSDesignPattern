namespace MyAkademi.CQRSDesignPattern.CQRSPattern.Commands
{
    public class CreateProductComment
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryID { get; set; }
    }
}
