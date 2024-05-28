namespace ApiLayer.Models
{
    public class Accounting
    {
        public int AccountingId { get; set; }
        public string HesapAdi { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public decimal Bakiye { get; set; }
    }
}
