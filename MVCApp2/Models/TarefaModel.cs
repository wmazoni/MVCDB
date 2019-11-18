using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp2.Models
{
    public class TarefaModel
    {

        //public int TarefaId { get; set; }

        [Display(Name = "Nome")]
        [StringLength(50, ErrorMessage = "O nome da tarefa pode ter no máximo 50 caracteres")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Data Entrega")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

    }
}