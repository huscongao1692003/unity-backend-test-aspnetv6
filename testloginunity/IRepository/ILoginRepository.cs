using System;
using testloginunity.DTO;

namespace testloginunity.IRepository
{
	public interface ILoginRepository
	{
		Task<string> Login(LoginDto loginDto);
	}
}

