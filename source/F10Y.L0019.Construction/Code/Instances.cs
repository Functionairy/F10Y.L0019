using System;


namespace F10Y.L0019.Construction
{
    public static class Instances
    {
        public static IFilePaths FilePaths => Construction.FilePaths.Instance;
        public static INotepadPlusPlusOperator NotepadPlusPlusOperator => L0019.NotepadPlusPlusOperator.Instance;
    }
}