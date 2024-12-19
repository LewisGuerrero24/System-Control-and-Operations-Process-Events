using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Dtos;
using Domain.Entities;

namespace Application.useCases
{
    public interface SalesDetailUseCase
    {
        Task<ICollection<SalesDetail>> GetList();

        Task<SalesDetail> SalesDetailUnique(int SalesDetail_Id);

        Task<SalesDetail> CreateSalesDetail(SalesDetailsDto newSalesDetail);

        Task<SalesDetail> UpdateSalesDetail(int saleDetail_Id,SalesDetail newSalesDetail);

        Task<SalesDetail> DeleteSalesDetail(int salesDetail_Id);
    }
}