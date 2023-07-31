using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }
    public class Processo
    {
        public void Execute()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Joao",
                DataNascimento = DateTime.Now,
                DataAdmissao = DateTime.Now,
                Registro = "0123456"
            };

            funcionario.CalculaIdade();
        }
    }
}
