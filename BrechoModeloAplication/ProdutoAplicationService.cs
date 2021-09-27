using BrechoDomainCore.Interfaces.Services;
using BrechoModeloAplication.Dtos;
using BrechoModeloAplication.Interfaces;
using BrechoModeloAplication.Interfaces.Mapper;
using System.Collections.Generic;

namespace BrechoModeloAplication
{
    public class ProdutoAplicationService : IProdutoAplicationService
    {
        private readonly IProdutoService _produtoService;
        private readonly IProdutoMapper _produtoMapper;

        public ProdutoAplicationService(IProdutoService produtoService,
                                         IProdutoMapper produtoMapper)
        {
            _produtoService = produtoService;
            _produtoMapper = produtoMapper;
        }

        public void Add(ProdutoDTO produtoDTO)
        {
            var Produto = _produtoMapper.MapperToEntity(produtoDTO);
            _produtoService.add(Produto);
            
        }

         //public void Dispose() 
        

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = _produtoService.GetAll();
            return _produtoMapper.MapperListProdutos(produtos);
        }

        public ProdutoDTO GetById(int id)
        {
            var produto = _produtoService.GetById(id);
            return _produtoMapper.MapperToDTO(produto);
        }

        public void Remove(ProdutoDTO obj)
        {
            var objProduto = _produtoMapper.MapperToEntity(obj);
            _produtoService.Remove(objProduto);
        }

        public void Update(ProdutoDTO obj)
        {
            var objProduto = _produtoMapper.MapperToEntity(obj);
            _produtoService.Update(objProduto);
        }
    }
}
