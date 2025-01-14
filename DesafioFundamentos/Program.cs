﻿using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento LocalUm = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("[1] - Cadastrar veículo");
    Console.WriteLine("[2] - Remover veículo");
    Console.WriteLine("[3] - Listar veículos");
    Console.WriteLine("[4] - Encerrar");

    switch (Console.ReadLine())
    {
        case "1": LocalUm.AdicionarVeiculo(); break;
        case "2": LocalUm.RemoverVeiculo(); Console.ReadKey(); break;
        case "3": LocalUm.ListarVeiculos(); Console.ReadKey(); break;
        case "4": exibirMenu = false; break;
        default: Console.WriteLine("Opção inválida"); break;
    }
    Console.WriteLine("Voltando..."); Thread.Sleep(300);
}

Console.WriteLine("O programa se encerrou");