﻿using Microsoft.AspNetCore.Identity;

namespace BookShop.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? City {  get; set; }
    }
}
