using System;

namespace Movie4AllCsharpPT
{

        public class Utilizador 
        {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telemovel { get; set; }
        public int NumFiscal { get; set; }
        public string Email { get; set; }
        public string Nick { get; set; }

        public Utilizador(int id, string nome, int telemovel, int numFiscal, string email, string nick)
        {
            Id = id;
            Nome = nome;
            Telemovel = telemovel;
            NumFiscal = numFiscal;
            Email = email;
            Nick = nick;

        }

        public Utilizador()
        {

        }


        public void  NovoCliente(int ID)
        {
            Id = ID;
            Console.WriteLine("Por favor preencha os seguintes dados:");
            Console.WriteLine("Nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Telemóvel:");
            Telemovel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nif:");
            NumFiscal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email:");
            Email = Console.ReadLine();
            Console.WriteLine("Nick:");
            Nick = Console.ReadLine();
            Console.WriteLine("Perfil criado com sucesso!");

        }

        

        public void DisplayDados()
        {
            Console.WriteLine("Área pessol de {0}", Nome);
            Console.WriteLine("Dados pessoais = Contacto: {0}, Nif: {1}, Email: {2}.", Telemovel, NumFiscal, Email);
            Console.WriteLine("Dados de conta = IdUtilizador {0}, NickName {1}, PassWord {2}", Id, Nome, Nick);
        }

        
        }

       

        
    
}
