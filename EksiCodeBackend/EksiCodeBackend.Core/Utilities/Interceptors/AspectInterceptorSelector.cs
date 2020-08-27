using System;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy;

namespace EksiCodeBackend.Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAtribustes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();
            var methosAttributes = type.GetMethod(method.Name).GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAtribustes.AddRange(methosAttributes);

            return classAtribustes.OrderBy(s=>s.Priority).ToArray();
        }
    }
}
