using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPanda.Services
{
    public interface IDataStore<T>
    {
        Task<T> GetItemAsync(string headtitle);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
