using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_20_orientacao_a_objetos_classe_singleton
{
    public class Email
    {
        private Email() { }

        private static Email instancia;
        public string Origem; 
        public string Destino; 
        public string Titulo; 
        public string Corpo;

        public void EnviarEmail()
        {
            Console.WriteLine("Enviando e-mail para " + Destino + "\nCom o titulo: " + Titulo + "\nCorpo: " + Corpo);
        }

        public static Email Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Email();
                }

                return instancia;
            }

        }
    }
}
