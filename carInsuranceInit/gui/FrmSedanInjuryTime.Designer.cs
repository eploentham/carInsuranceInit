namespace carInsuranceInit.gui
{
    partial class FrmSedanInjuryTime
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(674, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvAdd
            // 
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Location = new System.Drawing.Point(21, 20);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.Size = new System.Drawing.Size(758, 395);
            this.dgvAdd.TabIndex = 4;
            this.dgvAdd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdd_CellDoubleClick);
            this.dgvAdd.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvAdd_EditingControlShowing);
            // 
            // FrmSedanInjuryTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 476);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAdd);
            this.Name = "FrmSedanInjuryTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSedanInjuryTime";
            this.Load += new System.EventHandler(this.FrmSedanInjuryTime_Load);
            this.Resize += new System.EventHandler(this.FrmSedanInjuryTime_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAdd;
    }
}