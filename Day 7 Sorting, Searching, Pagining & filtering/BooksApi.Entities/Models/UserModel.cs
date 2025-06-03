using BooksApi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApi.Entities.Models
{
    public class UserModel
    {
        public List<BookDetails> BookDetails;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

    }
}
