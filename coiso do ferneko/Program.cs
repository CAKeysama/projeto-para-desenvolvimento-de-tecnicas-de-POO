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

Carro car = new Carro();
car.Marca = "VW";
car.NumeroPortas = 4;
car.NumeroRodas = 4;
car.Cor = "roxo";

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
Console.WriteLine(car.ExibirDados());
