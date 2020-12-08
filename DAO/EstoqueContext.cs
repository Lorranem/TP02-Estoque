using Estoque.DAO;
using Estoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

public class EstoqueContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    public DbSet<CategoriaDoProduto> Categorias { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }


}
