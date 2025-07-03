using Deserializar.classes;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("archives/vendas.json");

List<venda> listaVenda = JsonConvert.DeserializeObject<List<venda>>(conteudoArquivo);

var listaAnonima = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonima)
{
    Console.WriteLine($"Produto: {venda.Produto} Preço: {venda.Preco}");
}
