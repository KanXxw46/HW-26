using System;
using System.Collections.Generic;
using System.Text;

namespace HW26
{
    public class User : Entity
    {
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Profile Profile { get; set; }

        public Guid ProfileId { get; set; }
    }
}
