using InternsManager.BL.Interfaces;
using InternsManager.TL.DTO;
using Microsoft.AspNetCore.Mvc;

namespace InternsManager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        private readonly IAdminLogic _adminLogic;

        public AdminController(IAdminLogic adminLogic)
        {
            _adminLogic = adminLogic ?? throw new ArgumentNullException(nameof(adminLogic));
        }

        /// <summary>
        /// Get all admins
        /// </summary>
        /// <returns>a list of all admins</returns>
        /// <response code="200">All admins are listed</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Server problems</response>
        /// <response code="429">Too Many Requests</response>
        [HttpGet]
        public async Task<IActionResult> GetAdmins()
        {
            return Ok(await _adminLogic.GetAll());
        }

        /// <summary>
        /// Verify if the username match
        /// </summary>
        /// <returns>id of the person that owns the account</returns>

        /// <param name="username"></param>
        /// <response code="404">Not Found</response>
        /// <response code="500">Server problems</response>
        /// <response code="429">Too Many Requests</response>
        [HttpGet("verify/username")]
        public async Task<IActionResult> VerifyUsername([FromBody] string username)
        {
            return Ok(await _adminLogic.VerifyUsername(username));
        }

        /// <summary>
        /// Verify if the password match
        /// </summary>
        /// <returns>id of the person that owns the account</returns>
        /// <param name="password"></param>
        /// <response code="404">Not Found</response>
        /// <response code="500">Server problems</response>
        /// <response code="429">Too Many Requests</response>
        [HttpGet("verify/password")]
        public async Task<IActionResult> VerifyPassword([FromBody] string password)
        {
            return Ok(await _adminLogic.VerifyPassword(password));
        }


        /// <summary>
        /// Get admin by id
        /// </summary>
        /// <param Name="id"></param>
        /// <returns>admin</returns>
        /// <response code="200">admin found</response>
        /// <response code="404">admin not found</response>
        /// <response code="500">Server problems</response>
        /// <response code="429">Too Many Requests</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdmin([FromRoute] int id)
        {
            return Ok(await _adminLogic.GetById(id));
        }

        /// <summary>
        /// Create an admin record
        /// </summary>
        /// <param Name="admin"></param>
        /// <response code="200">admin created</response>
        /// <response code="500">Server problems</response>
        /// <response code="429">Too Many Requests</response>
        [HttpPost("create")]
        public async Task<IActionResult> CreateAdmin([FromBody] AdminDTO admin)
        {
            if (admin == null)
            {
                return BadRequest("Admin record should not be null");
            }

            await _adminLogic.AddAdmin(admin);

            return Ok(await _adminLogic.GetAll());
        }

        /// <summary>
        /// Update an admin record
        /// </summary>
        /// <param Name="id"></param>
        /// <param Name="admin"></param>
        /// <returns></returns>
        /// <response code="200">Admin record was updated</response>
        /// <response code="404">The admin record can't be created</response>
        /// <response code="400">The admin record can't be null</response>
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateAdmin([FromRoute] int id, [FromBody] AdminDTO admin)
        {

            if (admin == null)
            {
                return BadRequest("Admin record can't be null");
            }

            if (!await _adminLogic.UpdateAdmin(id, admin))
            {
                return NotFound("Admin record not found");
            }

            return Ok(await _adminLogic.GetAll());
        }

        /// <summary>
        /// Delete an admin record
        /// </summary>
        /// <param Name = "id" ></param >
        /// <returns ></returns >
        /// <response code="200">Admin record deleted</response>
        /// <response code="404">Admin record not found</response>

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteAdmin([FromRoute] int id)
        {
            AdminDTO admin = await _adminLogic.GetById(id);
            bool ok = await _adminLogic.RemoveAdmin(admin);

            if (!ok)
            {
                return NotFound("Admin record Not Found");
            }

            return Ok("Admin record deleted");
        }
    }
}
