using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Web.Mvc;

namespace shoppingstore.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }

        [Required]
        [DisplayName("Categoría")]
        public int CategoryId { get; set; }

        [Required]
        public int ProducerId { get; set; }

        [Required(ErrorMessage ="Es requerido un título del ítem")]
        [StringLength(160)]
        public string Title { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        [Range(0.1,100, ErrorMessage ="El precio debe ser entre 0.1 y 100")]
        public int Price { get; set; }

        [DisplayName("Url del ItemArt")]
        [StringLength(1024)]
        public string ItemArtUrl { get; set; }
        public virtual Category Category { get; set; }
        public virtual Producer Producer { get; set; }

        public virtual List<OrderDetail> OrderDatails { get; set; }

    }
}