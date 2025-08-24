using System;

namespace SchoolManagement.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
        public string Class { get; set; } = default!;
    }
}
