using HOST_Telery.Config;
using HOST_Telery.Models;
using HOST_Telery.Repository;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs.Requets;
using TechStore.Utils;

namespace HOST_Telery.Controller.V1.Auth
{
    [Route("api/v1/auth")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class AuthController : ControllerBase
    {
        protected readonly IEmployeeRepository servicios;

        public AuthController(IEmployeeRepository employeeRepository)
        {
            servicios = employeeRepository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginDTO data)
        {
            var employee = await servicios.GetByEmail(data.Email);

            if (employee == null)
            {
                return BadRequest("El usuario no existe");
            }

            // Verificar la contraseña hasheada
            bool isPasswordValid = PasswordHasher.VerifyPassword(data.Password, employee.Password);

            if (!isPasswordValid)
            {
                return BadRequest("Contraseña incorrecta");
            }

            var token = JWT.GenerateJwtToken(employee);

            return Ok($"ACA ESTA SU TOKEN: {token}");
        }

    }
}