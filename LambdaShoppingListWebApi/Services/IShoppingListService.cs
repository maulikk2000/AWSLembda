using LambdaShoppingListWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaShoppingListWebApi.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();

        void AddItemsToShoppingList(ShoppingListModel shoppingListModel);

        void DeleteItemsFromShoppingList(string shoppingListModel);
    }
}
