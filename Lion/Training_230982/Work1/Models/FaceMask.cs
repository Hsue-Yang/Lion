using System.ComponentModel.DataAnnotations;
namespace Work1.Models;

public partial class FaceMask
{
    [Display(Name = "醫療機構代碼")]
    public string Code { get; set; }

    [Display(Name = "醫療機構名稱")]
    public string Name { get; set; }

    [Display(Name = "醫療機構地址")]
    public string Address { get; set; }

    [Display(Name = "醫療機構電話")]
    public string Phone { get; set; }

    [Display(Name = "成人口罩剩餘數")]
    public int AdultCount { get; set; }

    [Display(Name = "兒童口罩剩餘數")]
    public int ChildCount { get; set; }

    [Display(Name = "來源資料時間")]
    public DateTime SourceDatetime { get; set; }
}