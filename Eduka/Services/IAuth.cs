using Eduka.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eduka.Services
{
    public interface IAuth
    {
        Task<string> Register(string username, string password, string userclass);
        Task<User> Login(string userid, string password);
    }
}
