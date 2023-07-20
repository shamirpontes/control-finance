using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFinance.Domain.Interfaces 
{
    public interface IGenerics<T> where T : class
    {
        Task Add(T Object);

        Task Update(T Object);

        Task Delete(T Object);

        Task GetEntityById(int Id);

        Task<List<T>> List();

    }
}
