using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _195_Paycore_Net_Bootcamp_Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        IStaffService _staffService; //To avoid instance generation process everytime,injection was implemented.

        public StaffsController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() //The method to obtain all the items in the list.
        {
            var result = _staffService.GetAll();
            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result); //If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id) //The method of bringing the element according to the id of the element.
        {
            var result = _staffService.GetById(id);
            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result); //If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] Staff staff) //This method of adding the instance with the parameters taken from body to the list.
        {
            var result = _staffService.Add(staff);
            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result);//If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] Staff staff) //This method of updating the instance according to the parameters taken from body to the list.
        {
            var result = (_staffService.Update(staff));
            if (result.Success)
            {
                return Ok(result); //If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result);//If the process was fail, it will return 400 status code with a relevant message.
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromBody] Staff staff)
        {
            var result = (_staffService.Delete(staff)); //This method of deleting the instance according to the parameters taken from body to the list.
            if (result.Success)
            {
                return Ok(result);//If the process was successful, it will return 200 status code with a relevant message.
            }
            return BadRequest(result);//If the process was fail, it will return 400 status code with a relevant message.
        }
    }
}
