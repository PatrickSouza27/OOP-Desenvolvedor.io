using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //se vc está implementando essa interface, vc é obrigado a implementar os metodos
    public interface IRepositorio
    {
        void Adicionar();
    }
    public class Repositorio : IRepositorio
    {
        //public Repositorio(int num) // se estiver diferente Implementando na classe, o codigo n permite, pois existe um contrato, se for no UsoAbstracao, ele ira deixar, tem mais vantagens
        //{
            
        //}
        public void Adicionar()
        {
            // AdicionarItem
        }

    }
    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            //AdicionarItem
        }
    }
    public class UsoImplementacao
    {
        public void Processo()
        {
            var repo = new Repositorio();
            repo.Adicionar();
        }
    }
    public class UsoAbstracao
    {
        private readonly IRepositorio _repositorio;
        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }
    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoAbstracao(new Repositorio()); //vc pode passar a classe que implementa o construtor, nesse caso esse e o repositorioFake Implementa (qualquer um, n importa qual) 
            //vc está tirando a responsabilidade da classe, sempre prefira o uso de Interface
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioFake());
            repoAbsFake.Processo();
        }
    }
}
