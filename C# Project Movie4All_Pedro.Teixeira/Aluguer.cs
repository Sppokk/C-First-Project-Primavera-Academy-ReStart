using System;

namespace Movie4AllCsharpPT
{

        public class Aluguer
        {
        public int Id { get; set; }
        public string MetodoPag { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataFim { get; set; }
        public int Valor { get; set; }
        public Show Programa { get; set; }
        public Utilizador Cliente { get; set; }

        public Aluguer()
        {

        }

        public Aluguer(int id, string metodoPag, DateTime data, DateTime dataFim, int valor, Show programa, Utilizador cliente)
        {
            Id = id;
            MetodoPag = metodoPag;
            Data = data;
            DataFim = dataFim;
            Valor = valor;
            Programa = programa;
            Cliente = cliente;
        }

        public void NovoAluguer(int ID)
        {
            Id = ID;
            Console.WriteLine();
            Console.WriteLine("Inserir novo Aluguer na base de dados:");
            Console.WriteLine("Método de Pagamento:");
            MetodoPag = Console.ReadLine();

            Console.Write("Introduza Data (formato: 10/22/1987): ");
            Data = DateTime.Parse(Console.ReadLine());
            Console.Write("Introduza Data Fim (formato: 10/22/1987): ");
            DataFim = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Valor:");
            Valor = Console2.ReadInt();

            BaseDados bd = new BaseDados(); //Base de dados não deve de ser chamada numa clase de dados (model)
            bd.ReadAllData();

            Console.WriteLine("Indique o nome do Show:");
            string nomeShow = Console.ReadLine();
            Programa = bd.BuscarShow(nomeShow);

            Console.WriteLine("Indique o nome do cliente:");
            string nomeUser = Console.ReadLine();
            Cliente = bd.BuscarUtilizador(nomeUser);

            Console.WriteLine("Aluguer criado com sucesso!");
        }
    } 
}
