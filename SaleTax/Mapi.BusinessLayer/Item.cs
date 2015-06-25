using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapi.DataLayer;
using Mapi.Models;

namespace Mapi.BusinessLayer
{
    public class Item : IItem
    {
        UnitOfWork.GenericUnitOfWork genericUnitOfWork = new UnitOfWork.GenericUnitOfWork();
   

        public IEnumerable<ItemCategory> GetItemCategories()
        {
            return genericUnitOfWork.Repository<ItemCategory>().Get();
        }
        public void PostItemCategories(ItemCategory itemCategory)
        {
            genericUnitOfWork.Repository<ItemCategory>().Insert(itemCategory);
            genericUnitOfWork.Save();
        }
        public void DeleteItemCategory(int id)
        {
            genericUnitOfWork.Repository<ItemCategory>().Delete(id);
            genericUnitOfWork.Save();
        }

        public void UpdateItemCategory(ItemCategory itemCategory)
        {
            genericUnitOfWork.Repository<ItemCategory>().Update(itemCategory);
            genericUnitOfWork.Save();
        }

        public IEnumerable<Mapi.Models.Article> GetItems()
        {
            return genericUnitOfWork.Repository<Mapi.Models.Article>().Get();
        }
        public void PostItem(Mapi.Models.Article item)
        {
            genericUnitOfWork.Repository<Mapi.Models.Article>().Insert(item);
            genericUnitOfWork.Save();
        }
        public void DeleteItem(int id)
        {
            genericUnitOfWork.Repository<Article>().Delete(id);
            genericUnitOfWork.Save();
        }

        public void UpdateItem(Article item)
        {
            genericUnitOfWork.Repository<Article>().Update(item);
            genericUnitOfWork.Save();
        }
      

    }
}
