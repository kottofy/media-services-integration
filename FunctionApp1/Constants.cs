using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1
{
    public static class Constants
    {
        public static string storageAccountName = Environment.GetEnvironmentVariable("MediaServicesStorageAccountName");
        public static string storageAccountKey = Environment.GetEnvironmentVariable("MediaServicesStorageAccountKey");

        public static readonly string AADTenantDomain = Environment.GetEnvironmentVariable("AMSAADTenantDomain");
        public static readonly string RESTAPIEndpoint = Environment.GetEnvironmentVariable("AMSRESTAPIEndpoint");

        public static readonly string mediaservicesClientId = Environment.GetEnvironmentVariable("AMSClientId");
        public static readonly string mediaservicesClientSecret = Environment.GetEnvironmentVariable("AMSClientSecret");
    }
}
