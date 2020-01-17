using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSaleApp.Models
{
    public class BookLanguage
    {
        public int BookId { get; set; }
        public int LanguageId { get; set; }
        public Book Book { get; set; }
        public Language Language { get; set; }
    }
}
