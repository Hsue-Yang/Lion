using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Work1.Models;
using Work1.ViewModels;

namespace Work1.Controllers
{
    public class FaceMasksController : Controller
    {
        private readonly Training230982Context _context;
        private readonly IMemoryCache _memoryCache;
        private static int totalRows;
        private static int pages = 0;
        private static int pageRows = 10; //每頁幾筆資料

        public FaceMasksController(Training230982Context context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: FaceMasks
        public async Task<IActionResult> Index(int code, string City, string Area)
        {
            //Api
            string faceMaskUrl = "https://localhost:7176/api/FaceMaskSource";
            var faceCacheKey = "faceMaskKey";
            var checkedFM = _memoryCache.TryGetValue(faceCacheKey, out List<FaceMaskViewModel> faceCacheValue);
            if (!checkedFM)
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(faceMaskUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        Task<string> readTask = response.Content.ReadAsStringAsync();
                        List<FaceMaskViewModel> jsonFile = JsonConvert.DeserializeObject<List<FaceMaskViewModel>>(readTask.Result);

                        //新增快取
                        _memoryCache.Set(faceCacheKey, jsonFile, TimeSpan.FromSeconds(30));

                        //資料寫入資料庫
                        var existingCode = await _context.FaceMasks.Select(s => s.Code).ToListAsync();
                        var matchCode = jsonFile.Where(j => existingCode.Contains(j.Code)).ToList();
                        if (!(matchCode.Count > 0))
                        {
                            var fm = jsonFile.Select(jsonFile => new FaceMask()
                            {
                                Code = jsonFile.Code,
                                Name = jsonFile.Name,
                                Address = jsonFile.Address,
                                Phone = jsonFile.Phone,
                                SourceDatetime = (DateTime)jsonFile.SourceTime,
                                AdultCount = jsonFile.AdultCount,
                                ChildCount = jsonFile.ChildCount,
                            });
                            _context.AddRange(fm);
                            await _context.SaveChangesAsync();
                        }
                    }
                }
            }
            _memoryCache.TryGetValue(faceCacheKey, out List<FaceMaskViewModel> faceMaskCache);
            var finalFM = faceCacheValue ?? faceMaskCache;
            ViewBag.fmApi = finalFM;

            string cityAreaUrl = "https://localhost:7176/api/CityAreaSource";
            var CitycacheKey = "CityKey";
            var checkedCT = _memoryCache.TryGetValue(CitycacheKey, out List<CountyViewModel> CitycacheValue);
            if (!checkedCT)
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(cityAreaUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        Task<string> readTask = response.Content.ReadAsStringAsync();
                        List<CountyViewModel> jsonFile = JsonConvert.DeserializeObject<List<CountyViewModel>>(readTask.Result);

                        //新增快取
                        _memoryCache.Set(CitycacheKey, jsonFile, new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromSeconds(30) });

                    }
                }
            }
            _memoryCache.TryGetValue(CitycacheKey, out List<CountyViewModel> CityCacheValue);
            var finalCity = CitycacheValue ?? CityCacheValue;
            var filterJson = finalCity.GroupBy(s => new { s.City, s.Area }).Select(g => g.First()).ToList();
            ViewBag.filterArea = filterJson;
            ViewBag.city = finalCity.GroupBy(s => s.City);
            ViewBag.county = finalCity.GroupBy(s => s.Area);

            List<FaceMask> faceMask;
            //Api
            if (City != null && Area != null)
            {
                faceMask = await _context.FaceMasks.Where(fm => fm.Address.Contains(City) && fm.Address.Contains(Area) || fm.Address.Contains(City) && fm.Name.Contains(Area)).ToListAsync();
            }
            else
            {
                faceMask = await _context.FaceMasks.ToListAsync();
            }
            var cvm = faceMask.Select(faceMask => new CEViewModel()
            {
                FaceMaskViewModel = new FaceMaskViewModel()
                {
                    Code = faceMask.Code,
                    Name = faceMask.Name,
                    Address = faceMask.Address,
                    Phone = faceMask.Phone,
                    AdultCount = faceMask.AdultCount,
                    ChildCount = faceMask.ChildCount,
                    SourceTime = faceMask.SourceDatetime,
                }
            });

            if (code == 0) { code = 1; };//目前所在頁
            totalRows = faceMask.Count(); //總筆數 
            if (totalRows % pageRows == 0)
            {
                pages = totalRows / pageRows;
            }
            else
            {
                pages = (totalRows / pageRows) + 1;
            }

            int startRow = (code - 1) * pageRows; //過濾幾筆資料

            List<CEViewModel> data = cvm.OrderByDescending(x => x.FaceMaskViewModel.Code).Skip(startRow).Take(pageRows).ToList();
            //--------------------------------------------------------------------//

            ViewData["ActivePage"] = code;    //Activec分頁碼
            ViewData["Pages"] = pages;  //頁數
            ViewData["TotalRows"] = totalRows;

            return View(data);
        }

        [HttpGet]
        public IActionResult Search(CEViewModel cEViewModel)
        {
            return RedirectToAction("Index", new { cEViewModel.CountyViewModel.City, cEViewModel.CountyViewModel.Area });
        }

        // GET: FaceMasks/Create
        public IActionResult Create()
        {
            var IsEdit = new CEViewModel
            {
                IsEdit = false,
            };
            return View("CreaEdit", IsEdit);
        }

        // POST: FaceMasks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CEViewModel ceVm)
        {
            var faceMask = new FaceMask()
            {
                Code = ceVm.FaceMaskViewModel.Code,
                Name = ceVm.FaceMaskViewModel.Name,
                Address = ceVm.FaceMaskViewModel.Address,
                Phone = ceVm.FaceMaskViewModel.Phone,
                AdultCount = ceVm.FaceMaskViewModel.AdultCount,
                ChildCount = ceVm.FaceMaskViewModel.ChildCount,
                SourceDatetime = (DateTime)ceVm.FaceMaskViewModel.SourceTime
            };
            if (ModelState.IsValid)
            {
                if (FaceMaskExists(faceMask.Code))
                {
                    return View("Error");
                }
                _context.Add(faceMask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("CreaEdit", faceMask);
        }

        // GET: FaceMasks/Edit
        public async Task<IActionResult> Edit(string code)
        {
            if (code == null)
            {
                return NotFound();
            }

            var faceMask = await _context.FaceMasks.FirstOrDefaultAsync(c => c.Code == code);
            if (faceMask == null)
            {
                return NotFound();
            }

            var vm = new CEViewModel()
            {
                FaceMaskViewModel = new FaceMaskViewModel()
                {
                    Code = faceMask.Code,
                    Name = faceMask.Name,
                    Address = faceMask.Address,
                    Phone = faceMask.Phone,
                    AdultCount = faceMask.AdultCount,
                    ChildCount = faceMask.ChildCount,
                    SourceTime = faceMask.SourceDatetime,
                },
                IsEdit = true
            };
            return View("CreaEdit", vm);
        }

        // POST: FaceMasks/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CEViewModel ceVm)
        {
            var faceMask = new FaceMask()
            {
                Code = ceVm.FaceMaskViewModel.Code,
                Name = ceVm.FaceMaskViewModel.Name,
                Address = ceVm.FaceMaskViewModel.Address,
                Phone = ceVm.FaceMaskViewModel.Phone,
                AdultCount = ceVm.FaceMaskViewModel.AdultCount,
                ChildCount = ceVm.FaceMaskViewModel.ChildCount,
                SourceDatetime = (DateTime)ceVm.FaceMaskViewModel.SourceTime
            };

            if (!ceVm.FaceMaskViewModel.Code.Equals(faceMask.Code))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faceMask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaceMaskExists(faceMask.Code))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var vm = new CEViewModel()
            {
                FaceMaskViewModel = new FaceMaskViewModel()
                {
                    Code = faceMask.Code,
                    Name = faceMask.Name,
                    Address = faceMask.Address,
                    Phone = faceMask.Phone,
                    AdultCount = faceMask.AdultCount,
                    ChildCount = faceMask.ChildCount,
                    SourceTime = faceMask.SourceDatetime,
                }
            };

            return View("CreaEdit", vm);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteConfirmed(string code)
        {
            var faceMask = await _context.FaceMasks.FirstOrDefaultAsync(m => m.Code == code);
            if (faceMask != null)
            {
                _context.FaceMasks.Remove(faceMask);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public bool FaceMaskExists(string id)
        {
            return _context.FaceMasks.Any(e => e.Code == id);
        }
    }
}