using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace backup_KOTH
{
    public partial class Form1 : Form
    {
        public static DateTime Today { get; }
        public Form1()
        {
            InitializeComponent();
            loadTo(dataGridView1);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string saveDir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Arma 3\";
            DateTime thisDay = DateTime.Today;
            DateTime thisNow = DateTime.Now;
            string backupDir = Directory.GetCurrentDirectory() + "\\Backup\\" + thisDay.ToString("d") + " - " + thisNow.ToString("HH;mm;ss");
            string DataNow = thisNow.ToString("HH:mm") + " - " + thisDay.ToString("d");
   
            try
            {
                string[] Arma3List = Directory.GetFiles(saveDir, "*.Arma3Profile");

                foreach (string f in Arma3List)
                {
                    // Создание бэкапа
                    string fName = f.Substring(saveDir.Length);
                    Directory.CreateDirectory(backupDir);
                    File.Copy(Path.Combine(saveDir, fName), Path.Combine(backupDir, fName), true);
                }


       
            dataGridView1.Rows.Add(DataNow, "", "Восстановить", "Удалить", backupDir);
            saveTo(dataGridView1);
            }

            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
                MessageBox.Show("Ошибка");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                // Восстонов.
                if (e.ColumnIndex == 2)
                {


                    string saveDir = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string backupDir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Arma 3\";


                    string[] Arma3List = Directory.GetFiles(saveDir, "*.Arma3Profile");

                    foreach (string f in Arma3List)
                    {
                        string fName = f.Substring(saveDir.Length + 1);
                        File.Copy(Path.Combine(saveDir, fName), Path.Combine(backupDir, fName), true);
                    }
                    MessageBox.Show("Успешно!");

                }

                // Удаление
                if (e.ColumnIndex == 3)
                {
                    string saveDir = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string[] Arma3List = Directory.GetFiles(saveDir, "*.Arma3Profile");

                    for (int i = 0; i < Arma3List.Length; i++)
                    {
                        File.Delete(Arma3List[i]);
                    }
                    Directory.Delete(saveDir);
                }

                saveTo(dataGridView1);

            }

            catch {}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{ 
            int last = dataGridView1.Rows.Count - 1;
            string saveDir = dataGridView1.Rows[last].Cells[4].Value.ToString();
            string backupDir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Arma 3\";


            string[] Arma3List = Directory.GetFiles(saveDir, "*.Arma3Profile");

            foreach (string f in Arma3List)
            {
                string fName = f.Substring(saveDir.Length + 1);
                File.Copy(Path.Combine(saveDir, fName), Path.Combine(backupDir, fName), true);
            }
            saveTo(dataGridView1);
            MessageBox.Show("Успешно!");

        }

            catch { MessageBox.Show("Ошибка"); }
        }

        public static void saveTo(DataGridView dr)
        {
            try
            {
                //DataGridView dgv=...
                string file = "data.bin";
                using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
                {
                    bw.Write(dr.Columns.Count);
                    bw.Write(dr.Rows.Count);
                    foreach (DataGridViewRow dgvR in dr.Rows)
                    {
                        for (int j = 0; j < dr.Columns.Count; ++j)
                        {
                            object val = dgvR.Cells[j].Value;
                            if (val == null)
                            {
                                bw.Write(false);
                                bw.Write(false);
                            }
                            else
                            {
                                bw.Write(true);
                                bw.Write(val.ToString());
                            }
                        }
                    }
                }
            }
            catch { MessageBox.Show("Ошибка сохранения"); }
        }

        public static void loadTo(DataGridView dr)
        {
            try { 

            dr.Rows.Clear();
            string file = "data.bin";
            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    dr.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dr.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }
            }

        }

            catch
            {

            }


        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            saveTo(dataGridView1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveTo(dataGridView1);
        }

        private void инфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор - https://vk.com/id208497682 \n PreHack.ru");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
