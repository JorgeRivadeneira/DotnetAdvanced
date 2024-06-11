using DesignPatternASP.Models.ViewModels;
using DesignPatternASP.Strategies;
using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.InteropServices;

namespace DesignPatternASP.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                               select new BeerViewModel
                                               {
                                                   Id = d.Id,
                                                   Name = d.Name,
                                                   Style = d.Style
                                               };
            return View("Index", beers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            GetBrandsData();
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerViewModel)
        {
            if(!ModelState.IsValid)
            {
                GetBrandsData();
                return View("Add", beerViewModel);
            }

            var context = beerViewModel.BrandId == null ?
                    new BeerContext(new BeerWithBrandStrategy()) :
                    new BeerContext(new BeerStrategy());

            context.Add(beerViewModel, _unitOfWork);

            return RedirectToAction("Index");
        }

        #region Helpers
        private void GetBrandsData()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        }

        #endregion
    }
}
