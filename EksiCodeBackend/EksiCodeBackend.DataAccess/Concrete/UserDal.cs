using EksiCodeBackend.Core.DataAccess;
using EksiCodeBackend.DataAccess.Abstract;
using EksiCodeBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EksiCodeBackend.DataAccess.Concrete
{
    public class UserDal : BaseRepository<User, EksiCodeBackendContext>, IUserDal
    {
    }
}
