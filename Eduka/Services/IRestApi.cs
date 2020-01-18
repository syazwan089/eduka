using Eduka.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eduka.Services
{
    public interface IRestApi
    {
        Task<List<Peta>> GetPeta(string topic_id);
    }
}
