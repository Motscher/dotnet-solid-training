using System.Collections.Generic;

namespace DevBasics.CarManagement
{
    public static class ApiEndpointsProvider
    {
        public static IDictionary<int, string> GetApiEndpoints()
        {
            var apiEndpoints = new Dictionary<int, string>
            {
                { 1, "/bulk-registration-devices" },
                { 2, "/check-transaction-status" },
                { 3, "/show-registration-details" },
            };
            return apiEndpoints;
        }
    }
}