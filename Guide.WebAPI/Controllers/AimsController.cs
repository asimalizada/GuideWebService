using Core.WebAPI;
using Guide.Business.Abstract;
using Guide.Entities.Concrete.Aims;
using Guide.Entities.Models.ApiModels;
using Microsoft.AspNetCore.Mvc;

namespace Guide.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AimsController : BaseController<IAimService, Aim, AimAddModel, AimUpdateModel, AimDeleteModel>
    {
        private readonly IAimService _service;

        public AimsController(IAimService service) : base(service)
        {
            _service = service;
        }

        //[HttpGet("getaimdetails")]
        //public IActionResult GetAimDetails()
        //{
        //    return base.CreateResponse(_service.GetAimDetails());
        //}

        //[HttpGet("getdailyaims")]
        //public IActionResult GetDailyAims()
        //{
        //    return base.CreateResponse(_service.GetDailyAims());
        //}

        //[HttpGet("getweeklyaims")]
        //public IActionResult GetWeeklyAims()
        //{
        //    return base.CreateResponse(_service.GetWeeklyAims());
        //}

        //[HttpGet("getmonthlyaims")]
        //public IActionResult GetMonthlyAims()
        //{
        //    return base.CreateResponse(_service.GetMonthlyAims());
        //}

        //[HttpGet("getaimtododetails")]
        //public IActionResult GetAimToDoDetails()
        //{
        //    return base.CreateResponse(_service.GetAimToDoDetails());
        //}

        //[HttpGet("getdailytodoaims")]
        //public IActionResult GetDailyToDoAims()
        //{
        //    return base.CreateResponse(_service.GetDailyToDoAims());
        //}

        //[HttpGet("getweeklytodoaims")]
        //public IActionResult GetWeeklyToDoAims()
        //{
        //    return base.CreateResponse(_service.GetWeeklyToDoAims());
        //}

        //[HttpGet("getmonthlytodoaims")]
        //public IActionResult GetMonthlyToDoAims()
        //{
        //    return base.CreateResponse(_service.GetMonthlyToDoAims());
        //}
    }
}
