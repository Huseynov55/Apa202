using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }



        //List<Slider> _sliders = new List<Slider>
        //{
        //    new Slider
        //    {
        //        Title = "Slider 1",
        //        Subtitle = "Subtitle for Slider 1",
        //        Description = "Description for Slider 1",
        //        Image = "1-2-370x300.jpg",
        //        Order = 2,
        //        IsDeleted = false
        //    },
        //    new Slider
        //    {
        //        Title = "Slider 2",
        //        Subtitle = "Subtitle for Slider 2",
        //        Description = "Description for Slider 2",
        //        Image = "1-2-570x633.jpg",
        //        Order = 1,
        //        IsDeleted = true
        //    },
        //    new Slider
        //    {
        //        Title = "Slider 3",
        //        Subtitle ="Subtitle for Slider 3",
        //        Description = "Description for Slider 3",
        //        Image = "2-1-70x78.png",
        //        Order = 3,
        //        IsDeleted = false
        //    }
        //};
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders
                .Where(s => !s.IsDeleted)
                .OrderBy(s => s.Order)
                .Take(2)
                .ToListAsync();

            List<Product> products = await _context.Products
                .Where(p => !p.IsDeleted)
                .Include(p=>p.ProductImages.Where(pi=> pi.IsPrimary != null))
                .Take(4)
                .ToListAsync();


            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders,
                Products = products
            };


            return View(homeVM);
            //_context.AddRange(_sliders);
            //_context.SaveChanges();
        }
    }
}
