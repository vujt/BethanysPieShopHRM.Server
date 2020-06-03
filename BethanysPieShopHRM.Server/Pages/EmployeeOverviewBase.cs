﻿using BethanysPieShopHRM.Server.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

        private List<Country> Countries { get; set; }

        private List<JobCategory> JobCategories { get; set; }

     

    }
}
