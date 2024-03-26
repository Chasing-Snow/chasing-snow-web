using Microsoft.AspNetCore.Mvc;
using Chasing.Snow.Domain.Catalog;
using System.Runtime.CompilerServices;

namespace Chasing.Snow.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {

    }
}
[HttpGet]
public IActionResult GetItems()
{
    var items = new List<Item>()
    {
        new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
        new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m),
    };
    return Ok(items);
}
[HttpGet("{id:int}")]
public IActionResult GetItem(int id)
{
    var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m)
    item.Id = id;

    return Ok(item);
}
[HttpPost]
public IActionResult Post (Item item)
{
    return Created("/catalog/42", item);
}
[httpPost("{id:int}/ratings")]
public IActionResult PostRating(int id, [FromBody] Rating rating)
{
    var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m)
    item.Id = id;
    item.AddRating(rating);

    return Ok(item);
}
[HttpPut("{id:int}")]
public IActionResult Put(int id, Item item)
{
    return noContent();
}
[HttpDelete("{id:int}")]
public IActionResult Delete(int id)
{
    return NoContent();
}