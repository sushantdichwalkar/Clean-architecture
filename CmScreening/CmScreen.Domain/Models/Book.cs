using System;
using System.Collections.Generic;
using System.Text;

namespace CmScreen.Domain.Models
{
    public class Book 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
    }
}
