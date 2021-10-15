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

        private bool Excluido {get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Gênero ........: {this.Genero}");
            sb.AppendLine($"Título ........: {this.Titulo}");
            sb.AppendLine($"Descrição .....: {this.Descricao}");
            sb.AppendLine($"Ano de Início .: {this.Ano}");
            sb.AppendLine($"Excluído ......: {(this.Excluido ? "Sim" : "Não")}");
            return sb.ToString();
        }

    }
}