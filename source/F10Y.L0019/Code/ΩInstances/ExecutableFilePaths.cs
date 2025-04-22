using System;


namespace F10Y.L0019
{
    public class ExecutableFilePaths : IExecutableFilePaths
    {
        #region Infrastructure

        public static IExecutableFilePaths Instance { get; } = new ExecutableFilePaths();


        private ExecutableFilePaths()
        {
        }

        #endregion
    }
}
