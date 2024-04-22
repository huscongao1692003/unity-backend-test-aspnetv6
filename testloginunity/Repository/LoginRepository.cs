using System;
using Microsoft.EntityFrameworkCore;
using testloginunity.DTO;
using testloginunity.IRepository;
using testloginunity.Models;

namespace testloginunity.Repository
{
	public class LoginRepository : ILoginRepository
	{

		private readonly appsoftspaceContext _context;
		public LoginRepository(appsoftspaceContext context)
		{
			_context = context;
		}

		public async Task<string> Login(LoginDto dto)
		{
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == dto.Username && x.Password == dto.password);

            if (user != null)
            {
                    // Passwords match, login successful
                    return "Login successful!";
                
            }

            // Login failed
            return "Invalid username or password.";
        }
	}
}

