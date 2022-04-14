namespace AutoSave.ehdgns
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Txt_Hour = new System.Windows.Forms.TextBox();
            this.Txt_Min = new System.Windows.Forms.TextBox();
            this.Txt_Sec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(23, 125);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 42);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Start_Button_Event);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(2, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 3;
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Stop.Location = new System.Drawing.Point(113, 125);
            this.Btn_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(75, 42);
            this.Btn_Stop.TabIndex = 4;
            this.Btn_Stop.Text = "Stop";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Txt_Hour
            // 
            this.Txt_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_Hour.Location = new System.Drawing.Point(77, 65);
            this.Txt_Hour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Hour.Name = "Txt_Hour";
            this.Txt_Hour.Size = new System.Drawing.Size(48, 23);
            this.Txt_Hour.TabIndex = 5;
            // 
            // Txt_Min
            // 
            this.Txt_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_Min.Location = new System.Drawing.Point(153, 65);
            this.Txt_Min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Min.Name = "Txt_Min";
            this.Txt_Min.Size = new System.Drawing.Size(48, 23);
            this.Txt_Min.TabIndex = 6;
            // 
            // Txt_Sec
            // 
            this.Txt_Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Txt_Sec.Location = new System.Drawing.Point(229, 65);
            this.Txt_Sec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Sec.Name = "Txt_Sec";
            this.Txt_Sec.Size = new System.Drawing.Size(46, 23);
            this.Txt_Sec.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Interval : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(131, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = ": ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(207, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = ": ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Btn_Start);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Txt_Sec);
            this.panel2.Controls.Add(this.Btn_Stop);
            this.panel2.Controls.Add(this.Txt_Min);
            this.panel2.Controls.Add(this.Txt_Hour);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 220);
            this.panel2.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Size = new System.Drawing.Size(363, 220);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.TextBox Txt_Hour;
        private System.Windows.Forms.TextBox Txt_Min;
        private System.Windows.Forms.TextBox Txt_Sec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}