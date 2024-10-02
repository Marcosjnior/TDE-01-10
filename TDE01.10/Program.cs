Carro carro = new Carro();
carro.setMarca("Ferrari");
carro.setModelo("01");
carro.setAno(2020);
carro.ExibirInformacoes();


Moto moto = new Moto();
moto.setMarca("Kawazaki");
moto.setModelo("01");
moto.setAno(2020);
moto.setTemBagageiro(true);
moto.ExibirInformacoes();



carro.Ligar();
carro.AbrirMalas();
carro.Desligar();

moto.Ligar();
moto.DarGrau();
moto.Desligar();