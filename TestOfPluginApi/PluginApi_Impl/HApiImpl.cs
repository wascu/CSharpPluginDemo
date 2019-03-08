using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOfPluginApi;

namespace PluginApi_Impl
{
    public class HApiImpl : IPluginBase
    {
        public string PluginName
        {
            get
            {
                return "HApiImpl by wasku!";
            }
        }

        public double Version
        {
            get
            {
                return 0.1;
            }
        }

        public string IdentifyEntity(int entityId)
        {

            if (entityId > 0)
                return "dayu!";
            else
                return "nothing!";
        }
    }


    public class Test { }

    public struct sTest { }
}
