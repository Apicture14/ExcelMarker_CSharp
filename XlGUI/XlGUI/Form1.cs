using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text;
using Org.BouncyCastle.Asn1.X509;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace XlGUI
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager mgr;
        public XLWorkbook wb;
        public IXLWorksheet ws;
        public SynchronizationContext syn;
        public byte[] buffer = null;

        public string[] targets;
        public Form1()
        {
            InitializeComponent();
            mgr = MaterialSkinManager.Instance;
            mgr.AddFormToManage(this);
            mgr.EnforceBackcolorOnAllComponents = true;
            btn_confirm.Enabled = false;
            if (!File.Exists("./config.txt"))
            {
                DialogResult d = MessageBox.Show("Not Found Cfg,create one?", "Error", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    byte[] b = Encoding.UTF8.GetBytes("优秀|满分|全对|搬书|发书|搬发|表扬|加分|比赛|乐于助人");
                    FileStream fsr = new FileStream("./config.txt", FileMode.Create);
                    fsr.Write(b);
                    fsr.Close();
                    fsr.Dispose();
                }
            }
            FileStream fs = new FileStream("./config.txt", FileMode.Open);
            fs.Read(buffer);
            fs.Close();
            fs.Dispose();
            this.targets = Encoding.UTF8.GetString(buffer).Split("|");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "Row";
            ch.Width = 120;
            ch.TextAlign = HorizontalAlignment.Left;
            lv.Columns.Add(ch);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.InitialDirectory = "./";
            d.Filter = "Xlsx fIle(*.xlsx)|*.xlsx";
            var f = d.ShowDialog();
            if (f == DialogResult.OK)
            {
                pathin.Text = d.FileName;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            mgr.Theme = mgr.Theme == MaterialSkinManager.Themes.LIGHT ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {


        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.wb = new XLWorkbook(pathin.Text);
                this.ws = wb.Worksheet(int.Parse(sheetin.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Run()
        {
            int matches = 0;
            int changes = 0;
            bool found = false;
            bool changed = false;

            var r = ws.Range(colin.Text + stin.Text, colin.Text + edin.Text);
            foreach (var c in r.Cells())
            {
                found = false;
                changed = false;
                if (Array.IndexOf(targets, c.Value) > 0)
                {
                    matches++;
                    found = true;
                    if (c.Style.Fill.BackgroundColor != XLColor.Red)
                    {
                        changes++;
                        changed = true;
                        c.Style.Fill.BackgroundColor = XLColor.Red;
                    }

                }
                wb.Save();
            }
        }
    }
}