using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Estoque.Models;


namespace Estoque.DAO
{
    public class CategoriasDAO
    {
        public void Adiciona(CategoriaDoProduto categoria)
        {
            using (var context = new EstoqueContext())
            {
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }

        }

        public IList<CategoriaDoProduto> Lista()
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Categorias.ToList();
            }
        }

        public CategoriaDoProduto BuscaPorId(int id)
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Categorias.Include("Categoria")
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

        public void Atualiza(CategoriaDoProduto categoria)
        {
            using (var contexto = new EstoqueContext())
            {
                contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }

        }


    }
}