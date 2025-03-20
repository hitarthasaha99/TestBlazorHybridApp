using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlazorHybridApp
{
    public static class Constants
    {
        public const string DatabaseFilename = "TestApplication.db3";
        public const string LocalDirname = "TestApp";

        public const string ControllerHealth = "HealthSurvey";

        public const string PostAddress = "http://115.124.119.17/APIV3/";
        public const string APIHEALTHURL = "http://115.124.119.17/APIV3/api/SURVEY/v1/";
        public const string ActionFetchFSULIST = "GetFsuListByUserId";
    }
}
