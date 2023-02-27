using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PMS_API.Data;
using PMS_API.DTO.Address;
using PMS_API.Models;
using PMS_API.Services.Interface;

namespace PMS_API.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AddressController : ControllerBase
    {
        #region Fields       
        private readonly IAddressService _addressService;
        #endregion
        #region Constructor       
        public AddressController(IAddressService addressService)
        {        
            _addressService = addressService;
        }
        #endregion
        #region Methods      
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAddress(int id)
        {         
            var address = await _addressService.GetAddressAsync(id);         
            return Ok(address);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> CreateAddress([FromBody] CreateAddressDto address)
        {          
            var createdAddress = await _addressService.CreateAddressAsync(address);
            return Ok(createdAddress);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAddress(Address address)
        {
           var updatedAddress = await _addressService.UpdateAddressAsync(address);
            return Ok(updatedAddress); 
           
        }
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var deletedAddress = await _addressService.DeleteAddressAsync(id);
            return Ok(deletedAddress);
        }
        [HttpGet("List")]
        public async Task<IActionResult> GetAllAddress()
        {
            var addresses = await _addressService.GetAllAddressAsync();
            return Ok(addresses);
        }
        #endregion
       
    }
}
