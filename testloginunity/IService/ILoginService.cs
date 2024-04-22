using System;
using testloginunity.DTO;

namespace testloginunity.IService
{
	public interface ILoginService
	{
        Task<string> LoginService(LoginDto dto);
    }
}

