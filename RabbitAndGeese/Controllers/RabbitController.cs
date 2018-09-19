using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitAndGeese.Models;
using RabbitAndGeese.DataAccess;

namespace RabbitAndGeese.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        [HttpPost]
        public void AddACustomer(Rabbit rabbit)
        {
            var storage = new RabbitStorage();
            storage.Add(rabbit);
        }

        [HttpPut("{id}/geese")]
        public IActionResult AddGooseToRabbit(Goose goose, int id)
        {
            var storage = new RabbitStorage();
            var rabbit = storage.GetById(id);

            //check to see if there is rabbit
            if (rabbit == null) return NotFound();

            rabbit.OwnedGeese.Add(goose);
            return Ok();
        }
        //material psuede, lol
        [HttpPut("{id}/saddles")]
        public IActionResult ProcureGooseSaddle(int id, Saddle saddle)
        {
            var storage = new RabbitStorage();
            var rabbit = storage.GetById(id);

            //check to see if there is rabbit
            if (rabbit == null) return NotFound();
            rabbit.OwnedSaddles.Add(saddle);
            return Ok();
        }
    }
}