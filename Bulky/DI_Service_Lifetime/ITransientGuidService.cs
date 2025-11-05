using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Service_Lifetime
{
    public interface ITransientGuidService
    {
        string GetGuid();
    }
}
