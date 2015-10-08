using System;
using System.Collections.Generic;
using System.Linq;

namespace FWS.Utils.CodeMerge.Logic.Models
{
    public class MergeConsignment
    {
        public MergeConsignment()
        {
            this.MergeItems = new List<MergeItem>();
        }

        public string CodeInput { get; set; }
        public List<MergeItem> MergeItems { get; set; }

        public PropertyValidationResult ValidateProperties()
        {
            var propertyValidationResult = new PropertyValidationResult();

            if(string.IsNullOrEmpty(this.CodeInput))
                propertyValidationResult.Add("Code input is needed");

            if (MergeItems == null || !MergeItems.Any())
                propertyValidationResult.Add("Merge items are needed");

            return propertyValidationResult;
        }
    }
}