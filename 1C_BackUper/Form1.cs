using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace _1C_Backuper
{
    public partial class backup1c : Form
    {

        INI _ini = new INI(AppDomain.CurrentDomain.BaseDirectory + "\\Task.ini");

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

        private void saveTaskINI(String Task)
        {
            // Путь к архивам
            _ini.IniWriteValue(Task, "backupPath",  txtBackUpPath.Text);
            // 1C путь файлу 1C
            _ini.IniWriteValue(Task, "file1CPath",  txt1CFilePath.Text);
            // Activ
            _ini.IniWriteValue(Task, "activ", chbActiv.Checked.ToString());
            // 1C путь к базе
            _ini.IniWriteValue(Task, "base1CPath", txtBasePath.Text);
            // 1C сервер
            _ini.IniWriteValue(Task, "server1C", txt1CServer.Text);
            // 1C база
            _ini.IniWriteValue(Task, "base1C", txt1CBase.Text);
            // 1C пользователь
            _ini.IniWriteValue(Task, "user1C", txt1CUser.Text);
            // 1C пароль
            _ini.IniWriteValue(Task, "password1C", txt1CPassword.Text);
            // час
            _ini.IniWriteValue(Task, "taskHour", numHour.Value.ToString());
            // минута
            _ini.IniWriteValue(Task, "taskMin", numMin.Value.ToString());
            // вид базы
            _ini.IniWriteValue(Task, "FileOrServer", rbtn1CFile.Checked ? "1" : "2");

            // Удалить секцию
            //_ini.IniWriteValue(Task, null, null);
        }

        private void readTaskINI(String Task)
        {
            txtTaskName.Text = Task;
            // Путь к архивам
            txtBackUpPath.Text = _ini.IniReadValue(Task,"backupPath");
            // 1C путь файлу 1C
            txt1CFilePath.Text = _ini.IniReadValue(Task,"file1CPath");
            // Activ
            if (_ini.IniReadValue(Task, "activ") == "True")
            {
                chbActiv.Checked = true;
            }
            else
            {
                chbActiv.Checked = false;
            }
            // 1C путь к базе
            txtBasePath.Text = _ini.IniReadValue(Task, "base1CPath");
            // 1C сервер
            txt1CServer.Text = _ini.IniReadValue(Task, "server1C");
            // 1C база
            txt1CBase.Text = _ini.IniReadValue(Task, "base1C");
            // 1C пользователь
            txt1CUser.Text = _ini.IniReadValue(Task, "user1C");
            // 1C пароль
            txt1CPassword.Text = _ini.IniReadValue(Task, "password1C");
            // час
            numHour.Value = Convert.ToInt32(_ini.IniReadValue(Task, "taskHour"));
            // минута
            numMin.Value = Convert.ToInt32(_ini.IniReadValue(Task, "taskMin"));
            // вид базы
            if (_ini.IniReadValue(Task, "FileOrServer") == "1")
            {
                rbtn1CFile.Checked = true;
            }
            else if (_ini.IniReadValue(Task, "FileOrServer") == "2")
            {
                rbtn1CServer.Checked = true;
            }
        }

        // Сохранить задание
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
                saveTaskINI(txtTaskName.Text);
            }

            lstTask.Items.Clear();
            lstTask.Items.AddRange(_ini.GetSectionNames());
        }

        // Выбор исполняемого файла 1С
        private void btn1CPathBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = txt1CFilePath.Text;
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

        // Выбор задания в списке
        private void lstTask_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            readTaskINI(lstTask.GetItemText(lstTask.SelectedItem));		
        }

        // Загрузка формы
        private void backup1c_Load(object sender, EventArgs e)
        {
            lstTask.Items.Clear();
            lstTask.Items.AddRange(_ini.GetSectionNames());
        }

        // Удаление задания из списка
        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            // Удалить секцию
            _ini.IniWriteValue(lstTask.GetItemText(lstTask.SelectedItem), null, null);

            lstTask.Items.Clear();
            lstTask.Items.AddRange(_ini.GetSectionNames());
        }

        // Новая задача
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            readTaskINI(null);
        }

    }


    class INI
    { 
        //Использование может быть следующим. Записываем значение в файл: 
        //INI ini = new INI("Путь_к_файлу"); ini.IniWriteValue("Test_block","Key","Value");

        //Теперь в нашем файле есть значение Key, которое равно Value. Теперь считаем его: 
        //string value = ini.IniReadValue("Test_block","Key");

        public string pathINI;

        [DllImport("kernel32")] 
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")] 
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        // Second Method
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, int Key, string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result, int Size, string FileName);

        // Third Method
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(int Section, string Key, string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result, int Size, string FileName);

        public INI(string INIPath) 
        { 
             pathINI = INIPath; 
        } 

        public void IniWriteValue(string Section, string Key, string Value) 
        { 
               if(!Directory.Exists(Path.GetDirectoryName(pathINI))) 
                     Directory.CreateDirectory(Path.GetDirectoryName(pathINI)); 
               if(!File.Exists(pathINI)) 
                      using (File.Create(pathINI)) { }; 

               WritePrivateProfileString(Section, Key, Value, this.pathINI); 
        } 

       public string IniReadValue(string Section, string Key) 
       { 
             StringBuilder temp = new StringBuilder(255); 
             int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.pathINI); 
             return temp.ToString(); 
       }

       public string[] GetSectionNames()
       {
           //    Sets the maxsize buffer to 500, if the more
           //    is required then doubles the size each time.
           for (int maxsize = 500; true; maxsize *= 2)
           {
               //    Obtains the information in bytes and stores
               //    them in the maxsize buffer (Bytes array)
               byte[] bytes = new byte[maxsize];
               int size = GetPrivateProfileString(0, "", "", bytes, maxsize, this.pathINI);

               // Check the information obtained is not bigger
               // than the allocated maxsize buffer - 2 bytes.
               // if it is, then skip over the next section
               // so that the maxsize buffer can be doubled.
               if (size < maxsize - 2)
               {
                   // Converts the bytes value into an ASCII char. This is one long string.
                   //string Selected = Encoding.ASCII.GetString(bytes, 0, size - (size > 0 ? 1 : 0));

                   // русский
                   string Selected = Encoding.Default.GetString(bytes, 0, size - (size > 0 ? 1 : 0));
                   // sRet = System.Text.Encoding.Default.GetString(bRet, 0, i).TrimEnd((char)0);
                   //string Selected = System.Text.Encoding.Default.GetString(bRet, 0, i).TrimEnd((char)0);

                   // Splits the Long string into an array based on the "\0"
                   // or null (Newline) value and returns the value(s) in an array
                   return Selected.Split(new char[] { '\0' });
               }
           }
       }
    }
}
