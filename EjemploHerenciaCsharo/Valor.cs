using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaCsharo
{
   public class Valor
    {
        private long numero;

        public void setNumero(long valor){
            this.numero = valor;
        }

        public long getNumero() {
            return this.numero;
        }
    }
}
