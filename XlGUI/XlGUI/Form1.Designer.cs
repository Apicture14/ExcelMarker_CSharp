namespace XlGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lv = new System.Windows.Forms.ListView();
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.edin = new MaterialSkin.Controls.MaterialTextBox();
            this.stin = new MaterialSkin.Controls.MaterialTextBox();
            this.colin = new MaterialSkin.Controls.MaterialTextBox();
            this.sheetin = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_browse = new MaterialSkin.Controls.MaterialButton();
            this.pathin = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.RightToLeftLayout = true;
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.ShowToolTips = true;
            this.materialTabControl1.Size = new System.Drawing.Size(788, 377);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lv);
            this.tabPage1.Controls.Add(this.btn_confirm);
            this.tabPage1.Controls.Add(this.edin);
            this.tabPage1.Controls.Add(this.stin);
            this.tabPage1.Controls.Add(this.colin);
            this.tabPage1.Controls.Add(this.sheetin);
            this.tabPage1.Controls.Add(this.btn_browse);
            this.tabPage1.Controls.Add(this.pathin);
            this.tabPage1.ImageKey = "chart.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lv
            // 
            this.lv.Location = new System.Drawing.Point(123, 105);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(614, 222);
            this.lv.TabIndex = 8;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(670, 51);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_confirm.Size = new System.Drawing.Size(67, 36);
            this.btn_confirm.TabIndex = 7;
            this.btn_confirm.Text = "Start";
            this.btn_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm.UseAccentColor = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // edin
            // 
            this.edin.AnimateReadOnly = false;
            this.edin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edin.Depth = 0;
            this.edin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.edin.Hint = "End";
            this.edin.LeadingIcon = null;
            this.edin.Location = new System.Drawing.Point(354, 54);
            this.edin.MaxLength = 50;
            this.edin.MouseState = MaterialSkin.MouseState.OUT;
            this.edin.Multiline = false;
            this.edin.Name = "edin";
            this.edin.Size = new System.Drawing.Size(59, 36);
            this.edin.TabIndex = 6;
            this.edin.Text = "";
            this.edin.TrailingIcon = null;
            this.edin.UseTallSize = false;
            // 
            // stin
            // 
            this.stin.AnimateReadOnly = false;
            this.stin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stin.Depth = 0;
            this.stin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stin.Hint = "Start";
            this.stin.LeadingIcon = null;
            this.stin.Location = new System.Drawing.Point(289, 51);
            this.stin.MaxLength = 50;
            this.stin.MouseState = MaterialSkin.MouseState.OUT;
            this.stin.Multiline = false;
            this.stin.Name = "stin";
            this.stin.Size = new System.Drawing.Size(59, 36);
            this.stin.TabIndex = 5;
            this.stin.Text = "";
            this.stin.TrailingIcon = null;
            this.stin.UseTallSize = false;
            this.stin.UseWaitCursor = true;
            // 
            // colin
            // 
            this.colin.AnimateReadOnly = false;
            this.colin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colin.Depth = 0;
            this.colin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.colin.Hint = "col";
            this.colin.LeadingIcon = null;
            this.colin.Location = new System.Drawing.Point(215, 51);
            this.colin.MaxLength = 50;
            this.colin.MouseState = MaterialSkin.MouseState.OUT;
            this.colin.Multiline = false;
            this.colin.Name = "colin";
            this.colin.Size = new System.Drawing.Size(68, 36);
            this.colin.TabIndex = 4;
            this.colin.Text = "";
            this.colin.TrailingIcon = null;
            this.colin.UseTallSize = false;
            // 
            // sheetin
            // 
            this.sheetin.AnimateReadOnly = false;
            this.sheetin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sheetin.Depth = 0;
            this.sheetin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sheetin.Hint = "Sheet ID";
            this.sheetin.LeadingIcon = null;
            this.sheetin.Location = new System.Drawing.Point(123, 49);
            this.sheetin.MaxLength = 50;
            this.sheetin.MouseState = MaterialSkin.MouseState.OUT;
            this.sheetin.Multiline = false;
            this.sheetin.Name = "sheetin";
            this.sheetin.Size = new System.Drawing.Size(86, 36);
            this.sheetin.TabIndex = 3;
            this.sheetin.Text = "";
            this.sheetin.TrailingIcon = null;
            this.sheetin.UseTallSize = false;
            // 
            // btn_browse
            // 
            this.btn_browse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_browse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btn_browse.Depth = 0;
            this.btn_browse.HighEmphasis = true;
            this.btn_browse.Icon = null;
            this.btn_browse.Location = new System.Drawing.Point(670, 9);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_browse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_browse.Size = new System.Drawing.Size(80, 36);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Browse";
            this.btn_browse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_browse.UseAccentColor = false;
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // pathin
            // 
            this.pathin.AnimateReadOnly = false;
            this.pathin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathin.Depth = 0;
            this.pathin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pathin.Hint = "Path";
            this.pathin.LeadingIcon = null;
            this.pathin.Location = new System.Drawing.Point(124, 6);
            this.pathin.MaxLength = 50;
            this.pathin.MouseState = MaterialSkin.MouseState.OUT;
            this.pathin.Multiline = false;
            this.pathin.Name = "pathin";
            this.pathin.Size = new System.Drawing.Size(539, 36);
            this.pathin.TabIndex = 0;
            this.pathin.Text = "";
            this.pathin.TrailingIcon = null;
            this.pathin.UseTallSize = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialButton2);
            this.tabPage2.ImageKey = "dashboard.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(129, 6);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(80, 36);
            this.materialButton2.TabIndex = 0;
            this.materialButton2.Text = "Change";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dashboard.png");
            this.imageList1.Images.SetKeyName(1, "chart.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerWidth = 130;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btn_browse;
        private MaterialSkin.Controls.MaterialTextBox pathin;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox edin;
        private MaterialSkin.Controls.MaterialTextBox stin;
        private MaterialSkin.Controls.MaterialTextBox colin;
        private MaterialSkin.Controls.MaterialTextBox sheetin;
        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private ListView lv;
    }
}