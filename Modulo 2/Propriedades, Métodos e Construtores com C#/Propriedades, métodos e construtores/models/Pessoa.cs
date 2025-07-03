using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Humano.models
{
    public class Pessoa
    {
        public Pessoa(){}
        public Pessoa(string nome, string sobrenome) { }
        private string _nome;
        public string Nome
        {
            get
            {
                return  _nome.ToUpper();
            }

            set
            {
                if (value == "" || value == " ")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        private string _sobrenome;

        public string sobrenome
        {
            get
            {
                return _sobrenome.ToUpper();
            }
            set
            {
                if (value == "" || value == " ")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
                _sobrenome = value;
            }
        }

        public string nomeCompleto => $"{_nome} {_sobrenome}";

        private int _idade;
        public int idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Sua idade não pode ser nula ou negativa");
                }
                idade = _idade;
            }
        }
        public void apresentar()
        {
            Console.WriteLine($"Nome: {nomeCompleto} | Idade: {idade} ");
        }


    }
}