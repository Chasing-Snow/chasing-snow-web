using Microsoft.AspNetCore.Mvc;
using Chasing.Snow.Domain.Catalog;
using System.Runtime.CompilerServices;

namespace Chasing.Snow.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _db;

        public CatalogController(StoreContxt db){
            _db = db;
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
    return Ok(_db.items);
}
[HttpGet("{id:int}")]
public IActionResult GetItem(int id)
{
    var item = _db.Items.Find(int id)
    if (item == null)
    {
        return NotFound();
    }
    return Ok();

}
[HttpPost]
public IActionResult Post (Item item)
{
    _db.Items.Add(item);
    _db.saveChanges();
    return Created($"/catalog/{item.Id}", item);
}
[httpPost("{id:int}/ratings")]
public IActionResult PostRating(int id, [FromBody] Rating rating)
{
    var item = _db.Items.Find(id);
    if (item == null){
        return NotFound();
    }
    
    item.AddRating(rating);
    _db.saveChanges();

    return Ok(item);
}
[HttpPut("{id:int}")]
public IActionResult PutItem(int id, Item item)
{
    if (id != item.Id)
    {
        return BadRequest();
    }
    if (_db.Items.Find(id) == null)
    {
        return NotFound();
    }
    _db.Entry(item).State = EntityState.Modified;
    _db.saveChanges();
    return NoContent();
}
[HttpDelete("{id:int}")]
public IActionResult Delete(int id)
{
    var item = _db.Items.Find(id);
    if (item == null)
    {
        return NotFound();
    }
    _db.Items.remove(item);
    _db.saveChanges();
    return Ok;
}
}