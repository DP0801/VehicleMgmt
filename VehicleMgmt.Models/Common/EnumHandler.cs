using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMgmt.Models.Helper
{
    public class EnumHandler
    {

        public class QueryConditionColumn
        {
            private QueryConditionColumn(string value) { Value = value; }

            public string Value { get; set; }
             

        }

        public enum OperationType
        {
            CREATE, READ, UPDATE, DELETE
        }

        public enum AccessType
        {
            ALL, COMPANY, TEAM, EMPLOYEE
        }

        public enum AccessStatus
        {
            OK,
            ERROR_UNAUTHORIZED,
            ERROR_ACCESS_DENIED,
            ERROR_DUPLICATE_RECORD,
            ERROR_NOT_FOUND,
            ERROR_TEAM_MISSING,
            ERROR_UNKNOWN
        }

    }
}
