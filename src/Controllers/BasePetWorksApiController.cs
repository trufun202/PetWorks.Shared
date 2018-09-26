using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using PetWorks.Shared.Services.Interfaces;

namespace PetWorks.Shared.Controllers
{
    public class BasePetWorksApiController
        : ApiController
    {
        protected IReadOnlyList<IPetService> PetServices { get; }
        protected ILoggingService LoggingService { get; }        

        public BasePetWorksApiController(IReadOnlyList<IPetService> petServices, ILoggingService loggingService)
        {
            this.PetServices = petServices;
            this.LoggingService = loggingService;
        }

        public virtual void LogMessage(string msg)
        {
            this.LoggingService.LogMessage(msg);
        }
    }
}
