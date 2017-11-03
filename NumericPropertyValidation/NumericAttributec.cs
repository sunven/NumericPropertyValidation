using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace NumericPropertyValidation
{
    internal class NumericAttribute : ValidationAttribute, IClientValidatable
    {
        public override bool IsValid(object value)
        {
            return true;
        }
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule { ValidationType = "number", ErrorMessage = FormatErrorMessage(metadata.DisplayName)};
        }
    }
}