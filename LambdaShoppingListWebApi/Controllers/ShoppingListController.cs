using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaShoppingListWebApi.Model;
using LambdaShoppingListWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LambdaShoppingListWebApi.Controllers
{
    [Route("v1/[controller]")]
    
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }
        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItemsFromShoppingList();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItemToShoppingList([FromBody] ShoppingListModel shoppingListModel)
        {
            _shoppingListService.AddItemsToShoppingList(shoppingListModel);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItemsFromShoppingList([FromBody]ShoppingListModel shoppingListModel)
        {
            _shoppingListService.DeleteItemsFromShoppingList(shoppingListModel.Name);
            return Ok();
        }
    }
}