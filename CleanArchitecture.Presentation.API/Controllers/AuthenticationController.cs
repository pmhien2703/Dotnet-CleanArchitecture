﻿using CleanArchitecture.Application.Authentication;
using CleanArchitecture.Presantation.Contracts.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.API.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResutl = _authenticationService.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password
                );

            var response = new AuthenticationResponse(
                authResutl.Id,
                authResutl.FirstName,
                authResutl.LastName,
                authResutl.Email,
                authResutl.Token
                );
            return Ok(request);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request) 
        {
            var authResult = _authenticationService.Login(request.Email, request.Password);
            var response = new AuthenticationResponse(
                authResult.Id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token
                );
            return Ok(response);
        }
    }
}
