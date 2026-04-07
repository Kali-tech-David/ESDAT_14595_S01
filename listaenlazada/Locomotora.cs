using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaenlazada{
    internal class Locomotora{
        private Vagon Primero {  get; set; }
        
        public void AgregaIni(int valor) {

            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null) {
                this.Primero = nuevo;
            } else {
                Vagon prim = this.Primero;
                nuevo.Sig = prim;
                this.Primero = nuevo;
            }
        }

        public void AgregaFin(int valor) {

            Vagon nuevo = new Vagon(valor);
            if (this.Primero == null) {
                this.Primero = nuevo;
            }else if (this.Primero.Sig == null) {
                this.Primero.Sig = nuevo;
            } else {
                Vagon ultimo = Primero;
                while (ultimo.Sig != null) {
                    ultimo = ultimo.Sig;
                }
                ultimo.Sig = nuevo;
            }
        }

        public void Imprime(){
            Vagon tmp = Primero;
            while (tmp != null){
                Console.WriteLine($"{tmp.Dato}, ");
                tmp = tmp.Sig;
            }   
        }

        public void Buscar(int valor)
        {
            Vagon actual = Primero;
            while(actual != null)
            {
                if(actual.Dato == valor)
                {
                    Console.WriteLine("Dato encontrado");
                    return;
                }
                actual = actual.Sig;
            }
        }

        public void EliminarSegundo()
        {
            Vagon actual = Primero;

            if (actual == null || actual.Sig == null)
            {
                Console.WriteLine("Los vagones son insuficientes.");
                return;
            }
            else
            {
                Vagon conservar = Primero.Sig.Sig;
                actual.Sig = conservar;
                Primero = actual;
            }
             
        }
    }
}
