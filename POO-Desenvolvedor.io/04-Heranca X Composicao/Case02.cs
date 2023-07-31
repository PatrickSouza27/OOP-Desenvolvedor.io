using POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Desenvolvedor.io._04_Heranca_X_Composicao
{
    public interface IRepositorio<T>
    {
        void Adicionar(T obj);
        void Excluir(T obj);
    }
    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }
    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T obj) { }

        public void Excluir(T obj)
        {
        }
    }
    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {
        
    }
    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        
        private readonly IRepositorio<Pessoa> _repositorio;
        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorio)
        {
            _repositorio = repositorio;
        }
        public void Adicionar(Pessoa obj)
        {
            _repositorio.Adicionar(obj);
            // nesse caso, eu vou mostrar somente o metodo adicionar, pois n quero ter o excluir!
        }
    }
    public class TesteHerancaComposicao2
    {
        public TesteHerancaComposicao2()
        {
            var repoH = new RepositorioHerancaPessoa();
            repoH.Adicionar(new Pessoa());
            repoH.Excluir(new Pessoa());

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>()); //mais pra frente, um container vai fazer isso para vc, (precisa passar uma instancia)
            repoC.Adicionar(new Pessoa());
            //repoC.Excluir(new Pessoa()); Não tem, é uma forma de não expor um metodo que vc n queira mostrar, pois só com o repositorio<T> ele mostra tudo que for necessario

            //acoplamento vc expôe somente oq vc quer, sempre buscar ele doq usar herança
          
        }
    }
}
