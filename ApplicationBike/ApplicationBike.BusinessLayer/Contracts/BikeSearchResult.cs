using ApplicationBike.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBike.BusinessLayer.Contracts
{
    /// <summary>
    /// Class for bike search resault
    /// </summary>
    public class BikeSearchResult : CommandResult
    {
        public List<Bike> Result { get; set; }

        public bool HasNext { get; set; }

        public bool HasPrevious { get; set; }
    }
}
