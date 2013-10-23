namespace carInsuranceInit.gui
{
    partial class FrmSedanModelAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnActive = new System.Windows.Forms.Button();
            this.chkUnActive = new System.Windows.Forms.RadioButton();
            this.chkActive = new System.Windows.Forms.RadioButton();
            this.txtSedanModelId = new System.Windows.Forms.TextBox();
            this.txtBrandId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkCatCar5 = new System.Windows.Forms.RadioButton();
            this.chkCatCar4 = new System.Windows.Forms.RadioButton();
            this.chkCatCar3 = new System.Windows.Forms.RadioButton();
            this.chkCatCar2 = new System.Windows.Forms.RadioButton();
            this.chkCatCar1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMax2000cc = new System.Windows.Forms.RadioButton();
            this.chkMin2000cc = new System.Windows.Forms.RadioButton();
            this.txtSedanPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSedanPriceMax = new System.Windows.Forms.TextBox();
            this.txtSedanPriceMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEngineCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.txtSedanModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnActive);
            this.groupBox1.Controls.Add(this.chkUnActive);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtSedanModelId);
            this.groupBox1.Controls.Add(this.txtBrandId);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtSedanPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSedanPriceMax);
            this.groupBox1.Controls.Add(this.txtSedanPriceMin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEngineCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboBrand);
            this.groupBox1.Controls.Add(this.txtSedanModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 326);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnUnActive
            // 
            this.btnUnActive.Location = new System.Drawing.Point(506, 224);
            this.btnUnActive.Name = "btnUnActive";
            this.btnUnActive.Size = new System.Drawing.Size(103, 23);
            this.btnUnActive.TabIndex = 33;
            this.btnUnActive.Text = "ยกเลิกการใช้งาน";
            this.btnUnActive.UseVisualStyleBackColor = true;
            this.btnUnActive.Click += new System.EventHandler(this.btnUnActive_Click);
            // 
            // chkUnActive
            // 
            this.chkUnActive.AutoSize = true;
            this.chkUnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkUnActive.Location = new System.Drawing.Point(394, 224);
            this.chkUnActive.Name = "chkUnActive";
            this.chkUnActive.Size = new System.Drawing.Size(106, 24);
            this.chkUnActive.TabIndex = 32;
            this.chkUnActive.TabStop = true;
            this.chkUnActive.Text = "ยกเลิกใช้งาน";
            this.chkUnActive.UseVisualStyleBackColor = true;
            this.chkUnActive.Click += new System.EventHandler(this.chkUnActive_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkActive.Location = new System.Drawing.Point(322, 224);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(66, 24);
            this.chkActive.TabIndex = 31;
            this.chkActive.TabStop = true;
            this.chkActive.Text = "ใช้งาน";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.Click += new System.EventHandler(this.chkActive_Click);
            // 
            // txtSedanModelId
            // 
            this.txtSedanModelId.Location = new System.Drawing.Point(442, 52);
            this.txtSedanModelId.Name = "txtSedanModelId";
            this.txtSedanModelId.Size = new System.Drawing.Size(100, 20);
            this.txtSedanModelId.TabIndex = 30;
            // 
            // txtBrandId
            // 
            this.txtBrandId.Location = new System.Drawing.Point(442, 19);
            this.txtBrandId.Name = "txtBrandId";
            this.txtBrandId.Size = new System.Drawing.Size(100, 20);
            this.txtBrandId.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(131, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 82);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "กลุ่มรถ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkCatCar5);
            this.panel2.Controls.Add(this.chkCatCar4);
            this.panel2.Controls.Add(this.chkCatCar3);
            this.panel2.Controls.Add(this.chkCatCar2);
            this.panel2.Controls.Add(this.chkCatCar1);
            this.panel2.Location = new System.Drawing.Point(8, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 43);
            this.panel2.TabIndex = 27;
            // 
            // chkCatCar5
            // 
            this.chkCatCar5.AutoSize = true;
            this.chkCatCar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkCatCar5.Location = new System.Drawing.Point(399, 15);
            this.chkCatCar5.Name = "chkCatCar5";
            this.chkCatCar5.Size = new System.Drawing.Size(36, 24);
            this.chkCatCar5.TabIndex = 30;
            this.chkCatCar5.TabStop = true;
            this.chkCatCar5.Text = "5";
            this.chkCatCar5.UseVisualStyleBackColor = true;
            // 
            // chkCatCar4
            // 
            this.chkCatCar4.AutoSize = true;
            this.chkCatCar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkCatCar4.Location = new System.Drawing.Point(303, 15);
            this.chkCatCar4.Name = "chkCatCar4";
            this.chkCatCar4.Size = new System.Drawing.Size(36, 24);
            this.chkCatCar4.TabIndex = 29;
            this.chkCatCar4.TabStop = true;
            this.chkCatCar4.Text = "4";
            this.chkCatCar4.UseVisualStyleBackColor = true;
            // 
            // chkCatCar3
            // 
            this.chkCatCar3.AutoSize = true;
            this.chkCatCar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkCatCar3.Location = new System.Drawing.Point(207, 15);
            this.chkCatCar3.Name = "chkCatCar3";
            this.chkCatCar3.Size = new System.Drawing.Size(36, 24);
            this.chkCatCar3.TabIndex = 28;
            this.chkCatCar3.TabStop = true;
            this.chkCatCar3.Text = "3";
            this.chkCatCar3.UseVisualStyleBackColor = true;
            // 
            // chkCatCar2
            // 
            this.chkCatCar2.AutoSize = true;
            this.chkCatCar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkCatCar2.Location = new System.Drawing.Point(111, 15);
            this.chkCatCar2.Name = "chkCatCar2";
            this.chkCatCar2.Size = new System.Drawing.Size(36, 24);
            this.chkCatCar2.TabIndex = 27;
            this.chkCatCar2.TabStop = true;
            this.chkCatCar2.Text = "2";
            this.chkCatCar2.UseVisualStyleBackColor = true;
            // 
            // chkCatCar1
            // 
            this.chkCatCar1.AutoSize = true;
            this.chkCatCar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkCatCar1.Location = new System.Drawing.Point(15, 15);
            this.chkCatCar1.Name = "chkCatCar1";
            this.chkCatCar1.Size = new System.Drawing.Size(36, 24);
            this.chkCatCar1.TabIndex = 26;
            this.chkCatCar1.TabStop = true;
            this.chkCatCar1.Text = "1";
            this.chkCatCar1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkMax2000cc);
            this.panel1.Controls.Add(this.chkMin2000cc);
            this.panel1.Location = new System.Drawing.Point(238, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 39);
            this.panel1.TabIndex = 25;
            // 
            // chkMax2000cc
            // 
            this.chkMax2000cc.AutoSize = true;
            this.chkMax2000cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkMax2000cc.Location = new System.Drawing.Point(173, 8);
            this.chkMax2000cc.Name = "chkMax2000cc";
            this.chkMax2000cc.Size = new System.Drawing.Size(107, 24);
            this.chkMax2000cc.TabIndex = 1;
            this.chkMax2000cc.TabStop = true;
            this.chkMax2000cc.Text = "เกิน 2000cc";
            this.chkMax2000cc.UseVisualStyleBackColor = true;
            // 
            // chkMin2000cc
            // 
            this.chkMin2000cc.AutoSize = true;
            this.chkMin2000cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkMin2000cc.Location = new System.Drawing.Point(14, 8);
            this.chkMin2000cc.Name = "chkMin2000cc";
            this.chkMin2000cc.Size = new System.Drawing.Size(124, 24);
            this.chkMin2000cc.TabIndex = 0;
            this.chkMin2000cc.TabStop = true;
            this.chkMin2000cc.Text = "ไม่เกิน 2000cc";
            this.chkMin2000cc.UseVisualStyleBackColor = true;
            // 
            // txtSedanPrice
            // 
            this.txtSedanPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSedanPrice.Location = new System.Drawing.Point(131, 285);
            this.txtSedanPrice.Name = "txtSedanPrice";
            this.txtSedanPrice.Size = new System.Drawing.Size(177, 26);
            this.txtSedanPrice.TabIndex = 23;
            this.txtSedanPrice.Enter += new System.EventHandler(this.txtSedanPrice_Enter);
            this.txtSedanPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSedanPrice_KeyPress);
            this.txtSedanPrice.Leave += new System.EventHandler(this.txtSedanPrice_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(8, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "ราคากลาง :";
            // 
            // txtSedanPriceMax
            // 
            this.txtSedanPriceMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSedanPriceMax.Location = new System.Drawing.Point(131, 253);
            this.txtSedanPriceMax.Name = "txtSedanPriceMax";
            this.txtSedanPriceMax.Size = new System.Drawing.Size(177, 26);
            this.txtSedanPriceMax.TabIndex = 21;
            this.txtSedanPriceMax.Enter += new System.EventHandler(this.txtSedanPriceMax_Enter);
            this.txtSedanPriceMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSedanPriceMax_KeyPress);
            this.txtSedanPriceMax.Leave += new System.EventHandler(this.txtSedanPriceMax_Leave);
            // 
            // txtSedanPriceMin
            // 
            this.txtSedanPriceMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSedanPriceMin.Location = new System.Drawing.Point(132, 221);
            this.txtSedanPriceMin.Name = "txtSedanPriceMin";
            this.txtSedanPriceMin.Size = new System.Drawing.Size(177, 26);
            this.txtSedanPriceMin.TabIndex = 20;
            this.txtSedanPriceMin.Enter += new System.EventHandler(this.txtSedanPriceMin_Enter);
            this.txtSedanPriceMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSedanPriceMin_KeyPress);
            this.txtSedanPriceMin.Leave += new System.EventHandler(this.txtSedanPriceMin_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(8, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ราคาขั้นสูง :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(7, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "ราคาขั้นต่ำ :";
            // 
            // txtEngineCC
            // 
            this.txtEngineCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtEngineCC.Location = new System.Drawing.Point(132, 97);
            this.txtEngineCC.Name = "txtEngineCC";
            this.txtEngineCC.Size = new System.Drawing.Size(100, 26);
            this.txtEngineCC.TabIndex = 17;
            this.txtEngineCC.Enter += new System.EventHandler(this.txtEngineCC_Enter);
            this.txtEngineCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEngineCC_KeyPress);
            this.txtEngineCC.Leave += new System.EventHandler(this.txtEngineCC_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "ขนาดเครื่องยนต์ :";
            // 
            // cboBrand
            // 
            this.cboBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(132, 19);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(205, 28);
            this.cboBrand.TabIndex = 14;
            this.cboBrand.SelectedIndexChanged += new System.EventHandler(this.cboBrand_SelectedIndexChanged);
            this.cboBrand.Click += new System.EventHandler(this.cboBrand_Click);
            this.cboBrand.Enter += new System.EventHandler(this.cboBrand_Enter);
            this.cboBrand.Leave += new System.EventHandler(this.cboBrand_Leave);
            // 
            // txtSedanModel
            // 
            this.txtSedanModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSedanModel.Location = new System.Drawing.Point(132, 52);
            this.txtSedanModel.Name = "txtSedanModel";
            this.txtSedanModel.Size = new System.Drawing.Size(205, 26);
            this.txtSedanModel.TabIndex = 13;
            this.txtSedanModel.Enter += new System.EventHandler(this.txtSedanModel_Enter);
            this.txtSedanModel.Leave += new System.EventHandler(this.txtSedanModel_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ชื่อรุ่น :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ยี่ห้อรถ :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(506, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 41);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmSedanModelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 354);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSedanModelAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSedanModelAdd";
            this.Load += new System.EventHandler(this.FrmSedanModelAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton chkMax2000cc;
        private System.Windows.Forms.RadioButton chkMin2000cc;
        private System.Windows.Forms.TextBox txtSedanPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSedanPriceMax;
        private System.Windows.Forms.TextBox txtSedanPriceMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEngineCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.TextBox txtSedanModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton chkCatCar1;
        private System.Windows.Forms.RadioButton chkCatCar5;
        private System.Windows.Forms.RadioButton chkCatCar4;
        private System.Windows.Forms.RadioButton chkCatCar3;
        private System.Windows.Forms.RadioButton chkCatCar2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSedanModelId;
        private System.Windows.Forms.TextBox txtBrandId;
        private System.Windows.Forms.Button btnUnActive;
        private System.Windows.Forms.RadioButton chkUnActive;
        private System.Windows.Forms.RadioButton chkActive;
    }
}