using BrechoDomain.Entitys;
using BrechoDomain.InputDTO;
using BrechoDomainCore.Interfaces.Repository;
using BrechoDomainCore.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace BrechoDomain.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
       


        //public static Task<ResponseDto> AddAsync(ClienteInputDto model)
        //{
        //    var resultadoValidacao = new ClienteInputDtoValidator().Validate(model);
        //    if (!resultadoValidacao.IsValid)
        //        throw new InvalidOperationException(string.Join("\n", resultadoValidacao.Errors.Select(s => s)));



        //    try
        //    {
        //        var cliente = < Cliente > (model);
        //        await ValidateAdd(Dto, cliente);
        //        cliente = await _clienteRepository.AddAsync(cliente);
        //        await _clienteRepository.CommitAsync();

        //        return new ResponseDto { Id = cliente.Id, Mensagem = "Cliente adicionado." };
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        private static Task ValidateAdd(ClienteInputDto dto, object cliente)
        {
            throw new NotImplementedException();
        }


        //public static void ValidateParams
    }
}
