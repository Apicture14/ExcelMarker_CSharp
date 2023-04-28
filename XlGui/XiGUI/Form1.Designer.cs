namespace XiGUI
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
            PB = new ProgressBar();
            LPB = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Bt_R = new Button();
            CBC = new CheckBox();
            Bt_S = new Button();
            Bt_F = new Button();
            Iin = new TextBox();
            Cin = new TextBox();
            Win = new TextBox();
            Fin = new TextBox();
            LV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tabPage2 = new TabPage();
            label2 = new Label();
            FNin = new TextBox();
            LG = new Label();
            Bt_G = new Button();
            STin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            LL = new Label();
            label1 = new Label();
            Bt_L = new Button();
            Bt_C = new Button();
            Cfin = new TextBox();
            tabPage3 = new TabPage();
            COB = new ComboBox();
            CBL = new CheckedListBox();
            LCTW = new Label();
            LCTB = new Label();
            Ain = new TextBox();
            label8 = new Label();
            Bt_Cc = new Button();
            LCT = new Label();
            Bt_Sc = new Button();
            Bin = new TextBox();
            Gin = new TextBox();
            Rin = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Lb = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // PB
            // 
            PB.Location = new Point(147, 84);
            PB.Name = "PB";
            PB.Size = new Size(220, 23);
            PB.TabIndex = 8;
            // 
            // LPB
            // 
            LPB.AutoSize = true;
            LPB.Location = new Point(386, 90);
            LPB.Name = "LPB";
            LPB.Size = new Size(23, 17);
            LPB.TabIndex = 9;
            LPB.Text = "-/-";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Bt_R);
            tabPage1.Controls.Add(LPB);
            tabPage1.Controls.Add(CBC);
            tabPage1.Controls.Add(PB);
            tabPage1.Controls.Add(Bt_S);
            tabPage1.Controls.Add(Bt_F);
            tabPage1.Controls.Add(Iin);
            tabPage1.Controls.Add(Cin);
            tabPage1.Controls.Add(Win);
            tabPage1.Controls.Add(Fin);
            tabPage1.Controls.Add(LV);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 396);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Bt_R
            // 
            Bt_R.Location = new Point(668, 84);
            Bt_R.Name = "Bt_R";
            Bt_R.Size = new Size(75, 23);
            Bt_R.TabIndex = 16;
            Bt_R.Text = "Reset";
            Bt_R.UseVisualStyleBackColor = true;
            Bt_R.Click += Bt_R_Click;
            // 
            // CBC
            // 
            CBC.AutoSize = true;
            CBC.Location = new Point(11, 84);
            CBC.Name = "CBC";
            CBC.Size = new Size(130, 21);
            CBC.TabIndex = 15;
            CBC.Text = "Auto Close EXCEL";
            CBC.UseVisualStyleBackColor = true;
            // 
            // Bt_S
            // 
            Bt_S.Location = new Point(668, 44);
            Bt_S.Name = "Bt_S";
            Bt_S.Size = new Size(75, 23);
            Bt_S.TabIndex = 14;
            Bt_S.Text = "Start";
            Bt_S.UseVisualStyleBackColor = true;
            Bt_S.Click += Bt_S_Click;
            // 
            // Bt_F
            // 
            Bt_F.Location = new Point(668, 1);
            Bt_F.Name = "Bt_F";
            Bt_F.Size = new Size(75, 23);
            Bt_F.TabIndex = 13;
            Bt_F.Text = "Browse";
            Bt_F.UseVisualStyleBackColor = true;
            Bt_F.Click += Bt_F_Click;
            // 
            // Iin
            // 
            Iin.Location = new Point(427, 44);
            Iin.Name = "Iin";
            Iin.Size = new Size(100, 23);
            Iin.TabIndex = 12;
            Iin.Text = "10";
            // 
            // Cin
            // 
            Cin.Location = new Point(217, 44);
            Cin.Name = "Cin";
            Cin.Size = new Size(100, 23);
            Cin.TabIndex = 11;
            Cin.Text = "C";
            // 
            // Win
            // 
            Win.Location = new Point(11, 44);
            Win.Name = "Win";
            Win.Size = new Size(100, 23);
            Win.TabIndex = 10;
            Win.Text = "1";
            Win.TextChanged += Win_TextChanged;
            // 
            // Fin
            // 
            Fin.Location = new Point(11, 0);
            Fin.Name = "Fin";
            Fin.Size = new Size(635, 23);
            Fin.TabIndex = 9;
            Fin.TextChanged += Fin_TextChanged;
            // 
            // LV
            // 
            LV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            LV.Location = new Point(6, 123);
            LV.Name = "LV";
            LV.Size = new Size(756, 267);
            LV.TabIndex = 8;
            LV.UseCompatibleStateImageBehavior = false;
            LV.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Row";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Event";
            columnHeader3.Width = 350;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Result";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Operation";
            columnHeader5.Width = 150;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(FNin);
            tabPage2.Controls.Add(LG);
            tabPage2.Controls.Add(Bt_G);
            tabPage2.Controls.Add(STin);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(LL);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(Bt_L);
            tabPage2.Controls.Add(Bt_C);
            tabPage2.Controls.Add(Cfin);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 396);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Config";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 169);
            label2.Name = "label2";
            label2.Size = new Size(27, 17);
            label2.TabIndex = 25;
            label2.Text = ".ycf";
            // 
            // FNin
            // 
            FNin.Location = new Point(14, 163);
            FNin.Name = "FNin";
            FNin.Size = new Size(100, 23);
            FNin.TabIndex = 24;
            FNin.Text = "Config1";
            // 
            // LG
            // 
            LG.AutoSize = true;
            LG.Location = new Point(11, 198);
            LG.Name = "LG";
            LG.Size = new Size(35, 17);
            LG.TabIndex = 23;
            LG.Text = "NaN";
            // 
            // Bt_G
            // 
            Bt_G.Location = new Point(662, 130);
            Bt_G.Name = "Bt_G";
            Bt_G.Size = new Size(75, 23);
            Bt_G.TabIndex = 22;
            Bt_G.Text = "Generate";
            Bt_G.UseVisualStyleBackColor = true;
            Bt_G.Click += Bt_G_Click;
            // 
            // STin
            // 
            STin.Location = new Point(11, 129);
            STin.Name = "STin";
            STin.Size = new Size(629, 23);
            STin.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 109);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 20;
            label4.Text = "Generate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 12);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 19;
            label3.Text = "Load";
            // 
            // LL
            // 
            LL.AutoSize = true;
            LL.Location = new Point(11, 68);
            LL.Name = "LL";
            LL.Size = new Size(82, 17);
            LL.TabIndex = 18;
            LL.Text = "WaitForLoad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 68);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 17;
            // 
            // Bt_L
            // 
            Bt_L.Location = new Point(662, 62);
            Bt_L.Name = "Bt_L";
            Bt_L.Size = new Size(75, 23);
            Bt_L.TabIndex = 16;
            Bt_L.Text = "Load";
            Bt_L.UseVisualStyleBackColor = true;
            Bt_L.Click += Bt_L_Click;
            // 
            // Bt_C
            // 
            Bt_C.Location = new Point(662, 33);
            Bt_C.Name = "Bt_C";
            Bt_C.Size = new Size(75, 23);
            Bt_C.TabIndex = 15;
            Bt_C.Text = "Browse";
            Bt_C.UseVisualStyleBackColor = true;
            Bt_C.Click += Bt_C_Click;
            // 
            // Cfin
            // 
            Cfin.Location = new Point(11, 32);
            Cfin.Name = "Cfin";
            Cfin.Size = new Size(629, 23);
            Cfin.TabIndex = 14;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(COB);
            tabPage3.Controls.Add(CBL);
            tabPage3.Controls.Add(LCTW);
            tabPage3.Controls.Add(LCTB);
            tabPage3.Controls.Add(Ain);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(Bt_Cc);
            tabPage3.Controls.Add(LCT);
            tabPage3.Controls.Add(Bt_Sc);
            tabPage3.Controls.Add(Bin);
            tabPage3.Controls.Add(Gin);
            tabPage3.Controls.Add(Rin);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(Lb);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 396);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            // 
            // COB
            // 
            COB.FormattingEnabled = true;
            COB.Items.AddRange(new object[] { "None", "Thin", "Medium", "Thick" });
            COB.Location = new Point(142, 133);
            COB.Name = "COB";
            COB.Size = new Size(121, 25);
            COB.TabIndex = 15;
            COB.SelectedIndexChanged += COB_SelectedIndexChanged;
            // 
            // CBL
            // 
            CBL.FormattingEnabled = true;
            CBL.Items.AddRange(new object[] { "Top", "Bottom", "Left", "Right" });
            CBL.Location = new Point(3, 133);
            CBL.Name = "CBL";
            CBL.Size = new Size(120, 76);
            CBL.TabIndex = 14;
            CBL.SelectedIndexChanged += CBL_SelectedIndexChanged;
            // 
            // LCTW
            // 
            LCTW.AutoSize = true;
            LCTW.BackColor = Color.Gainsboro;
            LCTW.Location = new Point(327, 75);
            LCTW.Name = "LCTW";
            LCTW.Size = new Size(56, 17);
            LCTW.TabIndex = 13;
            LCTW.Text = "TestText";
            // 
            // LCTB
            // 
            LCTB.AutoSize = true;
            LCTB.BackColor = Color.Black;
            LCTB.Location = new Point(234, 75);
            LCTB.Name = "LCTB";
            LCTB.Size = new Size(56, 17);
            LCTB.TabIndex = 12;
            LCTB.Text = "TestText";
            // 
            // Ain
            // 
            Ain.Location = new Point(141, 3);
            Ain.Name = "Ain";
            Ain.Size = new Size(100, 23);
            Ain.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(125, 9);
            label8.Name = "label8";
            label8.Size = new Size(16, 17);
            label8.TabIndex = 10;
            label8.Text = "A";
            // 
            // Bt_Cc
            // 
            Bt_Cc.Location = new Point(141, 32);
            Bt_Cc.Name = "Bt_Cc";
            Bt_Cc.Size = new Size(75, 23);
            Bt_Cc.TabIndex = 9;
            Bt_Cc.Text = "Choose";
            Bt_Cc.UseVisualStyleBackColor = true;
            Bt_Cc.Click += Bt_Cc_Click;
            // 
            // LCT
            // 
            LCT.AutoSize = true;
            LCT.BackColor = Color.Transparent;
            LCT.Location = new Point(141, 75);
            LCT.Name = "LCT";
            LCT.Size = new Size(56, 17);
            LCT.TabIndex = 8;
            LCT.Text = "TestText";
            // 
            // Bt_Sc
            // 
            Bt_Sc.Location = new Point(234, 35);
            Bt_Sc.Name = "Bt_Sc";
            Bt_Sc.Size = new Size(75, 23);
            Bt_Sc.TabIndex = 7;
            Bt_Sc.Text = "Select";
            Bt_Sc.UseVisualStyleBackColor = true;
            Bt_Sc.Click += Bt_Sc_Click;
            // 
            // Bin
            // 
            Bin.Location = new Point(531, 6);
            Bin.Name = "Bin";
            Bin.Size = new Size(100, 23);
            Bin.TabIndex = 6;
            // 
            // Gin
            // 
            Gin.Location = new Point(389, 6);
            Gin.Name = "Gin";
            Gin.Size = new Size(100, 23);
            Gin.TabIndex = 5;
            // 
            // Rin
            // 
            Rin.Location = new Point(260, 6);
            Rin.Name = "Rin";
            Rin.Size = new Size(100, 23);
            Rin.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(509, 12);
            label7.Name = "label7";
            label7.Size = new Size(16, 17);
            label7.TabIndex = 3;
            label7.Text = "B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 12);
            label6.Name = "label6";
            label6.Size = new Size(17, 17);
            label6.TabIndex = 2;
            label6.Text = "G";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 9);
            label5.Name = "label5";
            label5.Size = new Size(16, 17);
            label5.TabIndex = 1;
            label5.Text = "R";
            label5.Click += label5_Click;
            // 
            // Lb
            // 
            Lb.FormattingEnabled = true;
            Lb.ItemHeight = 17;
            Lb.Items.AddRange(new object[] { "Fill", "Stroke" });
            Lb.Location = new Point(3, 3);
            Lb.Name = "Lb";
            Lb.Size = new Size(120, 89);
            Lb.Sorted = true;
            Lb.TabIndex = 0;
            Lb.SelectedIndexChanged += Lb_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "XlGui";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ProgressBar PB;
        private Label LPB;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox CBC;
        private Button Bt_S;
        private Button Bt_F;
        private TextBox Iin;
        private TextBox Cin;
        private TextBox Win;
        private TextBox Fin;
        private ListView LV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TabPage tabPage2;
        private Label label2;
        private TextBox FNin;
        private Label LG;
        private Button Bt_G;
        private TextBox STin;
        private Label label4;
        private Label label3;
        private Label LL;
        private Label label1;
        private Button Bt_L;
        private Button Bt_C;
        private TextBox Cfin;
        private Button Bt_R;
        private TabPage tabPage3;
        private Label label5;
        private ListBox Lb;
        private Label LCT;
        private Button Bt_Sc;
        private TextBox Bin;
        private TextBox Gin;
        private TextBox Rin;
        private Label label7;
        private Label label6;
        private Button Bt_Cc;
        private TextBox Ain;
        private Label label8;
        private Label LCTW;
        private Label LCTB;
        private CheckedListBox CBL;
        private ComboBox comboBox2;
        private ComboBox COB;
    }
}