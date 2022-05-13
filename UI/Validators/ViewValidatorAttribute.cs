using AspectInjector.Broker;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UI.Validators
{
    [Aspect(Scope.Global)]
    [Injection(typeof(ViewValidatorAttribute))]
    public sealed class ViewValidatorAttribute : Attribute
    {
        [Advice(Kind.Before)] //After, Around
        public void Validate([Argument(Source.Arguments)] object[] objs)
        {
            ICollection<ValidationResult> results = new List<ValidationResult>();

            var validGlobal = true;
            string errorMessage = default;

            foreach (var obj in objs)
            {
                var isValid = TryValidate(obj, out results);

                if (!isValid)
                {
                    validGlobal = false;
                    //errorMessage = $"{ obj }: \n"; -> no quiero que en la interfaz de usuario se vea el nombre del obj con error.

                    foreach (var validationResult in results)
                    {
                        errorMessage += validationResult.ErrorMessage + System.Environment.NewLine;
                    }
                }
            }

            if (!validGlobal)
                throw new Exception(errorMessage);
        }
        private bool TryValidate(object @object, out ICollection<ValidationResult> results)
        {
            var context = new ValidationContext(@object, serviceProvider: null, items: null);
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(
                @object, context, results,
                validateAllProperties: true
            );
        }
    }
}
