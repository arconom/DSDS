﻿using Core.Interfaces;
using Core.Models;
using DecisionSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecisionSystem.Repository
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
