using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinskGuide.Core
{
    public static class AppContainer
    {
        static AppContainer()
        {
            Instance = new ServiceContainer();
        }

        public static ServiceContainer Instance { get; private set; }
    }
}
