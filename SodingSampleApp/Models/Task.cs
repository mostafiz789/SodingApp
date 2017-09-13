﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodingSampleApp.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}