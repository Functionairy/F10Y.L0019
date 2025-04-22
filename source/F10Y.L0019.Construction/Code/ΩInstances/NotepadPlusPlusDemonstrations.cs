using System;


namespace F10Y.L0019.Construction
{
    public class NotepadPlusPlusDemonstrations : INotepadPlusPlusDemonstrations
    {
        #region Infrastructure

        public static INotepadPlusPlusDemonstrations Instance { get; } = new NotepadPlusPlusDemonstrations();


        private NotepadPlusPlusDemonstrations()
        {
        }

        #endregion
    }
}
