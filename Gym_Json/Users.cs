﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Json
{
    class Users
    {
        public List<User> userData;

        public void Add(User user)
        {
            userData.Add(user);
        }
    }
}
