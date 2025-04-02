namespace bmiTest
{
    partial class MainApp
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxCM = new System.Windows.Forms.TextBox();
            this.textboxKG = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.labelbmiResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbarBmi = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelgradeResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textboxCMresult = new System.Windows.Forms.TextBox();
            this.textboxKGresult = new System.Windows.Forms.TextBox();
            this.textboxBMIresult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBmi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxCM
            // 
            this.textboxCM.Location = new System.Drawing.Point(80, 38);
            this.textboxCM.Name = "textboxCM";
            this.textboxCM.Size = new System.Drawing.Size(37, 21);
            this.textboxCM.TabIndex = 0;
            this.textboxCM.TextChanged += new System.EventHandler(this.textboxCM_TextChanged);
            // 
            // textboxKG
            // 
            this.textboxKG.Location = new System.Drawing.Point(200, 39);
            this.textboxKG.Name = "textboxKG";
            this.textboxKG.Size = new System.Drawing.Size(37, 21);
            this.textboxKG.TabIndex = 1;
            this.textboxKG.TextChanged += new System.EventHandler(this.textboxKG_TextChanged);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(272, 21);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(62, 54);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Run";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // labelbmiResult
            // 
            this.labelbmiResult.AutoSize = true;
            this.labelbmiResult.Location = new System.Drawing.Point(7, 316);
            this.labelbmiResult.Name = "labelbmiResult";
            this.labelbmiResult.Size = new System.Drawing.Size(27, 12);
            this.labelbmiResult.TabIndex = 3;
            this.labelbmiResult.Text = "BMI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(117, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 11);
            this.label3.TabIndex = 6;
            this.label3.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(237, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 11);
            this.label4.TabIndex = 7;
            this.label4.Text = "kg";
            // 
            // tbarBmi
            // 
            this.tbarBmi.Enabled = false;
            this.tbarBmi.Location = new System.Drawing.Point(177, 21);
            this.tbarBmi.Maximum = 28;
            this.tbarBmi.Minimum = 15;
            this.tbarBmi.Name = "tbarBmi";
            this.tbarBmi.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarBmi.Size = new System.Drawing.Size(45, 265);
            this.tbarBmi.TabIndex = 8;
            this.tbarBmi.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarBmi.Value = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "18.5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "23";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "25";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(203, 207);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(91, 67);
            this.label8.TabIndex = 12;
            this.label8.Text = "Underweight";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Lime;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(203, 128);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(91, 79);
            this.label9.TabIndex = 13;
            this.label9.Text = "Normal weight";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(203, 69);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(91, 59);
            this.label10.TabIndex = 14;
            this.label10.Text = "Overweight";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(202, 31);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(91, 38);
            this.label11.TabIndex = 15;
            this.label11.Text = "Obese";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelgradeResult);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelbmiResult);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbarBmi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(25, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 367);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // labelgradeResult
            // 
            this.labelgradeResult.AutoSize = true;
            this.labelgradeResult.Location = new System.Drawing.Point(165, 316);
            this.labelgradeResult.Name = "labelgradeResult";
            this.labelgradeResult.Size = new System.Drawing.Size(39, 12);
            this.labelgradeResult.TabIndex = 18;
            this.labelgradeResult.Text = "Grade";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textboxCMresult, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textboxKGresult, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textboxBMIresult, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(56, 199);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(4, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 31);
            this.label12.TabIndex = 18;
            this.label12.Text = "Height";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(4, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 31);
            this.label13.TabIndex = 20;
            this.label13.Text = "Weight";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(4, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 31);
            this.label14.TabIndex = 20;
            this.label14.Text = "BMI";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxCMresult
            // 
            this.textboxCMresult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxCMresult.Location = new System.Drawing.Point(4, 38);
            this.textboxCMresult.Name = "textboxCMresult";
            this.textboxCMresult.Size = new System.Drawing.Size(48, 21);
            this.textboxCMresult.TabIndex = 19;
            this.textboxCMresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxKGresult
            // 
            this.textboxKGresult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxKGresult.Location = new System.Drawing.Point(4, 102);
            this.textboxKGresult.Name = "textboxKGresult";
            this.textboxKGresult.Size = new System.Drawing.Size(48, 21);
            this.textboxKGresult.TabIndex = 19;
            this.textboxKGresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxBMIresult
            // 
            this.textboxBMIresult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxBMIresult.Location = new System.Drawing.Point(4, 169);
            this.textboxBMIresult.Name = "textboxBMIresult";
            this.textboxBMIresult.Size = new System.Drawing.Size(48, 21);
            this.textboxBMIresult.TabIndex = 19;
            this.textboxBMIresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(25, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 63);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 480);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxKG);
            this.Controls.Add(this.textboxCM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainApp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbarBmi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxCM;
        private System.Windows.Forms.TextBox textboxKG;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label labelbmiResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbarBmi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textboxCMresult;
        private System.Windows.Forms.TextBox textboxKGresult;
        private System.Windows.Forms.TextBox textboxBMIresult;
        private System.Windows.Forms.Label labelgradeResult;
    }
}

