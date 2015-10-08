using System.Text;
using FWS.Generic.Helpers;
using FWS.Utils.CodeMerge.Logic.Models;

namespace FWS.Utils.CodeMerge.Logic.Helpers
{
    public static class MergeHelper
    {
        /// <summary>
        /// Turns a merge consignment and options into code
        /// </summary>
        /// <param name="mergeConsignment">The merger details</param>
        /// <param name="mergeOptions">Options for the code merger</param>
        /// <returns>Merged code</returns>
        public static string Merge(MergeConsignment mergeConsignment, MergeOptions mergeOptions)
        {
            var stringBuilder = new StringBuilder();

            foreach (var mergeItems in mergeConsignment.MergeItems)
                stringBuilder.Append(MergeItem(mergeConsignment.CodeInput, mergeItems, mergeOptions));

            return stringBuilder.ToString();
        }

        public static string MergeItem(string inputCode, MergeItem mergeItem, MergeOptions mergeOptions)
        {
            var output = string.Empty;
            var substitutionOutput = string.Empty;
            
            foreach (var mergeParing in mergeItem.MergeParings)
            {
                var swapValue = mergeParing.SwapValue;
                var inputValue = mergeParing.InputValue;

                if (inputValue != null && inputValue.Trim().Length > 0)
                {
                    substitutionOutput = inputCode.Replace(swapValue, inputValue);

                    //Perform the camel replacement if needed on the output code
                    if (mergeOptions.CameliseSubstitutionAlso)
                    {
                        //Camilise our text values
                        var swapValueCamelised = swapValue.CameliseString();
                        var inputValueCamelised = mergeParing.InputValue.CameliseString();

                        if (inputValueCamelised != null && inputValue.Trim().Length > 0)
                            substitutionOutput = substitutionOutput.Replace(swapValueCamelised, inputValueCamelised);
                    }

                    //Perform the space replacement if needed on the output code
                    if (mergeOptions.SpaciliseSubstitutionAlso)
                    {
                        //Camilise our text values
                        var swapValueSpacilised = swapValue.SpaciliseCapitals();
                        var inputValueSpacilised = mergeParing.InputValue.SpaciliseCapitals();

                        if (inputValueSpacilised != null && inputValueSpacilised.Trim().Length > 0)
                            substitutionOutput = substitutionOutput.Replace(swapValueSpacilised, inputValueSpacilised);
                    }
                }

                output += substitutionOutput;
            }

            return output;
        }
    }
}