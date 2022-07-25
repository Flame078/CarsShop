using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;

namespace Shop.Controllers 
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allcars;
        private readonly ICarsCategory _allcategories;

        public CarsController(IAllCars cars, ICarsCategory category) 
        {
            _allcars = cars;
            _allcategories = category;
        }

        public ViewResult CarsList() 
        {
            ViewBag.Title = "Страница с автомобилями 1";
            CarsListViewModel obj = new CarsListViewModel();
            obj.GetAllCars = _allcars.Cars;
            obj.CarCategory = "Автомобили";
            return View(obj);
        }
    }

}