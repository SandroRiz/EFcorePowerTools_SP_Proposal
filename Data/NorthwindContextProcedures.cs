// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EFcorePowerTools_SP_Proposal.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace EFcorePowerTools_SP_Proposal.Data
{
    public partial class NorthwindContext
    {
        private NorthwindContextProcedures _procedures;

        public virtual NorthwindContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new NorthwindContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public NorthwindContextProcedures GetProcedures()
        {
            return Procedures;
        }
    }

    public partial class NorthwindContextProcedures
    {
        private readonly NorthwindContext _context;

        public NorthwindContextProcedures(NorthwindContext context)
        {
            _context = context;
        }

        //original with GetDiscontinuedProductsResult
        public virtual async Task<List<GetDiscontinuedProductsResult>> GetDiscontinuedProductsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new[]
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<GetDiscontinuedProductsResult>("EXEC @returnValue = [dbo].[GetDiscontinuedProducts]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        // with Product Model instead
        public virtual async Task<List<Product>> GetDiscontinuedProductsAsync2(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new[]
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<Product>("EXEC @returnValue = [dbo].[GetDiscontinuedProducts]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
