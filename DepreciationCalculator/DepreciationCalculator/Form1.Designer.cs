namespace DepreciationCalculator
{
    partial class Form1
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
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblSalvage = new System.Windows.Forms.Label();
            this.txtLife = new System.Windows.Forms.Label();
            this.txtInitialCost = new System.Windows.Forms.TextBox();
            this.txtSalvageValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_StraightLine = new System.Windows.Forms.RadioButton();
            this.rd_SumofYears = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_UpdateSchedule = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbLife = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitial.Location = new System.Drawing.Point(53, 95);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(93, 24);
            this.lblInitial.TabIndex = 0;
            this.lblInitial.Text = "Initial Cost";
            // 
            // lblSalvage
            // 
            this.lblSalvage.AutoSize = true;
            this.lblSalvage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalvage.Location = new System.Drawing.Point(53, 140);
            this.lblSalvage.Name = "lblSalvage";
            this.lblSalvage.Size = new System.Drawing.Size(131, 24);
            this.lblSalvage.TabIndex = 1;
            this.lblSalvage.Text = "Salvage Value";
            // 
            // txtLife
            // 
            this.txtLife.AutoSize = true;
            this.txtLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLife.Location = new System.Drawing.Point(53, 185);
            this.txtLife.Name = "txtLife";
            this.txtLife.Size = new System.Drawing.Size(39, 24);
            this.txtLife.TabIndex = 2;
            this.txtLife.Text = "Life";
            // 
            // txtInitialCost
            // 
            this.txtInitialCost.Location = new System.Drawing.Point(210, 99);
            this.txtInitialCost.Name = "txtInitialCost";
            this.txtInitialCost.Size = new System.Drawing.Size(154, 20);
            this.txtInitialCost.TabIndex = 3;
            // 
            // txtSalvageValue
            // 
            this.txtSalvageValue.Location = new System.Drawing.Point(210, 144);
            this.txtSalvageValue.Name = "txtSalvageValue";
            this.txtSalvageValue.Size = new System.Drawing.Size(154, 20);
            this.txtSalvageValue.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_SumofYears);
            this.groupBox1.Controls.Add(this.rd_StraightLine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(536, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depreciation";
            // 
            // rd_StraightLine
            // 
            this.rd_StraightLine.AutoSize = true;
            this.rd_StraightLine.Location = new System.Drawing.Point(15, 34);
            this.rd_StraightLine.Name = "rd_StraightLine";
            this.rd_StraightLine.Size = new System.Drawing.Size(117, 24);
            this.rd_StraightLine.TabIndex = 0;
            this.rd_StraightLine.TabStop = true;
            this.rd_StraightLine.Text = "Straight Line";
            this.rd_StraightLine.UseVisualStyleBackColor = true;
            // 
            // rd_SumofYears
            // 
            this.rd_SumofYears.AutoSize = true;
            this.rd_SumofYears.Location = new System.Drawing.Point(15, 73);
            this.rd_SumofYears.Name = "rd_SumofYears";
            this.rd_SumofYears.Size = new System.Drawing.Size(124, 24);
            this.rd_SumofYears.TabIndex = 1;
            this.rd_SumofYears.TabStop = true;
            this.rd_SumofYears.Text = "Sum of Years";
            this.rd_SumofYears.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Depreciation Schedule";
            // 
            // btn_UpdateSchedule
            // 
            this.btn_UpdateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateSchedule.Location = new System.Drawing.Point(536, 233);
            this.btn_UpdateSchedule.Name = "btn_UpdateSchedule";
            this.btn_UpdateSchedule.Size = new System.Drawing.Size(132, 29);
            this.btn_UpdateSchedule.TabIndex = 8;
            this.btn_UpdateSchedule.Text = "Update Schedule";
            this.btn_UpdateSchedule.UseVisualStyleBackColor = true;
            this.btn_UpdateSchedule.Click += new System.EventHandler(this.btn_UpdateSchedule_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(536, 278);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(132, 28);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 272);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(486, 144);
            this.listBox1.TabIndex = 10;
            // 
            // cbLife
            // 
            this.cbLife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLife.FormattingEnabled = true;
            this.cbLife.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbLife.Location = new System.Drawing.Point(211, 192);
            this.cbLife.Name = "cbLife";
            this.cbLife.Size = new System.Drawing.Size(153, 21);
            this.cbLife.TabIndex = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbLife);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_UpdateSchedule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSalvageValue);
            this.Controls.Add(this.txtInitialCost);
            this.Controls.Add(this.txtLife);
            this.Controls.Add(this.lblSalvage);
            this.Controls.Add(this.lblInitial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblSalvage;
        private System.Windows.Forms.Label txtLife;
        private System.Windows.Forms.TextBox txtInitialCost;
        private System.Windows.Forms.TextBox txtSalvageValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_SumofYears;
        private System.Windows.Forms.RadioButton rd_StraightLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_UpdateSchedule;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbLife;
    }
}

