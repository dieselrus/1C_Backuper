using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace _1C_Backuper
{
    public partial class backup1c : Form
    {
        public backup1c()
        {
            InitializeComponent();
        }

        private void rbtn1CFile_CheckedChanged(object sender, EventArgs e)
        {
            txt1CServer.Enabled = !rbtn1CFile.Checked;
            txt1CBase.Enabled = !rbtn1CFile.Checked;
        }

        private void rbtn1CServer_CheckedChanged(object sender, EventArgs e)
        {
            txtBasePath.Enabled = !rbtn1CServer.Checked;
        }

        // Browse dir for backup
        private void btnBackUpPathBrows_Click(object sender, EventArgs e)
        {
            if (fbdBackUp.ShowDialog() == DialogResult.OK)
            {
                txtBackUpPath.Text = fbdBackUp.SelectedPath;
            }
        }

        // Browse dir for base 1c
        private void btnBasePathBrows_Click(object sender, EventArgs e)
        {
            if (fbd1CBase.ShowDialog() == DialogResult.OK)
            {
                txtBasePath.Text = fbd1CBase.SelectedPath;
            }
        }

        // Cancel & exit
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Saveand exit
        private void btnOK_Click(object sender, EventArgs e)
        {
            const string message = "Сохранить и закрыть программу?";
            const string caption = "Закрыть программу";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                // cancel the closure of the form.
                //e.Cancel = true;
                this.Close();
            }
        }

        private void saveTask()
        {
            // Если файл не существует, создаем
            if (!File.Exists("Task.xml"))
            {
                // Создаём сам XML-файл
                XmlTextWriter textWritter = new XmlTextWriter("Task.xml", Encoding.UTF8);
                // Создаём в файле заголовок XML-документа
                textWritter.WriteStartDocument();
                // Создём голову (head):
                textWritter.WriteStartElement("root");
                // Закрываем её
                textWritter.WriteEndElement();
                //  И закрываем наш XmlTextWriter
                textWritter.Close();
            }

            XmlDocument document = new XmlDocument();
            //Загружаем наш файл
            document.Load("Task.xml");

            XmlNode element = document.CreateElement("Task");
            document.DocumentElement.AppendChild(element);                  // указываем родителя
            XmlAttribute attribute = document.CreateAttribute("Name");      // создаём атрибут
            attribute.Value = txtTaskName.Text;                             // устанавливаем значение атрибута
            element.Attributes.Append(attribute);                           // добавляем атрибут

            // Task name
            XmlNode backupPath = document.CreateElement("backupPath");      // даём имя
            backupPath.InnerText = txtBackUpPath.Text;                      // и значение
            element.AppendChild(backupPath);                                // и указываем кому принадлежит

            // 1C путь файлу 1C
            XmlNode file1CPath = document.CreateElement("file1CPath");
            file1CPath.InnerText = txt1CFilePath.Text;
            element.AppendChild(file1CPath);

            // Activ
            XmlNode activ = document.CreateElement("activ");
            activ.InnerText = chbActiv.Checked.ToString();
            element.AppendChild(activ);

            // 1C путь к базе
            XmlNode filePath = document.CreateElement("base1CPath");
            filePath.InnerText = txtBasePath.Text;
            element.AppendChild(filePath);

            // 1C сервер
            XmlNode server1C = document.CreateElement("server1C");
            server1C.InnerText = txt1CServer.Text;
            element.AppendChild(server1C);

            // 1C база
            XmlNode base1C = document.CreateElement("base1C");
            base1C.InnerText = txt1CBase.Text;
            element.AppendChild(base1C);

            // 1C пользователь
            XmlNode user1C = document.CreateElement("user1C");
            user1C.InnerText = txt1CUser.Text;
            element.AppendChild(user1C);

            // 1C пароль
            XmlNode password1C = document.CreateElement("password1C");
            password1C.InnerText = txt1CPassword.Text;
            element.AppendChild(password1C);

            // час
            XmlNode taskHour = document.CreateElement("taskHour");
            taskHour.InnerText = numHour.Value.ToString();
            element.AppendChild(taskHour);

            // минута
            XmlNode taskMin = document.CreateElement("taskMin");
            taskMin.InnerText = numMin.Value.ToString();
            element.AppendChild(taskMin);

            // вид базы
            XmlNode FileOrServer = document.CreateElement("FileOrServer");
            FileOrServer.InnerText = rbtn1CFile.Checked ? "1" : "2";
            element.AppendChild(FileOrServer);

            document.Save("Task.xml");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTaskName.Text == "")
            {
                MessageBox.Show("Заполните имя задания!");
                return;
            }

            const string message = "Сохранить изменения в задании?";
            const string caption = "Сохранить";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                saveTask();
            }
        }

        // Выбор исполняемого файла 1С
        private void btn1CPathBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Исполняемый файл (*.exe)|*.exe";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "1cv8";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt1CFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void backup1c_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Закрыть программу?";
            const string caption = "Закрыть программу";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }

        private void readXML()
        {
            // Если файл не существует, создаем
            if (!File.Exists("Task.xml"))
            {
                return;
            }

            XDocument doc = XDocument.Load("Task.xml");
            if (doc == null || doc.Root == null)
                throw new ApplicationException("invalid data");

            //проходим по каждому элементу в найшей library
            //(этот элемент сразу доступен через свойство doc.Root)
            foreach (XElement el in doc.Root.Elements())
            {
                lstTask.Items.Add(el.Attribute("Name").Value);
                /*
                //Выводим имя элемента и значение аттрибута id
                Console.WriteLine("{0} {1}", el.Name, el.Attribute("Task").Value);
                Console.WriteLine("  Attributes:");
                //выводим в цикле все аттрибуты, заодно смотрим как они себя преобразуют в строку
                foreach (XAttribute attr in el.Attributes())
                    Console.WriteLine("    {0}", attr);
                Console.WriteLine("  Elements:");
                //выводим в цикле названия всех дочерних элементов и их значения
                foreach (XElement element in el.Elements())
                    Console.WriteLine("    {0}: {1}", element.Name, element.Value);
                 */
            }
        }

        private void readTaskSettings(String taskName)
        {
            // Если файл не существует, создаем
            if (!File.Exists("Task.xml"))
            {
                return;
            }

            XDocument doc = XDocument.Load("Task.xml");
            if (doc == null || doc.Root == null)
                throw new ApplicationException("invalid data");

            //проходим по каждому элементу в найшей library
            //(этот элемент сразу доступен через свойство doc.Root)
            foreach (XElement el in doc.Root.Elements("Task"))
            {

                if (el.Attribute("Name").Value == taskName)
                {

                    try
                    {
                        //foreach (XElement element in el.Elements())
                        //    Console.WriteLine("    {0}: {1}", element.Name, element.Value);

                        txtTaskName.Text = taskName;

                        txtBackUpPath.Text = el.Elements("backupPath").First().Value;

                        txt1CFilePath.Text = el.Elements("file1CPath").First().Value;

                        if (el.Elements("activ").First().Value == "True")
                        {
                            chbActiv.Checked = true;
                        }
                        else
                        {
                            chbActiv.Checked = false;
                        }

                        txtBasePath.Text = el.Elements("base1CPath").First().Value;
                        txt1CServer.Text = el.Elements("server1C").First().Value;
                        txt1CBase.Text = el.Elements("base1C").First().Value;
                        txt1CUser.Text = el.Elements("user1C").First().Value;
                        txt1CPassword.Text = el.Elements("password1C").First().Value;
                        numHour.Value = Convert.ToInt32(el.Elements("taskHour").First().Value);
                        numMin.Value = Convert.ToInt32(el.Elements("taskMin").First().Value);

                        if (el.Elements("FileOrServer").First().Value == "1")
                        {
                            rbtn1CFile.Checked = true;
                        }
                        else if (el.Elements("FileOrServer").First().Value == "2")
                        {
                            rbtn1CServer.Checked = true;
                        }
                    }

                    catch (IOException e)
                    {
                        string message = e.Source.ToString();
                        const string caption = "Ошибка тения файла заданий!";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void lstTask_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Console.WriteLine("lstTask_SelectedIndexChanged" + sender);
            readTaskSettings(lstTask.GetItemText(lstTask.SelectedItem));		
        }

        private void backup1c_Load(object sender, EventArgs e)
        {
            lstTask.Items.Clear();
            readXML();
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            // Если файл не существует, создаем
            if (!File.Exists("Task.xml"))
            {
                return;
            }

            XDocument doc = XDocument.Load("Task.xml");
            if (doc == null || doc.Root == null)
                throw new ApplicationException("invalid data");

            doc.Element("Сводная").RemoveAll();
        }
    }
}
