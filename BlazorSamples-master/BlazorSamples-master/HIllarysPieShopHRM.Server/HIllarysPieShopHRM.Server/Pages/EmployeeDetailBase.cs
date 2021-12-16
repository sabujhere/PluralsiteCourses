using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HillarysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace HillarysPieShopHRM.Server.Pages
{
    public class EmployeeDetailBase:ComponentBase
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        public IEnumerable<Employee> Employees { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitializeEmployees();

            Employee = Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));


            return base.OnInitializedAsync();
        }

        private void InitializeEmployees()
        {
            var e1 = new Employee
            {
                CountryId = 1,
                BirthDate = new DateTime(1989, 3, 11),
                City = "Brussels",
                Email = "bethany@bethanyspieshop.com",
                EmployeeId = 1,
                FirstName = "Bethany",
                LastName = "Smith",
                PhoneNumber = "324777888773",
                Smoker = false,
                Street = "Grote Markt 1",
                Zip = "1000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1)
            };

            var e2 = new Employee
            {
                CountryId = 2,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Antwerp",
                Email = "gill@bethanyspieshop.com",
                EmployeeId = 2,
                FirstName = "Gill",
                LastName = "Cleeren",
                PhoneNumber = "33999909923",
                Smoker = false,
                Street = "New Street",
                Zip = "2000",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24)
            };
            Employees = new List<Employee> { e1, e2 };
        }
    }
}
