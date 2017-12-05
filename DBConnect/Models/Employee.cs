using System.ComponentModel.DataAnnotations.Schema;
namespace DBConnect.Models
{
    [Table("employees")]
    public class Employee
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("surname")]
        public string Surname { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("age")]
        public int Age { get; set; }

        [Column("sex")]
        public string Sex { get; set; }

        [Column("date_of_birth")]
        public int DateOfBirth { get; set; }

        [Column("is_deleted")]
        public int IsDeleted { get; set; }
    }
}
