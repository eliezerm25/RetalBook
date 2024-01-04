using DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class Author : BaseEntity
    {
        public Author() 
        {
        Books = new List<Book>();
        }
        public string Name { get; set; }=string.Empty;
        public string LastName { get; set; }= string.Empty;
        public Gender Gender { get; set; }
        public ICollection<Book> Books { get; set; }


    }
}
