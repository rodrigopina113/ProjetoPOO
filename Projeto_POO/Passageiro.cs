using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO
{
    public class Passageiro
    {
        //variaveis
        private DateTime data_nasc;
        private string morada;
        private string nome;
        private int nif;


        //construtor
        public Passageiro(string nome, string morada, DateTime data_nasc, int nif)
        {
            this.data_nasc = data_nasc;
            this.morada = morada;
            this.nome = nome;
            this.nif = nif;
        }

        //metodos

        public DateTime GetDataNas()
        {
            return data_nasc;
        }
        public void SetDataNas(DateTime _data_nasc)
        {
            this.data_nasc = _data_nasc;
        }

        public string GetMorada() 
        {
            return morada;
        }

        public void SetMorada(string _morada)
        {
            this.morada = _morada;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string _nome)
        {
            this.nome = _nome;
        }

        public int getNif()
        {
            return nif;
        }

        public void setNif(int _nif)
        {
            this.nif = _nif;
        }

    }
}
