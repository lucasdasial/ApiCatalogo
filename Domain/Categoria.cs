﻿using System.Collections.ObjectModel;

namespace CatalogApi.Domain
{
    public class Categoria
    {

        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        public int CategoriaId { get; set; }

        public string? Nome { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}