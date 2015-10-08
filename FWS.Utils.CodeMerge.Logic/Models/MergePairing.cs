namespace FWS.Utils.CodeMerge.Logic.Models
{
    public class MergePairing
    {
        public string InputValue { get; set; } 
        public string SwapValue { get; set; }

        public PropertyValidationResult ValidateProperties()
        {
            var propertyValidationResult = new PropertyValidationResult();

            if (this.InputValue == null)
                propertyValidationResult.Add("InputValue is needed");

            if (string.IsNullOrEmpty(this.SwapValue))
                propertyValidationResult.Add("SwapValue is needed");
            
            return propertyValidationResult;
        }
    }
}