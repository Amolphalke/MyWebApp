using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [PlaceholderContext("name")]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; }= DateTime.Now;

        private class PlaceholderContextAttribute : Attribute
        {
            public PlaceholderContextAttribute(string v)
            {
            }
        }
    }
}
