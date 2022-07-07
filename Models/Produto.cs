using System.Collections.Generic;

namespace REPEATER.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int Categoria { get; set; }
        public int SubCategoria { get; set; }

        public static List<Produto> Listar()
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto { ID = 101, Descricao = "Produto 1", Categoria = 201, SubCategoria = 301 });
            lista.Add(new Produto { ID = 102, Descricao = "Produto 2", Categoria = 202, SubCategoria = 302 });
            lista.Add(new Produto { ID = 103, Descricao = "Produto 3", Categoria = 203, SubCategoria = 303 });
            lista.Add(new Produto { ID = 104, Descricao = "Produto 4", Categoria = 202, SubCategoria = 302 });
            lista.Add(new Produto { ID = 105, Descricao = "Produto 5", Categoria = 201, SubCategoria = 301 });

            return lista;
        }
    }

    public class ProdutoCategoria
    {
        public int ID { get; set; }
        public string Descricao { get; set; }

        public static List<ProdutoCategoria> Listar()
        {
            List<ProdutoCategoria> lista = new List<ProdutoCategoria>();

            lista.Add(new ProdutoCategoria { ID = 201, Descricao = "Categoria 1" });
            lista.Add(new ProdutoCategoria { ID = 202, Descricao = "Categoria 2" });
            lista.Add(new ProdutoCategoria { ID = 203, Descricao = "Categoria 3" });

            return lista;
        }
    }

    public class ProdutoSubCategoria
    {
        public int ID { get; set; }
        public string Descricao { get; set; }

        public static List<ProdutoSubCategoria> Listar()
        {
            List<ProdutoSubCategoria> lista = new List<ProdutoSubCategoria>();

            lista.Add(new ProdutoSubCategoria { ID = 301, Descricao = "SubCategoria 1" });
            lista.Add(new ProdutoSubCategoria { ID = 302, Descricao = "SubCategoria 2" });
            lista.Add(new ProdutoSubCategoria { ID = 303, Descricao = "SubCategoria 3" });

            return lista;
        }
    }
}
