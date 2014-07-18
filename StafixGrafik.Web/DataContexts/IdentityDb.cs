using Microsoft.AspNet.Identity.EntityFramework;
using StafixGrafik.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StafixGrafik.Web.DataContexts
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection")
        {
        }
    }
}