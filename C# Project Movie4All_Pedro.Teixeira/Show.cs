using System;
using System.Collections.Generic;

namespace Movie4AllCsharpPT
{
   
        public class Show
        {
        public int Id { get; set; }
        public int Ano { get; set; }
        public string Titulo { get; set; }
        public string TipoShow { get; set; }
        public string CodPais { get; set; }
        public List<Temporada> Temporadas { get; set; }
        public List<Ator> Ator { get; set; }

        public Show()
        {

        }

        public Show(int id, int ano, string titulo, string tipo, string codPais, List<Temporada> temporadas, List<Ator> atores)
        {
            Id = id;
            Ano = ano;
            Titulo = titulo;
            TipoShow = tipo;
            CodPais = codPais;
            Temporadas = temporadas;
            Ator = atores;
        }


        public  void NovoShow(int ID)
        {
            Id = ID;
            Console.WriteLine();
            Console.WriteLine("Inserir novo Show na base de dados:");
            Console.WriteLine("Ano:");
            Ano = Console2.ReadInt();
            Console.WriteLine("Título:");
            Titulo = Console.ReadLine();
            Console.WriteLine("Tipo:");
            TipoShow = Console.ReadLine();
            Console.WriteLine("CodPais:");
            CodPais = Console.ReadLine();

            BaseDados bd = new BaseDados(); //Base de dados não deve de ser chamada numa clase de dados (model)
            bd.ReadAllData();
            int temporadaId; 

            do
            {
                Console.WriteLine("Indique o ID da temporada: (para nao adicionar introduza o valor 0)");
                temporadaId = Console2.ReadInt();
                if (temporadaId != 0)
                {
                    Temporadas = new List<Temporada>();
                    Temporadas.Add(bd.GetTemporada(temporadaId));
                }
            } while (temporadaId != 0);


            string atorNome;
            do
            {
                Console.WriteLine("Indique o nome do ator: (para nao adicionar introduza a palavra Fim)");
                atorNome = Console.ReadLine();
                if (atorNome != "Fim")
                {
                    Ator = new List<Ator>();
                    Ator.Add(bd.BuscarAtor(atorNome));
                }
            } while (atorNome != "Fim");

            Console.WriteLine("Show criado com sucesso!");

        }

        }
    
}
