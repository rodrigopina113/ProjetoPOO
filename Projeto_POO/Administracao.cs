using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO
{
    public class Administracao
    {
        //variaveis
        protected string palavra_passe;
        private int user;

        //construtor
        public Administracao(string palavra_passe, int user)
        {
            this.palavra_passe = palavra_passe;
            this.user = user;
        }

        //metodos
        public string GetPassword()
        {
            return palavra_passe;
        }
        public void SetPassword(string _palavra_passe)
        {
            palavra_passe = _palavra_passe;
        }

        public int GetUser()
        {
            return user;
        }

        public void SetUser(int _user)
        {
            user = _user;
        }

    }
}
