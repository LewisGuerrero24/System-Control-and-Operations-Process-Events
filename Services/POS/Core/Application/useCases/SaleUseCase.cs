using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Dtos;
using Domain.Entities;

namespace Application.useCases
{
    public interface SaleUseCase
    {
        Task<ICollection<Sale>> GetList();

        Task<Sale> SaleUnique(int Sale_Id);

        Task<Sale> CreateSale(SalesDto newSale);

        Task<Sale> UpdateSale(int sale_Id,Sale newSale);

        Task<Sale> DeleteSale(int sale_Id);
    }
}