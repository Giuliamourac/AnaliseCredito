using System;

    double emprestimoSolicitado = 0.0;
    double quantidadeParcelas = 0.0;
    double rendaMensal = 0.0;

    double parcela = 0.0;
    double porcentagemRenda = 0.0;

    Console.WriteLine("Bem vindo a analise de credito, pressione uma tecla para prosseguir.");
    Console.ReadKey();

    Console.Write("Digite o valor desejado para emprestimo: ");
    emprestimoSolicitado = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("Digite sua renda mensal: ");
    rendaMensal = Convert.ToDouble(Console.ReadLine()!);

    Console.Write("Digite a quantidade de parcelas desejadas: ");
    quantidadeParcelas = Convert.ToDouble(Console.ReadLine()!);

    parcela = emprestimoSolicitado / quantidadeParcelas;
    porcentagemRenda = rendaMensal / 100 * 30;

    if (parcela > porcentagemRenda)
    {
        Console.WriteLine("Parcelas com valor superior a 30% da renda mensal. Emprestimo negado.");
    }
    else
    {
        Console.WriteLine("Renda mensal e parcelas aprovadas. Contate seu banco para prosseguir.");
    }