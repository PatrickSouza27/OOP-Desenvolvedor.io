using POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Desenvolvedor.io._02_Pilares_POO
{
    //public
    //protected
    //internal
    //protected Internal
    //private
    //private protected
    //Sealed - Classe que não pode ser herdada
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var espresso = new Cafeteira();
            espresso.Ligar();
            espresso.PrepararCafe(); //Aquecer e MoerGraos é privado e outras classes n consegue ver oq acontece
            espresso.Desligar();
        }
    }
}
