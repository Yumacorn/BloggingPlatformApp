using Microsoft.AspNetCore.Authorization;

namespace AuthorizationPolicies.Policies.Requirements;

public class isLoggedInRequirement : IAuthorizationRequirement
{
    public isLoggedInRequirement(bool loggedIn) =>
        isLoggedIn = loggedIn;

    public bool isLoggedIn { get; }
}
