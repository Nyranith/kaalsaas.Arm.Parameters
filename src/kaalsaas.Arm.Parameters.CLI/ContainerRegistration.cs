using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;

namespace kaalsaas.Arm.Parameters.CLI
{
    public static class ContainerRegistration
    {
        public static Container Init(Action<Container> diContainer = null)
        {
            var container = new Container();

            diContainer?.Invoke(container);
            Register(container);

            return container;
        }

        private static void Register(Container container)
        {

        }
    }
}
