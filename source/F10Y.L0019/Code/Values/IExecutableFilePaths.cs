using System;

using F10Y.T0003;


namespace F10Y.L0019
{
    [ValuesMarker]
    public partial interface IExecutableFilePaths
    {
        /// <summary>
        /// <para><value>C:\Program Files (x86)\Notepad++\notepad++.exe</value></para>
        /// </summary>
        string NotepadPlusPlus_Win32 => @"C:\Program Files (x86)\Notepad++\notepad++.exe";

        /// <summary>
        /// <para><value>C:\Program Files\Notepad++\notepad++.exe</value></para>
        /// </summary>
        string NotepadPlusPlus_Win64 => @"C:\Program Files\Notepad++\notepad++.exe";
    }
}
