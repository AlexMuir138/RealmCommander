using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RealmCommander.Models;
using RealmCommander.Services;

namespace RealmCommander.Controllers
 {
   [Route("api/[controller]")]
   [ApiController]
   public class KnightsController : ControllerBase
   {
    private readonly KnightsService _service;

    //GET ALL
    [HttpGet]
     public ActionResult<IEnumerable<Knight>> GetAll()
     {
       return Ok(_service.Find());
     }

     //Get ONE by ID
     [HttpGet("{id}")]
     public ActionResult<Knight> GetById(int id)
     {
       return Ok(_service.FindById(id));
       
     }

     //CREATE
     [HttpPost]
     public ActionResult<Knight> Create([FromBody] Knight knight)
     {
       return Ok(_service.Create(knight));
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

     public KnightsController(KnightsService service)
     {
         _service = service;
     }
   }
 }