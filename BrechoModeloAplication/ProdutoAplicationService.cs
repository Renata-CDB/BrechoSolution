using BrechoDomainCore.Interfaces.Services;
using BrechoModeloAplication.Dtos;
using BrechoModeloAplication.Interfaces;
using BrechoModeloAplication.Interfaces.Mapper;
using System.Collections.Generic;

namespace BrechoModeloAplication
{
    public class ProdutoAplicationService : IProdutoAplicationService
    {
        private readonly IProdutoService produtoService;
        private readonly IProdutoMapper produtoMapper;

        public ProdutoAplicationService (IProdutoService produtoService,
                                         IProdutoMapper produtoMapper)
        {
            //produtoService = produtoService;
            //produtoMapper = produtoMapper;
        }

        public void Add(ProdutoDTO produtoDTO)
        {
            var Produto = produtoMapper.MapperToEntity(produtoDTO);
            produtoService.add(Produto);
            
        }

         //public void Dispose() 
        

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var produtos = produtoService.GetAll();
            return produtoMapper.MapperListProdutos(produtos);
        }

        public ProdutoDTO GetById(int id)
        {
            var produto = produtoService.GetById(id);
            return produtoMapper.MapperToDTO(produto);
        }

        public void Remove(ProdutoDTO obj)
        {
            var objProduto = produtoMapper.MapperToEntity(obj);
            produtoService.Remove(objProduto);
        }

        public void Update(ProdutoDTO obj)
        {
            var objProduto = produtoMapper.MapperToEntity(obj);
            produtoService.Update(objProduto);
        }
    }
}
