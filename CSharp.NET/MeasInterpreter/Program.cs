using System;
using System.IO;
using System.Threading;

namespace MeasInterpreter
{
    class Program
    {
        static void Main()
        {
        START:;
            Console.Clear();
            string splashMessage = @"
     _______________________________________
    [                                       ]
    [   A.C.M.E. Measurement Interpreter    ]
    [   Technical Support 1(309)273-8047    ]
    [_______________________________________]
            |/
            '";
            Console.WriteLine(splashMessage);

            //::====================================================
            //::Check if file exists
            //::----------------------------------------------------
            string fileToRead = "C:\\A.C.M.E\\AtomicJetEngines\\PlasmaChromatograph_Q-36\\CSharp.NET\\MarsDataRaw.csv";
            if (File.Exists(fileToRead) == false)
            {
                Console.WriteLine("  " + fileToRead + " could not be found...");
                Console.WriteLine(" ");
                Console.Write("  ...Try Again in: ");
                Wait10s();
                goto START;
            }

            //::===========================================
            //:: Read and Parse Data Comments
            //::-------------------------------------------
            string[] myArray = File.ReadAllLines(fileToRead);
            string[] line4 = myArray[3].Split(',');
            string colA = line4[0];
            string colB = line4[1];

            //::===========================================
            //::set SampleLocID
            //::------------------------------------------ -
            string locTurbineHP = "Nan";
            string locTurbineLP = "Nan";
            string locNozzle = "Nan";
            if (colB == "\"TurbineHP\"") { locTurbineHP = "1"; }
            else if (colB == "\"TurbineLP\"") { locTurbineLP = "1"; }
            else if (colB == "\"Nozzle\"") { locNozzle = "1"; }

            //::===========================================
            //:: Output File
            //::-------------------------------------------
            string fileToWrite = "C:\\A.C.M.E\\AtomicJetEngines\\PlasmaChromatograph_Q-36\\CSharp.NET\\EarthDataRaw.ini";
            string[] linesToWrite = new string[] {
                "[MeasureLoc]",
                "TurbineHP=" + locTurbineHP,
                "TurbineLP=" + locTurbineLP,
                "Nozzle="    + locNozzle,
                " ",
                "[TechSupport]",
                "Contact=Philip_Stubbs",
                "Phone=1(309)273-8047"
            };
            File.WriteAllLines(fileToWrite, linesToWrite);

            //::===========================================
            //:: Display Current Values for 10s then loop
            //::-------------------------------------------
            Console.WriteLine("  READ: " + fileToRead);
            Console.WriteLine("  WRITE: " + fileToWrite);
            Console.WriteLine(" ");
            Console.WriteLine("  Sample Location Name: " + colB);
            Console.WriteLine(" ");
            Console.Write("  ...Refreshing in: ");
            Wait10s();
            Console.Clear();
            goto START;
        }

        private static void Wait10s()
        {
            int iRow = Console.CursorTop;
            int iCol = Console.CursorLeft;
            for (int i = 0; i < 10; ++i)
            {
                Console.SetCursorPosition(iCol, iRow);
                Console.Write((10 - i) + " ");
                Thread.Sleep(1000);
            }
        }
    }
}