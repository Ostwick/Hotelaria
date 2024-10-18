using System;
using System.Collections.Generic;

// Classe que representa uma Pessoa (hóspede)
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor da classe Pessoa
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

// Classe que representa uma Suíte de hotel
public class Suite
{
    public string Tipo { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiaria { get; set; }

    // Construtor da classe Suite
    public Suite(string tipo, int capacidade, decimal valorDiaria)
    {
        Tipo = tipo;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
}

// Classe que representa a Reserva, que relaciona uma ou mais Pessoas com uma Suite
public class Reserva
{
    public List<Pessoa> Hospedes { get; set; } // Lista de hóspedes na reserva
    public Suite Suite { get; set; }           // Suite reservada
    public int DiasReservados { get; set; }    // Quantidade de dias reservados

    // Construtor da classe Reserva
    public Reserva() 
    {
        // Inicializa a lista de hóspedes
        Hospedes = new List<Pessoa>();
    }

    // Método para cadastrar os hóspedes, verificando a capacidade da suíte
    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        // Verifica se o número de hóspedes não excede a capacidade da suíte
        if (hospedes.Count <= Suite.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Número de hóspedes excede a capacidade da suíte.");
        }
    }

    // Método para obter a quantidade de hóspedes na reserva
    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    // Método para calcular o valor total da reserva, considerando desconto de 10% para reservas acima de 10 dias
    public decimal CalcularValorReserva()
    {
        // Calcula o valor total da reserva sem desconto
        decimal valorTotal = DiasReservados * Suite.ValorDiaria;

        // Se a reserva for para mais de 10 dias, aplica o desconto de 10%
        if (DiasReservados > 10)
        {
            valorTotal *= 0.9m; // Multiplica por 90% (aplica o desconto)
        }

        return valorTotal;
    }
}

// Classe principal do programa
class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias de Pessoa (hóspedes)
        Pessoa pessoa1 = new Pessoa("João", 30);
        Pessoa pessoa2 = new Pessoa("Maria", 28);

        // Criando uma suíte com tipo "Premium", capacidade para 2 pessoas e diária de 150.00
        Suite suite = new Suite("Premium", 2, 150.0m);

        // Criando uma instância de Reserva
        Reserva reserva = new Reserva();
        
        // Definindo a suíte da reserva
        reserva.Suite = suite;
        
        // Definindo a quantidade de dias reservados (12 dias, maior que 10 para testar o desconto)
        reserva.DiasReservados = 12;

        // Cadastrando os hóspedes na reserva
        reserva.CadastrarHospedes(new List<Pessoa> { pessoa1, pessoa2 });

        // Exibindo a quantidade de hóspedes cadastrados na reserva
        Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");

        // Calculando e exibindo o valor total da reserva (com ou sem desconto)
        Console.WriteLine($"Valor Total da Reserva: {reserva.CalcularValorReserva()}");
    }
}
