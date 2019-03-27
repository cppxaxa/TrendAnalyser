using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Trend_Analyser
{
    public static class Path
    {
        public static string Result_Storage_Dir = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Analysis_Result");
        public static string Result_Table = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Analysis_Result\last_result.csv");
        public static string Storage_Dir = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Storage");
        public static string Buffer_CSV = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Buffer_CSV.csv");
        public static string Buffer_String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Buffer_String.txt");

        public static string PythonExecutable = File.ReadAllText("PythonPath.txt");
        public static string Trend_Analyser_DLL = "D:\\Libraries\\Documents\\visual studio 2013\\Projects\\Trend Analyser\\x64\\Debug\\Trend Analyser DLL.dll";

        public static string Last_Request_Multiple = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Config\last_request_multiple_list.config");
        /*
         * WAIT : Python can't handle commandline arguement with space. Instead we are enclosing them with \"
         * so that python may not encounter any problem. Don't prefer @
         * 
         * test_existence() won't detect the problem
         */

        //public string Trend_Analyser_Module_1 = "\"D:\\Libraries\\Documents\\visual studio 2013\\Projects\\Trend Analyser\\Trend Analyser Module 1\\Trend_Analyser_Module_1.py\"";
        public static string Trend_Analyser_Module_1 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Trend Analyser Module 1\\Trend_Analyser_Module_1.py");
        public static string Trend_Analyser_Module_2_Download_Data = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Trend Analyser Module 2 Download Data\\Trend_Analyser_Module_2_Download_Data.py");
        public static string Trend_Analyser_Module_3_Analyser = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Trend Analyser Module 3 Analyser\\Trend_Analyser_Module_3_Analyser.py");
        public static string Trend_Analyser_Module_3_Analyser_Line = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Trend Analyser Module 3 Analyser\\Trend_Analyser_Module_3_Analyser_Line.py");

        public static string Trend_Analyser_Module_3_Analyser_Highlighter = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Trend Analyser Module 3 Analyser\\Trend_Analyser_Module_3_Analyser_Highlighter.py");
        public static string Trend_Analyser_Module_3_Analyser_Line_Highlighter = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Trend Analyser Module 3 Analyser\\Trend_Analyser_Module_3_Analyser_Line_Highlighter.py");

        public static string Trend_Analyser_Module_3_support_resistance_predictor_1 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Trend Analyser Module 3 Analyser\\support_resistance_predictor_1.py");
        
        public static string test_existence(bool showMsg = true)
        {
            string error = "", probs = "";
            int length = 0;

            if (File.Exists(PythonExecutable))
                error += "Python Exec Found";
            else
            {
                error += "Python Exec NOT FOUND";
                probs += "Python Exec NOT FOUND\n";
            }

            error += "\n";

            if (File.Exists(Trend_Analyser_DLL))
                error += "DLL Found";
            else
            {
                error += "DLL NOT FOUND";
                probs += "DLL NOT FOUND\n";
            }

            error += "\n";

            length = Trend_Analyser_Module_1.Length;
            //if (File.Exists(Trend_Analyser_Module_1.Substring(1).Substring(0, length - 2)))
            if (File.Exists(Trend_Analyser_Module_1))
                error += "Module 1 Found";
            else
            {
                error += "Module 1 NOT FOUND";
                probs += "Module 1 NOT FOUND\n";
            }

            error += "\n";

            length = Trend_Analyser_Module_2_Download_Data.Length;
            //if (File.Exists(Trend_Analyser_Module_2_Download_Data.Substring(1).Substring(0, length - 2)))
            if (File.Exists(Trend_Analyser_Module_2_Download_Data))
                error += "Module 2 Found";
            else
            {
                error += "Module 2 NOT FOUND";
                probs += "Module 2 NOT FOUND\n";
            }

            error += "\n";

            if (File.Exists(Trend_Analyser_Module_3_support_resistance_predictor_1))
                error += "Module 3 support resistant predictor 1 Found";
            else
            {
                error += "Module 3 support resistant predictor 1 NOT FOUND";
                probs += "Module 3 support resistant predictor 1 NOT FOUND\n";
            }

            error += "\n";

            if(showMsg)
                MessageBox.Show(error);

            return error;
        }
    }
}
