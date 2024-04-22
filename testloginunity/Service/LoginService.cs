using System;
using testloginunity.DTO;
using testloginunity.IRepository;
using testloginunity.IService;

namespace testloginunity.Service
{
	public class LoginService: ILoginService
	{
		private readonly ILoginRepository _loginRepository;

		public LoginService(ILoginRepository loginRepository)
		{
			_loginRepository = loginRepository;
		}


        async Task<string> ILoginService.LoginService(LoginDto dto)
        {
            return await _loginRepository.Login(dto);
        }
    }
}

