using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.Services;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository,
            ICategoryRepository categoryRepository)
        {

            _pieRepository = pieRepository ??
               throw new ArgumentNullException(nameof(pieRepository));

            _categoryRepository = categoryRepository ??
                throw new ArgumentNullException(nameof(categoryRepository));


        }




        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();

            piesListViewModel.Pies = _pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "Chees cakes";
            return View(piesListViewModel);
        }
    }
}
