﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication17.Controllers;
using WebApplication17.Models;

namespace WebApplication17
{
    public class PersonalList
    {
        public static List<Personal2> pers=new List<Personal2>
        {
            new Personal2
            {
                Age=27,
                Name="Murad"
            },
            new Personal2
            {
                Age=30,
                Name="Xaliq"
                
            }
            
        };
    }
}
