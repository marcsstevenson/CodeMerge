using System.Collections.Generic;
using System.Linq;

namespace FWS.Utils.CodeMerge.Logic.Models
{
    public class MergeItem
    {
        public MergeItem()
        {
            this.MergeParings = new List<MergePairing>();
        }

        //public string SwapValue { get; set; }
        public List<MergePairing> MergeParings { get; set; }

        public PropertyValidationResult ValidateProperties()
        {
            var propertyValidationResult = new PropertyValidationResult();

            if (MergeParings == null || !MergeParings.Any())
            {
                propertyValidationResult.Add("MergeParings are required");
                return propertyValidationResult;
            }

            var paringPropertyValidationResults = this.MergeParings.Select(i => i.ValidateProperties());

            if(paringPropertyValidationResults.Any())
                propertyValidationResult.Add("Not all merge parings are valid");

            return propertyValidationResult;
        }
    }
}