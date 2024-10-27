using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentCarClient.Models
{
    public class MsCarImages
    {
        [Key]
        public string Image_car_id { get; set; }
        public string image_link { get; set; }
        [ForeignKey("MsCar")]
        public string Car_id { get; set; }
        public MsCar MsCar { get; set; }
    }
}
