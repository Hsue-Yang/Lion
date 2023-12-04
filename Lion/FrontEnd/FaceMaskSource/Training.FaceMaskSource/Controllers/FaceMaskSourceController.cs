using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection;
using Training.FaceMaskSource.Models.Models;

namespace Training.FaceMaskSource.Controllers
{
    [Route("api/[controller]")]
    public class FaceMaskSourceController : Controller
    {
        [HttpGet]
        public string Get()
        {
            string strResult = string.Empty;
            string workingDirectory = Environment.CurrentDirectory;

            using (StreamReader r = new StreamReader(@"" + workingDirectory + "" + "\\FaceMask.json"))
            {
                string json = r.ReadToEnd();
                var result = JsonConvert.DeserializeObject<List<FaceMaskSourceModels>>(json);
                strResult = JsonConvert.SerializeObject(result);
            }

            return strResult;
        }
    }
}