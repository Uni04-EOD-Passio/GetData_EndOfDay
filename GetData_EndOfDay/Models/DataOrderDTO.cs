using System.ComponentModel.DataAnnotations;

namespace GetData_EndOfDay.Models
{
    public class DataOrderDTO
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        public float Price { get; set; }
        public int PaymentID { get; set; } = 1;
        public int StoreID { get; set; } = 1;
        public bool Status { get; set; }
    }
}
