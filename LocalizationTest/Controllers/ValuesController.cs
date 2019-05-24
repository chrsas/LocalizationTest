using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationTest.Abc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IStringLocalizer<ValuesController> _stringLocalizer;

        public ValuesController(IStringLocalizer<ValuesController> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { _stringLocalizer["value1"], _stringLocalizer["value2"] };
        }
    }
}
