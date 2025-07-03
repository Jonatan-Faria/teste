using tupla;


leituraArquivo arquivo = new leituraArquivo();

var (sucesso, linhas, quantidadeLinhas) = arquivo.lerArquivo("leitura/README.md");

if (sucesso)
{
    Console.WriteLine("Quantidade linhas de arquivo: " + quantidadeLinhas);
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}





























//(int Id, string Nome, string Sobrenome) tupla = (1, "Jonatan", "Oliveira");

//Console.WriteLine($"ID: {tupla.Item1}");
//Console.WriteLine($"Nome: {tupla.Item2}");
//Console.WriteLine($"Sobrenome: {tupla.Item3}");