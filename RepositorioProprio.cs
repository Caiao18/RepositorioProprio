using System;
using System.Collections.Generic;

// Classe base Celular
public abstract class Celular
{
    // Propriedades comuns para todos os celulares
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public double Preco { get; set; }

    // Método que pode ser sobrescrito pelas classes filhas (polimorfismo)
    public abstract void Ligar();

    public void Desligar()
    {
        Console.WriteLine($"{Modelo} da {Marca} desligado.");
    }

    // Método para exibir as informações do celular
    public void ExibirInfo()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Preço: R${Preco}");
    }
}

// Classe derivada Samsung
public class Samsung : Celular
{
    public string SistemaOperacional { get; set; }

    // Sobrescrevendo o método Ligar para comportamento específico da Samsung
    public override void Ligar()
    {
        Console.WriteLine($"{Modelo} da {Marca} ligando com o Android.");
    }
}

// Classe derivada Apple
public class Apple : Celular
{
    public string SistemaOperacional { get; set; }

    // Sobrescrevendo o método Ligar para comportamento específico da Apple
    public override void Ligar()
    {
        Console.WriteLine($"{Modelo} da {Marca} ligando com o iOS.");
    }
}

// Classe principal para testar o sistema
class Program
{
    static void Main()
    {
        // Criando uma lista de celulares
        List<Celular> celulares = new List<Celular>();

        // Criando objetos Samsung e Apple
        var samsung = new Samsung
        {
            Marca = "Samsung",
            Modelo = "Galaxy S21",
            Preco = 4999.99,
            SistemaOperacional = "Android"
        };

        var apple = new Apple
        {
            Marca = "Apple",
            Modelo = "iPhone 13",
            Preco = 6999.99,
            SistemaOperacional = "iOS"
        };

        // Adicionando os celulares à lista
        celulares.Add(samsung);
        celulares.Add(apple);

        // Exibindo informações e ligando os celulares
        foreach (var celular in celulares)
        {
            celular.ExibirInfo();
            celular.Ligar();
            Console.WriteLine();
        }
    }
}
