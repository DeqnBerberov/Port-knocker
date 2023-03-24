using System;
using System.IO;

namespace PortKnocking
{
    class Program
    {
        public string tempPath = Directory.GetCurrentDirectory();
        public string tempdir;
        public static void Main(string[] args)
        {
            Program p= new Program();
            p.KurZaMaina();
        }            
        public void KurZaMaina()
        {
            tempdir = Path.GetFullPath(Path.Combine(tempPath, @"..\..\..\"));
            string[] updatepath = { tempdir, "Portknocker-Update.txt" };
            string[] createpath = { tempdir, "Portknocker-Create.txt" };
            string fullpathupdate = Path.Combine(updatepath);
            string fullpathcreate = Path.Combine(createpath);

            System.IO.File.WriteAllText(fullpathupdate, string.Empty);
            System.IO.File.WriteAllText(fullpathcreate, string.Empty);
            Create create = new Create();
            Update update = new Update();
            create.CreateAll();
            update.UpdateAll();
        }
    }
}
