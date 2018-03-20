﻿using Microsoft.AspNetCore.Identity;

namespace AspNetCoreID.Models
{
    public class PluralsightUser: IdentityUser
    {
        public string Locale { get; set; } = "en-GB";
        public string OrgId { get; set; }
    }

    public class Organization
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}