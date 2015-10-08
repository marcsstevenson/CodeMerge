using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodeMerge.Properties;
using FWS.Utils.CodeMerge.Logic.Helpers;
using FWS.Utils.CodeMerge.Logic.Models;

namespace CodeMerge
{
	public partial class Form1 : Form
	{
		private string SwapValue
		{
			get { return this.txtSwapValue.Text; }
			set { this.txtSwapValue.Text = value; }
		}

		private const string FlipOn = " = ";

		public Form1()
		{
			InitializeComponent();

			this.txtInputCode.Text = Properties.Settings.Default.MergeFrom;
			this.txtSubstitutions.Text = Properties.Settings.Default.MergeValues;
			this.txtSwapValue.Text = Properties.Settings.Default.MergeText;
			this.cbCamel.Checked = Properties.Settings.Default.Camel;
			this.cbAddSpaces.Checked = Properties.Settings.Default.AddSpaces;
		}

		private void SetSetting(System.Configuration.SettingsProperty setting, string val)
		{

		}

		private void SaveSettings()
		{
			Properties.Settings.Default.MergeFrom = this.txtInputCode.Text;
			Properties.Settings.Default.MergeValues = this.txtSubstitutions.Text;
			Properties.Settings.Default.MergeText = this.txtSwapValue.Text;
			Properties.Settings.Default.Camel = this.cbCamel.Checked;
			Properties.Settings.Default.AddSpaces = this.cbAddSpaces.Checked;

			Properties.Settings.Default.Save();
		}

        private void Merge()
        {
            //Setup
            string inputCode = this.txtInputCode.Text;

            var mergeItem = new MergeItem
                {
                    MergeParings =
                        this.GetInputValues()
                            .Select(i => new MergePairing {SwapValue = this.SwapValue, InputValue = i})
                            .ToList()
                };
            
            var mergeOptions = new MergeOptions { CameliseSubstitutionAlso = this.cbCamel.Checked, SpaciliseSubstitutionAlso = this.cbAddSpaces.Checked };

            //Exercise
            var actualCodeOutput = MergeHelper.MergeItem(inputCode, mergeItem, mergeOptions);

            this.txtOutputCode.Text = actualCodeOutput;
        }

        private IEnumerable<string> GetInputValues()
        {
            if (this.txtSubstitutions.Text.Contains("\n") && !this.txtSubstitutions.Text.Contains("\r\n"))
                this.txtSubstitutions.Text = this.txtSubstitutions.Text.Replace("\n", "\r\n");

            return this.txtSubstitutions.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        //private string Merge(bool camel, bool spacilise)
        //{
        //    string substitution;
        //    string swapValue;
        //    string inputCode = this.txtInputCode.Text;
        //    string output = string.Empty;
        //    string substitutionOutput = string.Empty;

        //    //Clean up the text if it has strange line returns
        //    if (this.txtSubstitutions.Text.Contains("\n") && !this.txtSubstitutions.Text.Contains("\r\n"))
        //        this.txtSubstitutions.Text = this.txtSubstitutions.Text.Replace("\n", "\r\n");

        //    string[] arrSubstitutions = this.txtSubstitutions.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

        //    foreach (string strSubstitution in arrSubstitutions)
        //    {
        //        swapValue = this.SwapValue;
        //        substitution = strSubstitution;

        //        if (substitution != null && substitution.Trim().Length > 0)
        //        {
        //            substitutionOutput = inputCode.Replace(swapValue, substitution);

        //            //Perform the camel replacement if needed on the output code
        //            if (camel)
        //            {
        //                //Camilise our text values
        //                swapValue = this.CameliseString(this.SwapValue);
        //                substitution = this.CameliseString(strSubstitution);

        //                if (substitution != null && substitution.Trim().Length > 0)
        //                    substitutionOutput = substitutionOutput.Replace(swapValue, substitution);
        //            }

        //            //Perform the space replacement if needed on the output code
        //            if (spacilise)
        //            {
        //                //Spacilise our text values
        //                swapValue = this.Spacilise(this.SwapValue);
        //                substitution = this.Spacilise(strSubstitution);

        //                if (substitution != null && substitution.Trim().Length > 0)
        //                    substitutionOutput = substitutionOutput.Replace(swapValue, substitution);
        //            }
        //        }

        //        output += substitutionOutput;
        //    }

        //    return output;
        //}

		private string CameliseString(string start)
		{
			return start.Substring(0, 1).ToLower() + start.Substring(1, start.Length - 1);
		}

		private string Spacilise(string start)
		{
			char[] bits = start.ToCharArray();
			string progress = string.Empty;

			foreach (char letter in bits)
			{
				if (progress != string.Empty && char.IsUpper(letter))
				{
					progress += " "; //Add a space before
				}

				progress += letter;
			}

			return progress;
		}

		private void Flip()
		{
			string strMerge = this.txtInputCode.Text;
			string[] arrSplit = new string[] { "\r\n" };
			string[] arrParts = strMerge.Split(arrSplit, StringSplitOptions.None);
			string strMergedPart;
			string[] arrSides;
			string strMerged = "";
			bool blnHasSemiColin;

			foreach (string strPart in arrParts)
			{
				blnHasSemiColin = strPart.Contains(";");
				arrSides = strPart.Replace(";", "").Split(new string[] { FlipOn }, StringSplitOptions.None);

				if (arrSides.Length == 2)
					strMergedPart = arrSides[1].Trim() + FlipOn + arrSides[0].Trim();
				else
					strMergedPart = strPart;

				if (blnHasSemiColin)
					strMergedPart += ";";

				strMergedPart += "\r\n";

				strMerged += strMergedPart;
			}

			this.txtOutputCode.Text = strMerged;

		}

		private void Quote()
		{
			string strText = this.txtInputCode.Text;
			string[] arrLines = strText.Split(new string[] { "\r\n" }, StringSplitOptions.None);
			string strQuotes = "";


			foreach (string strLine in arrLines)
			{
				strQuotes += Quotise(strLine) + "\r\n";
			}

			this.txtOutputCode.Text = strQuotes;
		}

		private string Quotise(string strLine)
		{
			string strReturn = "strCode += ";

			if (strLine.Trim().Length > 0)
			{
				strLine = strLine.Replace("\\", "\\\\");
				strLine = strLine.Replace("\"", "\\\"");
				strReturn += "\"" + strLine + "\" + ";
			}

			strReturn += "\"\\r\\n\";";

			return strReturn;
		}

		private void btnMerge_Click(object sender, EventArgs e)
		{
		    Merge();
			//this.txtOutputCode.Text = this.Merge(this.cbCamel.Checked, this.cbAddSpaces.Checked);

			SaveSettings();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			//this.gvItems.Rows.Clear();
			this.txtSubstitutions.Text = "";
			SaveSettings();
		}

		private void btnFlip_Click(object sender, EventArgs e)
		{
			Flip();
			SaveSettings();
		}

		private void btnQuote_Click(object sender, EventArgs e)
		{
			Quote();
			SaveSettings();
		}

        //internal sealed partial class TestSettings : global::System.Configuration.ApplicationSettingsBase
        //{
        //    private static Settings defaultInstance = ((TestSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new TestSettings())));

        //    var settings = 

        //    public static Settings Default
        //    {
        //        get
        //        {
        //            return defaultInstance;
        //        }
        //    }

        //    [global::System.Configuration.UserScopedSettingAttribute()]
        //    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        //    [global::System.Configuration.DefaultSettingValueAttribute("False")]
        //    public bool Something
        //    {
        //        get
        //        {
        //            return ((bool)(this["Something"]));
        //        }
        //        set
        //        {
        //            this["Something"] = value;
        //        }
        //    }
        //}
	}
}