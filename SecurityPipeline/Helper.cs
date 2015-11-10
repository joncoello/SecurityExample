using System;
using System.Diagnostics;
using System.Security.Principal;

namespace SecurityPipeline
{
    class Helper
    {
        public Helper()
        {
        }

        internal static void Write(string stage, IPrincipal principal)
        {
            Debug.WriteLine("------" + stage + "------");
            if (principal == null || principal.Identity == null || !principal.Identity.IsAuthenticated)
            {
                Debug.WriteLine("annonymous user");
            }
            else
            {
                Debug.WriteLine("user: " + principal.Identity.Name);
            }
            Debug.WriteLine("\n");
        }
    }
}