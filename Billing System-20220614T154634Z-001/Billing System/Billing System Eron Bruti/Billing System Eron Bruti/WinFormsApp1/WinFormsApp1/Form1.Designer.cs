namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.rtReceipt = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnumitem = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbl500 = new System.Windows.Forms.Label();
            this.lblUj = new System.Windows.Forms.Label();
            this.numUj = new System.Windows.Forms.NumericUpDown();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblDomate = new System.Windows.Forms.Label();
            this.numDomate = new System.Windows.Forms.NumericUpDown();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblQumesht = new System.Windows.Forms.Label();
            this.numQumesht = new System.Windows.Forms.NumericUpDown();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblOriz = new System.Windows.Forms.Label();
            this.numOriz = new System.Windows.Forms.NumericUpDown();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblBuk = new System.Windows.Forms.Label();
            this.numBuk = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDomate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQumesht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuk)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 788);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.btnExit1);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Controls.Add(this.btnPrint);
            this.panel5.Controls.Add(this.btnReceipt);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(10, 562);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1333, 118);
            this.panel5.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(1189, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Copyrights : Eron Bruti";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnExit1
            // 
            this.btnExit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit1.BackColor = System.Drawing.Color.Black;
            this.btnExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit1.ForeColor = System.Drawing.Color.White;
            this.btnExit1.Location = new System.Drawing.Point(1020, 15);
            this.btnExit1.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(147, 75);
            this.btnExit1.TabIndex = 5;
            this.btnExit1.Text = "Exit";
            this.btnExit1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit1.UseVisualStyleBackColor = false;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(1658, 40);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(326, 75);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(800, 15);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 75);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(565, 15);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(157, 75);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.Black;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Location = new System.Drawing.Point(316, 15);
            this.btnReceipt.Margin = new System.Windows.Forms.Padding(5);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(145, 75);
            this.btnReceipt.TabIndex = 1;
            this.btnReceipt.Text = "Fatura";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(114, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblReceipt);
            this.panel4.Controls.Add(this.rtReceipt);
            this.panel4.Location = new System.Drawing.Point(688, 168);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(655, 372);
            this.panel4.TabIndex = 1;
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReceipt.Location = new System.Drawing.Point(293, 13);
            this.lblReceipt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(68, 25);
            this.lblReceipt.TabIndex = 23;
            this.lblReceipt.Text = "Fatura";
            // 
            // rtReceipt
            // 
            this.rtReceipt.Location = new System.Drawing.Point(16, 45);
            this.rtReceipt.Margin = new System.Windows.Forms.Padding(5);
            this.rtReceipt.Name = "rtReceipt";
            this.rtReceipt.Size = new System.Drawing.Size(620, 307);
            this.rtReceipt.TabIndex = 0;
            this.rtReceipt.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblnumitem);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lbl500);
            this.panel3.Controls.Add(this.lblUj);
            this.panel3.Controls.Add(this.numUj);
            this.panel3.Controls.Add(this.lbl5);
            this.panel3.Controls.Add(this.lblDomate);
            this.panel3.Controls.Add(this.numDomate);
            this.panel3.Controls.Add(this.lbl4);
            this.panel3.Controls.Add(this.lblQumesht);
            this.panel3.Controls.Add(this.numQumesht);
            this.panel3.Controls.Add(this.lbl3);
            this.panel3.Controls.Add(this.lblOriz);
            this.panel3.Controls.Add(this.numOriz);
            this.panel3.Controls.Add(this.lbl2);
            this.panel3.Controls.Add(this.lblBuk);
            this.panel3.Controls.Add(this.numBuk);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(10, 168);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 372);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(445, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cmimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(267, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sasia";
            this.label3.Click += new System.EventHandler(this.label15_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Produktet";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblnumitem
            // 
            this.lblnumitem.AutoSize = true;
            this.lblnumitem.Location = new System.Drawing.Point(273, 274);
            this.lblnumitem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnumitem.Name = "lblnumitem";
            this.lblnumitem.Size = new System.Drawing.Size(61, 25);
            this.lblnumitem.TabIndex = 19;
            this.lblnumitem.Text = "0.00€";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(456, 276);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 25);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0.00€";
            this.lblTotal.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbl500
            // 
            this.lbl500.AutoSize = true;
            this.lbl500.Location = new System.Drawing.Point(114, 276);
            this.lbl500.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(131, 25);
            this.lbl500.TabIndex = 16;
            this.lbl500.Text = "Totali Fatures";
            // 
            // lblUj
            // 
            this.lblUj.AutoSize = true;
            this.lblUj.Location = new System.Drawing.Point(456, 235);
            this.lblUj.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUj.Name = "lblUj";
            this.lblUj.Size = new System.Drawing.Size(61, 25);
            this.lblUj.TabIndex = 15;
            this.lblUj.Text = "0.00€";
            // 
            // numUj
            // 
            this.numUj.Location = new System.Drawing.Point(244, 231);
            this.numUj.Margin = new System.Windows.Forms.Padding(5);
            this.numUj.Name = "numUj";
            this.numUj.Size = new System.Drawing.Size(129, 30);
            this.numUj.TabIndex = 14;
            this.numUj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUj.ValueChanged += new System.EventHandler(this.numUj_ValueChanged);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(114, 233);
            this.lbl5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(30, 25);
            this.lbl5.TabIndex = 13;
            this.lbl5.Text = "Uj";
            // 
            // lblDomate
            // 
            this.lblDomate.AutoSize = true;
            this.lblDomate.Location = new System.Drawing.Point(456, 194);
            this.lblDomate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDomate.Name = "lblDomate";
            this.lblDomate.Size = new System.Drawing.Size(61, 25);
            this.lblDomate.TabIndex = 12;
            this.lblDomate.Text = "0.00€";
            // 
            // numDomate
            // 
            this.numDomate.Location = new System.Drawing.Point(244, 190);
            this.numDomate.Margin = new System.Windows.Forms.Padding(5);
            this.numDomate.Name = "numDomate";
            this.numDomate.Size = new System.Drawing.Size(129, 30);
            this.numDomate.TabIndex = 11;
            this.numDomate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDomate.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(112, 192);
            this.lbl4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(80, 25);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "Domate";
            // 
            // lblQumesht
            // 
            this.lblQumesht.AutoSize = true;
            this.lblQumesht.Location = new System.Drawing.Point(456, 157);
            this.lblQumesht.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQumesht.Name = "lblQumesht";
            this.lblQumesht.Size = new System.Drawing.Size(61, 25);
            this.lblQumesht.TabIndex = 9;
            this.lblQumesht.Text = "0.00€";
            // 
            // numQumesht
            // 
            this.numQumesht.Location = new System.Drawing.Point(244, 150);
            this.numQumesht.Margin = new System.Windows.Forms.Padding(5);
            this.numQumesht.Name = "numQumesht";
            this.numQumesht.Size = new System.Drawing.Size(129, 30);
            this.numQumesht.TabIndex = 8;
            this.numQumesht.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQumesht.ValueChanged += new System.EventHandler(this.numQumesht_ValueChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(112, 152);
            this.lbl3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(92, 25);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Qumesht";
            // 
            // lblOriz
            // 
            this.lblOriz.AutoSize = true;
            this.lblOriz.Location = new System.Drawing.Point(456, 114);
            this.lblOriz.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOriz.Name = "lblOriz";
            this.lblOriz.Size = new System.Drawing.Size(61, 25);
            this.lblOriz.TabIndex = 6;
            this.lblOriz.Text = "0.00€";
            // 
            // numOriz
            // 
            this.numOriz.Location = new System.Drawing.Point(244, 110);
            this.numOriz.Margin = new System.Windows.Forms.Padding(5);
            this.numOriz.Name = "numOriz";
            this.numOriz.Size = new System.Drawing.Size(129, 30);
            this.numOriz.TabIndex = 5;
            this.numOriz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numOriz.ValueChanged += new System.EventHandler(this.numOriz_ValueChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(110, 112);
            this.lbl2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(48, 25);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Oriz";
            this.lbl2.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblBuk
            // 
            this.lblBuk.AutoSize = true;
            this.lblBuk.Location = new System.Drawing.Point(456, 72);
            this.lblBuk.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBuk.Name = "lblBuk";
            this.lblBuk.Size = new System.Drawing.Size(61, 25);
            this.lblBuk.TabIndex = 3;
            this.lblBuk.Text = "0.00€";
            this.lblBuk.Click += new System.EventHandler(this.label2_Click);
            // 
            // numBuk
            // 
            this.numBuk.Location = new System.Drawing.Point(244, 70);
            this.numBuk.Margin = new System.Windows.Forms.Padding(5);
            this.numBuk.Name = "numBuk";
            this.numBuk.Size = new System.Drawing.Size(129, 30);
            this.numBuk.TabIndex = 2;
            this.numBuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBuk.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buk";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(10, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 123);
            this.panel2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(424, 38);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(479, 42);
            this.label13.TabIndex = 2;
            this.label13.Text = "Billing System Management";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDomate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQumesht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuk)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Button button1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Button btnExit;
        private Button btnReset;
        private Button btnPrint;
        private Button btnReceipt;
        private RichTextBox rtReceipt;
        private Label lblBuk;
        private NumericUpDown numBuk;
        private Label label1;
        private Label lblnumitem;
        private Label lblTotal;
        private Label lbl500;
        private Label lblUj;
        private NumericUpDown numUj;
        private Label lbl5;
        private Label lblDomate;
        private NumericUpDown numDomate;
        private Label lbl4;
        private Label lblQumesht;
        private NumericUpDown numQumesht;
        private Label lbl3;
        private Label lblOriz;
        private NumericUpDown numOriz;
        private Label lbl2;
        private Label label13;
        private Label lblReceipt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnExit1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox textBox1;
    }
}