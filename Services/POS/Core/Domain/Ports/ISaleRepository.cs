using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Ports
{
    public interface ISaleRepository
    {
        Task<ICollection<Sale>> getAllSale();

        Task<Sale>  SaleFindById(int sale_Id);

         Task<Sale>  createSale(Sale newSale);

         Task<Sale>  updateSale(Sale saleUpdate, Sale sale);

        Task<Sale> deleteSale(Sale newSale);
    }
}