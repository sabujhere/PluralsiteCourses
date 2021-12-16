using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HillarysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace HillarysPieShopHRM.Server.Pages
{
    public class EmployeeEditBase:ComponentBase
    {
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        protected override void OnInitialized()
        {
            Employee = new Employee
            {
                CountryId = 1,
                //MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1989, 3, 11),
                City = "Brussels",
                Email = "bethany@bethanyspieshop.com",
                EmployeeId = 1,
                FirstName = "Bethany",
                LastName = "Smith",
                //Gender = Gender.Female,
                PhoneNumber = "324777888773",
                Smoker = false,
                Street = "Grote Markt 1",
                Zip = "1000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1)
            };
        }
    }
}
