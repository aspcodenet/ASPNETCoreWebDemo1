using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo20210622.Models;

namespace WebDemo20210622.Pages
{
    public class SupplierModel : PageModel
    {
        private readonly ILogger<SupplierModel> _logger;
        private readonly NorthwindContext _dbContext;


        public List<SupplierViewModel> Suppliers { get; set; }

        public class SupplierViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
        }

        public SupplierModel(ILogger<SupplierModel> logger, NorthwindContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Suppliers = _dbContext.Suppliers.Select(r => new SupplierViewModel
            {
                Name = r.CompanyName,
                City = r.City,
                Id = r.SupplierId
            }).OrderBy(r=>r.Name).ToList();

            //Suppliers = new List<SupplierViewModel>
            //{
            //    new SupplierViewModel{Id = 1, City="Stockholm", Name="Hejhopp"},
            //    new SupplierViewModel{Id = 2, City="Test", Name="Hej"},
            //    new SupplierViewModel{Id = 3, City="Test2", Name="Arne"}
            //};
        }
    }
}
