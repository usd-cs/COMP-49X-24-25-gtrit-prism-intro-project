﻿using System.ComponentModel.DataAnnotations;

namespace IntroProject.Models
{
    public class User
    {
        [Key] public int User_id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Boolean Admin { get; set; }
    }
}
