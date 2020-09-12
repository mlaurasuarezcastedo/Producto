﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductEnum.Models
{

    public enum CategoryType
    {
        Electronicos=10,
        Alimenticios=20,
        Moda=30,
        Belleza=40,
        Automotriz=50,
        Libros=60
    }
    public class Product
    {
        [Key]
        public int ProductID { get; set; }


        [Display(Name ="Nombre del producto")]
        [Required(ErrorMessage ="Debe ingresar el nombre")]
        public string Name { get; set; }


        [Display(Name = "Categoria del producto")]
        [Required(ErrorMessage = "Debe ingresar la categoria")]
        public CategoryType Category { get; set; }
    }
}