using System;
using System.Threading.Tasks;


namespace F10Y.L0019.Construction
{
    class Program
    {
        static async Task Main()
        {
            await Program.Demonstrations_();
        }

        static async Task Demonstrations_()
        {
            await NotepadPlusPlusDemonstrations.Instance.Open_File();
        }
    }
}