﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    class Amphitheatre
    {
        private int numberOfSeats;
        
        public Amphitheatre()
        {

        }

        public int NumberOfSeats
        {
            get { return this.numberOfSeats; }
            set { this.numberOfSeats = value; }
        }
    }
}
