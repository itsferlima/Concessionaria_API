// namespace API.Service
// {
//     public static class TokenService
//     {
//         public static string CriarToken(Comprador comprador)
//         {
//             JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
//             byte[] key = Encoding.ASCII.GetBytes(Settings.secret);
//             SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor

//                 //RefreshToken
//                 Expires = DateTime.UtcNow.AddHours(2),
//                 SigningCredentials = new SigningCredentials
//                 (
//                     new SymmetricSecurityKey(key),
//                     SecurityAlgorithms.HmacSha256Signature
//                 ),
//                 Subject = new ClaimsIdentity(new Claim[]
//                 {
//                     new Claim(ClaimTypes.Name, comprador.Email), //User.Identity.Name
//                     new Claim(ClaimTypes.Role, comprador.Permissao)
//                 })
//             }; 
//             SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
//             return tokenHandler.WriteToken(token);
//         }
//     }
           
