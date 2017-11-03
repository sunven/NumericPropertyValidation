using System.ComponentModel.DataAnnotations;

namespace NumericPropertyValidation.Models
{
    public class Employee
    {
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name = "性别")]
        public string Gender { get; set; }

        [Display(Name = "年龄")]
        public int Age { get; set; }
    }
}