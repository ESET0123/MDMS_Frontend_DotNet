using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MDMS_Frontend.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeRoleAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string[] _allowedRoles;

        public AuthorizeRoleAttribute(params string[] roles)
        {
            _allowedRoles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Check if JWT token exists
            var token = context.HttpContext.Request.Cookies["jwtToken"];
            var userRole = context.HttpContext.Request.Cookies["userType"];

            // If no token OR no userType, user is not authenticated - redirect to login
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(userRole))
            {
                //context.Result = new ViewResult
                //{
                //    ViewName = "~/Views/Shared/Unauthorized.cshtml"
                //};
                context.Result = new RedirectToActionResult("Login", "Auth", null);
                return;
            }

            // User is authenticated but check if they have the right role
            if (!_allowedRoles.Contains(userRole, StringComparer.OrdinalIgnoreCase))
            {
                // User is logged in but doesn't have permission - show unauthorized page
                context.Result = new ViewResult
                {
                    ViewName = "~/Views/Shared/Unauthorized.cshtml"
                };
                return;
            }

            // User is authenticated AND authorized - allow access
        }
    }
}