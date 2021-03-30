using System;
using System.Collections.Generic;

namespace Movie4AllCsharpPT
{
        public class Temporada
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int Numero { get; set; }
            public List<Episodio> Episodios { get; set; }

        public Temporada()
        {

        }

        public Temporada(int id, string nome, int num, List<Episodio> lista)
        {
            Id = id;
            Nome = nome;
            Numero = num;
            Episodios = lista;
        }

        public void NovaTemporada(int id)
        {
            Id = id;
            Console.WriteLine("Inserir Temporada:");
            Console.WriteLine(" - Nome:");
            Nome = Console.ReadLine();
            Console.WriteLine(" - Temporada número:");
            Numero = Console2.ReadInt();
            BaseDados bd = new BaseDados(); 
            Episodios = new List<Episodio>();

            int epNum;
            do
            {
                Console.WriteLine(" - Número do episodio (para terminar, introduza o número 0)");
                epNum = Console2.ReadInt();
                Episodios.Add(bd.GetEpisodio(epNum));

            } while (epNum != 0);
            Console.WriteLine("Temporada criada com sucesso!");
        }

    }
    
}
