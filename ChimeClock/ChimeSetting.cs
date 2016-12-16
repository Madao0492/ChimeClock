using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace ChimeClock
{
    public partial class ChimeSetting : Form
    {
        WindowsMediaPlayer mp = new WindowsMediaPlayer();
        public ChimeSetting()
        {
            InitializeComponent();
            mp.settings.autoStart = false;
            mp.StatusChange += new _WMPOCXEvents_StatusChangeEventHandler(mp_StatusChange);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            this.stopFile();
            if ((!checkBox_Sun.Checked) && (!checkBox_Mon.Checked) && (!checkBox_Tue.Checked) && (!checkBox_Wed.Checked) && (!checkBox_Thu.Checked) && (!checkBox_Fri.Checked) && (!checkBox_Sat.Checked))
            {
                MessageBox.Show("曜日が選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sun, mon, tue, wed, thu, fri, sat;
                int chime;
                sun = "";
                mon = "";
                tue = "";
                wed = "";
                thu = "";
                fri = "";
                sat = "";
                if (checkBox_Sun.Checked)
                    sun = "○";
                if (checkBox_Mon.Checked)
                    mon = "○";
                if (checkBox_Tue.Checked)
                    tue = "○";
                if (checkBox_Wed.Checked)
                    wed = "○";
                if (checkBox_Thu.Checked)
                    thu = "○";
                if (checkBox_Fri.Checked)
                    fri = "○";
                if (checkBox_Sat.Checked)
                    sat = "○";
                if (radioButton1.Checked)
                    chime = 1;
                else if (radioButton2.Checked)
                    chime = 2;
                else if (radioButton3.Checked)
                    chime = 3;
                else if (radioButton4.Checked)
                    chime = 4;
                else if (radioButton5.Checked)
                    chime = 5;
                else
                    chime = 6;
                dataGridView_Chime.Rows.Add(sun, mon, tue, wed, thu, fri, sat, chime, dateTimePicker1.Value.ToShortTimeString());
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            this.stopFile();
            if(dataGridView_Chime.SelectedRows.Count <= 0)
            {
                MessageBox.Show("削除する行を選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow r in dataGridView_Chime.SelectedRows)
                {
                    if (!r.IsNewRow)
                    {
                        dataGridView_Chime.Rows.Remove(r);
                    }
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            int i;
            String str_chime;
            this.stopFile();
            if (dataGridView_Chime.RowCount <= 0)
            {
                MessageBox.Show("チャイムが設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "*.dat";
                sfd.Filter = "チャイム設定ファイル(*.dat)|*.dat|すべてのファイル(*.*)|*.*";
                sfd.InitialDirectory = Directory.GetCurrentDirectory();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = sfd.OpenFile();
                    if (stream != null)
                    {
                        StreamWriter sw = new StreamWriter(stream);
                        i = 0;
                        while (i < dataGridView_Chime.RowCount)
                        {
                            str_chime = "";
                            for (int j = 0; j < 9; j++)
                            {
                                str_chime += dataGridView_Chime.Rows[i].Cells[j].Value + ",";
                            }
                            str_chime = str_chime.Remove(str_chime.Length - 1, 1);
                            sw.Write(str_chime + Environment.NewLine);
                            i++;
                        }
                        sw.Close();
                        stream.Close();
                    }
                    this.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.playFile("PT201_1.mp3");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.playFile("PT201_2.mp3");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.playFile("PT201_3.mp3");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.playFile("PT201_4.mp3");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.playFile("PT201_5.mp3");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.playFile("PT201_6.mp3");
        }

        private void playFile(String str)
        {
            mp.URL = str;
            mp.settings.volume = 100;
            mp.controls.play();
        }

        private void stopFile()
        {
            mp.controls.stop();
        }

        private void mp_StatusChange()
        {
            if ((int)mp.playState == 1)
            {
                mp.close();
            }
        }
    }
}
