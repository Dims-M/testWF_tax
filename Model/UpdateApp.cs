﻿using System;
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


        public void StartUpdaeApp()
        {
            
        }

        /// <summary>
        /// Удаление собственного экзешника
        /// </summary>
        public void StartBatDelete()
        {
            string absolitPath = Application.StartupPath;
            string extractPath = absolitPath + @"\new\WP_testTask.exe";

            try
            {
                //File.Delete(@"C:\Program Files (x86)\KKM-Сервис\TimeUpdatesWF\TimeUpdatesWF.exe");
                string path = Application.ExecutablePath;

               // 

                Process.Start("cmd.exe", "/C \"" + extractPath + "\"");  //Запуск батника для запуск обновления
               
              Thread.Sleep(50);
              Process.Start("cmd.exe", "/c del \"" + path + "\"");  //Запуск батника

            }
            catch (Exception ex)
            {
                WrateText($"Ошибка при попытки удаления старого файла{ex}");
                MessageBox.Show($"Ошибка при попытки удаления старого файла{ex}");
            }
           
            Process.GetCurrentProcess().Kill(); // закрытие текущего приложения
        }


    }
}