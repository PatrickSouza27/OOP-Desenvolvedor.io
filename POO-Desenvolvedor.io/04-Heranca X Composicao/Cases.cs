using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //sempre defenda a composição no lugar da herança
    //desde de que a classe que vc esteja herdando não sofra nenhuma alteração que deforme as caracteristicas dela, se começar a ter caracteristicas que não de uma Pessoa, é sinal que vc está forçando uma situação q n é para acontecer, e vc tem que entender que tudo que a classe Pessoa faz, tem que atender oq a Pessoa fisica espera
    public class PessoaFisica : Pessoa //Herança
    {
        public string CPF { get; set; }
    }
    public class PessoaFisica2 //composição
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }
    public class TesteHerancaComposicao
    {
        public TesteHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica()
            {
                Nome = "Joao",
                DataNascimento = DateTime.Now,
                CPF = "29381328098123"
            };
            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Joao",
                    DataNascimento = DateTime.Now
                },
                Cpf = "234098824391"

            };
            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }
}
