using CoreMvc5_NorthwindPagination.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace CoreMvc5_NorthwindPagination.Controllers
{
    public class ProductController : Controller
    {
        private static int totalRows = -1;
        private readonly NorthwindContext _ctx;
        private readonly IConfiguration _config;
        public ProductController(NorthwindContext ctx, IConfiguration config)
        {
            _ctx = ctx;

            _config = config;

            if (totalRows == -1)
            {
                totalRows = _ctx.Products.Count();   //計算總筆數
            }

        }

        public IActionResult Index(int id = 1)
        {
            int activePage = id; //目前所在頁
            int pageRows = 10;   //每頁幾筆資料
            //int totalRows = _ctx.Clothing.Count();   //計算總筆數

            //計算Page頁數
            int Pages = 0;
            if (totalRows % pageRows == 0)
            {
                Pages = totalRows / pageRows;
            }
            else
            {
                Pages = (totalRows / pageRows) + 1;
            }

            int startRow = (activePage - 1) * pageRows;  //起始記錄Index
            List<Product> products = _ctx.Products.OrderBy(x => x.ProductId).Skip(startRow).Take(pageRows).ToList();


            ViewData["Active"] = 1;    //SidebarActive頁碼
            ViewData["ActivePage"] = id;    //Activec分頁碼
            ViewData["Pages"] = Pages;  //頁數

            return View(products);
        }

    }
}
