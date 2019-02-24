using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioCliente.Banco
{
    internal static class FactoryConnection
    {
        public static string SQLConnectionString => @"Data Source=.;Initial Catalog=proficiencia;Integrated Security=True";
    }
}
