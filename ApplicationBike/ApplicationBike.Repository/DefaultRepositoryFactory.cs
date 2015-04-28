using ApplicationBike.Common.Interfaces;
using ApplicationBike.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBike.Repository
{
    /// <summary>
    /// Responsible for creating of repositories
    /// </summary>
    public class DefaultRepositoryFactory : IRepositoryFactory
    {

        public TRepository CreateRepository<TRepository>() where TRepository : IRepository
        {
            if (typeof(TRepository) == typeof(IBikeRepository))
            {
                return (TRepository)(object)new BikeRepository();
            }
            

            return default(TRepository);
        }
    }
}
