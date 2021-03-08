using System;
namespace projLista
{
    public class Serie : EntidadeBase
    {
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Gênero: {this.Genero}" + Environment.NewLine;
            retorno += $"Título: {this.Titulo}" + Environment.NewLine;
            retorno += $"Descrição: {this.Descricao}" + Environment.NewLine;
            retorno += $"Ano de início: {this.Ano}" + Environment.NewLine;
            retorno += $"Série excluída: {this.Excluido}" + Environment.NewLine;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    } 
}