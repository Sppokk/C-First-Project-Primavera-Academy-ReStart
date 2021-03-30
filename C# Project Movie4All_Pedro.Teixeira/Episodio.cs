using System;

namespace Movie4AllCsharpPT
{
        public class Episodio
        {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public DateTime Data { get; set; }

        public Episodio()
        {

        }

        public Episodio(int ID, string nome, int numero, DateTime data)
        {
            Id = ID;
            Nome = nome;
            Numero = numero;
            Data = data;
        }
        public void NovoEpisodio(int id)
        {
            Id = id;
            Console.WriteLine("Inserir o Episodio:");
            Nome = Console.ReadLine();
            Console.WriteLine(" - Numero:");
            Nome = Console.ReadLine();
            Console.Write("Introduza uma data (formato: 10/22/1987): ");
            Data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Criado com sucesso!");
        }
    }
}
