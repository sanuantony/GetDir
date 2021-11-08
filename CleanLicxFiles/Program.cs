
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLicxFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ClearContent(@"D:\EHRCore\NGDev\Core");
                ClearContent(@"D:\EHRCore");

            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(1000);
        }
        static void ClearContent(string rootFolder)
        {
            List<String> FileNames = new List<string>()
            {
                @"\core\EMR\NextGen32\Modules\Mainapp\licenses.licx"
                ,@"\core\NextGen\EMR\Controls\Properties\licenses.licx"
                ,@"\core\NextGen\EMR\Documents\EMR Docproc\Properties\licenses.licx"
                ,@"\core\NextGen\EMR\Documents\Generator\ActiveDocuments\Properties\licenses.licx"
                ,@"\core\NextGen\EMR\Documents\Generator\Common\Properties\licenses.licx"
                ,@"\core\NextGen\EMR\EMRApp\Workflow\ErxRefill\Properties\licenses.licx"
                ,@"\core\NextGen\EMR\EMRApp\Workflow\Properties\licenses.licx"
                ,@"\core\NextGen\EMR\Optical\UserInterface\Properties\licenses.licx"
                ,@"\core\NextGen\Interfaces\RulesEngine\Properties\licenses.licx"
                ,@"\core\NextGen\PopulationManagementHub\Properties\licenses.licx"
                ,@"\core\NextGen\Shared\Consent\NextGen.Shared.Consent\Properties\licenses.licx"
                ,@"\core\NextGen\Shared\Filemaintenance\My Project\licenses.licx"
                ,@"\core\NextGen\Shared\InfragisticsHelper\Properties\licenses.licx"
                ,@"\core\NextGen\Shared\InteropViewer\Properties\licenses.licx"
                ,@"\core\NextGen\Shared\InteropViewer\UnitTests\Properties\licenses.licx"
                ,@"\core\NextGen\Shared\Letters\Properties\licenses.licx"
                ,@"\core\NextGen\Shared\PatCorrespondence\Properties\licenses.licx"
            };
            foreach (var fileName in FileNames)
            {
                var path = rootFolder + fileName;
                if (File.Exists(path))
                File.WriteAllText(path, String.Empty);
            }
        }
    }
}
