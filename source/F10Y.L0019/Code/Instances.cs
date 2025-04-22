using System;


namespace F10Y.L0019
{
    public static class Instances
    {
        public static L0000.ICommandLineOperator CommandLineOperator => L0000.CommandLineOperator.Instance;
        public static IExecutableFilePaths ExecutableFilePaths => L0019.ExecutableFilePaths.Instance;
        public static L0000.IFileSystemOperator FileSystemOperator => L0000.FileSystemOperator.Instance;
        public static L0000.IStringOperator StringOperator => L0000.StringOperator.Instance;
        public static L0000.IStrings Strings => L0000.Strings.Instance;
    }
}