using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface INewRepository
    {
        Task<New> GetNewByIdAsync(string id);

        Task<IEnumerable<New>> GetAllNewsAsync();

        Task AddNewAsync(New news);


    }
}
