using aula_03;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tvSala = new Televisao(55);

//tvSala.Tamanho = 100; Não roda pois deixamos a classe privada

Console.WriteLine ($"O tamanho da tv é: {tvSala.Tamanho}");