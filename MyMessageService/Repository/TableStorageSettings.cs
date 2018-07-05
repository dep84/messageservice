using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMessageService.Repository
{
    public class TableStorageSettings
    {
        public string ConnectionString
        {
            get
            {
                return "UseDevelopmentStorage=true";
            }
            set
            {
                ConnectionString = "UseDevelopmentStorage=true";
            }

        }
    }
}
