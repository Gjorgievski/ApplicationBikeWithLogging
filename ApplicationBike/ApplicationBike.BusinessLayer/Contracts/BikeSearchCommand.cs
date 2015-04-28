﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBike.BusinessLayer.Contracts
{
    /// <summary>
    /// Class for bike search command
    /// </summary>
    public class BikeSearchCommand : Command
    {
        public string RegNumber { get; set; }

        public string Producer { get; set; }

        public string Colour { get; set; }

        public int PageSize { get; set; }

        public int PageIndex { get; set; }

    }
}
