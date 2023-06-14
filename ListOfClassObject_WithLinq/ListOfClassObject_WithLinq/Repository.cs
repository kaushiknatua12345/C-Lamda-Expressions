using System;
using System.Collections.Generic;
using System.Linq;


namespace ListOfClassObject_WithLamda
{
    public class Repository
    {    
        public bool AddData(List<Item> _itemList,Item item)
        {
            var checkIfItemCodeExists = _itemList.Where(x => x.ItemCode == item.ItemCode).FirstOrDefault();
            if (checkIfItemCodeExists == null)
            {
                _itemList.Add(item);
                return true;
            }
            else
                return false;
        }

        public List<Item> DisplayAllData(List<Item> _itemList)
        {
            if (_itemList.Count > 0)
            {
                return _itemList;
            }
            else
                return null;
        }
        public List<Item> DisplayAllDataInDescendingMannerByPriceSorted(List<Item> _itemList)
        {
            if (_itemList.Count > 0)
            {
                return _itemList.OrderByDescending(x=>x.Price).ToList();
            }
            else
                return null;
        }

        public List<Item> DisplayItemsWithPriceMoreThanRs500(List<Item> _itemList)
        {
            if (_itemList.Count > 0)
            {
                 return _itemList.Where(x => x.Price > 500).ToList();
               // return (from x in _itemList where x.Price > 500 select x).ToList();
            }
            else
                return null;
        }

        public bool UpdateData(List<Item> _itemList,int searchId,string updateBrandName)
        {
            var checkIfItemCodeExists = _itemList.Where(x => x.ItemCode == searchId).FirstOrDefault();
          
            if (checkIfItemCodeExists != null)
            {
                var findIndex = _itemList.IndexOf(checkIfItemCodeExists);
                _itemList[findIndex].BrandName = updateBrandName;
                return true;
            }
            else
                return false;
        }

        public bool DeleteRecord(List<Item> _itemList, int searchId)
        {
            var checkIfItemCodeExists = _itemList.Where(x => x.ItemCode == searchId).FirstOrDefault();
            if (checkIfItemCodeExists != null)
            {
                var findIndex = _itemList.IndexOf(checkIfItemCodeExists);
                _itemList.RemoveAt(findIndex);
                return true;
            }
            else
                return false;
        }
    }
}
