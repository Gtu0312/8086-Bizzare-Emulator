namespace _8086
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
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.XCHG_btn = new System.Windows.Forms.Button();
            this.MOV_btn = new System.Windows.Forms.Button();
            this.moVwind1 = new _8086.MOVwind();
            this.xchGwid1 = new _8086.XCHGwid();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.XCHG_btn);
            this.panel1.Controls.Add(this.MOV_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 406);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // XCHG_btn
            // 
            this.XCHG_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("XCHG_btn.BackgroundImage")));
            this.XCHG_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XCHG_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.XCHG_btn.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XCHG_btn.Location = new System.Drawing.Point(29, 219);
            this.XCHG_btn.Name = "XCHG_btn";
            this.XCHG_btn.Size = new System.Drawing.Size(56, 49);
            this.XCHG_btn.TabIndex = 0;
            this.XCHG_btn.Text = "XCHG";
            this.XCHG_btn.UseVisualStyleBackColor = true;
            this.XCHG_btn.Click += new System.EventHandler(this.XCHG_btn_Click);
            // 
            // MOV_btn
            // 
            this.MOV_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MOV_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MOV_btn.Font = new System.Drawing.Font("Jokerman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MOV_btn.Location = new System.Drawing.Point(29, 116);
            this.MOV_btn.Name = "MOV_btn";
            this.MOV_btn.Size = new System.Drawing.Size(56, 49);
            this.MOV_btn.TabIndex = 0;
            this.MOV_btn.Text = "MOV";
            this.MOV_btn.UseVisualStyleBackColor = true;
            this.MOV_btn.Click += new System.EventHandler(this.MOV_Click);
            // 
            // moVwind1
            // 
            this.moVwind1.BackColor = System.Drawing.Color.Linen;
            this.moVwind1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moVwind1.BackgroundImage")));
            this.moVwind1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.moVwind1.ForeColor = System.Drawing.Color.DeepPink;
            this.moVwind1.Location = new System.Drawing.Point(115, 0);
            this.moVwind1.Name = "moVwind1";
            this.moVwind1.Size = new System.Drawing.Size(556, 406);
            this.moVwind1.TabIndex = 15;
            // 
            // xchGwid1
            // 
            this.xchGwid1.BackColor = System.Drawing.Color.Transparent;
            this.xchGwid1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xchGwid1.BackgroundImage")));
            this.xchGwid1.ForeColor = System.Drawing.Color.MediumBlue;
            this.xchGwid1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.xchGwid1.Location = new System.Drawing.Point(115, -1);
            this.xchGwid1.Name = "xchGwid1";
            this.xchGwid1.Size = new System.Drawing.Size(556, 407);
            this.xchGwid1.TabIndex = 16;
            this.xchGwid1.Load += new System.EventHandler(this.xchGwid1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(673, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xchGwid1);
            this.Controls.Add(this.moVwind1);
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "8086 MOV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel1;
        private Button XCHG_btn;
        private Button MOV_btn;
        private MOVwind moVwind1;
        private XCHGwid xchGwid1;
    }
}