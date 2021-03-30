using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Movie4AllCsharpPT
{
    public class Avaliar: Utilizador
    {
        public int IdShow { get; set; }
        public int IdUser { get; set; }
        public int Stars { get; set; }
        public string Descricao { get; set; }
        public string DescricaoEN { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataUpdate { get; set; }

        public Avaliar(int show, int user, int estrelas, string descricao, string descricaoEN, DateTime data)
        {
            IdShow = show;
            IdUser = user;
            Stars = estrelas;
            Descricao = descricao;
            DescricaoEN = descricaoEN;
            DataCriacao = data;
            DataUpdate = data;
        }

        public Avaliar()
        {

        }
        



    }
}
