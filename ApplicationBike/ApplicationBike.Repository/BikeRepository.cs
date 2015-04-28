using ApplicationBike.Common;
using ApplicationBike.DataLayer;
using ApplicationBike.DomainModel;
using ApplicationBike.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBike.Repository
{
    /// <summary>
    /// Class for bike reposotory
    /// </summary>
    internal class BikeRepository : IBikeRepository
    {
        public IList<DomainModel.Bike> SearchBikes(string regNumber, string colour, string producer)
        {
            Log.Instance.LogInfo("Bike search started");
            using (RegistarDbContext context = new RegistarDbContext())
            {

                var query = from b in context.Bikes
                            select b;

                if (!string.IsNullOrEmpty(regNumber))
                {
                    query = query.Where(x => x.RegNumber.ToLower() == regNumber.ToLower());
                }
                if (!string.IsNullOrEmpty(colour))
                {
                    query = query.Where(x => x.Colour.ToLower() == colour.ToLower());
                }
                if (!string.IsNullOrEmpty(producer))
                {
                    query = query.Where(x => x.Producer.ToLower() == producer.ToLower());
                }

                //query = query
                //        .OrderBy(x => x.BikeId);

                //int tmp = query.Count();

                //query = query
                //        .Skip(command.PageIndex * command.PageSize)
                //        .Take(command.PageSize);


                //BikeSearchResult result = new BikeSearchResult();
                List<Bike> result = query.ToList();
                //int totalPages= (int) Math.Ceiling(tmp / (double)command.PageSize);
                //result.HasNext=(command.PageIndex+1 < totalPages);
                //result.HasPrevious=(command.PageIndex > 0);
                return result;
            }
            Log.Instance.LogInfo("Bike Search Ended");
        }
    }
}