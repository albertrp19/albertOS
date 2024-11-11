using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.IO;
using System.Timers;
using System.ComponentModel.Design;
using System.Threading;
using Cosmos.System.Graphics;

namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {
        Sys.FileSystem.CosmosVFS fs = new Cosmos.System.FileSystem.CosmosVFS();
        public static VBECanvas canvas = new VBECanvas(new Mode(1920, 1080, ColorDepth.ColorDepth32));
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
                Console.Write("touch - crea un arxiu\n");
                Console.Write("rm - elimina un arxiu\n");
                Console.Write("clear - neteja la pantalla\n");
                Console.Write("write - escriu en un fitxer\n");
                Console.Write("cat - mostra el contingut del arxiu\n");
            }
            else if (input.Contains("shutdown") && input.IndexOf("shutdown ") == 0)
            {
                string[] split = Array.Empty<string>();
                if (input.Contains('-'))
                {
                    split = input.Split(" ");
                }
                else
                {
                    split[0] = "a";
                }

                if (split.Length==1)
                {
                    Cosmos.System.Power.Shutdown();
                }
                else
                {
                    if (split[1]== "-t")
                    {
                        if (split.Length == 3)
                        {
                            var temps = split[2];
                            int tempsI = int.Parse(temps)*1000;
                            Thread.Sleep(tempsI);
                            Cosmos.System.Power.Shutdown();
                        }
                        else
                        {
                            Console.Write("No has indicat el temps\n");
                        }
                    }
                    else
                    {
                        Console.Write("Aquesta variable no existeix\n");
                    }
                }

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
            else if (input.Contains("touch") && input.IndexOf("touch ")==0)
            {
                string[] split = input.Split(" ");
                var nom = split[1];
                if (!File.Exists(@"0:\" + nom))
                {
                    File.Create(@"0:\" + nom);
                }
                else
                {
                    Console.Write("El fitxer " + nom + " ja existeix\n");
                }
            }
            else if (input.Contains("rm") && input.IndexOf("rm ") == 0)
            {
                string[] split = input.Split(" ");
                var nom = split[1];
                if (File.Exists(@"0:\" + nom))
                {
                    File.Delete(@"0:\" + nom);
                }
                else
                {
                    Console.Write("El fitxer " + nom + " no existeix\n");
                }
            }
            else if (input == "clear")
            {
                Console.Clear();
            }
            else if (input.Contains("write") && input.IndexOf("write ") == 0)
            {
                string[] split = input.Split(" ");
                var write = split[1];
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
            else if (input.Contains("cat") && input.IndexOf("cat ") == 0)
            {
                string[] split = input.Split(" ");
                var cat = split[1];
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
