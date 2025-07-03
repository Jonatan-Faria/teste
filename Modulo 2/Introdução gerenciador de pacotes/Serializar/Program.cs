using NewtonsoftJson.classes;
using Newtonsoft.Json;



List<venda> listaVendas = new List<venda>(); 

venda v1 = new venda(1, "Picanha", 69.76M); listaVendas.Add(v1);
venda v2 = new venda(2, "Pernil", 19.99M); listaVendas.Add(v2);
venda v3 = new venda(3, "Linguiça Toscana", 25.50M); listaVendas.Add(v3);
venda v4 = new venda(4, "Filé de frango", 21.99M); listaVendas.Add(v4);
venda v5 = new venda(5, "Tilapia", 35.00M); listaVendas.Add(v5);



string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("archives/vendas.json", serializado);

Console.WriteLine(serializado);