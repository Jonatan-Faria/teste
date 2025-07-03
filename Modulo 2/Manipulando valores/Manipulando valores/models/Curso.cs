using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Humano.models;

namespace Cursos.models
{
    
    public class Curso
    {
        public string NOME { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void adicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ContarQuantDeAlunos()
        {
            int quantidade = Alunos.Count;
            return (quantidade);
        }
        public bool removerAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void listarAluno()
        {

            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "Nº" + count + " " + Alunos[count].nomeCompleto;
                string texto = $"Nº {count + 1} {Alunos[count].nomeCompleto}";
                Console.WriteLine(texto); 
            }
        }
    }
}