using FluentApplication.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FluentApplication.Validator
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            IRuleBuilder<Student, string> ruleBuilder = GetRuleBuilder("Name");
            ruleBuilder.NotEmpty().Length(5);
        }

        private IRuleBuilder<Student, string> GetRuleBuilder(string Field)
        {
            return RuleFor(SelectField(Field));
        }


        //RuleSet("MyRule", () => {
        //    RuleFor(x => x.StudentId).NotNull();
        //    RuleFor(x => x.Name).NotEmpty().MinimumLength(10).MaximumLength(20);
        //});
        //RuleFor(x => x.StudentId).NotNull();
        //RuleFor(x => x.Name).NotEmpty().MinimumLength(4).MaximumLength(10);
        //RuleFor(x => x.Age).InclusiveBetween(25, 30);
        //RuleFor(x => x.EmailId).EmailAddress();


        private Expression<Func<Student, string>> SelectField(string Field)
        {
            var x = Expression.Parameter(typeof(Student), "x");
            var body = Expression.PropertyOrField(x, Field);
            Expression conversion = Expression.Convert(body, typeof(string));
            var lambda = Expression.Lambda<Func<Student, string>>(conversion, x);
            return lambda;
        }
    }
}
