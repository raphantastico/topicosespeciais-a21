using System;

class Pessoa
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso {get; set; }

    public Pessoa(string nome, double altura, double peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}, Altura: {Altura}, Peso: {Peso}kg");
    }

}

class Imc
{
    public Pessoa Pessoa {get;set;}

    public Imc(Pessoa pessoa)
    {
        Pessoa = pessoa;
    }

    public double CalcularImc()
    {
        return Pessoa.Peso / (Pessoa.Altura * Pessoa.Altura);
    }

    public string ClassificacaoImc()
    {
        double imc = CalcularImc();
        if (imc < 18.5) return "Abaixo do peso";
        if (imc < 24.9) return "Peso normal";
        if (imc < 29.9) return "Sobrepeso";
        return "Obesidade";
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa("João", 1.65, 90);
        Imc imc = new Imc(pessoa);

        pessoa.ExibirDados();
        Console.WriteLine($"IMC: {imc.CalcularImc():F2}");
        Console.WriteLine($"Classificação: {imc.ClassificacaoImc()}");
    }
}