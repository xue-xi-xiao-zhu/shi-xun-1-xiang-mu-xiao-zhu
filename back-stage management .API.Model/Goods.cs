using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace back_stage_management_.API.Model
{
    [Table("Goods")]
    public class Goods
    {
        [Key]
        public int GId { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string GName { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public int GQuantity { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public decimal GPrice { get; set; }
    }
}
