using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroFuncionarios.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Nome completo")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Matrícula")]
        public int EmpCode { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Cargo")]
        public int Position { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Localização")]
        public int OfficeLocation { get; set; }
    }
}
