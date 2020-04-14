using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTest.Core.DTO.User
{
    public class UserDto
    {
        public string username { get; set; }
        public string token { get; set; }
        public bool isAdmin { get; set; }
    }
}
