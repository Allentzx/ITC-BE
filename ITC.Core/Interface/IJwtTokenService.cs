using System;
using ITC.Data.Entities;
using System.Security.Claims;

namespace ITC.Core.Interface
{
	public interface IJwtTokenService
	{
        string GenerateTokenUser(User account);
        Task<string> GenerateTokenDMSAsync(User account);
        string GenerateToken(params Claim[] claims);
    }
}

