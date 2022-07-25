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
                    new Category { categoryname = "�������������", desc = "���� ��� ����������"},
                    new Category{categoryname = "���� � ���", desc = "������ � ���������� ����������� ��������" }  
                };
            }
            
            }
    }
}