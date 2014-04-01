using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Keyyum.DAL
{
    public class ContextFactory
    {
        public static KeyyumDbContext GetCurrentContext()
        {
            KeyyumDbContext _nContext = CallContext.GetData("KeyyumContext") as KeyyumDbContext;
            if (_nContext == null)
            {
                _nContext = new KeyyumDbContext();
                CallContext.SetData("KeyyumContext", _nContext);
            }
            return _nContext;
        }
    }
}
