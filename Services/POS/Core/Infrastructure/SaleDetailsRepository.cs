using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Ports;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SaleDetailsRepository : ISaleDetailRepository
    {
        private readonly MyContext _myContext;

        public SaleDetailsRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public async Task<SalesDetail> CreateSalesDetails(SalesDetail newSalesDetails)
        {
            _myContext.salesDetails.Add(newSalesDetails);
            await _myContext.SaveChangesAsync();
            return newSalesDetails;
        }

        public async Task<SalesDetail> DeleteSalesDetails(SalesDetail salesDetail)
        {
            _myContext.salesDetails.Remove(salesDetail);
            await _myContext.SaveChangesAsync();
            return salesDetail;
        }

        public async Task<ICollection<SalesDetail>> GetAllSalesDetails()
        {
            return await _myContext.salesDetails.ToListAsync();
        }

        public async Task<SalesDetail> SalesDetailsFindById(int Employee_Id)
        {
            var salesDetail = await _myContext.salesDetails.FirstOrDefaultAsync(x => x.Id == Employee_Id);
            return salesDetail;

        }

        public Task<SalesDetail> UpdateSalesDetails(SalesDetail salesDetailUpdate, SalesDetail newSalesDetails)
        {
            throw new NotImplementedException();
        }
    }
}