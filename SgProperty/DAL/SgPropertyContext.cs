using Microsoft.AspNet.Identity.EntityFramework;
using SgProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SgProperty.DAL
{
    public class SgPropertyContext : IdentityDbContext<ApplicationUser>
    {
        public SgPropertyContext()
            : base("SGpropertyDB", throwIfV1Schema: false)
        {
        }

        public static SgPropertyContext Create()
        {
            return new SgPropertyContext();
        }
    }
    
}