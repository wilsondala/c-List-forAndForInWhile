//CONCEITO DE LISTA EM C# USANDO A VARIAVEL LISTA ARRAY

Console.WriteLine(lista.Count()); // para sabermos o numero de lista que temos em nosso banco de dados 



var lista = new int[3] // deste jeito estamos a criar um programa que contem uma lista de tres

// onde todas as lista na programação começa com o zero desta feita a lista estara programada da seguinte forma 

lista[0] = 1;
lista[1] = 2;
lista[2] = 3;

//para imprimir no console a nossa lista podemos simplesmente imprimir todas as lista ou escolhermos o valor ou posição da lista que queremos mostrar em nosso console.

Console.WriteLine(lista[0]);
Console.WriteLine(lista[1]);
Console.WriteLine(lista[2]); // desse jeito estamos pedindo ao console para nos mostrar a lista 1, 2, 3.


//Para imprirmos a lista em uma linha unica de codigo usamos a expressão i(index) dessa feita ficara da seguinte forma.

var lista = new int[5] // deste jeito estamos a criar um programa que contem uma lista de tres

// onde todas as lista na programação começa com o zero desta feita a lista estara programada da seguinte forma 

lista[0] = 1;
lista[1] = 2;
lista[2] = 3;
lista[3] = 4;
lista[4] = 5;

for(var i = 0; i < lista.Count(); i++) {
	
	Console.WriteLine(lista[i]);
}


// ou podemos fazer dessa forma

var lista = new int[6]

for(var i = 0; i < lista.Count(); i++) {
	lista[i] = i;
	
}


for(var i = 0; i < lista.Count(); i++) {
	Console.WriteLine(lista[i]);
}




// tipo de Lista List para este forma de declarar lista é muita mais facilitada porque podemos adicionar a qualquer quantidade de lista no for observa no 100 ele pode ser mudificado por qualquervalor



var lista = new List<int>();

for(var i = 0; i < 100; i++){
	
	lista.Add(i);
}

for(var i = 0; i < lista.Count(); i++) {
	Console.WriteLine(lista[i]);
}



// REMOVER NO C# 


var lista = new List<int>();

for(var i = 0; i < 10; i++){
	lista.Add(i);
}

lista.RemoverAt(5)  // Neste caso estou removendo a posição de numero 5 porque toda numereçao no c# começa pelo numero zero.

for(var i = 0; i < lista.Count(); i++) {
	Console.WriteLine(lista[i]);
}


//  outra maneira de remover seria:

var lista = new List<int>();
	
	lista.Add(0);
	lista.Add(1);
	lista.Add(2);
	lista.Add(3);
	lista.Add(4);
}

liste.RemoverAt(3); /// Neste casa estamos pedindo para remover o terceiro elemento da nossa lista que no caso seria o (2) dois.

for(var i = 0; i < lista.Count(); i++) {
	Console.WriteLine(lista[i]);
}



// SUBLISTA NO C# USANDO METÓDO WHERE.

var lista = new List<int>();
	
	lista.Add(0);
	lista.Add(1);
	lista.Add(2);
	lista.Add(3);
	lista.Add(4);
	lista.Add(5);
	lista.Add(6);
	lista.Add(7);
	lista.Add(8);


var sublist = lista.Where(l => l > 5 && l < 8); // neste caso estou a pedir a minha sublist para mostrar uma outra lista onde aparecem apenas os numeros maior q 5 e menor que 8/

for(var i = 0; i < sublist.Count(); i++) {
	Console.WriteLine(sublist.ElementAt(i));
}


// outra maneira de fazer uma sublist seria .



var lista = new List<int>();
	
	lista.Add(0);
	lista.Add(1);
	lista.Add(2);
	lista.Add(3);
	lista.Add(4);
	lista.Add(5);
	lista.Add(6);
	lista.Add(7);
	lista.Add(8);


var sublist = new List<int>();
for(var i = 0; i < lista.Count(); i++) {
	if(lista[i] > 5)  ///  neste caso estou pedindo ao console que me mostre uma sublista que me mostre dos os valores maior que 5
		sublist.Add(lista[i]);
}


	for(var i = 0; i < sublist.Count(); i++) {
	Console.WriteLine(sublist[i]);
}




// LAST E FIRST / last para buscarmos o ultimo elemento da lista first para o 1 primeiro elemento.

var lista = new List<int>();
	
	lista.Add(0);
	lista.Add(1);
	lista.Add(2);
	lista.Add(3);
	lista.Add(4);
	lista.Add(5);
	lista.Add(6);
	lista.Add(7);
	lista.Add(8);
	
 Console.WriteLine(lista.Fist());



// trabalhando com lista Usando foreach 

var lista = new List<int>();
	
	lista.Add(0);
	lista.Add(1);
	lista.Add(2);
	lista.Add(3);
	lista.Add(4);
	lista.Add(5);
	lista.Add(6);
	lista.Add(7);
	lista.Add(8);


foreach (var x in lista) // para imprimir a lista devemos dar o nome de X ao var conforme o codigo isso no foreach
{
	Console.WriteLine(x);
}



// Usando for dentro do outro for / construindo uma tabela de tabuada

for(var i = 1; i <= 10; i++) {

	for(var y = 1; y <= 10; y++) {
		Console.WriteLine($"{i} * {y} = {i *y}");

	}
}

// A mesma coisa usando while
// Usando while dentro do outro while / construindo uma tabela de tabuada
var i = 1;
while (i <=10) {

	var y = 1;
	while(y <= 10) {
		Console.WriteLine($"{i} * {y} = {i * y}");
		y++;
	}
	i++;
}
