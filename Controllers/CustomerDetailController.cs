using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;


namespace api.Controllers
{
    [Route("api/CustomerDetail")]
    [ApiController]
    public class CustomerDetailController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CustomerDetailController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var CustomerDetails = _context.CustomerDetail.ToList();

            return Ok(CustomerDetails);
        }


        [HttpGet("{mobilenumber}")]
        public IActionResult GetById([FromRoute] long mobilenumber)
        {
            var CustomerDetail = _context.CustomerDetail.Find(mobilenumber);

            if (CustomerDetail == null)
            {
                return NotFound();
            }

            return Ok(CustomerDetail);
        }

        [HttpGet("GetMobileNumbers")]
        public IActionResult GetMobileNumbers(decimal latitude, decimal longitude)
        {
            // Query the database to find customer details based on latitude and longitude
            var customers = _context.CustomerDetail
                .Where(c => c.Latitude == latitude && c.Longitude == longitude)
                .Select(c => new { c.MobileNumber })
                .ToList();

            if (customers == null || !customers.Any())
            {
                return NotFound("No customers found at the specified location.");
            }

            return Ok(customers);
        }
    }
}