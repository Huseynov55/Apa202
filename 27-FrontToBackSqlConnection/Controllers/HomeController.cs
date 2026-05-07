using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            //_context.AddRange(_sliders);
            //_context.SaveChanges();
            List<Slider> sliders = _context.Sliders
                .Where(s => !s.IsDeleted)
                .OrderBy(s => s.Order)
                .Take(2)
                .ToList();

            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders
                
            };


            return View(homeVM);
        }
    }
}
