using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTest.Core.DTO.User
{
    public class RegisterConfirmDto
    {
        public string UserId { get; set; }
        public string Code { get; set; }
    }
}
