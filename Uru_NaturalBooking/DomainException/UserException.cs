﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainException
{
    public class UserException: Exception
    {
        public UserException(String message) : base(message) { }
    }
}
