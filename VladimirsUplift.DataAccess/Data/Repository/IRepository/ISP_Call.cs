using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace VladimirsUplift.DataAccess.Data.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null);

        void ExecuteWithouthReturn(string procedureName, DynamicParameters param = null);

        T ExecuteReturnScaler<T>(string procedureName, DynamicParameters param = null);
    }
}
