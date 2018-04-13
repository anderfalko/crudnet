using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public partial class Categoria
    {
        public int ID { get; set; }
        //[Required]
        //[StringLength(100, MinimumLength = 3)]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        //[StringLength(10, MinimumLength = 3)]
        public string Referencia { get; set; }

        public Categoria() { }

        public Categoria(string descricao)
        {
            Descricao = descricao;
        }

        public Categoria(string descricao, string referencia)
        {
            Descricao = descricao;
            Referencia = referencia;
        }
    }
}
