using System;

using F10Y.T0003;


namespace F10Y.L0019.Construction
{
    [ValuesMarker]
    public partial interface IFilePaths
    {
        /// <summary>
        /// <para><value>C:\Temp\Output.txt</value></para>
        /// </summary>
        string Output_TextFilePath => @"C:\Temp\Output.txt";
    }
}
