using Application.Features.Clientes.Commands.CreateClienteCommand;
using Application.Features.Clientes.Commands.DeleteClienteCommand;
using Application.Features.Clientes.Commands.UpdateClienteCommand;
using Application.Features.Clientes.Queries.GetClienteById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClientesController : BaseApiController
    {

        //GET: api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetClienteByIdQuery { Id = id}));
        }

        //POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post(CreateClienteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        //PUT api/<controller>/5
        [HttpPut("{id}")]

        public async Task<ActionResult> Put(int id, UpdateClienteCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }

        //DELETE api/<controller>/5
        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteClienteCommand { Id = id }));
        }
    }
}
