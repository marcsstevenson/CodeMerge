using System;
using System.Collections.Generic;
using FWS.Utils.CodeMerge.Logic.Helpers;
using FWS.Utils.CodeMerge.Logic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FWS.Utils.CodeMerge.Testing
{
    [TestClass]
    public class MergeServiceTets
    {
        [TestMethod]
        public void CodeMergeItemWithDefaultOptionsShallSucceed()
        {
            //Setup
            var inputCode = @"public string Something { get; set; }

";
            var expectedOutputCode = @"public string Name { get; set; }

public string Code { get; set; }

public string Description { get; set; }

";
            var swapValue = "Something";
            var mergeItem = new MergeItem
            {
                MergeParings = new List<MergePairing> 
                { 
                    new MergePairing { SwapValue = swapValue, InputValue = "Name" } ,
                    new MergePairing { SwapValue = swapValue, InputValue = "Code" } ,
                    new MergePairing { SwapValue = swapValue, InputValue = "Description" } 
                }
            };


            var mergeOptions = new MergeOptions();//Default

            //Exercise
            var actualCodeOutput = MergeHelper.MergeItem(inputCode, mergeItem, mergeOptions);

            //Verify
            Assert.AreEqual(expectedOutputCode, actualCodeOutput, "The actual code output is not what was expected: " + actualCodeOutput);
        }

        [TestMethod]
        public void CodeMergeItemWithCameliseShallPerformAnAdditionalSubstitutionOnCamelisedInputAndMergeItems()
        {
            //Setup
            var inputCode = @"public string somethingElse SomethingElse { get; set; }";
            var expectedOutputCode = @"public string nameMe NameMe { get; set; }";

            var swapValue = "SomethingElse";
            var mergeItem = new MergeItem
            {
                MergeParings = new List<MergePairing> 
                { 
                    new MergePairing { SwapValue = swapValue, InputValue = "NameMe" } 
                }
            };
            
            var mergeOptions = new MergeOptions { CameliseSubstitutionAlso = true };

            //Exercise
            var actualCodeOutput = MergeHelper.MergeItem(inputCode, mergeItem, mergeOptions);

            //Verify
            Assert.AreEqual(expectedOutputCode, actualCodeOutput, "The actual code output is not what was expected: " + actualCodeOutput);
        }

        [TestMethod]
        public void CodeMergeItemWithSpaciliseShallPerformAnAdditionalSubstitutionOnSpacilisedInputAndMergeItems()
        {
            //Setup
            var inputCode = @"public string somethingElse SomethingElse { get; set; }";
            var expectedOutputCode = @"public string nameMe NameMe { get; set; }";

            var swapValue = "SomethingElse";
            var mergeItem = new MergeItem
            {
                MergeParings = new List<MergePairing> 
                { 
                    new MergePairing { SwapValue = swapValue, InputValue = "NameMe" } 
                }
            };

            //var mergeItem = new MergeItem { SwapValue = "SomethingElse", MergeParings = new List<string> { "NameMe" } };

            var mergeOptions = new MergeOptions { CameliseSubstitutionAlso = true };

            //Exercise
            var actualCodeOutput = MergeHelper.MergeItem(inputCode, mergeItem, mergeOptions);

            //Verify
            Assert.AreEqual(expectedOutputCode, actualCodeOutput, "The actual code output is not what was expected: " + actualCodeOutput);
        }

        [TestMethod]
        public void CodeMergeConsignmentWithSimpleConsignmentAndDefaultOptionsShallSucceed()
        {
            //Setup
            var inputCode = @"public TYPE PROP;
";
            var expectedOutputCode = @"public string Name;
public int Id;
";
            
            var mergeConsignment = new MergeConsignment
                {
                    CodeInput = inputCode,
                    MergeItems = new List<MergeItem>
                        {
                            new MergeItem
                                {
                                    MergeParings = new List<MergePairing> 
                                    { 
                                        new MergePairing { SwapValue = "PROP", InputValue = "Name" } ,
                                        new MergePairing { SwapValue = "TYPE", InputValue = "string" }  
                                    }
                                },
                            new MergeItem
                                {
                                    MergeParings = new List<MergePairing> 
                                    { 
                                        new MergePairing { SwapValue = "PROP", InputValue = "Id" } ,
                                        new MergePairing { SwapValue = "TYPE", InputValue = "int" }  
                                    }
                                }
                        }
                };
            
            var mergeOptions = new MergeOptions();//Default

            //Exercise
            var actualCodeOutput = MergeHelper.Merge(mergeConsignment, mergeOptions);

            //Verify
            Assert.AreEqual(expectedOutputCode, actualCodeOutput, "The actual code output is not what was expected: " + actualCodeOutput);
        }
    }
}
