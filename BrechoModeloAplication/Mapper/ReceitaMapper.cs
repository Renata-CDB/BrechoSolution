using BrechoDomain.Entitys;
using BrechoModeloAplication.Dtos;
using BrechoModeloAplication.Interfaces.IMapper;
using System.Collections.Generic;

namespace BrechoModeloAplication.Mapper
{
    public class ReceitaMapper : IReceitaMapper
    {
        List<ReceitaDTO> receitaDTOs = new List<ReceitaDTO>();



        public Receita MapperToEntity(ReceitaDTO receitaDTO)
        {
            Receita receita = new Receita
            {
                

                NomeCliente = receitaDTO.NomeCliente,

                ProdutoComprado = receitaDTO.ProdutoComprado


            };

            return receita;

        }


        public IEnumerable<ReceitaDTO> MapperListClientes(IEnumerable<Receita> receitas)
        {
            foreach (var item in receitas)
            {


                ReceitaDTO receitaDTO = new ReceitaDTO
                {


                    NomeCliente = item.NomeCliente,

                    ProdutoComprado = item.ProdutoComprado
                };



                receitaDTOs.Add(receitaDTO);

            }

            return receitaDTOs;
        }

        public ReceitaDTO MapperToDTO(Receita receita)
        {

            ReceitaDTO receitaDTO = new ReceitaDTO
            {


                NomeCliente = receita.NomeCliente,

                ProdutoComprado = receita.ProdutoComprado


            };

            return receitaDTO;

        }



    }
}
