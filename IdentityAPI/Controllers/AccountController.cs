//using IdentityAPI.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;

//namespace IdentityAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AccountController : ControllerBase
//    {
//        private readonly UserManager<IdentityUser> _userManager;
//        private readonly SignInManager<IdentityUser> _signInManager;
//        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
//        {
//            _signInManager = signInManager;
//            _userManager = userManager;
//        }

//        [HttpPost]
//        [Route("login")]
//        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                // Authenticate the user
//                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);

//                if (result.Succeeded)
//                {
//                    // User login successful
//                    return Ok();
//                }
//                else
//                {
//                    // User login failed
//                    return BadRequest("Invalid login credentials");
//                }
//            }
//            else
//            {
//                // Invalid model state
//                return BadRequest(ModelState);
//            }
//        }
//        [HttpPost]
//        [Route("register")]
//        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                // Create a new IdentityUser
//                var user = new IdentityUser
//                {
//                    UserName = model.Username,
//                    Email = model.Email
//                };

//                // Register the user
//                var result = await _userManager.CreateAsync(user, model.Password);

//                if (result.Succeeded)
//                {
//                    // User registration successful
//                    return Ok();
//                }
//                else
//                {
//                    // User registration failed
//                    return BadRequest(result.Errors);
//                }
//            }
//            else
//            {
//                // Invalid model state
//                return BadRequest(ModelState);
//            }
//        }
//        [HttpPost]
//        [Route("logout")]
//        public IActionResult Logout()
//        {
//            return Ok();
//        }
        
//    }
//}
