using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeviceShop.Models
{
    public class CategoryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? ModelName { get; set; }
        public Category Category { get; set; }

        public class CategoryListViewModel
        {
            public SelectList ModelName { get; set; }
        }
    }
}
