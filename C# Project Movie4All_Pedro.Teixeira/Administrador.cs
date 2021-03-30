using System;

namespace Movie4AllCsharpPT
{

        public class Administrador 
        {

        public int IdAdministrador { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public Administrador()
        {
            

        }
        public Administrador(string userName, string passWord)
        {
            UserName = userName;
            PassWord = passWord;
        }
            
        public static string InsertUser()
        {
             Console.WriteLine("Digite o seu user name sff");
             string adminName = (Console.ReadLine());

             return adminName;
        }

        public static string InsertPass()
        {
             Console.WriteLine("Digite digite a sua password sff");
             string passWord = (Console.ReadLine());

             return passWord;
        }

        public void NovoAdministrador(int ID)
        {
            IdAdministrador = ID;
            Console.WriteLine("Por favor preencha os seguintes dados:");
            Console.WriteLine("UserName:");
            UserName = Console.ReadLine();
            Console.WriteLine("PassWord:");
            PassWord = Console.ReadLine();
            
            Console.WriteLine("Perfil criado com sucesso!");
        }


        }
    
}
