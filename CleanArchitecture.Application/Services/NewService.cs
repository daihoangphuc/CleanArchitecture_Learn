using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class NewService
    {
        public readonly INewRepository _newRepository;

        public NewService(INewRepository newRepository)
        {
            _newRepository = newRepository;
        }

        public Task<IEnumerable<New>> GetAllNewsSerViece()
        {
            return _newRepository.GetAllNewsAsync();
        }
        public Task<New> GetNewById(string id)
        {
            return _newRepository.GetNewByIdAsync(id);
        }

        public Task AddNewService(New news) 
        {
            return _newRepository.AddNewAsync(news);
        }
    }
}
