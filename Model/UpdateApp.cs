using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_testTask.Model
{
    /// <summary>
    /// Класс отвечает за обновление программы
    /// </summary>
    public class UpdateApp
    {
       private string tempPathDir = @"Log\";

        /// <summary>
        /// Получаем текущую версию приложения
        /// </summary>
        /// <returns></returns>
        public string getVersionApp()
        {
           return Application.ProductVersion.ToString();
        }

        /// <summary>
        /// Получаем текущую версию Сборки приложения
        /// </summary>
        /// <returns></returns>
        public string getAssemblyVersionApp()
        {
            return  Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

      
        
        /// <summary>
        /// запись в текстовой файл. Журнал событий
        /// </summary>
        /// <param name="myText"></param>
        public void WrateText(string myText)
        {
            
            using (StreamWriter sw = new StreamWriter(@"Log.txt", true, System.Text.Encoding.Default))

            // using (StreamWriter sw = new StreamWriter(myPachDir + @"texLog.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(DateTime.Now + "\t\n" + myText); // запись
            }
        }


        /// <summary>
        /// Удаление собственного экзешника
        /// </summary>
        public void StartBatDelete()
        {
            string absolitPath = Application.StartupPath;
            string extractPath = absolitPath + @"\new\WP_testTask.exe";
            string finalPath = absolitPath +"\\"+ @"WP_testTask.exe";
            string path = Application.ExecutablePath;
            string command = $"/C copy {extractPath} {absolitPath}";
          //  string command = $"/k copy {extractPath} {absolitPath}";

            try
            {
              Process.Start("cmd.exe", "/C del \"" + path + "\"");  //Удаление рабочего, текущего exe
              Thread.Sleep(100);
              Process.Start("cmd.exe", command);  //Копирование файла из папки new


               // System.Diagnostics.Process proc = new System.Diagnostics.Process();
               // proc.StartInfo.FileName = path;
               // proc.StartInfo.RedirectStandardError = false;
               // proc.StartInfo.RedirectStandardOutput = false;
               // proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
               //// proc.StartInfo.WorkingDirectory = @"C:\0TeklaBatchProcess\1-SCAD_Issue_Processing\DXF";
               //// proc.StartInfo.Arguments = @"-cfg tekla_dstv2dxf_metric.def -m batch -f *.nc1";
               // proc.Start();
               //// proc.WaitForExit();

               // Process.Start("cmd.exe", "/k \"" + path + "\"");  //Запуск обнолвенной версии
               // Process.Start("cmd.exe", "start /R:Hidden \"" + path + "\"");  //Запуск обнолвенной версии
                Process.Start("cmd.exe", " /k \"" + path + "\"");  //Запуск обнолвенной версии

            }
            catch (Exception ex)
            {
                WrateText($"Ошибка при попытки удаления старого файла{ex}");
                MessageBox.Show($"Ошибка при попытки удаления старого файла{ex}");
            }
           

            Process.GetCurrentProcess().Kill(); // закрытие текущего приложения
        }

        //тестовые методы
        public void voidTestMedod()
        {
            string absolitPath = Application.StartupPath;
            string extractPath = absolitPath + @"\new\WP_testTask1.exe";
            string finalPath = absolitPath + "\\" + @"WP_testTask.exe";
            string command = $"/k copy {extractPath} {absolitPath}";

            Process pr = new Process();
            pr.StartInfo.FileName = "cmd";
            //pr.StartInfo.Arguments = @"/k copy C:\Users\Dmytriy\Source\Repos\testWF_tax\bin\Debug\new\WP_testTask1.exe C:\Users\Dmytriy\Source\Repos\testWF_tax\bin\Debug";
            pr.StartInfo.Arguments = command;
           // pr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pr.Start();
            pr.WaitForExit();

           
        }
    }
}
