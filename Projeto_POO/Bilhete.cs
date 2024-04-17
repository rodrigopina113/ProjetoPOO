using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO
{
    public abstract class Bilhete
    {

        //variaveis
        protected double preco;
        private double distancia;
        private int nif;

        protected Bilhete(double preco, double distancia, int nif)
        {
            this.preco = preco;
            this.distancia = distancia;
            this.nif = nif;
        }




        //metodos gets e sets
        public double getPreco()
        {
            return preco;
        }

        public void setPreco(double _preco)
        {
            preco = _preco;
        }

        public int getNifc()
        {
            return nif;
        }

        // Método abstrato para calcular o preço com base na distância
        public abstract double CalcularPreco(double distancia);



    }
}
