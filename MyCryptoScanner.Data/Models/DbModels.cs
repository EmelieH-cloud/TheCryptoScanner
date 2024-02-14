using System.ComponentModel.DataAnnotations;

namespace MyCryptoScanner.Data.Models
{
    public class CoinDbModel
    {
        [Key]
        public int Id { get; set; }

        public string? Symbol { get; set; }

        public double? sek { get; set; }
        public string? Name { get; set; }

    }


}
