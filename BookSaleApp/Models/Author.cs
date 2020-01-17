using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookSaleApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Name { get; set; }
        public ICollection<AuthorBook> AuthorBooks { get; set; }
        public Author()
        {
            AuthorBooks = new HashSet<AuthorBook>();
        }
    }
}
