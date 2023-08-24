using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCADS2023.Models
{

    enum Periodo { Diurno, Vespertino, Noturno}

    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [Display(Name = "Nome")]
        [StringLength(35)]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo aniversario é obrigatório")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Aniversário")]
        public DateTime aniversario { get; set; }


        [Required(ErrorMessage = "Campo email é obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email inválido")]
        [Display(Name = "Email")]
        public string email { get; set; }

        public int cursoID { get; set; }
        [Display(Name = "Curso")]
        [ForeignKey("cursoID")]
        public Curso curso { get; set; }

        [Required(ErrorMessage = "Campo período é obrigatório")]
        [Display(Name = "Período")]
        public int periodo { get; set; }
    }
}
