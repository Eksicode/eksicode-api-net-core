using System;
using Castle.DynamicProxy;

namespace EksiCodeBackend.Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        // Method çalışmadan önce çalışacak kısım
        // IInvocation Çalıştırılmaya çalışılan method
        protected virtual void OnBefore(IInvocation invocation) { }
        // Method tamamlandıktan sonra çalışacak kısım
        protected virtual void OnAfter(IInvocation invocation) { }
        // Method hata vermişse çalışacak kısım
        protected virtual void OnException(IInvocation invocation) { }
        // Method başarılı ise çalışacak kısım
        protected virtual void OnSuccess(IInvocation invocation) { }

        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                // Method u çalıştır
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                OnException(invocation);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
