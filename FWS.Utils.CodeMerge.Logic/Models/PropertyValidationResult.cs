using System.Collections.Generic;
using System.Linq;

namespace FWS.Utils.CodeMerge.Logic.Models
{
    public class PropertyValidationResult
    {
        public PropertyValidationResult()
        {
            this.InvalidProperties = new List<string>();
        }

        public List<string> InvalidProperties { get; private  set; }

        public void Add(string invalidProperty)
        {
            this.InvalidProperties.Add(invalidProperty);
        }

        public bool IsValid
        {
            get { return !this.InvalidProperties.Any(); }
        }
    }
}