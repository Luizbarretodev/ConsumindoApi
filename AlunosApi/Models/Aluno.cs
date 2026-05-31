using System.ComponentModel.DataAnnotations;

namespace AlunosApi.Models
{
    //Poderia definir como tabela digitando [Table("Alunos")], mas já definimos no context
    public class Aluno
    {
        //Poderia utilizar o DA [Key], mas o EF entende que ID é uma PK
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(80)]
        public string Email { get; set; }

        [Required]
        public int Idade { get; set; }
    }
}
