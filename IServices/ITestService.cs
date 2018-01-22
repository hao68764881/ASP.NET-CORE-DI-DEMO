using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMO.IServices
{
   public interface ITestService
    {
        Guid MyProperty { get; }
        List<string> GetList(string a);
    }
}
