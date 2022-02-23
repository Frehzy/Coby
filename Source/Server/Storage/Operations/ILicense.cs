using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Operations;

internal interface ILicense
{
    IDisposable GetLicense(Guid waiterId);
}