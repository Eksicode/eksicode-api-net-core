using EksiCodeBackend.Core.DataAccess;
using EksiCodeBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EksiCodeBackend.DataAccess.Abstract
{
    public interface IUserDal : IRepository<User>
    {
    }
}
