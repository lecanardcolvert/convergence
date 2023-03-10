/* The MIT License (MIT)

Copyright (c) 2021 Jason Watmore

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using convergence_backend.Data;
using convergence_backend.Entities;
using convergence_backend.Helpers;
using convergence_backend.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace convergence_backend.Services;

public interface IUserService
{
    AuthenticateResponse? Authenticate(User user);
    Task<IEnumerable<User>> GetAll();
    Task<User> GetById(int id);
    Task Register(User user);
}

public class UserService : IUserService
{
    private readonly AppSettings _appSettings;
    private readonly AppDbContext _context;

    public UserService(IOptions<AppSettings> appSettings, AppDbContext context)
    {
        _appSettings = appSettings.Value;
        _context = context;
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> GetById(int id)
    {
        User? user = await _context.Users.FindAsync(id);

        if (user == null)
        {
            throw new KeyNotFoundException("Utilisateur non trouvé.");
        }

        return user;
    }

    public async Task Register(User user)
    {
        if (isUsernameExists(user.Username))
        {
            throw new InvalidOperationException("Nom d'utilisateur existant.");
        }

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public AuthenticateResponse? Authenticate(User user)
    {
        User? foundUser = _context.Users.SingleOrDefault(x =>
            x.Username == user.Username &&
            x.Password == user.Password);

        if (foundUser == null)
        {
            return null;
        }

        string token = generateJwtToken(foundUser);

        return new AuthenticateResponse(foundUser, token);
    }

    // Helper methods
    private string generateJwtToken(User user)
    {
        // Generate token that is valid for 7 days
        JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
        byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] {
                new Claim("id", user.Id.ToString())
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };

        SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    private bool isUsernameExists(string username)
    {
        return _context.Users.Any(u => u.Username == username);
    }
}
