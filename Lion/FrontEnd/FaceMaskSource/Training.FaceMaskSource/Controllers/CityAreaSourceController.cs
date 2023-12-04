using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Training.FaceMaskSource.Models.Models;

namespace Training.FaceMaskSource.Controllers
{
    [Route("api/[controller]")]
    public class CityAreaSourceController : Controller
    {
        [HttpGet]
        public string Get()
        {
            string strResult = string.Empty;
            string workingDirectory = Environment.CurrentDirectory;

            using (StreamReader r = new StreamReader(@"" + workingDirectory + "" + "\\CityArea.json"))
            {
                string json = r.ReadToEnd();
                var result = JsonConvert.DeserializeObject<List<CityAreaModels>>(json);
                strResult = JsonConvert.SerializeObject(result);
            }

            return strResult;
        }
    }
}