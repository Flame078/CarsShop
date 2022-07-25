using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get 
            {
                return new List<Car>
            {
            new Car 
                {
                name = "Tesla model S", 
                ShortDesc = "������� ����", 
                longDesc = "����� ���������� �������� Tesla", 
                img = "/img/Tesla_Model_S.jpg", 
                price = 45000, 
                isFavourite = true, 
                available = true, 
                category = _categoryCars.AllCategories.First()
                },
            new Car
                {
                name = "BMW M3",
                ShortDesc = "������ �� ����������� ����������",
                longDesc = "������� ���������� ��� ��������� ����� �� ���",
                img = "/img/bmw-m3.jpg",
                price = 17000,
                isFavourite = false,
                available = true,
                category = _categoryCars.AllCategories.Last()
                },
             new Car
                {
             name = "Chevrolet Blazer",
                ShortDesc = "��������� �����",
                longDesc = "������� ���������� ��� ��������� ����� �� �����������",
                img = "/img/Blazer.jpg",
                price = 22000,
                isFavourite = false,
                available = false,
                category = _categoryCars.AllCategories.First() 
                },
              new Car
                {
             name = "Renault Logan",
                ShortDesc = "��������� ����",
                longDesc = "������� ���������� ��� ��������� ����� �� ���",
                img = "/img/renault_Logan.jpg",
                price = 33000,
                isFavourite = true,
                available = true,
                category = _categoryCars.AllCategories.Last() 
                }
            };
            }
        
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}