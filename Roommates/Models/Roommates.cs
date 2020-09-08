﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Roommates.Models
{
    // C# representation of the Roommate table
    public class Roommate
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int RentPortion { get; set; }
        public DateTime MoveInDate { get; set; }
        public Room Room { get; set; }
    }
}
