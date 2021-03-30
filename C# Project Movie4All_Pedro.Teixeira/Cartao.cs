using System;

namespace Movie4AllCsharpPT
{
    public class Cartao
    {
        public int Numero { get; set; }
        public int CVC { get; set; }
        public String Nome { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int Id { get; set; }

        public Utilizador Cliente { get; set; }

        public Cartao()
        {

        }

        public Cartao(int cartaoId,string nome, int numCartao, int cvc, int ano, int mes, Utilizador cliente)
        {
            Id = cartaoId;
            Nome = nome;
            Numero = numCartao;
            Ano = ano;
            Mes = mes;
            Cliente = cliente;
            CVC = cvc;

        }

        public void NovoCartao(Utilizador cliente, int cartaoId)
        {
            Cliente =  cliente;
            Id = cartaoId;
            Console.WriteLine("Precisamos de associar um cartão de crédito à sua conta");
            Console.WriteLine("Por favor responda às seguintes perguntas:");
            Console.WriteLine("Qual o nome no cartão?");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual o número do seu cartão de crédito?");
            Numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o cvc do seu cartão de crédito?");
            CVC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o ano da validade?");
            Ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o mês da validade?");
            Mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Obrigado. O seu cartão foi adicionado com sucesso");
        }
    }
}
