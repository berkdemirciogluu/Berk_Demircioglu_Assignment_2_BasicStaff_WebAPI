using Business.Constants;
using Business.Utilities.Results;
using Entities.Concrete;
using FluentValidation;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class StaffValidator:AbstractValidator<Staff>
    {
        public StaffValidator()
        {
            //Considering the possibility of adding a condition to any rule in the future, all rules were given in separate lines.
            //For example, the minimumLength and maximumLength for the LastName could be written on a single line. 

            RuleFor(s => s.Id).NotEmpty(); //Id cannot be empty. 
            RuleFor(s => s.Name).MinimumLength(2);  //A name can contain a minimum of 2 characters.
            RuleFor(s => s.Name).MaximumLength(50); //A name can contain a maximum of 50 characters.
            RuleFor(s => s.LastName).MinimumLength(2); //A Lastname can contain a minimum of 2 characters.
            RuleFor(s => s.LastName).MaximumLength(50); //A Lastname can contain a maximum of 50 characters.
            RuleFor(s => s.Name).Must(IsValidName).WithMessage(Messages.StaffNameInvalid);//Name validation with a defined method.
            RuleFor(s => s.LastName).Must(IsValidName).WithMessage(Messages.StaffLastNameInvalid);//Name validation with a defined method.
            RuleFor(s => s.DateOfBirth).Must(IsValidDateOfBirth).WithMessage(Messages.StaffDateOfBirthInvalid);//Date of Birth validation with a defined method.
            RuleFor(s => s.PhoneNumber).Must(IsValidPhoneNumber).WithMessage(Messages.StaffPhoneNumberInvalid);////Phone number validation with a defined method.
            RuleFor(s => s.Salary).LessThan(9000);//The salary can be maximum 9000.
            RuleFor(s => s.Salary).GreaterThan(2000);//The salary can be minimum 2000.
            RuleFor(s => s.Email).Must(IsValidEmailAddress).WithMessage(Messages.StaffEmailInvalid);////Email validation with a defined method.
            RuleFor(s => s.Email).EmailAddress();
        }

        private bool IsValidPhoneNumber(string arg)
        {

            //^ => start anchor
            //\+-character => '+'
            //\d{1,2) => any digit repeating min 1 and max 4 times
            //[1 - 9] => any digit apart from 0, taking place exactly once
            //\d{ 0,9} => -any digit repeating min 0 and max 9 times
            //$ => end anchor
            //maximum length of a phone number can be 13 considering for example +05057248888

            return (Regex.IsMatch(arg, @"^\+\d{1,2}[1-9]\d{0,9}$")) && (arg.Length==13);
        }

        private bool IsValidName(string arg)
        {
            //A name cannot contain any special characters or numbers.
            return Regex.IsMatch(arg, @"^[a-zA-Z]+$");
        }

        private bool IsValidDateOfBirth(DateTime arg)
        {
            //Date of Birth has to be between 11.11.1945 and 10.10.2002

            DateTime upperBound = new DateTime(2002,10,10);
            DateTime lowerBound = new DateTime(1945, 11, 11);

            return arg > lowerBound && arg < upperBound;
        }

        private bool IsValidEmailAddress(string arg)
        {
            //An email cannot contain any special characters or numbers except "." and "@".
            return Regex.IsMatch(arg, @"^[a-zA-Z.@]+$");
        }
    }
}
