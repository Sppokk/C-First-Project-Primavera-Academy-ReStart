using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;


namespace Movie4AllCsharpPT
{
   public class BaseDados
    {
        public List<Ator> atores = new List<Ator>();
        public List<Show> shows = new List<Show>();
        public List<Utilizador> clientes = new List<Utilizador>();
        public List<Cartao> cartoes = new List<Cartao>();
        public List<Avaliar> avaliacoes = new List<Avaliar>();
        public List<Administrador> administradores = new List<Administrador>();
        public List<Precario> precarios = new List<Precario>();
        public List<Temporada> temporadas = new List<Temporada>();
        public List<Episodio> episodios = new List<Episodio>();
        

        public BaseDados()
        {

        }

        public void AddSampleData()
        {
            JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };

            //adicionar adminstradores
            var admin = new Administrador("admin", "admin");
            administradores.Add(admin);

            //adicionar precario
            var precario1 = new Precario();
            precarios.Add(precario1);

            //adicionar episodios
            var episodio = new Episodio(1, "A fuga das galinhas", 5, DateTime.Now);
            episodios.Add(episodio);

            //avaliação
            Avaliar avaliacao = new Avaliar(1, 1, 5, "Descrição em PT", "Descrição em EN", new DateTime());
            avaliacoes.Add(avaliacao);

            // adicionar clientes
            Utilizador cliente1 = new Utilizador(1, "pedro", 961234567, 227127199, "joao@jhdkjgh", "cliente");
            clientes.Add(cliente1);


            //adicionar cartao
            var cartao = new Cartao(1,"Emanuel", 546354, 903, 2022, 6, cliente1 );
            cartoes.Add(cartao);

       
           //adicionar temporadas
           var twinPeaksTemp1 = new Temporada(1,"Twin Peaks", 3, episodios);
            temporadas.Add(twinPeaksTemp1);

            // Adicionar atores
            Ator stalone = new Ator(1,"Rambo", "Silvester", "H");
            Ator pitt = new Ator(2,"Pit", "Brad", "H");
            atores.Add(stalone);
            atores.Add(pitt);

            

            // Adicionar Filmes
           
            var rambo = new Show(1, 2020,"Rambo","Filme", "US", temporadas,atores);
            var pulpFiction = new Show(2, 2019, "Pulp Fiction", "Filme","US", temporadas, atores);
            var fightClub = new Show(3, 2009, "Fight Club", "Filme", "US", temporadas, atores);
            var starTrek = new Show(4, 2019, "Star Trek", "Filme", "US", temporadas, atores);
            var jaws = new Show(5, 2010, "Jaws", "Filme", "US", temporadas, atores);
            var django = new Show(6, 2019, "Django", "Filme", "US", temporadas, atores);
            var twinPeaks = new Show(7, 2005, "Twin Peaks", "Série", "US", temporadas, atores);

            shows.Add(rambo);
            shows.Add(pulpFiction);
            shows.Add(fightClub);
            shows.Add(starTrek);
            shows.Add(jaws);
            shows.Add(django);
            shows.Add(twinPeaks);




            string jsonAtores = JsonSerializer.Serialize(atores, options);
            File.WriteAllText(@"c:\basedados\atores.json", jsonAtores);

            string jsonEpisodios = JsonSerializer.Serialize(episodios, options);
            File.WriteAllText(@"c:\basedados\episodios.json", jsonEpisodios);

            string jsonTemporadas = JsonSerializer.Serialize(temporadas, options);
            File.WriteAllText(@"c:\basedados\temporadas.json", jsonTemporadas);

            string jsonPrecarios = JsonSerializer.Serialize(precarios, options);
            File.WriteAllText(@"c:\basedados\precarios.json", jsonPrecarios);

            string jsonAdministradores = JsonSerializer.Serialize(administradores, options);
            File.WriteAllText(@"c:\basedados\administradores.json", jsonAdministradores);

            string jsonCartoes = JsonSerializer.Serialize(cartoes, options);
            File.WriteAllText(@"c:\basedados\cartoes.json", jsonCartoes);

            string jsonShows = JsonSerializer.Serialize(shows, options);
            File.WriteAllText(@"c:\basedados\shows.json", jsonShows);

            string jsonClientes = JsonSerializer.Serialize(clientes, options);
            File.WriteAllText(@"c:\basedados\clientes.json", jsonClientes);


            string jsonAvaliacoes = JsonSerializer.Serialize(avaliacoes, options);
            File.WriteAllText(@"c:\basedados\avaliacoes.json", jsonAvaliacoes);
        }

        public void ReadAllData()
        {
            if (File.Exists(@$"c:\basedados\episodios.json"))
            {
                string jsonEpisodios = File.ReadAllText(@$"c:\basedados\episodios.json");
                episodios = JsonSerializer.Deserialize<List<Episodio>>(jsonEpisodios);
            }

            if (File.Exists(@$"c:\basedados\temporadas.json"))
            {
               string jsonTemporadas = File.ReadAllText(@$"c:\basedados\temporadas.json");
               temporadas = JsonSerializer.Deserialize<List<Temporada>>(jsonTemporadas);
            }

            if (File.Exists(@$"c:\basedados\cartoes.json"))
            {
                string jsonCartoes = File.ReadAllText(@$"c:\basedados\cartoes.json");
                cartoes = JsonSerializer.Deserialize<List<Cartao>>(jsonCartoes);
            }

            if (File.Exists(@$"c:\basedados\clientes.json"))
            {
                string jsonClientes = File.ReadAllText(@$"c:\basedados\clientes.json");
                clientes = JsonSerializer.Deserialize<List<Utilizador>>(jsonClientes);
            }

            if (File.Exists(@$"c:\basedados\shows.json"))
            {
                string jsonShows = File.ReadAllText(@$"c:\basedados\shows.json");
                shows = JsonSerializer.Deserialize<List<Show>>(jsonShows);
            }

            if (File.Exists(@$"c:\basedados\atores.json"))
            {
                string jsonAtores = File.ReadAllText(@$"c:\basedados\atores.json");
                atores = JsonSerializer.Deserialize<List<Ator>>(jsonAtores);
            }

            if (File.Exists(@$"c:\basedados\avaliacoes.json"))
            {
                string jsonAvaliacoes = File.ReadAllText(@$"c:\basedados\avaliacoes.json");
               avaliacoes = JsonSerializer.Deserialize<List<Avaliar>>(jsonAvaliacoes);
            }

            if (File.Exists(@$"c:\basedados\administradores.json"))
            {
                string jsonAdministradores = File.ReadAllText(@$"c:\basedados\administradores.json");
                administradores = JsonSerializer.Deserialize<List<Administrador>>(jsonAdministradores);
            }

            if (File.Exists(@$"c:\basedados\precarios.json"))
            {
                string jsonPrecarios = File.ReadAllText(@$"c:\basedados\precarios.json");
                precarios = JsonSerializer.Deserialize<List<Precario>>(jsonPrecarios);
            }

            

        }

        public void Updatedb()
        {
            JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };

            string jsonTemporadas = JsonSerializer.Serialize(temporadas, options);
            File.WriteAllText(@"c:\basedados\temporadas.json", jsonTemporadas);

            string jsonAtores = JsonSerializer.Serialize(atores, options);
            File.WriteAllText(@"c:\basedados\atores.json", jsonAtores);

            string jsonClientes = JsonSerializer.Serialize(clientes, options);
            File.WriteAllText(@"c:\basedados\clientes.json", jsonClientes);

            string jsonCartoes = JsonSerializer.Serialize(cartoes, options);
            File.WriteAllText(@"c:\basedados\cartoes.json", jsonCartoes);

            string jsonAvaliacoes = JsonSerializer.Serialize(avaliacoes, options);
            File.WriteAllText(@"c:\basedados\avaliacoes.json", jsonAvaliacoes);

            string jsonAdministradores = JsonSerializer.Serialize(administradores, options);
            File.WriteAllText(@"c:\basedados\administradores.json", jsonAdministradores);

            string jsonPrecarios = JsonSerializer.Serialize(precarios, options);
            File.WriteAllText(@"c:\basedados\precarios.json", jsonPrecarios);

            //episodios
        }
       

       
        public bool TemShow(string filme)
        {
            bool encontrouShow = false;
            foreach (var show in shows)
            {
                if (show.Titulo == filme)
                    encontrouShow = true;
            }

            return encontrouShow;
        }

        public int BuscarIdShow(string titulo)
        {
            
            foreach (var show in shows)
            {
                if (show.Titulo == titulo)
                    return show.Id;
            }
            return 0;
        }

        public Show BuscarShow(string titulo)
        {

            foreach (var show in shows)
            {
                if (show.Titulo == titulo)
                    return show;
            }
            return null;
        }

        

        public int IdUserMaximo()
        {
            int max = 0;
            foreach (var user in clientes)
            {
                if (user.Id > max)
                {
                    max = user.Id;
                }
            }
            return max;
        }

        public bool TemNick(string nick)
        {
            bool encontrouNick = false;
            foreach (var cliente in clientes)
            {
                if (cliente.Nick == nick)
                    encontrouNick = true;
            }

            return encontrouNick;
        }

        public Utilizador BuscarUtilizador(string nick)
        {
            foreach (var cliente in clientes)
            {
             if(   cliente.Nick == nick)
                {
                    return cliente;
                }

            }
            return null;
        }

        
        public int IdCartaoMaximo()
        {
            int max = 0;
            foreach (var cartao in cartoes)
            {
                if (cartao.Id> max)
                {
                    max = cartao.Id;
                }
            }
            return max;
        }

        
        public Temporada GetTemporada(int id)
        {
            foreach (var temporada in temporadas)
            {
                if (temporada.Id == id)
                {
                    return temporada;
                }

            }
            return null;
        }

       
        public Episodio GetEpisodio(int id)
        {
            foreach (var episodio in episodios)
            {
                if (episodio.Id == id)
                {
                    return episodio;
                }

            }
            return null;
        }

        
        public Ator BuscarAtor(string nome)
        {
            foreach (var ator in atores)
            {
                if (ator.Nome == nome)
                {
                    return ator;
                }

            }
            return null;
        }

        public bool AdminTemUser(string adminUser)
        {
            bool encontrouUserName = false;
            foreach (var admin in administradores)
            {
                if (admin.UserName == adminUser)
                    encontrouUserName = true;
            }

            return encontrouUserName;
        }

        public bool AdminTemPassword(string pass)
        {
            bool encontrouPass = false;
            foreach (var admin in administradores)
            {
                if (admin.PassWord == pass)
                    encontrouPass = true;
            }

            return encontrouPass;
        }

        public int IdAdminMaximo()
        {
            int max = 0;
            foreach (var admin in administradores)
            {
                if (admin.IdAdministrador > max)
                {
                    max = admin.IdAdministrador;
                }
            }
            return max;
        }


    }
}
