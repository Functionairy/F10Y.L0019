using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0019
{
    [FunctionsMarker]
    public partial interface INotepadPlusPlusOperator
    {
        /// <summary>
        /// <para>
        /// Returns whether Notepad++ has been installed on the executing machine and if so,
        /// returns the 64-bit executable path, or else the 32-bit path if 32-bit Notepad++ path.
        /// </para>
        /// <para>In any case, the list of checked file path locations is returned.</para>
        /// </summary>
        /// <remarks>
        /// Whether or not Notepad++ has been installed is determined by whether the expected Notepad++ executable file exists.
        /// </remarks>
        bool Is_NotepadPlusPlusInstalled(
            out string notepadPlusPlus_ExecutableFilePath,
            out string[] checked_FilePaths)
        {
            checked_FilePaths = new[]
            {
                Instances.ExecutableFilePaths.NotepadPlusPlus_Win64,
                Instances.ExecutableFilePaths.NotepadPlusPlus_Win32
            };

            var _64bit_ExecutableExists = Instances.FileSystemOperator.Exists_File(
                Instances.ExecutableFilePaths.NotepadPlusPlus_Win64);

            if (_64bit_ExecutableExists)
            {
                notepadPlusPlus_ExecutableFilePath = Instances.ExecutableFilePaths.NotepadPlusPlus_Win64;

                return true;
            }

            var _32bit_ExecutableExists = Instances.FileSystemOperator.Exists_File(
                Instances.ExecutableFilePaths.NotepadPlusPlus_Win32);

            if (_32bit_ExecutableExists)
            {
                notepadPlusPlus_ExecutableFilePath = Instances.ExecutableFilePaths.NotepadPlusPlus_Win32;

                return true;
            }

            // Else
            notepadPlusPlus_ExecutableFilePath = Instances.Strings.Empty;

            return false;
        }

        string Get_NotepadPlusPlus_ExecutableFilePath()
        {
            var notepadPlusPlus_IsInstalled = this.Is_NotepadPlusPlusInstalled(
                out var notepadPlusPlus_ExecutableFilePath,
                out _);

            if (!notepadPlusPlus_IsInstalled)
            {
                //var checked_FilePathsText =

                throw new FileNotFoundException($"The Notepad++ executable was not found.");
            }

            return notepadPlusPlus_ExecutableFilePath;
        }

        /// <summary>
        /// Opens Notepad++.
        /// </summary>
        void Open()
        {
            var notepadPlusPlusExecutableFilePath = this.Get_NotepadPlusPlus_ExecutableFilePath();

            Instances.CommandLineOperator.Run_NoWait(notepadPlusPlusExecutableFilePath);
        }

        /// <summary>
        /// Opens the given filepath in Notepad++.
        /// </summary>
        void Open(string filePath)
        {
            var enquotedFilePath = Instances.StringOperator.Ensure_Enquoted(filePath);

            var notepadPlusPlusExecutableFilePath = this.Get_NotepadPlusPlus_ExecutableFilePath();

            Instances.CommandLineOperator.Run_NoWait(
                notepadPlusPlusExecutableFilePath,
                enquotedFilePath);
        }

        void Open(IEnumerable<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                this.Open(filePath);
            }
        }

        void Open(params string[] filePaths)
            => this.Open(filePaths.AsEnumerable());
    }
}
