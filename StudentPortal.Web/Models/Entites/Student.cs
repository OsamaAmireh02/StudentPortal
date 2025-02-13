﻿using System.Reflection.Metadata.Ecma335;

namespace StudentPortal.Web.Models.Entites
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Subscribed { get; set; }
    }
}
