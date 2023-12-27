namespace jwtWebAPI.Documents
{
    public class RoadMap
    {
        #region RoadMap
        /*
            1. Hiểu Về JWT:
                Tìm hiểu về cấu trúc và nguyên tắc hoạt động của JSON Web Token (JWT).
                Nắm vững các thành phần chính của JWT: Header, Payload, Signature.

            2. Cài Đặt Gói NuGet Cho JWT:
                Sử dụng Gói NuGet "Microsoft.AspNetCore.Authentication.JwtBearer" để thêm hỗ trợ JWT vào dự án của bạn.

            3. Cấu Hình JWT Middleware:
                Cấu hình JWT Middleware trong Startup.cs để xác định cách ứng dụng của bạn sẽ xác thực và xử lý JWT.
                csharp
                Copy code
                public void ConfigureServices(IServiceCollection services)
                {
                    // Cấu hình xác thực JWT
                    services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                        .AddJwtBearer(options =>
                        {
                            options.TokenValidationParameters = new TokenValidationParameters
                            {
                                ValidateIssuer = true,
                                ValidateAudience = true,
                                ValidateLifetime = true,
                                ValidateIssuerSigningKey = true,
                                ValidIssuer = "your_issuer",
                                ValidAudience = "your_audience",
                                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key"))
                            };
                        });

                    // Cấu hình các dịch vụ khác...
                }

                public void Configure(IApplicationBuilder app, IHostingEnvironment env)
                {
                    // Sử dụng xác thực JWT
                    app.UseAuthentication();

                    // Cấu hình middleware và routing khác...
                }

            4. Phát Hành JWT (JWT Signing):
                Hiểu cách tạo và phát hành JWT bằng cách sử dụng một khóa bí mật (secret key).
                csharp
                Copy code
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes("your_secret_key");

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, "username"),
                        new Claim(ClaimTypes.Role, "user_role")
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);

            5. Xác Thực JWT:
                Xác minh tính hợp lệ của JWT và trích xuất thông tin từ JWT để xác thực người dùng.
                csharp
                Copy code
                [Authorize]
                [ApiController]
                [Route("api/[controller]")]
                public class SampleController : ControllerBase
                {
                    [HttpGet("secure-endpoint")]
                    public IActionResult SecureEndpoint()
                    {
                        // Đã xác thực thành công, thực hiện công việc bảo mật ở đây
                        return Ok("This is a secure endpoint.");
                    }
                }

            6. Tự Động Gia Hạn Token (Refresh Token - Tuỳ Chọn):
                Hiểu và triển khai cơ chế refresh token để gia hạn thời gian sống của token.

            7. Xử Lý Lỗi và Exception:
                Xử lý các trường hợp lỗi liên quan đến xác thực JWT.

            8. Tích Hợp Với Identity và Roles (Tuỳ Chọn):
                Tích hợp JWT với Identity Framework để quản lý người dùng và vai trò.

            9. Bảo Mật và Best Practices:
                Hiểu và triển khai các biện pháp bảo mật như HTTPS, bảo vệ khóa bí mật, cấu hình hợp lý cho JWT.
                Lưu ý rằng, khi triển khai JWT trong ứng dụng của bạn, bạn cần đảm bảo rằng bạn tuân thủ các chuẩn bảo mật và thực hành tốt nhất để tránh các lỗ hổng bảo mật.
         */
        #endregion
        #region Summary JWT
        /*
            https://jwt.io/introduction
            What is the Json Web Token structure?
            + Header: The type of token( jwt), the signing algorithm.
            + Payload: This cantains the claims. Claims are statements about an entity and addtional data. 
            There are three type of  claims: registered, public and private claims.
	            Registered claims: these are a set of predefined claims which are not mandatory but recommeded, to provide a set of userful, interoperable claims.
	            Public claims:
	            Private claims:
            + Signature: To create the signature part you have t o take the encoded header, the encoded payload, a secret, the algorithm specified in the header and sign that.

            How do JSON Web Tokens work?
            In authentication, when the user succesfully logs in using their credetials, a jwt will be returned.
            Since tokens are credentials, great care musst be taken to prevent security issues.In general, you should not keep tokens longer than required.
            You also shouldn't store sentitive session data in browser storage due to lack of security.
            Whenever the user wants to access a protected route or ressource, the user agent should send the JWT, typocally in the authorization header using the bearer schema.

            Set up JWT
            Step 1: Add the Microsoft.AspNetCore.Authentication.JwtBearer NuGet package to our project.
            Step 2: Implement JWT authentication in the Program.cs file.
            Step 3: Config Middle ware
            Step 4: Create Token generation method
         */
        #endregion
        #region Renew a expired token time
        /*
         https://code-maze.com/using-refresh-tokens-in-asp-net-core-authentication/        
         */
        #endregion
    }
}
