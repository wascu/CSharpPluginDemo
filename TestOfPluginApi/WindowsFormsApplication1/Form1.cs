using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestOfPluginApi;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsValidPlugin(Type t)
        {
            Type[] interfaces = t.GetInterfaces();
            foreach (Type ty in interfaces)
            {
                if (ty.FullName == "TestOfPluginApi.IPluginBase")
                    return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PluginPath = "E:\\工程文件\\vs2015\\VS2015工程文件 C#\\TestOfPluginApi\\build\\bin\\";


            string[] files = Directory.GetFiles(PluginPath);
            foreach(string file in files)
            {
                string ext = file.Substring(file.LastIndexOf(".")).ToLower();
                if (ext != ".dll")
                    continue;

                try {
                    Assembly ass = Assembly.LoadFrom(file);
                    Type[] types = ass.GetTypes();
                    foreach (Type type in types)
                    {
                        if(IsValidPlugin(type))
                        {
                            IPluginBase customPlugin =(IPluginBase)ass.CreateInstance(type.FullName);
                        }

                    }

                } catch(Exception ex)
                {

                }

            }
        }
    }
}
