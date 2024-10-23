using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.IO;
using System.Timers;
using System.ComponentModel.Design;

namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {
        Sys.FileSystem.CosmosVFS fs = new Cosmos.System.FileSystem.CosmosVFS();
        protected override void BeforeRun()
        {
            Console.WriteLine("albertOS\n");
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
        }
        protected override void Run()
        {
            int bucle = 0;
            while (bucle != 1)
            {
                Console.Write("Input: ");
                var input = Console.ReadLine();
                Opcions(input);
            }
        }
        public void ls()
        {
            var files_list = Directory.GetFiles(@"0:\");
            foreach (var file in files_list)
            {
                Console.WriteLine(file);
            }
        }
        public void Opcions(string input)
        {
            if (input == "help")
            {
                Console.Write("help - Mostra aquest missatge\n");
                Console.Write("shutdown - Apaga el equip\n");
                Console.Write("reboot - Reinicia el equip\n");
                Console.Write("space - Mostra l'espai lliure \n");
                Console.Write("ls - llista els arxius\n");
                Console.Write("clear - neteja la pantalla\n");
            }
            else if (input == "shutdown")
            {
                Cosmos.System.Power.Shutdown();
            }
            else if (input == "reboot")
            {
                Cosmos.System.Power.Reboot();
            }
            else if (input == "space")
            {
                var available_space = fs.GetAvailableFreeSpace(@"0:\");
                available_space = available_space / 1000;
                available_space = available_space / 1000;
                Console.WriteLine("Available Free Space: " + available_space + "MB");
            }
            else if (input == "ls")
            {
                ls();
            }
            else if (input == "touch")
            {
                Console.Write("Indica el nom del fitxer:\n");
                var nom = Console.ReadLine();
                if (!File.Exists(@"0:\" + nom))
                {
                    File.Create(@"0:\" + nom);
                }
                else
                {
                    Console.Write("El fitxer " + nom + " ja existeix\n");
                }
            }
            else if (input == "rm")
            {
                ls();
                Console.Write("Indica el nom del fitxer:\n");
                var rm = Console.ReadLine();
                if (File.Exists(@"0:\" + rm))
                {
                    File.Delete(@"0:\" + rm);
                }
                else
                {
                    Console.Write("El fitxer " + rm + " no existeix\n");
                }
            }
            else if (input == "clear")
            {
                Console.Clear();
            }
            else if (input == "write")
            {
                ls();
                Console.Write("Indica el nom del fitxer:\n");
                var write = Console.ReadLine();
                if (File.Exists(@"0:\" + write))
                {
                    Console.Write("Indica el text:\n");
                    var text = Console.ReadLine();
                    File.WriteAllText(@"0:\" + write, text);
                }
                else
                {
                    Console.Write("El fitxer " + write + " no existeix\n");
                }
            }
            else if (input == "cat")
            {
                ls();
                Console.Write("Indica el nom del fitxer:\n");
                var cat = Console.ReadLine();
                if (File.Exists(@"0:\" + cat))
                {
                    Console.WriteLine(File.ReadAllText(@"0:\" + cat));
                }
                else
                {
                    Console.Write("El fitxer " + cat + " no existeix\n");
                }
            }
            else
            {
                Console.WriteLine("Comande no valida\n");
            }

        }
    }
}
