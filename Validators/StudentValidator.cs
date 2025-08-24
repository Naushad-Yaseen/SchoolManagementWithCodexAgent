using FluentValidation;
using SchoolManagement.Models;

namespace SchoolManagement.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.DateOfBirth).NotEmpty();
            RuleFor(x => x.Class).NotEmpty();
        }
    }
}
