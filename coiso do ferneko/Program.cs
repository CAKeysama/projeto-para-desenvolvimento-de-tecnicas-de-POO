using coiso_do_ferneko;

Console.WriteLine("hallo zauardooo");

Produto p1 = new Produto(1, "mouse sem fio", 59.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());


Endereco e1 = new Endereco("Rua Mario mizara","N°91","CEP:32165421","Bairro:Sobral","Taquaritinga","SP");

Cliente c1 = new Cliente(1, "Ferneko", "9913404447", e1);
Cliente c2 = new Cliente(2, "Gustavo", "3543546855", e1);
Cliente c3 = new Cliente(3, "Luan"   , "5343543543", e1);
Cliente c4 = new Cliente(4, "Matheus", "2452454658", e1);

Console.WriteLine(c1.getEndereco().EnderecoCompleto() );
c1.getEndereco().setRua("prudente de Moraes");

Carro carro = new Carro();
carro.Marca = "VW";
carro.NumeroPortas = 4;
carro.NumeroRodas = 4;
carro.Cor = "roxo";

Aviao aviao = new Aviao();
aviao.PortasInternas = 20;
aviao.NumeroPortas = 2;
aviao.NumeroRodas = 3;
aviao.Cor = "colorido";
aviao.NumeroAcentos = 500;
aviao.PagaImposto = false;

Bicicleta bic = new Bicicleta();
bic.PagaImposto = false;

Console.WriteLine(aviao.ExibirDados());
Console.WriteLine(carro.ExibirDados());

List<Veiculos> listaVeiculos = new List<Veiculos>();
listaVeiculos.Add(carro);
listaVeiculos.Add(aviao);
listaVeiculos.Add(bic);

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);
listaCliente.Add(c4);

foreach (var item in listaCliente) 
{
    Console.WriteLine(item.getName());
}
