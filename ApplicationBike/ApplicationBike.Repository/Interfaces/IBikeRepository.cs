using ApplicationBike.Common.Interfaces;
using ApplicationBike.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBike.Repository.Interfaces
{
    /// <summary>
    /// Interface for bike repository
    /// </summary>
    public interface IBikeRepository : IRepository
    {
        IList<Bike> SearchBikes(string regNumber, string colour, string producer);
    }
}
