using BrechoModeloAplication.Dtos;
using BrechoModeloAplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BrechoAPI.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private readonly IClienteAplicationService _clienteApplicationService;


        public ClientesController(IClienteAplicationService ClienteApplicationService)
        {
            _clienteApplicationService = ClienteApplicationService;
        }
        // GET api/values
        [HttpGet]

        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_clienteApplicationService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_clienteApplicationService.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                //ClienteInputDtoValidator validator = new ClienteInputDtoValidator();
                //ValidatorResult result = validator.Validate(clienteDto);
                
                //if (result.IsValid == false)
                //return Ok(result.Errors);

                if (clienteDTO == null)
                    return NotFound();

                _clienteApplicationService.Add(clienteDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _clienteApplicationService.Update(clienteDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _clienteApplicationService.Remove(clienteDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

