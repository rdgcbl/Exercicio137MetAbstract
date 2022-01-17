using Exercicio137Her_Poli_Final.Entities;
using System;
using System.Globalization;

List<Pessoa> list = new List<Pessoa>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (type == 'i')
    {
        Console.Write("Healt expenditures: ");
        double hexpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new PessoaFisica(hexpend, name, anualincome));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employee = int.Parse(Console.ReadLine());
        list.Add(new PessoaJuridica(employee, name, anualincome));
    }
}

double sum = 0.0;
Console.WriteLine();
Console.WriteLine("TAXES PAID:");
foreach (Pessoa p in list) // serve para imprimir todos os resultados, como no comeco do exercicio
                           // eu criei uma variavel 'n' para ler varios dados
{
    double tax = p.Tax();
    Console.WriteLine(p.Name + ": $ " +tax.ToString("f2", CultureInfo.InvariantCulture));
    sum += tax;
}

Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " +sum.ToString("f2", CultureInfo.InvariantCulture));



