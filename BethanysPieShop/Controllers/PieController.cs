using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            _pieRepository = pieRepository;

            _categoryRepository = categoryRepository;


        }


        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();

            piesListViewModel.Pies = _pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "Chees cakes";
            return View(piesListViewModel);
        }
        

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);


            if(pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }
    }
}
