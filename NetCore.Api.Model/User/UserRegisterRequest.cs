﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Api.Model.User
{
    public class UserRegisterRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
