using Shop.Data.Models;
using System;
using System.Collections.Generic;

namespace Shop.Data.Interfaces {
    public interface ICarsCategory { 
    IEnumerable<Category> AllCategories { get; }
    }
}