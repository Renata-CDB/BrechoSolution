using BrechoDomainCore.Interfaces.Services;
using BrechoModeloAplication.Dtos;
using BrechoModeloAplication.Interfaces.IMapper;
using System.Collections.Generic;

//namespace BrechoModeloAplication
//{
//    public class ReceitaAplicationService : IReceitaAplicationService
//    {

//        private readonly IReceitaService _receitaService;
//        private readonly IReceitaMapper _receitaMapper;

//        public ReceitaAplicationService(IReceitaService receitaService
//                                        , IReceitaMapper receitaMapper)
//        {
//            _receitaService = receitaService;
//            _receitaMapper = receitaMapper;
//        }



//        public void Add(ReceitaDTO receitaDTO)
//        {
//            var Receita = _receitaMapper.MapperToEntity(receitaDTO);
//            _receitaService.add(Receita);
//        }

//        //public void Dispose()


//        public IEnumerable<ReceitaDTO> GetAll()
//        {
//            var clientes = _receitaService.GetAll();
//            return _receitaMapper.MapperListReceita(receitas);
//        }

//        public ReceitaDTO GetById(int id)
//        {
//            var cliente = _receitaService.GetById(id);
//            return _receitaMapper.MapperToDTO(cliente);
//        }

//        public void Remove(ReceitaDTO obj)
//        {
//            var objCliente = _receitaMapper.MapperToEntity(obj);
//            _receitaService.Remove(objReceita);
//        }

//        public void Update(ReceitaDTO obj)
//        {
//            var objCliente = _receitaMapper.MapperToEntity(obj);
//            _receitaService.Update(objCliente);
//        }
//    }
//}
