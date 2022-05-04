using System.IO;

namespace App.Con
{
    public class HandleFiles
    {
        public void Run()
        {
            //path handlings
            pathHandle();
        }

        private void pathHandle()
        {
            var path = Path.GetFullPath("\\abc.txt");
            System.Console.WriteLine(path);
        }
    }
}