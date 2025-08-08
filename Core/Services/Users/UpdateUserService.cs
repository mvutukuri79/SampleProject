using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;

namespace Core.Services.Users
{
    [AutoRegister(AutoRegisterTypes.Singleton)]
    public class UpdateUserService : IUpdateUserService
    {
        public void Update(User user, string name, string email, UserTypes type, int age, decimal? annualSalary, IEnumerable<string> tags)
        {
            user.SetEmail(email);
            user.SetName(name);
            user.SetType(type);         
            
            if (annualSalary is null)
            {
                throw new ArgumentNullException("Annual Salary is not provided.");
            }

            user.SetMonthlySalary(annualSalary.Value / 12);
            user.SetTags(tags);
            user.SetAge(age);
        }
    }
}