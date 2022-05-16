using System;

namespace Warren.StudyCource.CustomerService.API.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
