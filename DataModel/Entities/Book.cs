using DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class Book : BaseEntity
    {
        public Book() 
        { 
            Category = new Category();
            Author = new Author();
        }
        public string Title { get; set; }= string.Empty;
        public string Description { get; set; }=string.Empty;
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int NumberPages { get; set; }
        public string UrlImage { get; set; } = string.Empty;
        public string Editorial { get; set; } = string.Empty;
        public Language Language { get; set; }
        public DateTime PublicationDate { get; set; }
        public StatusBook StatusBooks { get; set; }

    }
}
