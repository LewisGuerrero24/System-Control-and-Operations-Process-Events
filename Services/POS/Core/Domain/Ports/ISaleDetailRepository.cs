using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Ports
{
    public interface ISaleDetailRepository
    {
        Task<ICollection<SalesDetail>> GetAllSalesDetails();

        Task<SalesDetail> SalesDetailsFindById(int Employee_Id);

        Task<SalesDetail> CreateSalesDetails(SalesDetail newSalesDetails);

        Task<SalesDetail> UpdateSalesDetails(SalesDetail salesDetailUpdate, SalesDetail newSalesDetails);

        Task<SalesDetail> DeleteSalesDetails(SalesDetail salesDetail);
    }
}