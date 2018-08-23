using LambdaShoppingListWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaShoppingListWebApi.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();
        //private readonly HashSet<ShoppingListModel> sm = new HashSet<ShoppingListModel>();
        public Dictionary<string, int> GetItemsFromShoppingList()
        {
            return _shoppingListStorage;
        }

        public void AddItemsToShoppingList(ShoppingListModel shoppingList)
        {
            _shoppingListStorage.Add(shoppingList.Name, shoppingList.Quantity);
            //sm.Add(shoppingList);
        }

        public void DeleteItemsFromShoppingList(string shoppingListItemName)
        {
            _shoppingListStorage.Remove(shoppingListItemName);
            //sm.Remove(sm.First(s => s.Name == shoppingListItemName));
        }

    }
}
