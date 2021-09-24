using BrechoDomain.Entitys;
using BrechoModelo.Infrastructure.CrossCutting.Interfaces;
using BrechoModeloAplication.Dtos;
using System;
using System.Collections.Generic;

namespace BrechoModelo.Infrastructure.CrossCutting.Mapper
{
    public class ProdutoMapper : IProdutoMapper
    {
        

        List<ProdutoDTO> produtoDTOs = new List<ProdutoDTO>();

        

        public Produto MapperToEntity(ProdutoDTO produtoDTO)
        {
            Produto produto = new Produto
            {

                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Valor = produtoDTO.Valor

            };

            return produto;

        }

        public IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> produtos)
        {
            foreach (var item in produtos)
            {

                ProdutoDTO produtoDTO = new ProdutoDTO
                {
                    Id = item.Id
                   ,
                    Nome = item.Nome
                   ,
                    Valor = item.Valor

                };

                produtoDTOs.Add(produtoDTO);
            }


            return produtoDTOs;

        }

        public ProdutoDTO MapperToDTO(Produto produto)
        {
            ProdutoDTO produtoDTO = new ProdutoDTO
            {
                Id = produto.Id
               ,
                Nome = produto.Nome
               ,
                Valor = produto.Valor
            };

            return produtoDTO;

        }

       
    }
}


































    
