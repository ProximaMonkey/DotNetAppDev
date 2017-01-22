﻿using FirstsStepsRUI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstsStepsRUI.Repositories
{
   public interface IUserRepository
   {
      Task<User> Login(string userName, string unsecurePassword);
      Task<IList<Menu>> GetMenuByUser(User user);
      Task<bool> Submit(User user);
   }
}
