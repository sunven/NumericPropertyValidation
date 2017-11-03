using System.Collections.Generic;
using System.Web.Mvc;
using NumericPropertyValidation.Properties;

namespace NumericPropertyValidation
{
    public class FilterableClientDataTypeModelValidatorProvider : ClientDataTypeModelValidatorProvider
    {
        public override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ControllerContext context)
        {           
            var allValidators = base.GetValidators(metadata, context);
            var validators = new List<ModelValidator>();
            foreach (var v in allValidators)
            {
                if (v.GetType().Name != "NumericModelValidator")
                {
                    validators.Add(v);
                }
                else
                {
                    //NumericAttribute attribute = new NumericAttribute{ ErrorMessage = "自定义"};
                    NumericAttribute attribute = new NumericAttribute { ErrorMessage = Resources.FieldMustBeNumeric };
                    DataAnnotationsModelValidator validator = new DataAnnotationsModelValidator(metadata, context, attribute);
                    validators.Add(validator);
                }
            }
            return validators;
        }
    }
}