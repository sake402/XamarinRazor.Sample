using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace XaaRinRazor.Sample.Services
{
    public class AuthenticationProvider : AuthenticationStateProvider, IAuthorizationPolicyProvider, IAuthorizationService, IAuthorizationRequirement
    {
        public AuthenticationProvider()
        {
        }

        public async Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object resource, IEnumerable<IAuthorizationRequirement> requirements)
        {
            return user.Identity != null ? AuthorizationResult.Success() : AuthorizationResult.Failed();
        }

        public async Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object resource, string policyName)
        {
            return user.Identity != null ? AuthorizationResult.Success() : AuthorizationResult.Failed();
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return new AuthenticationState(new ClaimsPrincipal());
        }

        public async Task<AuthorizationPolicy> GetDefaultPolicyAsync()
        {
            return new AuthorizationPolicy(new IAuthorizationRequirement[] { this }, new string[] { });
        }

        public async Task<AuthorizationPolicy> GetFallbackPolicyAsync()
        {
            return new AuthorizationPolicy(new IAuthorizationRequirement[] { this }, new string[] { });
        }

        public async Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            return new AuthorizationPolicy(new IAuthorizationRequirement[] { this }, new string[] { });
        }
    }
}
