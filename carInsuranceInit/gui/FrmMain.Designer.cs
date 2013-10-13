namespace carInsuranceInit.gui
{
    partial class FrmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ลักษณะการใช้รถ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ขนาดเครื่องยนต์");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("อายุผู้ขับขี่");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("อายุรถ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ทุนเอาประกัน");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("กลุ่มรถ");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("บาดเจ็บ ต่อคน");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("บาดเจ็บ ต่อครั้ง");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("บาดเจ็บ ทรัพย์สิน");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ร.ย. 01");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("ร.ย. 02");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("รถเก่ง", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("รถกระบะ");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("รถตู้");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("อายุผู้ขับขี่");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("กำหนดค่าโปรแกรม", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.tv1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tv1
            // 
            this.tv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tv1.Location = new System.Drawing.Point(12, 12);
            this.tv1.Name = "tv1";
            treeNode1.Name = "nSedanUseCar";
            treeNode1.Text = "ลักษณะการใช้รถ";
            treeNode2.Name = "nSedanEngineCC";
            treeNode2.Text = "ขนาดเครื่องยนต์";
            treeNode3.Name = "nSedanAgeDriver";
            treeNode3.Text = "อายุผู้ขับขี่";
            treeNode4.Name = "nSedanAgeCar";
            treeNode4.Text = "อายุรถ";
            treeNode5.Name = "nSedanCapitalInsur";
            treeNode5.Text = "ทุนเอาประกัน";
            treeNode6.Name = "nSedanCatCar";
            treeNode6.Text = "กลุ่มรถ";
            treeNode7.Name = "nSedanInjuryPerson";
            treeNode7.Text = "บาดเจ็บ ต่อคน";
            treeNode8.Name = "nSedanInjuryTime";
            treeNode8.Text = "บาดเจ็บ ต่อครั้ง";
            treeNode9.Name = "nSedanInjuryAsset";
            treeNode9.Text = "บาดเจ็บ ทรัพย์สิน";
            treeNode10.Name = "nSedanRY01";
            treeNode10.Text = "ร.ย. 01";
            treeNode11.Name = "nSedanRY02";
            treeNode11.Text = "ร.ย. 02";
            treeNode12.Name = "nSedan";
            treeNode12.Text = "รถเก่ง";
            treeNode13.Name = "nPickup";
            treeNode13.Text = "รถกระบะ";
            treeNode14.Name = "nVan";
            treeNode14.Text = "รถตู้";
            treeNode15.Name = "Node5";
            treeNode15.Text = "อายุผู้ขับขี่";
            treeNode16.Name = "nInitConfig";
            treeNode16.Text = "กำหนดค่าโปรแกรม";
            this.tv1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode16});
            this.tv1.Size = new System.Drawing.Size(601, 441);
            this.tv1.TabIndex = 0;
            this.tv1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv1_NodeMouseDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 465);
            this.Controls.Add(this.tv1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv1;
    }
}