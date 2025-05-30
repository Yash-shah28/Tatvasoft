using BooksApi.Entities.Entities;
using BooksApi.Entities.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApi.Entities.Repositories.Interface
{
    public interface IUserRepository
    {
        Task AddUser(Users user);

        Users? Login(string username, string password);

    }
}
