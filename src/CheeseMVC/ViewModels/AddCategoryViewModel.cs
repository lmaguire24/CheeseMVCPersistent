﻿using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
    }
}
