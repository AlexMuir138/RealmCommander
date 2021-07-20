using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RealmCommander.Models;
using RealmCommander.Services;

namespace RealmCommander.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QuestsController : ControllerBase
  {
    private readonly QuestsService _service;

    //GET ALL
    [HttpGet]
     public ActionResult<IEnumerable<Quest>> Get()
     {
       //return Quests[]
       return Ok(_service.Find());
     }

     //Get ONE by ID
     [HttpGet("{id}")]
     public ActionResult<Quest> GetById(int id)
     {
       return Ok(_service.FindById(id));
     }

     //CREATE
     [HttpPost]
     public ActionResult<Quest> Create([FromBody] Quest q)
     {
       return Ok(_service.Create(q));
     }

     //EDIT
     [HttpPut("{id}")]
     public void Update(int id)
     {

     }

     //DELETE
     [HttpDelete("{id}")]
     public ActionResult<bool> Delete(int id)
     {
       return Ok(_service.Delete(id));
     }
     public QuestsController(QuestsService service)
     {
       _service = service;
     }
  }
}