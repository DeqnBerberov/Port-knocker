using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PortKnocking
{
    class Update
    {
        public string tempPath = Directory.GetCurrentDirectory();
        public string tempdir;
        public void UpdateAll()
        {
            Update update = new Update();
            update.UpdateGWNR01();
            update.UpdateGWNR02();
            update.UpdateGWSF03();
           // update.UpdateGWSF04();
            update.UpdateGWSK01();
            //update.UpdateGWSK02();
        }

        public void UpdateGWNR01()
        {
            tempdir = Path.GetFullPath(Path.Combine(tempPath, @"..\..\..\"));
            string[] paths = { tempdir, "Portknocker-Update.txt" };
            string fullpath = Path.Combine(paths);
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(fullpath, true))
            {
                file.WriteLine("==================================================GW-NR01======================================================");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.135 list=ROUTERACCESS comment=""Temp for updating port-knocking. If it is still here - delete it""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp comment=""ports for portknocking""") ;
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
            }
        }

        public void UpdateGWNR02()
        {
            tempdir = Path.GetFullPath(Path.Combine(tempPath, @"..\..\..\"));
            string[] paths = { tempdir, "Portknocker-Update.txt" };
            string fullpath = Path.Combine(paths);
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(fullpath, true))
            {
                file.WriteLine("==================================================GW-NR02======================================================");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.135 list=ROUTERACCESS comment=""Temp for updating port-knocking. If it is still here - delete it""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp comment=""ports for portknocking""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
            }
        }

        public void UpdateGWSF03()
        {
            tempdir = Path.GetFullPath(Path.Combine(tempPath, @"..\..\..\"));
            string[] paths = { tempdir, "Portknocker-Update.txt" };
            string fullpath = Path.Combine(paths);
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(fullpath, true))
            {
                file.WriteLine("==================================================GW-SF03======================================================");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.135 list=ROUTERACCESS comment=""Temp for updating port-knocking. If it is still here - delete it""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp comment=""ports for portknocking""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
            }
        }
        /*
        public void UpdateGWSF04()
        {
            tempdir = Path.GetFullPath(Path.Combine(tempPath, @"..\..\..\"));
            string[] paths = { tempdir, "Portknocker-Update.txt" };
            string fullpath = Path.Combine(paths);
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(fullpath, true))
            {
                file.WriteLine("==================================================GW-SF04======================================================");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.135 list=ROUTERACCESS comment=""Temp for updating port-knocking. If it is still here - delete it""");      
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp comment=""ports for portknocking""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
            }
        }
        */
        public void UpdateGWSK01()
        {
            tempdir = Path.GetFullPath(Path.Combine(tempPath, @"..\..\..\"));
            string[] paths = { tempdir, "Portknocker-Update.txt" };
            string fullpath = Path.Combine(paths);
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(fullpath, true))
            {
                file.WriteLine("==================================================GW-SK01======================================================");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.135 list=ROUTERACCESS comment=""Temp for updating port-knocking. If it is still here - delete it""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp comment=""ports for portknocking""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
            }
        }
        /*
        public void UpdateGWSK02()
        {
            tempdir = Path.GetFullPath(Path.Combine(tempPath, @"..\..\..\"));
            string[] paths = { tempdir, "Portknocker-Update.txt" };
            string fullpath = Path.Combine(paths);
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(fullpath, true))
            {
                file.WriteLine("==================================================GW-SK02======================================================");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.135 list=ROUTERACCESS comment=""Temp for updating port-knocking. If it is still here - delete it""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp comment=""ports for portknocking""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
            }
        }
        */
    }
}
