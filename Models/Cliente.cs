using System.Collections.Generic;

namespace REPEATER.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            lista.Add(new Cliente { ID = 1, Nome = "Cliente 1" });
            lista.Add(new Cliente { ID = 2, Nome = "Cliente 2" });
            lista.Add(new Cliente { ID = 3, Nome = "Cliente 3" });
            lista.Add(new Cliente { ID = 4, Nome = "Cliente 4" });
            lista.Add(new Cliente { ID = 5, Nome = "Cliente 5" });

            return lista;
        }
    }
}
