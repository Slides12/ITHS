using System.ComponentModel.DataAnnotations;

namespace DemoDockerComposeAPI_DB.Data.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }
    }
}
