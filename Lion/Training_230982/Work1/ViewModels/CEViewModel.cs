using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Work1.ViewModels
{
    public class CEViewModel
    {
        public FaceMaskViewModel FaceMaskViewModel { get; set; }
        public CountyViewModel CountyViewModel { get; set; }
        public bool IsEdit { get; set; }
    }
    public class FaceMaskViewModel
    {
        [Required(ErrorMessage = "Code is required")]
        [Display(Name = "醫事機構代碼")]
        [JsonProperty("醫事機構代碼")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "Code cannot contain spaces")]
        //[RegularExpression(@"^\d+$", ErrorMessage = "Code must contain only digits")]
        public string Code { get; set; }

        [Display(Name = "醫事機構名稱")]
        [JsonProperty("醫事機構名稱")]
        public string Name { get; set; }

        [Display(Name = "醫事機構地址")]
        [JsonProperty("醫事機構地址")]
        public string Address { get; set; }

        [Display(Name = "醫事機構電話")]
        [JsonProperty("醫事機構電話")]

        public string Phone { get; set; }

        [Display(Name = "成人口罩剩餘數")]
        [JsonProperty("成人口罩剩餘數")]
        public int AdultCount { get; set; }

        [Display(Name = "兒童口罩剩餘數")]
        [JsonProperty("兒童口罩剩餘數")]
        public int ChildCount { get; set; }

        [Display(Name = "來源資料時間")]
        [JsonProperty("來源資料時間")]
        public DateTime? SourceTime { get; set; }

        public bool SelectedCode { get; set; }
    }

    public class CountyViewModel
    {
        public int Zip5 { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Road { get; set; }
        public string Scope { get; set; }
    }
}