using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO
{
    public class Rota
    {
        //variaveis
        private int id_rota;
        private int n_voos;
        private string destino;
        protected double distancia;

        //construtor
        public Rota(int id_rota, int n_voos, string destino, double distancia)
        {
            this.id_rota = id_rota;
            this.n_voos = n_voos;
            this.destino = destino;
            this.distancia = distancia;
        }


        //metodos
        public string GetDestino()
        {
            return destino;
        }
        public void SetDestino(string _destino)
        {
            this.destino = _destino;
        }

        public int Getn_rota()
        {
            return n_voos;
        }

        public void Setn_rota(int _n_rota)
        {
            this.n_voos = _n_rota;
        }

        public int Getid_rota()
        {
            return id_rota;
        }

        public void Setid_rota(int _id_rota)
        {
            this.id_rota = _id_rota;
        }

        public double Getdistancia()
        {
            return distancia;
        }

        public void Setn_rota(double _distancia)
        {
            this.distancia = _distancia;
        }









    }
}
