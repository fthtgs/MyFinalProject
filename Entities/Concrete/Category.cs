using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın - Inheritance ya da Interface implemantation almıyorsa bir problem çıkarır
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
