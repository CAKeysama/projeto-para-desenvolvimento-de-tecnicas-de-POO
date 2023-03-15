using coiso_do_ferneko;

Console.WriteLine("hallo zauardooo");

Produto p1 = new Produto(1, "mouse sem fio", 59.90m);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());


Endereco e1 = new Endereco("Mario mizara","91","32165421","Sobral","Taquaritinga","SP");

Cliente c1 = new Cliente(1, "Ferneko", "9913404447", e1);
Cliente c2 = new Cliente(2, "Gustavo", "3543546855", e1);
Cliente c3 = new Cliente(3, "Luan"   , "5343543543", e1);
Cliente c4 = new Cliente(4, "Matheus", "2452454658", e1);

Console.WriteLine(c1.getEndereco().getRua() );
c1.getEndereco().setRua("prudente de Moraes");
Console.WriteLine(c1.getEndereco().getRua());