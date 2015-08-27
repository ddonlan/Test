using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SqlScriptCombine
{
    class Program
    {
        static void Main(string[] args)
        {
            var outFile = new StringBuilder();

            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_FORMAT_LETTER_DATA.sql"));
            outFile.AppendLine("");

            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_MEMBER_INDICATIVE.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_MEMBER_ADDRESS.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_PROVIDER_INDICATIVE.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_PROVIDER_ADDRESS.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_SUBSCRIBER_INDICATIVE.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_SUBSCRIBER_ADDRESS.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_MCRP_INDICATIVE.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_CSCI_CONTACT_INFO.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_LOB_RETURN.sql"));
            outFile.AppendLine("");

            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_APPEALS_LETTER_LOAD.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_CASEMGMT_LETTER_LOAD.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_CLAIMS_LETTER_LOAD.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_MEMBER_LETTER_LOAD.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_CUSTSVC_LETTER_LOAD.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_UM_OUTPATIENT_LETTER_LOAD.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_UM_INPATIENT_LETTER_LOAD.sql"));
            outFile.AppendLine("");
            outFile.Append(File.ReadAllText(
                @"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\FDSSP_TCS_ENROLLMENT_LETTER_LOAD.sql"));
            outFile.AppendLine("");

            File.WriteAllText(@"C:\Users\Dan\Documents\Fidelis Templates\FD TCS Procedures\Install.sql", outFile.ToString());
        }
    }
}
