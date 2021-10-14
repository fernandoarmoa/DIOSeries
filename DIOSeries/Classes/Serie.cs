using System.Text;
using DIOSeries.Enums;

namespace DIOSeries.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Gênero ........: {this.Genero}");
            sb.AppendLine($"Título ........: {this.Titulo}");
            sb.AppendLine($"Descrição .....: {this.Descricao}");
            sb.AppendLine($"Ano de Início .: {this.Ano}");
            return sb.ToString();
        }

    }
}