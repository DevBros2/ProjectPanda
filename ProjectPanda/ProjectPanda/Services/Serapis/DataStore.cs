using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPanda.Services.Serapis
{
    public interface DataStore<T>
    {
        Task<bool> AddMessage(T item);
        Task<bool> UpdateMessageAsync(T item);
        Task<T> GetMessageAsync(string id);
        //Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
