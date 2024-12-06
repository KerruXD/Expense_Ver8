﻿using ASI.Basecode.Data.Models;
using ASI.Basecode.Services.ServiceModels;
using System.Threading.Tasks;
using static ASI.Basecode.Resources.Constants.Enums;

namespace ASI.Basecode.Services.Interfaces
{
    public interface IUserService
    {
        LoginResult AuthenticateUser(string userEmail, string password, ref User user);
        void AddUser(UserViewModel model);
        User GetUserByEmail(string userEmail);
        void UpdateUser(User user);
        User GetUserNameByEmail(string Email);
    }
}
