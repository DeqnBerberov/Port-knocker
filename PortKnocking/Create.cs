using System;
using System.Collections.Generic;
using System.Text;

namespace PortKnocking
{
    class Create
    {
        public void CreateAll()
        {
            Create create = new Create();
            create.CreateDefault();
            create.CreateGWNR01();
            create.CreateGWNR02();
            create.CreateGWSF03();
            create.CreateGWSF04();
            create.CreateGWSK01();
            create.CreateGWSK02();
        }
        public void CreateDefault()
        {
            Random rnd = new Random();
            int port1 = 62521;
            int port2 = 29819;
            int port3 = 9851;
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Documenti\AAAAWORK\PortKnocking\Portknocker-Create.txt", true))
            {
                file.WriteLine("==================================================Default======================================================");
                file.WriteLine("/ip firewall filter add action=accept chain=input connection-state=established,related");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp src-port=""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
                file.WriteLine($@"/ip firewall filter add action=drop chain=input dst-port=22,88,443,8291 protocol=tcp src-address-list=!ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.0 list=ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=78.90.5.201 list=ROUTERACCESS");
            }
        }

        public void CreateGWNR01()
        {
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Documenti\AAAAWORK\PortKnocking\Portknocker-Create.txt", true))
            {
                file.WriteLine("==================================================GW-NR01======================================================");
                file.WriteLine("/ip firewall filter add action=accept chain=input connection-state=established,related");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp src-port=""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
                file.WriteLine($@"/ip firewall filter add action=drop chain=input dst-port=22,88,443,8291 protocol=tcp src-address-list=!ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.0 list=ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=78.90.5.201 list=ROUTERACCESS");
            }
        }

        public void CreateGWNR02()
        {
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Documenti\AAAAWORK\PortKnocking\Portknocker-Create.txt", true))
            {
                file.WriteLine("==================================================GW-NR02======================================================");
                file.WriteLine("/ip firewall filter add action=accept chain=input connection-state=established,related");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp src-port=""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
                file.WriteLine($@"/ip firewall filter add action=drop chain=input dst-port=22,88,443,8291 protocol=tcp src-address-list=!ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.0 list=ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=78.90.5.201 list=ROUTERACCESS");
            }
        }

        public void CreateGWSF03()
        {
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Documenti\AAAAWORK\PortKnocking\Portknocker-Create.txt", true))
            {
                file.WriteLine("==================================================GW-SF03======================================================");
                file.WriteLine("/ip firewall filter add action=accept chain=input connection-state=established,related");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp src-port=""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
                file.WriteLine($@"/ip firewall filter add action=drop chain=input dst-port=22,88,443,8291 protocol=tcp src-address-list=!ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.0 list=ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=78.90.5.201 list=ROUTERACCESS");
            }
        }

        public void CreateGWSF04()
        {
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Documenti\AAAAWORK\PortKnocking\Portknocker-Create.txt", true))
            {
                file.WriteLine("==================================================GW-SF04======================================================");
                file.WriteLine("/ip firewall filter add action=accept chain=input connection-state=established,related");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp src-port=""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
                file.WriteLine($@"/ip firewall filter add action=drop chain=input dst-port=22,88,443,8291 protocol=tcp src-address-list=!ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.0 list=ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=78.90.5.201 list=ROUTERACCESS");
            }
        }

        public void CreateGWSK01()
        {
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Documenti\AAAAWORK\PortKnocking\Portknocker-Create.txt", true))
            {
                file.WriteLine("==================================================GW-SK01======================================================");
                file.WriteLine("/ip firewall filter add action=accept chain=input connection-state=established,related");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp src-port=""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
                file.WriteLine($@"/ip firewall filter add action=drop chain=input dst-port=22,88,443,8291 protocol=tcp src-address-list=!ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.0 list=ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=78.90.5.201 list=ROUTERACCESS");
            }
        }

        public void CreateGWSK02()
        {
            Random rnd = new Random();
            int port1 = rnd.Next(1024, 65535);
            int port2 = rnd.Next(1024, port1);
            int port3 = rnd.Next(1024, port2);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Documenti\AAAAWORK\PortKnocking\Portknocker-Create.txt", true))
            {
                file.WriteLine("==================================================GW-SK02======================================================");
                file.WriteLine("/ip firewall filter add action=accept chain=input connection-state=established,related");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=FirstKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port1} protocol=tcp src-port=""");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=SecondKnock_RouterAccess address-list-timeout=10s chain=input dst-port={port2} protocol=tcp src-address-list=FirstKnock_RouterAccess");
                file.WriteLine($@"/ip firewall filter add action=add-src-to-address-list address-list=ROUTERACCESS address-list-timeout=1m chain=input dst-port={port3} protocol=tcp src-address-list=""SecondKnock_RouterAccess""");
                file.WriteLine($@"/ip firewall filter add action=drop chain=input dst-port=22,88,443,8291 protocol=tcp src-address-list=!ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=192.168.3.0 list=ROUTERACCESS");
                file.WriteLine($@"/ip firewall address-list add address=78.90.5.201 list=ROUTERACCESS");
            }
        }
    }
}
