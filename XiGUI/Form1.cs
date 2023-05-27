using ClosedXML;
using ClosedXML.Excel;
using XlUtils;


namespace XiGUI
{
    public partial class Form1 : Form
    {
        public bool Loaded = false;
        public string[]? tar = null;
        public int prog = 0;
        public enum ColorType
        {
            Fill = 0,
            Stroke

        }
        public enum Flag
        {
            INITING,
            SUSPENDING,
            RUNNING,
            RESETING
        }
        public Flag flag = Flag.INITING;
        public ColorType ct = ColorType.Fill;
        public Color c = Color.Red;
        public Thread t;
        public Form1()
        {
            InitializeComponent();
            /*
            ColumnHeader i = new ColumnHeader();
            ColumnHeader n = new ColumnHeader();
            ColumnHeader e = new ColumnHeader();
            ColumnHeader r = new ColumnHeader();
            ColumnHeader o = new ColumnHeader();
            i.Text = "Row"; n.Text = "Name"; e.Text = "Description"; r.Text = "Result"; o.Text = "Operation";
            LV.Columns.Add(i);
            LV.Columns.Add(n);
            LV.Columns.Add(e);
            LV.Columns.Add(r);
            LV.Columns.Add(o);
            */
            COB.SelectedItem = COB.Items[0];
            COB.Enabled = false;
            //Bt_S.Enabled = false;
            //CBC.Enabled = false;
            CBC.Checked = true;
            Bt_R.Enabled = false;
            if (File.Exists("./Default.ycf"))
            {
                this.tar = Utils.read("./Default.ycf", "ybyb");

                this.LL.Text = Utils.seqPrint(this.tar);
                Loaded = true;
            }
            this.Lb.SelectedItem = this.Lb.Items[0];
            t = new Thread(new ParameterizedThreadStart(Tick));
        }

        public void log(object msg)
        {
            string time = DateTime.Now.ToShortTimeString();
            this.Invoke(delegate
            {
                RT_LOG.AppendText(time + msg.ToString() + "\r\n");
            });
        }
        private void Bt_F_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.InitialDirectory = "./";
            d.Filter = "Xlsx File(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (d.ShowDialog() == DialogResult.OK)
            {
                Fin.Text = d.FileName;
            }
        }

        private void Fin_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(Fin.Text) && new FileInfo(Fin.Text).Extension == ".xlsx")
            {
                //Bt_S.Enabled = true;
                Cin.Enabled = true;
                Win.Enabled = true;
                Iin.Enabled = true;
            }
            else
            {
                Cin.Enabled = false;
                Win.Enabled = false;
                Iin.Enabled = false;
                Bt_S.Enabled = false;
            }
        }

        private void Win_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(Win.Text);
                Bt_S.Enabled = true;
            }
            catch (Exception ex)
            {
                Bt_S.Enabled = false;
                //MessageBox.Show(ex.Message);
            }
        }

        private async void Bt_S_Click(object sender, EventArgs e)
        {
            if (!Loaded)
            {
                MessageBox.Show("Load Config First");
                return;
            }
            Bt_F.Enabled = false;
            Fin.Enabled = false;
            Win.Enabled = false;
            Cin.Enabled = false;
            Iin.Enabled = false;
            Bt_S.Enabled = false;

            if (CBC.Checked)
            {
                Utils.cmdRun("taskkill -IM EXCEL.EXE -F -T");
                Task.Delay(1);
            }

            await Task.Run(() => run(tar));

        }
        private async void run(string[] tars)
        {
            this.flag = Flag.RUNNING;
            t.Start();
            //int current = 0;
            var ing = int.Parse(Iin.Text);
            var wb = new XLWorkbook(Fin.Text);
            var ws = wb.Worksheet(int.Parse(Win.Text));
            var cl = ws.Column(Cin.Text);
            int cl2 = ws.LastRowUsed().RowNumber();

            this.Invoke(delegate
            {
                PB.Maximum = cl2;
            });
            for (int i = 1; i <= cl2; i++)
            {
                try
                {

                    var c = cl.Cell(i);

                    //MessageBox.Show(ws.Column(2).Cell(c.WorksheetRow().RowNumber()).Value.ToString());

                    string name = (string)ws.Column(2).Cell(c.WorksheetRow().RowNumber()).Value;
                    bool find = false;
                    bool change = false;
                    if (ing <= 0)
                    {
                        return;
                    }
                    if (string.IsNullOrEmpty((string)c.Value))
                    {
                        ing--;
                    }
                    foreach (var t in tars)
                    {
                        if (((string)c.Value).Contains(t))
                        {
                            find = true;
                            if (this.ct == ColorType.Fill)
                            {
                                if (!(c.Style.Fill.BackgroundColor == XLColor.FromColor(this.c)))
                                {
                                    c.Style.Fill.BackgroundColor = XLColor.FromColor(this.c);
                                    change = true;

                                }
                            }
                            else
                            {
                                if (!(c.Style.Font.FontColor == XLColor.FromColor(this.c)))
                                {
                                    c.Style.Font.FontColor = XLColor.FromColor(this.c);
                                    change = true;

                                }
                            }
                            int ind = 0;
                            this.Invoke(delegate
                            {
                                ind = COB.SelectedIndex;
                            });
                            XLBorderStyleValues? bv = null;
                            switch (ind)
                            {
                                case 0:
                                    bv = XLBorderStyleValues.None;
                                    break;
                                case 1:
                                    bv = XLBorderStyleValues.Thin;
                                    break;
                                case 2:
                                    bv = XLBorderStyleValues.Medium;
                                    break;
                                case 3:
                                    bv = XLBorderStyleValues.Thick;
                                    break;
                            }

                            if (CBL.GetItemChecked(0))
                            {
                                c.Style.Border.TopBorder = (XLBorderStyleValues)bv;
                            }
                            if (CBL.GetItemChecked(1))
                            {
                                c.Style.Border.BottomBorder = (XLBorderStyleValues)bv;
                            }
                            if (CBL.GetItemChecked(2))
                            {
                                c.Style.Border.LeftBorder = (XLBorderStyleValues)bv;
                            }
                            if (CBL.GetItemChecked(3))
                            {
                                c.Style.Border.RightBorder = (XLBorderStyleValues)bv;
                            }


                        }
                    }
                    string cc = "/ ", ff = "未发现";
                    if (find)
                    {
                        ff = "发现";
                        if (change)
                        {
                            cc = "已更改";
                        }
                        else
                        {
                            cc = "未更改";
                        }
                    }

                    this.Invoke(delegate
                    {
                        this.LV.Items.Add(new ListViewItem(new string[5] { i.ToString(), name, (string)c.Value, ff, cc }));
                        PB.Value = i;
                        LPB.Text = i.ToString() + $"/{cl2}";


                    });
                    prog++;


                }
                catch (Exception ex)
                {
                    log(ex);
                    continue;
                }
            }
                this.flag = Flag.SUSPENDING;
                if (MessageBox.Show("Save?", "Warn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    wb.Save();
                }
                wb.Dispose();
            
                this.Invoke(delegate { Bt_R.Enabled = true; });
            }

        private void Tick(object prog)
        {
            float st = (float)System.Environment.TickCount;
            float et = 0;
            while (this.flag == Flag.RUNNING)
            {
                et = (float)System.Environment.TickCount;
                this.Invoke(delegate { SLB_T.Text = $"TimeCost:{(et - st) / 1000f}s";SLB_V.Text = $"AvergeSpeed:{Math.Round((float)this.prog / (((float)et - (float)st) / 1000f),2)}"; });
                
                
            }
            //Environment.Exit(0);
            
        }

            private void Bt_L_Click(object sender, EventArgs e)
            {
                try
                {
                    if (File.Exists(Cfin.Text) && (new FileInfo(Cfin.Text).Extension == ".ycf"))
                    {
                        this.tar = Utils.read(Cfin.Text, "ybyb");
                        if (this.tar != null)
                        {
                            this.LL.Text = Utils.seqPrint(this.tar);
                            Loaded = true;
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invaild File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex) { log(ex); }
            }

            private void Bt_G_Click(object sender, EventArgs e)
            {
                try {
                    Utils.gen(STin.Text, "ybyb", FNin.Text);
                } catch (Exception ex) { log(ex); }
            }

            private void Bt_C_Click(object sender, EventArgs e)
            {
                try
                {
                    OpenFileDialog d = new OpenFileDialog();
                    d.InitialDirectory = "./";
                    d.Filter = "Config File(*.ycf)|*.ycf|All Files(*.*)|*.*";
                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        Cfin.Text = d.FileName;
                    }
                } catch (Exception ex) { log(ex); }
            }

            private void Bt_R_Click(object sender, EventArgs e)
            {
                try
                {
                    Fin.Enabled = true;
                    Win.Enabled = true;
                    Iin.Enabled = true;
                    Cin.Enabled = true;

                    LV.Items.Clear();
                    PB.Value = 0;
                prog = 0;
                    LPB.Text = "-/-";
                    Bt_F.Enabled = true;
                    Bt_R.Enabled = false;
                    Bt_S.Enabled = true;
                t.Abort();
                }
                catch (Exception ex) { log(ex); }
            }  

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Sc_Click(object sender, EventArgs e)
        {
            try { 
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.c = cd.Color;
                Rin.Text = Convert.ToString(c.R);
                Gin.Text = Convert.ToString(c.G);
                Bin.Text = Convert.ToString(c.B);
                Ain.Text = Convert.ToString(c.A);
                LCT.ForeColor = c;
                LCTB.ForeColor = c;
                LCTW.ForeColor = c;
                }
            }catch(Exception ex) { log(ex); }
        }

        private void Lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lb.SelectedIndex == 0)
            {
                ct = ColorType.Fill;
            }
            else
            {
                ct = ColorType.Stroke;
            }
        }

        private void Bt_Cc_Click(object sender, EventArgs e)
        {
            try {
                this.c = Color.FromArgb(int.Parse(Ain.Text), int.Parse(Rin.Text), int.Parse(Gin.Text), int.Parse(Bin.Text));
                LCT.ForeColor = c;
                LCTW.ForeColor = c;
                LCTB.ForeColor = c;
            }catch (Exception ex) { log(ex); }
        }



        private void CBL_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_Test.Text = Convert.ToString(CBL.CheckedItems.Count);
            if (CBL.CheckedItems.Count != 0)
            {
                COB.Enabled = true;
            }
            else { COB.Enabled = false; }
        }

        private void COB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
