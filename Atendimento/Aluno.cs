using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCADS2023.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(35)]
        public string descricao { get; set; }
        public DateTime aniversario { get; set; }
        public Curso curso { get; set; }
        public string periodo { get; set; }
    }
}
