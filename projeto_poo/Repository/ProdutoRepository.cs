﻿using AutoCenter.Data;
using AutoCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
    public class ProdutoRepository
    {
        static public void AdicionarProduto(Produto produto)
        {
            using (var context = new AutoCenterContext())
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        static public void ExcluirProduto(Produto produto)
        {

            using (var context = new AutoCenterContext())
            {
                context.Produtos.Remove(produto);
                context.SaveChanges();
            }
        }
        
        static public void EditarProduto(int id, string? novoNome, string? novaDescricao,
            double? novoPreco, double? novaQuantidade)
        {
            using (var context = new AutoCenterContext())
            {
                var produtoParaEditar = context.Produtos.Find(id);

                if (produtoParaEditar == null)
                {
                    throw new ArgumentException("ID não encontrado");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(novaDescricao))
                {
                    produtoParaEditar.Descricao = novaDescricao;
                }

                if (novoPreco >= produtoParaEditar.CustoMedio || novoPreco != null)
                {
                    produtoParaEditar.Preco = novoPreco.Value;
                }

                if (novaQuantidade >= 0 || novaQuantidade != null)
                {
                    produtoParaEditar.Quantidade = novaQuantidade.Value;
                }

                context.SaveChanges();
            }
        }

        static public List<Produto> ListarProdutos()
        {
            using (var context = new AutoCenterContext())
            {
                var produtos = context.Produtos.ToList();
                return produtos;
            }
        }

        static public Produto ProdutoPorId(int id)
        {
            using (var context = new AutoCenterContext())
            {
                //procura o produto pelo id
                var produto = context.Produtos.Find(id);

                if (produto == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return produto;
            }
        }
    }
}
