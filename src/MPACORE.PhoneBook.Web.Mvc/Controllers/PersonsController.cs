using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MPACORE.PhoneBook.Controllers;
using MPACORE.PhoneBook.PhoneBooks;
using MPACORE.PhoneBook.PhoneBooks.Dtos;

namespace MPACORE.PhoneBook.Web.Mvc.Controllers
{
    public class PersonsController : PhoneBookControllerBase
    {

        private readonly IPersonAppService _personAppService;

        public PersonsController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        public async Task<IActionResult> Index(GetPersionInput input)
        {
            var dtos= await _personAppService.GetPagedPeronAsync(input);
            return View(dtos);
        }
    }
}