using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace MyEventsProject.Services
{
    public class ClaimsService
    {
        public static bool HasClaimCanEditProducts(ClaimsPrincipal user)
        {


            if (user.HasClaim("CanEditProducts", "true"))
            {
                return true;
            };
            return false;

        }
    }
}