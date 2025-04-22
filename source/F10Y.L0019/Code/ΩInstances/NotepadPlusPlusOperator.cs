using System;


namespace F10Y.L0019
{
    public class NotepadPlusPlusOperator : INotepadPlusPlusOperator
    {
        #region Infrastructure

        public static INotepadPlusPlusOperator Instance { get; } = new NotepadPlusPlusOperator();


        private NotepadPlusPlusOperator()
        {
        }

        #endregion
    }
}
