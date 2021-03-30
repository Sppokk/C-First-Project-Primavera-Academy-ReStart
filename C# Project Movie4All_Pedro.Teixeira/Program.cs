using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace Movie4AllCsharpPT
{

    public class Program
    {
        
        static void Main(string[] args)
        {
            BaseDados bd = new BaseDados();
            bd.AddSampleData();
            bd.ReadAllData();

            Displays.SaudacaoInicial();
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                Displays.MenuAreaCliente();
                string opcao1 = Console.ReadLine();

                if (opcao1 == "1")
                {
                    Utilizador cliente = new Utilizador();
                    cliente.NovoCliente(bd.IdUserMaximo() + 1);
                    bd.clientes.Add(cliente);
                    bd.Updatedb();
                    Thread.Sleep(2500);
                    Console.Clear();

                    Cartao cartao = new Cartao();
                    cartao.NovoCartao(cliente, bd.IdCartaoMaximo() + 1);
                    bd.cartoes.Add(cartao);
                    bd.Updatedb();
                    Thread.Sleep(2500);
                    Console.Clear();
                }


                Console.WriteLine("Digite o seu NickName sff");
                string nick = Console.ReadLine();
                if (bd.TemNick(nick))
                {
                    Console.Clear();
                    Displays.Regresso();

                    while (true)
                    {
                        Console.WriteLine();
                        Displays.OpcoesUtilizador();
                        string escolha = Console.ReadLine();

                        if (escolha == "1")
                        {
                            bd.BuscarUtilizador(nick).DisplayDados();
                            Thread.Sleep(3000);
                        }
                        else if (escolha == "2")
                        {
                            Console.Clear();
                            foreach (var show in bd.shows)
                                Console.WriteLine(show.Titulo.ToString());
                            Thread.Sleep(3000);
                        }
                        else if (escolha == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("Qual o Título do Show que pretende avaliar?");
                            string show = Console.ReadLine();
                            Console.WriteLine("Quantas Estrelas? [1 - 5]");
                            int estrelas = Console2.ReadInt();

                            if (bd.TemShow(show))
                            {
                                Console.WriteLine("Indique a descricao em PT");
                                string descricaoPT = Console.ReadLine();
                                Console.WriteLine("Indique a descricao em EN");
                                string descricaoEN = Console.ReadLine();

                                var avaliacao = new Avaliar(bd.BuscarIdShow(show), bd.BuscarUtilizador(nick).Id, estrelas, descricaoPT, descricaoEN, new DateTime());
                                bd.avaliacoes.Add(avaliacao);
                                bd.Updatedb();
                                Console.WriteLine("Avaliação introduzida com sucesso");
                                Thread.Sleep(3000);
                            }
                            else
                                Console.WriteLine("Show não existe");
                            Thread.Sleep(3000);


                        }
                        else if (escolha == "4")
                        {
                            Console.Clear();
                            foreach (var ator in bd.atores)
                                Console.WriteLine(ator.Nome.ToString());
                            Thread.Sleep(3000);
                        }
                        else if (escolha == "5")
                        {
                            Console.Clear();
                            Console.WriteLine("A nossa fantástica seleção de conteúdos:");
                            foreach (var show in bd.shows)
                                Console.WriteLine(show.Titulo.ToString());
                            Console.WriteLine();
                            Console.WriteLine("Qual o título do show que quer ver?");
                            string input = Console.ReadLine();

                            bd.BuscarShow(input);
                            Console.Clear();
                            Console.WriteLine("Vá buscar as pipocas! Vamos visualizar {0}!", input);
                            Thread.Sleep(4000);
                            break;

                        }

                        else
                            break;


                    }

                }
                else
                {
                    Console.WriteLine("Nick inválido!");
                    Console.WriteLine("Por motivos de segurança a página será encerrada");
                }
                Thread.Sleep(2000);
            }

            else if (keyInfo.Key == ConsoleKey.RightArrow) 
            {

                Console.WriteLine("Está registado: Não[1] Sim[2]");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    Administrador administrador = new Administrador();

                    administrador.NovoAdministrador(bd.IdAdminMaximo() + 1);
                    bd.administradores.Add(administrador);
                    bd.Updatedb();
                    Console.WriteLine("Registo concluído com sucesso");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                    Console.Clear();
                    Console.WriteLine("Faça Login para entrar na áerea de administrador");
                    string user = Administrador.InsertUser();
                    string pass = Administrador.InsertPass();

                if (bd.AdminTemUser(user) && bd.AdminTemPassword(pass))

                {
                    Displays.Regresso();
                    Thread.Sleep(2000);
                    Console.Clear();

                    while (true)
                    {
                        Displays.OpcoesAdmin();
                        ConsoleKeyInfo key1Info = Console.ReadKey();

                        if (key1Info.Key == ConsoleKey.LeftArrow)
                        {
                            Displays.MenuShowAdmin();
                            string opcaoShow = Console.ReadLine();

                            if (opcaoShow == "1")
                            {
                                Console.Clear();

                                foreach (var show in bd.shows)
                                    Console.WriteLine(show.Titulo.ToString());
                                Thread.Sleep(2500);
                                Console.WriteLine();
                            }

                            else if (opcaoShow == "2")
                            {
                                var show = new Show();
                                show.NovoShow(+1);
                                bd.shows.Add(show);
                                bd.Updatedb();
                                Thread.Sleep(3000);
                                Console.Clear();
                            }

                            else
                                break;

                        }

                        else if (key1Info.Key == ConsoleKey.DownArrow)
                        {
                            Console.Clear();
                            Displays.MenuAtoresAdmin();
                            string opcaoAtores = Console.ReadLine();

                            if (opcaoAtores == "1")
                            {
                                Console.Clear();
                                foreach (var ator in bd.atores)
                                    Console.WriteLine(ator.Nome.ToString());
                                Thread.Sleep(3000);
                            }

                            else if (opcaoAtores == "2")
                            {
                                var ator = new Ator();

                                ator.NovoAtor(+1);
                                bd.atores.Add(ator);
                                bd.Updatedb();

                                Thread.Sleep(2500);
                                Console.Clear();
                            }

                            else
                                break;

                        }

                        else if (key1Info.Key == ConsoleKey.RightArrow)
                        {
                            var precario = new Precario();

                            precario.NovoPrecario(+1);
                            bd.precarios.Add(precario);
                            bd.Updatedb();
                            Thread.Sleep(2500);
                            Console.Clear();
                        }

                        else if (key1Info.Key == ConsoleKey.UpArrow)
                        {
                            Console.Clear();
                            Console.WriteLine("Lista de clientes atuais:");
                            foreach (var cliente in bd.clientes)
                                Console.WriteLine(cliente.Nome.ToString());
                            Thread.Sleep(2500);
                        }
                    
                        else if (key1Info.Key == ConsoleKey.Escape)
                        break;
                    }
                }

                else
                { 
                 Console.WriteLine("Admin não válido");
                          Console.WriteLine("A página irá encerrar!");
                }
            }
        else if (keyInfo.Key == ConsoleKey.Escape)
        {
            Console.WriteLine("Até breve!");
            Thread.Sleep(1000);
        }

        }
    }
}
