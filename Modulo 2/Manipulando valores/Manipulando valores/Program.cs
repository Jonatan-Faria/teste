using Humano.models;
using Cursos.models;


Pessoa p1 = new Pessoa("Jonatan","Oliveira");
p1.apresentar();

Pessoa p2 = new Pessoa();

p2.Nome  = "Davi";
p2.Sobrenome = "Oliveira";
p2.apresentar();

Curso cursoDeIngles = new Curso();
cursoDeIngles.NOME = ("cursoDeIngles");
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.adicionarAluno(p1);
cursoDeIngles.adicionarAluno(p2);
cursoDeIngles.listarAluno();