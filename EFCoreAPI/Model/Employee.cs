using System.ComponentModel.DataAnnotations;

namespace EFCoreAPI.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        
    }

}
