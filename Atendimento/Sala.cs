﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCADS2023.Models
{

    enum Situacao {Livre, Ocupado, Reservado, Manutencao, Outras}

    [Table("Salas")]
    public class Sala
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        [StringLength(25)]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo monitor é obrigatório")]
        [StringLength(30)]
        [Display(Name = "Monitor")]
        public string monitor { get; set; }

        [Required(ErrorMessage = "Campo equipamentos é obrigatório")]
        [Display(Name = "Equipamentos")]
        public int equipamentos { get; set; }

        [Required(ErrorMessage = "Campo situação é obrigatório")]
        [Display(Name = "Situação")]
        public int situacao { get; set; }





    }
}
