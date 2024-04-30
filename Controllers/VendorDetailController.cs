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
    [Route("api/VendorDetail")]
    [ApiController]
    public class VendorDetailController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public VendorDetailController(ApplicationDBContext context)
        {
            _context = context;
        }   

        [HttpGet]
        public IActionResult GetAll()
        {
            var VendorDetails = _context.VendorDetail.ToList();

            return Ok(VendorDetails);
        }
    }
}