using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace ChimeClock
{
    public partial class Main : Form
    {
        WindowsMediaPlayer mp = new WMPLib.WindowsMediaPlayer();
        List<int> dateList = new List<int>();
        List<int> chimeList = new List<int>();
        List<DateTime> timeList = new List<DateTime>();
        Boolean isChimeON = false;

        public Main()
        {
            InitializeComponent();
            this.setCurrentTime();
            mp.settings.autoStart = false;
            mp.StatusChange += new _WMPOCXEvents_StatusChangeEventHandler(mp_StatusChange);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = this.setCurrentTime();
            if (isChimeON)
            {
                this.insertDataGridView(dt);
                this.playChime();
            }
        }

        private DateTime setCurrentTime()
        {
            DateTime dt_Now = DateTime.Now;
            CultureInfo ci = new CultureInfo("en-US");
            label_Date.Text = DateTime.Now.ToString("yyyy/MM/dd (ddd)", ci);
            label_Time.Text = dt_Now.ToString("HH:mm:ss");
            return dt_Now;
        }

        private void playFile(String str)
        {
            mp.URL = str;
            mp.settings.volume = 100;
            mp.controls.play();
        }

        private void mp_StatusChange()
        {
            if ((int)mp.playState == 1)
            {
                mp.close();
            }
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            ChimeSetting c1 = new ChimeSetting();
            c1.ShowDialog(this);
            c1.Dispose();
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            String str_chime;
            String[] str_chime_split;
            ofd.FileName = "*.dat";
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            ofd.Filter = "チャイム設定ファイル(*.dat) | *.dat | すべてのファイル(*.*) | *.* ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dateList.Clear();
                chimeList.Clear();
                timeList.Clear();
                try
                {
                    Stream stream = ofd.OpenFile();
                    if (stream != null)
                    {
                        StreamReader sr = new StreamReader(stream);
                        while ((str_chime = sr.ReadLine()) != null)
                        {
                            str_chime_split = str_chime.Split(',');
                            if (str_chime_split[0] == "○")
                            {
                                dateList.Add(0);
                                chimeList.Add(int.Parse(str_chime_split[7]));
                                timeList.Add(DateTime.Parse(str_chime_split[8]));
                            }
                            if (str_chime_split[1] == "○")
                            {
                                dateList.Add(1);
                                chimeList.Add(int.Parse(str_chime_split[7]));
                                timeList.Add(DateTime.Parse(str_chime_split[8]));
                            }
                            if (str_chime_split[2] == "○")
                            {
                                dateList.Add(2);
                                chimeList.Add(int.Parse(str_chime_split[7]));
                                timeList.Add(DateTime.Parse(str_chime_split[8]));
                            }
                            if (str_chime_split[3] == "○")
                            {
                                dateList.Add(3);
                                chimeList.Add(int.Parse(str_chime_split[7]));
                                timeList.Add(DateTime.Parse(str_chime_split[8]));
                            }
                            if (str_chime_split[4] == "○")
                            {
                                dateList.Add(4);
                                chimeList.Add(int.Parse(str_chime_split[7]));
                                timeList.Add(DateTime.Parse(str_chime_split[8]));
                            }
                            if (str_chime_split[5] == "○")
                            {
                                dateList.Add(5);
                                chimeList.Add(int.Parse(str_chime_split[7]));
                                timeList.Add(DateTime.Parse(str_chime_split[8]));
                            }
                            if (str_chime_split[6] == "○")
                            {
                                dateList.Add(6);
                                chimeList.Add(int.Parse(str_chime_split[7]));
                                timeList.Add(DateTime.Parse(str_chime_split[8]));
                            }
                        }
                        sr.Close();
                        stream.Close();
                        this.insertDataGridView(DateTime.Now);
                        this.Text = ofd.FileName + " - ChimeClock";
                    }
                }
                catch
                {
                    MessageBox.Show("チャイム設定ファイルを読み込めません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void insertDataGridView(DateTime dt_Now)
        {
            DateTime dt = dt_Now;
            dataGridView_Chime.Rows.Clear();
            for (int i = 0; i < dateList.Count; i++)
            {
                if ((int)dt.DayOfWeek == dateList[i])
                {
                    dataGridView_Chime.Rows.Add(timeList[i].ToShortTimeString(), chimeList[i]);
                }
            }
        }

        private void button_ON_Click(object sender, EventArgs e)
        {
            if (this.Text.Contains("チャイム設定なし"))
            {
                MessageBox.Show("チャイム設定ファイルを指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isChimeON = true;
                this.button_ON.Enabled = false;
                this.button_OFF.Enabled = true;
            }
        }

        private void button_OFF_Click(object sender, EventArgs e)
        {
            isChimeON = false;
            this.button_ON.Enabled = true;
            this.button_OFF.Enabled = false;
        }

        private void playChime()
        {
            DateTime dt = DateTime.Now;
            DateTime dt_tmp;
            for (int i = 0; i < dataGridView_Chime.Rows.Count; i++)
            {
                dt_tmp = DateTime.Parse(dataGridView_Chime.Rows[i].Cells[0].Value.ToString());
                if (dt.Second == 0 )
                {
                    if(dt_tmp.ToShortTimeString() == dt.ToShortTimeString())
                    {
                        this.playFile("PT201_" + dataGridView_Chime.Rows[i].Cells[1].Value.ToString() + ".mp3");
                    }
                }
            }
        }
    }
}
