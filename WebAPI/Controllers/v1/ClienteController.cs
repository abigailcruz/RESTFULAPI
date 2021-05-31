﻿using Application.Features.Clientes.Commands.CreateClienteCommand;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClienteController : BaseApiController
    {
        //POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post(CreateClienteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
