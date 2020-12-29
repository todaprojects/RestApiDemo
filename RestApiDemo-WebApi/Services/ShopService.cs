using System.Collections.Generic;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Services
{
    public class ShopService<T> : IShopService<T>
        where T : BaseItem
    {
        public List<T> Items { get; set; } = new List<T>();

        private static int _idCounter = 1;

        public T GetItem(int id)
        {
            return Items.Find(item => item.Id == id);
        }

        public List<T> GetAllItems()
        {
            return Items;
        }

        public void AddItem(T t)
        {
            if (t.Id == 0)
            {
                while (GetItem(_idCounter) != null)
                {
                    _idCounter++;
                }

                t.Id = _idCounter;
            }

            Items.Add(t);
        }

        public void DeleteItem(int id)
        {
            var item = GetItem(id);
            Items.Remove(item);
        }

        public void EditItem(int id, T t)
        {
            var item = GetItem(id);
            item.Name = t.Name;
        }
    }
}