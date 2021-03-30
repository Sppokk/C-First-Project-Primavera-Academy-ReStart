using System;
using System.Collections.Generic;
using System.Text;

namespace Movie4AllCsharpPT
{
    class Displays
    {
        public static void Regresso()
        {
            Console.WriteLine("Autenticação bem sucedida! Bem-vinda(o) de volta!");
        }

        public static void OpcoesAdmin()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("O que pretende fazer?");
            Console.WriteLine("Por favor selecione a sua opção usando as teclas correspondentes:");
            Console.WriteLine(" - consultar/alterar informações sobre shows [←] ");
            Console.WriteLine(" - consltar/alterar informações dos atores [↓] ");
            Console.WriteLine(" - consultar/alterar preçário [→] ");
            Console.WriteLine(" - consultar clientes [↑] ");
            Console.WriteLine(" - voltar [Esc] ");

        }

        public static void MenuAreaCliente()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo à Área de Cliente!");
            Console.WriteLine("Novo cliente? Registe-se já![1] Já tem conta? [2]");
        }

        public static void OpcoesUtilizador()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Escolha a opção que pretende:");
            Console.WriteLine(">Ver dados de conta?(1)");
            Console.WriteLine(">Ver lista de filmes?(2)");
            Console.WriteLine(">Avaliar um filme?(3)");
            Console.WriteLine(">Consultar Atores?(4)");
            Console.WriteLine(">Ver um show?(5)");
            Console.WriteLine("Voltar (6)");
           
        }

        public static void SaudacaoInicial()
        {
            Console.WriteLine();
            Console.WriteLine("Seja bem-vindo ao Movies4All!");
            Console.WriteLine("Por favor selecione a sua opção : Área de Cliente [←] ou Área Reservada [→]");
            Console.WriteLine("(Para sair pressione Esc)");
        }

       
        public static void MenuShowAdmin()
        {
            Console.Clear();
            Console.WriteLine("Menu Show:");
            Console.WriteLine(" - Consultar lista de Shows [1]");
            Console.WriteLine(" - Acrescentar Show à lista [2]");
            Console.WriteLine(" - Prima outra tecla para sair");
        }

        public static void MenuAtoresAdmin()
        {
            Console.WriteLine("Escolha a sua opção: ");
            Console.WriteLine("- Consultar Lista de Atores [1]");
            Console.WriteLine("- Criar Ator [2]");
            Console.WriteLine("Pressione qualquer tecla para sair");
        }

    }
}
