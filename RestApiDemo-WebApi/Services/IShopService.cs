using System.Collections.Generic;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Services
{
    public interface IShopService<T>
        where T : BaseItem
    {
        List<T> Items { get; set; }

        T GetItem(int id);

        List<T> GetAllItems();

        void AddItem(T item);

        void DeleteItem(int id);

        void EditItem(int id, T t);
    }
}