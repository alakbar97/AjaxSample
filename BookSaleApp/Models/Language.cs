using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookSaleApp.Models
{
    public class Language
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Name { get; set; }
        public ICollection<BookLanguage> BookLanguages { get; set; }
        public Language()
        {
            BookLanguages = new HashSet<BookLanguage>();
        }
    }
}
