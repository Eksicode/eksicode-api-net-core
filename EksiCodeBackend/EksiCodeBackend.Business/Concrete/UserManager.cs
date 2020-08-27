using System;
using System.Collections.Generic;
using EksiCodeBackend.Business.Abstract;
using EksiCodeBackend.Business.Contants;
using EksiCodeBackend.Business.ValidationRules.FluentValidation;
using EksiCodeBackend.Core.Aspects.Validation;
using EksiCodeBackend.Core.CrossCuttingConcerns.Validation;
using EksiCodeBackend.Core.Utilities.Results;
using EksiCodeBackend.DataAccess.Abstract;
using EksiCodeBackend.Entities.Concrete;

namespace EksiCodeBackend.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserValidator), Priority = 1)]
        public IResult Add(User user)
        {
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetList()
        {
            var result = _userDal.GetList();
            return new SuccessDataResult<List<User>>(result);
        }
    }
}
