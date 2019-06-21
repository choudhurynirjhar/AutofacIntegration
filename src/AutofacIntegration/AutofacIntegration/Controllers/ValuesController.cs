using Microsoft.AspNetCore.Mvc;

namespace AutofacIntegration.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IDataProvider dataProvider;

        public ValuesController(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return dataProvider.Get();
        }
    }
}
