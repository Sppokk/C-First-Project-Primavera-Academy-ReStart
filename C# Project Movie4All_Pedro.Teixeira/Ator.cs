using System;

namespace Movie4AllCsharpPT
{

        public class Ator
        {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }

        public Ator()
        {

        }

        public Ator(int ID, string nickName, string nomeAtor, string genero)
        {
            Id = ID;
            NickName = nickName;
            Nome = nomeAtor;
            Genero = genero;
        }
        public void NovoAtor(int ID)
        {
            Id = ID;
            Console.WriteLine("Inserir Ator:");
            Console.WriteLine(" - NickName:");
            NickName = Console.ReadLine();
            Console.WriteLine(" - Nome:");
            Nome = Console.ReadLine();
            Console.WriteLine(" - Genero:");
            Genero = Console.ReadLine();
            Console.WriteLine("Ator criado com sucesso!");

        }
        
         
        }
    
}
