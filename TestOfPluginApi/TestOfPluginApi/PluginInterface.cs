using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOfPluginApi
{
    public interface IPluginBase
    {
        string PluginName { get; }

        double Version { get; }

        string IdentifyEntity(int entityId);
    }
}
