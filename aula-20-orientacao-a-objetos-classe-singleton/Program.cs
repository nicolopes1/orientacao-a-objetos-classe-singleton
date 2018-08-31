using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_20_orientacao_a_objetos_classe_singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Email.Instancia.Corpo = "bla bla";
            Email.Instancia.Titulo = "Titulo do email";
            Email.Instancia.Origem = "nicollas";
            Email.Instancia.Destino = "lopes";
            Email.Instancia.EnviarEmail();

            Console.Read();
        }
    }
}
