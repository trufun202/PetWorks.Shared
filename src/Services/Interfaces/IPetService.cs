using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetWorks.Shared.Enumerations;

namespace PetWorks.Shared.Services.Interfaces
{
    public interface IPetService
    {
        bool CanHandle(PetType petType);
        List<string> GetPets();
    }
}
