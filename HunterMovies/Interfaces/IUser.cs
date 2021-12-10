using HunterMovies.Authentication;
using HunterMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HunterMovies.Interfaces
{
    public interface IUser
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        User GetById(Guid id);
    }
}
