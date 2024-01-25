using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }

        public User()
        {
            SetDefaultValues();
        }

        public void SetDefaultValues()
        {
            Id = -1;
            Email = "none";
            PhotoPath = @"~\image\default.jpg";
            Name = "Guest";
            Surname = "Visitor";
        }

    }
}
