using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_testTask.Model;

namespace WP_testTask
{
    public partial class Form1 : Form
    {
        UpdateApp servis;

        public Form1()
        {
            InitializeComponent();
           
        }

        //Кнопка получения текущей версии
        private void button2_Click(object sender, EventArgs e)
        {
            servis = new UpdateApp();
            // servis.StartBatDelete();
            //  servis.DeleteApp();
            servis.voidTestMedod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            servis = new UpdateApp();
            lbInfaVersion.Text = servis.getVersionApp();
            lbAssemblyApp.Text = servis.getAssemblyVersionApp();

        }
    }
}
