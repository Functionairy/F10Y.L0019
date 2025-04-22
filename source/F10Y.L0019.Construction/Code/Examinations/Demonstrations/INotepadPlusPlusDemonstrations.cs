using System;
using System.Threading.Tasks;

using F10Y.T0006;


namespace F10Y.L0019.Construction
{
    [DemonstrationsMarker]
    public partial interface INotepadPlusPlusDemonstrations
    {
        /// <summary>
        /// Shows how to open a file in Notepad++.
        /// </summary>
        Task Open_File()
        {
            /// Inputs.
            var filePath = Instances.FilePaths.Output_TextFilePath;


            /// Run.
            Instances.NotepadPlusPlusOperator.Open(filePath);

            return Task.CompletedTask;
        }
    }
}
