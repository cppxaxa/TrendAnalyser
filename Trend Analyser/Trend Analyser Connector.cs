using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Trend_Analyser
{
    class Trend_Analyser_Connector
    {
        // Business Logic

        //[DllImport(Path.Trend_Analyser_DLL, EntryPoint = "test_1", CallingConvention = CallingConvention.Cdecl)]
        //public static extern int CPP_test_1();

        public static List<string> List_Storage_Files()
        {
            List<string> fnamelist = new List<string>();

            string[] files = Directory.GetFiles(Path.Storage_Dir);
            foreach(string file in files){
                int len = file.Length;
                int trimmer = file.LastIndexOf('\\') + 1;
                //MessageBox.Show(file + " " + len + " " + trimmer);
                if (trimmer >= 0 && trimmer < len)
                {
                    string fname = file;
                    fname = fname.Substring(trimmer, len - trimmer);
                    fname = fname.Substring(0, fname.LastIndexOf('.'));
                    fnamelist.Add(fname);
                }
            }

            return fnamelist;
        }

        public static void Trend_Analyser_Module_1()
        {
            string result = RunPythonScript(Path.Trend_Analyser_Module_1, "");
            //string result = RunPythonScript("-V", "");
            MessageBox.Show(result);
        }

        public static string Trend_Analyser_Module_2_Download_Data(string symbol, string syear, string smonth, string sday, string eyear, string emonth, string eday)
        {
            string argv = "\"" + Path.Storage_Dir + "\" " + symbol + " " + syear + " " + smonth + " " + sday + " " + eyear + " " + emonth + " " + eday;
            //MessageBox.Show(argv);
            string result = RunPythonScript(Path.Trend_Analyser_Module_2_Download_Data, argv);
            //MessageBox.Show(result);
            return result;
        }

        public static string Trend_Analyser_Module_3_Analyser_with_Highlighter(string csvname, int syy, int smm, int sdd, int eyy, int emm, int edd)
        {
            string argv = "\"" + Path.Storage_Dir + "\" " + csvname + " " + syy.ToString() + " " + smm.ToString() + " " + sdd.ToString() + " " + eyy.ToString() + " " + emm.ToString() + " " + edd.ToString();
            //MessageBox.Show(argv);
            string result = RunPythonScript(Path.Trend_Analyser_Module_3_Analyser_Highlighter, argv);
            //MessageBox.Show(result);

            return result;
        }

        public static string Trend_Analyser_Module_3_Analyser(string csvname)
        {
            string argv = "\"" + Path.Storage_Dir + "\" " + csvname;
            //MessageBox.Show(argv);
            string result = RunPythonScript(Path.Trend_Analyser_Module_3_Analyser, argv);
            //MessageBox.Show(result);

            return result;
        }

        public static string Trend_Analyser_Module_3_Analyser_Line_with_Highlighter(string csvname, int syy, int smm, int sdd, int eyy, int emm, int edd)
        {
            string argv = "\"" + Path.Storage_Dir + "\" " + csvname + " " + syy.ToString() + " " + smm.ToString() + " " + sdd.ToString() + " " + eyy.ToString() + " " + emm.ToString() + " " + edd.ToString();
            //MessageBox.Show(argv);
            string result = RunPythonScript(Path.Trend_Analyser_Module_3_Analyser_Line_Highlighter, argv);
            //MessageBox.Show(result);

            return result;
        }

        public static string Trend_Analyser_Module_3_Analyser_Line(string csvname)
        {
            string argv = "\"" + Path.Storage_Dir + "\" " + csvname;
            //MessageBox.Show(argv);
            string result = RunPythonScript(Path.Trend_Analyser_Module_3_Analyser_Line, argv);
            //MessageBox.Show(result);

            return result;
        }

        public static string Trend_Analyser_Module_3_Support_Resistance_Predictor_1(string csvname)
        {
            string argv = "\"" + Path.Storage_Dir + "\" " + csvname + " n n";
            //MessageBox.Show(argv);
            string result = RunPythonScript(Path.Trend_Analyser_Module_3_support_resistance_predictor_1, argv);
            //MessageBox.Show(result);

            return result;
        }

        public static string Trend_Analyser_Module_3_Support_Resistance_Predictor_1_with_segmentation_chart(string csvname)
        {
            string argv = "\"" + Path.Storage_Dir + "\" " + csvname + " y n";
            //MessageBox.Show(argv);
            string result = RunPythonScript(Path.Trend_Analyser_Module_3_support_resistance_predictor_1, argv);
            //MessageBox.Show(result);

            return result;
        }

        public static string Trend_Analyser_Module_3_Support_Resistance_Predictor_1_with_regression_chart(string csvname)
        {
            string argv = "\"" + Path.Storage_Dir + "\" " + csvname + " n y";
            //MessageBox.Show(argv);
            string result = RunPythonScript(Path.Trend_Analyser_Module_3_support_resistance_predictor_1, argv);
            //MessageBox.Show(result);

            return result;
        }




        // Utilities

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        public static void Destroy()
        {
            int WM_CLOSE = 0x0010, WM_SETTEXT = 0x000C;
            string esc = "\x1b";
            IntPtr hWnd = (IntPtr)FindWindow("edges", null);
            SendMessage(hWnd, WM_SETTEXT, 0, esc);
            SendMessage(hWnd, WM_CLOSE, 0, null);
        }

        public static string RunPythonScript(string cmd, string args, bool errorStream = false)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = Path.PythonExecutable;
            start.FileName = Path.PythonExecutable;
            //start.Arguments = string.Format("\"{0}\" {1}", cmd, args);
            start.Arguments = "\"" + cmd + "\" " + args;

            //MessageBox.Show("Argument " + start.Arguments);

            start.UseShellExecute = false;
            if (!errorStream)
            {
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = false;
            }
            else
            {
                start.RedirectStandardOutput = false;
                start.RedirectStandardError = true;
            }
            string result = null;

            Process process = Process.Start(start);

            if (!errorStream)
            {
                StreamReader reader = process.StandardOutput;
                result = reader.ReadToEnd();
            }
            else
            {
                StreamReader reader = process.StandardError;
                result = "Standard Error: " + reader.ReadToEnd();
            }
            
            return result;
        }
    }
}
