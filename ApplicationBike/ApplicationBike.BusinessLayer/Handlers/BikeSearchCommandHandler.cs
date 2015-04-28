using ApplicationBike.BusinessLayer.Contracts;
using ApplicationBike.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using ApplicationBike.DomainModel;
using ApplicationBike.Repository.Interfaces;
using ApplicationBike.Common;

namespace ApplicationBike.BusinessLayer.Handlers
{
    /// <summary>
    /// Class for bike search commmad handler
    /// </summary>
    internal class BikeSearchCommandHandler : CommandHandlerBase<BikeSearchCommand, BikeSearchResult>
    {
        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            IBikeRepository repo = RepositoryManager.CreateRepository<IBikeRepository>();
            

            BikeSearchResult result = new BikeSearchResult();
            result.Result = repo.SearchBikes(command.RegNumber,command.Colour,command.Producer) as List<Bike>;
            
            return result;
        }

    }
}

