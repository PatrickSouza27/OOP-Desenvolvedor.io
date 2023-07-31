using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cafeteira : Eletrodomesticos
    {
        public Cafeteira(string nome, int voltagem) : base(nome, voltagem)
        {
        }
        public Cafeteira() : base("Padrao", 220) { }
        private static void AquecerAgua() { }
        public static void MoerGraos() { }
        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }
        public override void Testar()
        {
            //teste cafeteira
        }
        public override void Ligar()
        {
            //Verifica recipiente de agya
        }
        public override void Desligar()
        {
            //resfriar aquecedor
        }
    }
}
