using System;

namespace Movie4AllCsharpPT
{

        public class Precario
        {
        public int Id { get; set; }
        public string TipoShow { get; set; }
        public string DataFim { get; set; }
        public string DataInicio { get; set; }
        public double Preco { get; set; }
        public int PeriodoDias { get; set; }

        public Precario()
        {

        }

        public Precario(int id, string tiposhow,string dataFim, string dataInicio, double preco, int periodoDias)
        {
            Id = id;
            TipoShow = tiposhow;
            DataFim = dataFim;
            DataInicio = dataInicio;
            Preco = preco;
            PeriodoDias = periodoDias;
        }

        public void NovoPrecario(int ID)
        {
            Id = ID;
            Console.WriteLine("Inserir preçário:");
            Console.WriteLine(" - Tipo de Show:");
            TipoShow = Console.ReadLine();
            Console.Write("Introduza uma data de inicio de aluguer (formato: 10/22/1987): ");
            DataInicio =Console.ReadLine();
            Console.Write("Introduza uma data de fim de aluguer (formato: 10/22/1987): ");
            DataInicio = (Console.ReadLine());
            Console.WriteLine("Introduza o preço:");
            Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Número de dias:");
            PeriodoDias = Console2.ReadInt();
            Console.WriteLine("Preçario criado com sucesso!");

        }

        }
    
}
