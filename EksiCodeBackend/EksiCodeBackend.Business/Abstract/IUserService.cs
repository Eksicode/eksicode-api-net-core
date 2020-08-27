using System;
using System.Collections.Generic;
using EksiCodeBackend.Core.Utilities.Results;
using EksiCodeBackend.Entities.Concrete;

namespace EksiCodeBackend.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetList();
        IResult Add(User user);
    }
}
