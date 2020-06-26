using System;
using System.Collections.Generic;

namespace AULA26INTERFACES
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        
        public float ValorTotal { get; set; }

        public void Cadastrar(Produto produto){
            carrinho.Add(produto);
        }

         public void Listar(){
             foreach(Produto p in carrinho)
             System.Console.WriteLine($"R$ {p.Preco,2} - {p.Nome}");
         }

         public void Alterar(int _codigo, Produto produto){
             carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
             carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
         }

         public void Deletar(Produto produto){
             carrinho.Remove(produto);
         }

         public void MostrarTotal(){
            foreach(Produto p in carrinho){
               ValorTotal += p.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Valor total da compra: R$ {ValorTotal}" );
            Console.ResetColor();
         }
    }
}