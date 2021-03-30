using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFun.App.Entities;
using XFun.Dtos;

namespace XFun.App.Interfaces
{
    public interface IUserRepository
    {
        UserDto Add(User user);
    }
}
