﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;


namespace CoreDepartman.Models
{
    public class departmanlar
    {
        [Key]

        public int id { get; set; } 
        public string? departmanad { get; set; }

        public List<personel> personels { get; set; }

    }
}
