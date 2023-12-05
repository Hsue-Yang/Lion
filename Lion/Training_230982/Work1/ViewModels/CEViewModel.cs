using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Work1.ViewModels
{
    public class CEViewModel
    {
        public FaceMaskViewModel FaceMaskViewModel { get; set; }
        public CountyViewModel CountyViewModel { get; set; }
        public bool IsEdit { get; set; }
        public bool IsReadOnly { get; set; }
    }
    public class FaceMaskViewModel
    {
        [Required(ErrorMessage = "Code is required")]
        [Display(Name = "醫事機構代碼")]
        [JsonProperty("醫事機構代碼")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid format")]
        //[RegularExpression(@"^\d+$", ErrorMessage = "Code must contain only digits and cannot be empty or contain spaces")]
        public string Code { get; set; }

        [Display(Name = "醫事機構名稱")]
        [JsonProperty("醫事機構名稱")]
        [Required(ErrorMessage = "Name is required")]
        //[RegularExpression(@"^[\p{IsCJKUnifiedIdeographs}\p{IsCJKCompatibilityIdeographs}0-9]+$", ErrorMessage = "Invalid address format")]
        public string Name { get; set; }

        [Display(Name = "醫事機構地址")]
        [Required(ErrorMessage = "Address is required")]
        [JsonProperty("醫事機構地址")]
        [RegularExpression(@"^(?<city>\D+[縣市])(?<district>\D+?(市區|鎮區|鎮市|[鄉鎮市區]))?.*$", ErrorMessage = "Invalid address format")]
        public string Address { get; set; }

        [Display(Name = "醫事機構電話")]
        [Required(ErrorMessage = "Phone is required")]
        [JsonProperty("醫事機構電話")]
        //[RegularExpression(@"^\(\d{2}\)\d{8}$", ErrorMessage = "Invalid phone number format")]
        public string Phone { get; set; }

        [Display(Name = "成人口罩剩餘數")]
        [JsonProperty("成人口罩剩餘數")]
        [RegularExpression(@"^[^\W_]+$", ErrorMessage = "Invalid format")]
        public int AdultCount { get; set; }

        [Display(Name = "兒童口罩剩餘數")]
        [JsonProperty("兒童口罩剩餘數")]
        [RegularExpression(@"^[^\W_]+$", ErrorMessage = "Invalid format")]
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