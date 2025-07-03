
using System.Security.Cryptography;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo"); estados.Add("MG", "Minas Gerais"); estados.Add("AC", "Acre");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key } Valor: {item.Value}");
}