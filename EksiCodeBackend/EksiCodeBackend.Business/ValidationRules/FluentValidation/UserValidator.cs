using System;
using FluentValidation;
using EksiCodeBackend.Business.Contants;
using EksiCodeBackend.Entities.Concrete;

namespace EksiCodeBackend.Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {

        }
    }
}
