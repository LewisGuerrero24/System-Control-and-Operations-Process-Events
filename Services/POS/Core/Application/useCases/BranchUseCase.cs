using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.useCases
{
    public interface BranchUseCase
    {
        Task<ICollection<Branch>> getList();

        Task<Branch> BranchUnique(int branch_Id);

        Task<Branch> createBranch(Branch newBranch);

        Task<Branch> updateBranch(int branch_Id, Branch newBranch);

        Task<Branch> deleteBranch(int branch_Id);
    }
}