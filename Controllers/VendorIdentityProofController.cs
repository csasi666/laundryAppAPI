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
    [Route("api/VendorIdentityProof")]
    [ApiController]
    public class VendorIdentityProofController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public VendorIdentityProofController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var vendorIdentityProofs = _context.VendorIdentityProof.ToList();

            return Ok(vendorIdentityProofs);
        }
    }
}