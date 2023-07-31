using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Eletrodomesticos
    {
        private readonly string _name;
        private readonly int _voltagem;
        protected Eletrodomesticos(string nome, int voltagem)
        {
            _name = nome;
            _voltagem = voltagem;
        }
        public abstract void Ligar();
        public abstract void Desligar();
        public virtual void Testar()
        {
            //teste do equipamento
        }
    }
}
