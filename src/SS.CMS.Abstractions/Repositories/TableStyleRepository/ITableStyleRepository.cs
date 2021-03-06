using System.Collections.Generic;
using System.Threading.Tasks;
using Datory;

namespace SS.CMS.Abstractions
{
    public partial interface ITableStyleRepository : IRepository
    {
        Task<int> InsertAsync(List<int> relatedIdentities, TableStyle style);

        Task UpdateAsync(TableStyle style);

        Task DeleteAllAsync(string tableName);

        Task DeleteAsync(int relatedIdentity, string tableName, string attributeName);

        Task DeleteAsync(List<int> relatedIdentities, string tableName);
    }
}