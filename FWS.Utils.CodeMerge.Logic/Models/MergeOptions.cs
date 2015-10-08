namespace FWS.Utils.CodeMerge.Logic.Models
{
    public class MergeOptions
    {
        /// <summary>
        /// This option will enable an additional substitution on camelised input and merge string
        /// </summary> 
        /// <example>public string somethingElse SomethingElse { get; set; } => public string nameMe NameMe { get; set; }</example>
        public bool CameliseSubstitutionAlso { get; set; }

        /// <summary>
        /// This option will enable an additional substitution on spacilised input and merge string
        /// </summary> 
        /// <example>public string Something Else SomethingElse { get; set; } => public string Name Me NameMe { get; set; }</example>
        public bool SpaciliseSubstitutionAlso { get; set; }
    }
}