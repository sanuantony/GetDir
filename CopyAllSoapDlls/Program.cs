using System;
using System.IO;

namespace CopyAllSoapDlls
{
    class Program
    {
        static void Main(string[] args)
        {
            var dlls = new string[]
            {
                "NextGen.Solaire.Components.dll"
                ,"NextGen.Solaire.Components.Kbm.dll"
                ,"NextGen.Solaire.Components.Kbm.Resources.dll"
                ,"NextGen.Solaire.DataAccess.dll"
                ,"NextGen.Solaire.DataAccess.Interfaces.dll"
                ,"NextGen.Solaire.DataAccess.Kbm.dll"
                ,"NextGen.Solaire.DataAccess.Kbm.Interfaces.dll"
                ,"NextGen.Solaire.DataAccess.Kbm.Models.dll"
                ,"NextGen.Solaire.Framework.dll"
                ,"NextGen.Solaire.Generator.Models.dll"
                ,"NextGen.Solaire.Host.DataAccess.dll"
                ,"NextGen.Solaire.Host.DataAccess.Models.dll"
                ,"NextGen.Solaire.Host.EHR.dll"
                ,"NextGen.Solaire.Host.Interfaces.dll"
                ,"NextGen.Solaire.Host.Services.dll"
                ,"NextGen.Solaire.Logging.dll"
                ,"NextGen.Solaire.Logging.Interfaces.dll"
                ,"NextGen.Solaire.Models.dll"
                ,"NextGen.Solaire.Models.Kbm.dll"
                ,"NextGen.Solaire.Services.Kbm.dll"
                ,"NextGen.Solaire.Services.Kbm.Functions.dll"
                ,"NextGen.Solaire.Services.Kbm.Functions.Graphing.Percentile.dll"
                ,"NextGen.Solaire.Services.Kbm.Functions.Interfaces.dll"
                ,"NextGen.Solaire.Services.Kbm.Interfaces.dll"
            };
            try
            {
                string l = DateTime.Now.ToString(" yyyy-MM-dd-HH-mm-ss-fff");
                string backupPath = @"D:\Dlls\" + l;
                Directory.CreateDirectory(backupPath);

                //Taking Backup of existing files
                foreach (var dll in dlls)
                    File.Copy(Path.Combine(@"C:\NEXTGEN", dll), Path.Combine(backupPath, dll), true);

                File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Kbm.Fts_Soap.dll"), Path.Combine(backupPath, "NextGen.Kbm.Fts_Soap.dll"), true);
                File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Ui.dll"), Path.Combine(backupPath, "NextGen.Ace.Ui.dll"), true);
                File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Cards.dll"), Path.Combine(backupPath, "NextGen.Ace.Cards.dll"), true);
                File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Audit.dll"), Path.Combine(backupPath, "NextGen.Ace.Audit.dll"), true);
                File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Kbm.Fts_Intake.dll"), Path.Combine(backupPath, "NextGen.Kbm.Fts_Intake.dll"), true);
                File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Kbm.Well_Child_Soap.dll"), Path.Combine(backupPath, "NextGen.Kbm.Well_Child_Soap.dll"), true);
                try
                {
                    File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Services.dll"), Path.Combine(backupPath, "NextGen.Ace.Services.dll"), true);
                    File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Services.Interfaces.dll"), Path.Combine(backupPath, "NextGen.Ace.Services.Interfaces.dll"), true);
                    File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Services.Models.dll"), Path.Combine(backupPath, "NextGen.Ace.Services.Models.dll"), true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.ReadKey();
                }
                //File.Copy(Path.Combine(@"C:\NEXTGEN", "NextGen.Kbm.SystemTemplates.dll"), Path.Combine(backupPath, "NextGen.Kbm.SystemTemplates.dll"), true);

                //Copying the new files
                foreach (var dll in dlls)
                    if (!dll.Contains("NextGen.Solaire.Host"))
                        File.Copy(Path.Combine(@"D:\BananaCore\nextgen.solaire\bin", dll), Path.Combine(@"C:\NEXTGEN", dll), true);
                //File.Copy(Path.Combine(@"D:\BananaCore\nextgen.solaire\bin", "NextGen.Solaire.Host.EHRd.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Solaire.Host.EHR.dll"), true);

                File.Copy(Path.Combine(@"D:\BananaCore\nextgen.ace.services\bin", "NextGen.Ace.Services.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Services.dll"), true);
                File.Copy(Path.Combine(@"D:\BananaCore\nextgen.ace.services\bin", "NextGen.Ace.Services.Interfaces.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Services.Interfaces.dll"), true);
                File.Copy(Path.Combine(@"D:\BananaCore\nextgen.ace.services\bin", "NextGen.Ace.Services.Models.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Services.Models.dll"), true);

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Fts_Soap.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Fts_Soap.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Kbm.Fts_Soap.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Fts_Soap");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.ace.ui\bin", "NextGen.Ace.Ui.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.ace.ui\bin", "NextGen.Ace.Ui.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Ui.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy UI");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Ace.Cards.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Ace.Cards.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Cards.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Card");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Ace.Audit.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Ace.Audit.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Ace.Audit.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Audit");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Fts_Intake.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Fts_Intake.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Kbm.Fts_Intake.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Fts_Intake");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Well_Child_Soap.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Well_Child_Soap.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Kbm.Well_Child_Soap.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Well_Child_Soap");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.TemplateConfiguration.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.TemplateConfiguration.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Kbm.TemplateConfiguration.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy TemplateConfiguration");
                }

                var di = new DirectoryInfo(@"D:\NEXTGEN");
                di.Attributes &= FileAttributes.Normal;

                //Copying the new files
                foreach (var dll in dlls)
                    if (!dll.Contains("NextGen.Solaire.Host"))
                        File.Copy(Path.Combine(@"D:\BananaCore\nextgen.solaire\bin", dll), Path.Combine(@"D:\NEXTGEN", dll), true);
                //File.Copy(Path.Combine(@"D:\BananaCore\nextgen.solaire\bin", "NextGen.Solaire.Host.EHRd.dll"), Path.Combine(@"C:\NEXTGEN", "NextGen.Solaire.Host.EHR.dll"), true);

                File.Copy(Path.Combine(@"D:\BananaCore\nextgen.ace.services\bin", "NextGen.Ace.Services.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Ace.Services.dll"), true);
                File.Copy(Path.Combine(@"D:\BananaCore\nextgen.ace.services\bin", "NextGen.Ace.Services.Interfaces.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Ace.Services.Interfaces.dll"), true);
                File.Copy(Path.Combine(@"D:\BananaCore\nextgen.ace.services\bin", "NextGen.Ace.Services.Models.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Ace.Services.Models.dll"), true);

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Fts_Soap.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Fts_Soap.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Kbm.Fts_Soap.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Fts_Soap");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.ace.ui\bin", "NextGen.Ace.Ui.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.ace.ui\bin", "NextGen.Ace.Ui.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Ace.Ui.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy UI");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Ace.Cards.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Ace.Cards.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Ace.Cards.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Card");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Ace.Audit.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Ace.Audit.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Ace.Audit.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Audit");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Fts_Intake.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Fts_Intake.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Kbm.Fts_Intake.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Fts_Intake");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Well_Child_Soap.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.Well_Child_Soap.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Kbm.Well_Child_Soap.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy Well_Child_Soap");
                }

                if (File.Exists(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.TemplateConfiguration.dll")))
                {
                    File.Copy(Path.Combine(@"D:\BananaCore\nextgen.templates\bin", "NextGen.Kbm.TemplateConfiguration.dll"), Path.Combine(@"D:\NEXTGEN", "NextGen.Kbm.TemplateConfiguration.dll"), true);
                }
                else
                {
                    Console.WriteLine("Unable to copy TemplateConfiguration");
                }

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Done...............");
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                throw e;
            }
            if (Console.BackgroundColor == ConsoleColor.DarkRed)
            {
                Console.ReadKey();
            }
            System.Threading.Tasks.Task.Delay(1000);
        }
    }
}
