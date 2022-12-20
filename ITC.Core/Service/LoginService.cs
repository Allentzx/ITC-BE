using System;
using AutoMapper;
using ITC.Core.Common;
using ITC.Core.Data;
using ITC.Core.Interface;
using ITC.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITC.Core.Service
{
    public class LoginService : ILoginService
    {
        private readonly ITCDBContext _context;
        private readonly IMapper _mapper;
        public LoginService(ITCDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public User AuthenticateUser(string userName, string password)
        {
            var user = _context.Users
                           .Include(e => e.RoleUsers).ThenInclude(e => e.Roles)
                           .FirstOrDefault(e => e.Username.Equals(userName) && e.IsActive == true);

            if (user != null)
            {
                if (!Encryption.GenerateMD5(password).Equals(user.Password)) user = null;
            }

            return user;
        }
    }
}

