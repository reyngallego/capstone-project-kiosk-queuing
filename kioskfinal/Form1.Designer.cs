namespace kioskfinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nametxt = new System.Windows.Forms.TextBox();
            this.purposetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.departmentcbx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(390, 127);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 0;
            // 
            // purposetxt
            // 
            this.purposetxt.Location = new System.Drawing.Point(390, 210);
            this.purposetxt.Name = "purposetxt";
            this.purposetxt.Size = new System.Drawing.Size(100, 20);
            this.purposetxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "purpose:";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(308, 267);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // departmentcbx
            // 
            this.departmentcbx.FormattingEnabled = true;
            this.departmentcbx.Items.AddRange(new object[] {
            "studentaffairs",
            "department",
            "registrar",
            "director"});
            this.departmentcbx.Location = new System.Drawing.Point(390, 167);
            this.departmentcbx.Name = "departmentcbx";
            this.departmentcbx.Size = new System.Drawing.Size(106, 21);
            this.departmentcbx.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "fill up this form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(799, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departmentcbx);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purposetxt);
            this.Controls.Add(this.nametxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox purposetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.ComboBox departmentcbx;
        private System.Windows.Forms.Label label4;
    }
}

