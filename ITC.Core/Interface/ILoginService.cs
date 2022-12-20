using System;
using ITC.Data.Entities;

namespace ITC.Core.Interface
{
    public interface ILoginService
    {
        User AuthenticateUser(string userName, string password);
    }
}

