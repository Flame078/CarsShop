using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> 
                { 
                    new Category { categoryname = "Электромобили", desc = "Совр вид транспорта"},
                    new Category{categoryname = "Авто с ДВС", desc = "машины с двигателем внутреннего сгорания" }  
                };
            }
            
            }
    }
}