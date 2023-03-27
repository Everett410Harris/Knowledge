using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Knowledge.Models
{
    public class Vehicles
    {
        [Key]
        public int VId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string VLicensePlate { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string VModel { get; set; }
        [Column(TypeName = "int")]
        public int VYear { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string VEngType { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string VColor { get; set; }
        [Column(TypeName = "int")]
        public int VMileage { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string VMake { get; set; }
        [Column(TypeName = "varchar(10)")]  
        public string VBooked { get; set; }
    }
}
