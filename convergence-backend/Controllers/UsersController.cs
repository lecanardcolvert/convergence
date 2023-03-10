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

using AutoMapper;
using convergence_backend.Entities;
using convergence_backend.Models.Users;
using convergence_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace convergence_backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IUserService _userService;

    public UsersController(IMapper mapper, IUserService userService)
    {
        _mapper = mapper;
        _userService = userService;
    }

    // GET: api/Users
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        IEnumerable<User> users = await _userService.GetAll();
        return new List<User>(users);
    }

    // GET: api/Users/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int id)
    {
        try
        {
            User user = await _userService.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPost]
    public async Task<ActionResult<User>> Register(RegisterRequest registerModel)
    {
        User user = _mapper.Map<User>(registerModel);

        if (user == null)
        {
            return BadRequest(new
            {
                message = "Une erreur s'est produite. Veuillez recommencer."
            });
        }

        try
        {
            await _userService.Register(user);
        }
        catch (InvalidOperationException)
        {
            return BadRequest(new { message = "Le nom d'utilisateur existe déjà." });
        }

        return CreatedAtAction("GetUser", new { id = user.Id }, user);
    }

    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticateRequest authenticateModel)
    {
        User user = _mapper.Map<User>(authenticateModel);

        AuthenticateResponse response = _userService.Authenticate(user);

        if (response == null)
            return BadRequest(new { message = "Le nom d'utilisateur ou le mot de passe est incorrect." });

        return Ok(response);
    }
}
