
try
{

    string[] Linhas = File.ReadAllLines("Files/Leitura.txt");

    foreach (string linha in Linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exeção generica. {ex}");
}
finally
{
    Console.WriteLine("Chegou até aqui!");
}