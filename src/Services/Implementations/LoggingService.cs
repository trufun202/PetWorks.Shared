using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using PetWorks.Shared.Services.Interfaces;

namespace PetWorks.Shared.Services.Implementations
{
    public class LoggingService
        : ILoggingService
    {
        public void LogMessage(string msg)
        {
            File
                .AppendAllText
                (
                    Path.Combine
                    (
                        HttpRuntime.AppDomainAppPath,
                        "petworks.log"
                    ),
                    string.Format("{0}: {1}\r\n", DateTime.Now.ToString(), msg)
                );
        }
    }
}
