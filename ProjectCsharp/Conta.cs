using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp
{
    abstract class Conta : IValores
    {

        private int saldo;
    
        public void setValor(int valor)
        {
            this.saldo += valor;
        }
    
        public int getValor()
        {
            return this.saldo;
        }

        public void setPagar(int valor)
        {

            if (this.saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente!!!");
            }
            else
            {
                this.saldo -= valor;
            }
            
           
        }

        public void setDeposito(int valor)
        {
            this.saldo += valor;
        }
    
    }
}
