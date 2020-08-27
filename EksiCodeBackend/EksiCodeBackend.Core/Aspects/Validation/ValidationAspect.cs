using System;
using System.Linq;
using Castle.DynamicProxy;
using FluentValidation;
using EksiCodeBackend.Core.CrossCuttingConcerns.Validation;
using EksiCodeBackend.Core.Utilities.Interceptors;
using EksiCodeBackend.Core.Utilities.Messages;

namespace EksiCodeBackend.Core.Aspects.Validation
{
    public class ValidationAspect : MethodInterception
    {
        Type _validattorType;

        public ValidationAspect(Type validatorType)
        {
            // Gönderilen validator turu fluen validator türünde mi kontrolü
            if (typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new Exception(AspectMessages.WrongValidationType);
            }
            _validattorType = validatorType;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            // Fluent validator sınıfını new ledik
            var validator = (IValidator)Activator.CreateInstance(_validattorType);
            // Burada oluşturduğumuz validator sınıflarının base type ındaki generic verinin ilkini alıyoruz
            var entityType = _validattorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(s => s.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
