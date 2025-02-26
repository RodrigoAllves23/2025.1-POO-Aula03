using aula_03;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tvSala = new Televisao(22); //Objeto o que e get set?

//tvSala.Tamanho = 100; Não roda pois deixamos a classe privada

Console.WriteLine ($"O tamanho da tv é: {tvSala.Tamanho}");

Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.AumentarVolume();


tvSala.AumentarVolume();
Console.WriteLine($"O volume da tv é: {tvSala.Volume}");
tvSala.AumentarVolume();