using System;

namespace PortKnocking
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.WriteAllText(@"D:\Documenti\AAAAWORK\PortKnocking\Portknocker-Create.txt", string.Empty);
            System.IO.File.WriteAllText(@"D:\Documenti\AAAAWORK\PortKnocking\Portknocker-Update.txt", string.Empty);
            Create create = new Create();
            Update update = new Update();
            create.CreateAll();
            update.UpdateAll();
        }       
    }
}
