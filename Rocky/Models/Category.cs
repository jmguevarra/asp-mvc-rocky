using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Name")] //Annotation for asp-for in label at CreateCategory View
        public string name { get; set; }

        [DisplayName("Display order")]
        public int displayOrder { get; set; }
    }
}
