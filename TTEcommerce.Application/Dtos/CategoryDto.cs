using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TTEcommerce.Application.Dtos
{
    public class CategoryDto
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}