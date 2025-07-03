using Deserializar.classes;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("archives/vendas.json");

List<venda> listaVenda = JsonConvert.DeserializeObject<List<venda>>(conteudoArquivo);

foreach (venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}," +
    $"{(venda.Desconto.HasValue ? $"Desconto: {venda.Desconto}" : "" )}");
}
