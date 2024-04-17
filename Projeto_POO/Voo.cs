using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Projeto_POO
{
    public class Voo
    {
        //variáveis
        private DateTime data;
        private int id_voo;
        private string hora;
        private string aviao;
        private int n_lugares;
        private int suplentes;



        //construtor
        public Voo(int id_voo, DateTime data, string hora, string aviao, int n_lugares, int suplentes, double distancia)
        {
            this.id_voo = id_voo;
            this.data = data;
            this.hora = hora;
            this.aviao = aviao;
            this.n_lugares = n_lugares;
            this.suplentes = suplentes;

        }

        public Voo(int id_voo, DateTime data, string hora, string aviao, int n_lugares)
        {
            this.id_voo = id_voo;
            this.data = data;
            this.hora = hora;
            this.aviao = aviao;
            this.n_lugares = n_lugares;
            Suplentesvalor();

        }


        // Métodos relacionados a Voo

        public DateTime Getdata()
        {
            return data;
        }

        public void Setdata(DateTime _data)
        {
            this.data = _data;
        }

        public int GetIDvoo()
        {
            return id_voo;
        }

        public void SetIDvoo(int _idvoo)
        {
            this.id_voo = _idvoo;
        }

        public string Gethora()
        {
            return hora;
        }

        public void Sethora(string _hora)
        {
            this.hora = _hora;
        }


        public string Getaviao()
        {
            return aviao;
        }

        public void Setaviao(string _aviao)
        {
            this.aviao = _aviao;
        }

        public int GetNlugares()
        {
            return n_lugares;
        }

        public void SetNlugares(int _n_lugares)
        {
            this.n_lugares = _n_lugares;
        }

        public void Suplentesvalor()
        {
            this.suplentes = 4;
        }

        public void SetSuplentes(int _suplentes)
        {
            this.suplentes = _suplentes;
        }

        public int GetSuplentes()
        {
            return suplentes;
        }


        //metodo pesquisar se existe info repetida
        public bool ExisteVoo(int outroIdVoo, string outraHora)
        {
            return (id_voo == outroIdVoo) || (hora == outraHora);
        }


        public string ComprarBilhete(string nif, List<string> BilheteEfe, List<string> Bilhetesuplente)
        {
            if (n_lugares > 0)
            {
                // Adiciona à lista BilheteEfe e decrementa o número de lugares
                BilheteEfe.Add($"{id_voo}-{nif}");
                n_lugares--;

                return "Bilhete comprado com sucesso!";
            }
            else if (suplentes > 0)
            {
                // Adiciona à lista Bilhetesuplente e decrementa o número de suplentes
                Bilhetesuplente.Add($"{id_voo}-{nif}");
                suplentes--;

                return "Bilhete suplente comprado com sucesso!";
            }
            else
            {
                return "Bilhetes esgotados!";
            }
        }



    }


}

