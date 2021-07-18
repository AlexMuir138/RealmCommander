using Microsoft.AspNetCore.Mvc;

namespace RealmCommander.Controllers
 {
   [Route("api/[controller]")]
   [ApiController]
   public class KnightsController : ControllerBase
   {
     //GET ALL
     [HttpGet]
     public void GetAll()
     {

     }

     //Get ONE by ID
     [HttpGet("{id}")]
     public void GetById(int id)
     {
       
     }

     //CREATE
     [HttpPost]
     public void Create()
     {

     }

     //EDIT
     [HttpPut("{id}")]
     public void Update(int id)
     {

     }

     //DELETE
     [HttpDelete("{id}")]
     public void Delete(int id)
     {

     }
   }
 }