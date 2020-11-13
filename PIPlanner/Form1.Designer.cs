namespace PIPlanner
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpPlanets = new System.Windows.Forms.TabPage();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.rtbPlanetDesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAvailableResources = new System.Windows.Forms.ListBox();
            this.cbPlanetType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpResources = new System.Windows.Forms.TabPage();
            this.lbResourceUsed = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbResourceDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbResourceVolume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbResourceType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbProductVolume = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbProductTier = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rtbProductDesc = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbReqComponents = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbProductUsed = new System.Windows.Forms.ListBox();
            this.tcMain.SuspendLayout();
            this.tpPlanets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tpResources.SuspendLayout();
            this.tpProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpPlanets);
            this.tcMain.Controls.Add(this.tpResources);
            this.tcMain.Controls.Add(this.tpProducts);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(340, 448);
            this.tcMain.TabIndex = 0;
            // 
            // tpPlanets
            // 
            this.tpPlanets.BackColor = System.Drawing.SystemColors.Control;
            this.tpPlanets.Controls.Add(this.pbImage);
            this.tpPlanets.Controls.Add(this.rtbPlanetDesc);
            this.tpPlanets.Controls.Add(this.label3);
            this.tpPlanets.Controls.Add(this.label2);
            this.tpPlanets.Controls.Add(this.lbAvailableResources);
            this.tpPlanets.Controls.Add(this.cbPlanetType);
            this.tpPlanets.Controls.Add(this.label1);
            this.tpPlanets.Location = new System.Drawing.Point(4, 22);
            this.tpPlanets.Name = "tpPlanets";
            this.tpPlanets.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlanets.Size = new System.Drawing.Size(332, 422);
            this.tpPlanets.TabIndex = 0;
            this.tpPlanets.Text = "Planets";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(202, 6);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(122, 122);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // rtbPlanetDesc
            // 
            this.rtbPlanetDesc.BackColor = System.Drawing.Color.White;
            this.rtbPlanetDesc.Location = new System.Drawing.Point(8, 147);
            this.rtbPlanetDesc.Name = "rtbPlanetDesc";
            this.rtbPlanetDesc.ReadOnly = true;
            this.rtbPlanetDesc.Size = new System.Drawing.Size(316, 267);
            this.rtbPlanetDesc.TabIndex = 5;
            this.rtbPlanetDesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resources Available:";
            // 
            // lbAvailableResources
            // 
            this.lbAvailableResources.FormattingEnabled = true;
            this.lbAvailableResources.Location = new System.Drawing.Point(11, 59);
            this.lbAvailableResources.Name = "lbAvailableResources";
            this.lbAvailableResources.Size = new System.Drawing.Size(185, 69);
            this.lbAvailableResources.TabIndex = 2;
            this.lbAvailableResources.DoubleClick += new System.EventHandler(this.lbAvailableResources_DoubleClick);
            // 
            // cbPlanetType
            // 
            this.cbPlanetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlanetType.FormattingEnabled = true;
            this.cbPlanetType.Location = new System.Drawing.Point(11, 19);
            this.cbPlanetType.Name = "cbPlanetType";
            this.cbPlanetType.Size = new System.Drawing.Size(185, 21);
            this.cbPlanetType.TabIndex = 1;
            this.cbPlanetType.SelectedIndexChanged += new System.EventHandler(this.cbPlanetType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planet Type:";
            // 
            // tpResources
            // 
            this.tpResources.BackColor = System.Drawing.SystemColors.Control;
            this.tpResources.Controls.Add(this.lbResourceUsed);
            this.tpResources.Controls.Add(this.label7);
            this.tpResources.Controls.Add(this.rtbResourceDesc);
            this.tpResources.Controls.Add(this.label6);
            this.tpResources.Controls.Add(this.tbResourceVolume);
            this.tpResources.Controls.Add(this.label5);
            this.tpResources.Controls.Add(this.cbResourceType);
            this.tpResources.Controls.Add(this.label4);
            this.tpResources.Location = new System.Drawing.Point(4, 22);
            this.tpResources.Name = "tpResources";
            this.tpResources.Padding = new System.Windows.Forms.Padding(3);
            this.tpResources.Size = new System.Drawing.Size(332, 422);
            this.tpResources.TabIndex = 1;
            this.tpResources.Text = "Resources";
            // 
            // lbResourceUsed
            // 
            this.lbResourceUsed.FormattingEnabled = true;
            this.lbResourceUsed.Location = new System.Drawing.Point(11, 174);
            this.lbResourceUsed.Name = "lbResourceUsed";
            this.lbResourceUsed.Size = new System.Drawing.Size(313, 238);
            this.lbResourceUsed.TabIndex = 7;
            this.lbResourceUsed.DoubleClick += new System.EventHandler(this.lbResourceUsed_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Used to create:";
            // 
            // rtbResourceDesc
            // 
            this.rtbResourceDesc.BackColor = System.Drawing.Color.White;
            this.rtbResourceDesc.Location = new System.Drawing.Point(11, 59);
            this.rtbResourceDesc.Name = "rtbResourceDesc";
            this.rtbResourceDesc.ReadOnly = true;
            this.rtbResourceDesc.Size = new System.Drawing.Size(313, 96);
            this.rtbResourceDesc.TabIndex = 5;
            this.rtbResourceDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description:";
            // 
            // tbResourceVolume
            // 
            this.tbResourceVolume.BackColor = System.Drawing.Color.White;
            this.tbResourceVolume.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbResourceVolume.Location = new System.Drawing.Point(205, 19);
            this.tbResourceVolume.Name = "tbResourceVolume";
            this.tbResourceVolume.ReadOnly = true;
            this.tbResourceVolume.Size = new System.Drawing.Size(119, 20);
            this.tbResourceVolume.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Volume:";
            // 
            // cbResourceType
            // 
            this.cbResourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResourceType.FormattingEnabled = true;
            this.cbResourceType.Location = new System.Drawing.Point(11, 19);
            this.cbResourceType.Name = "cbResourceType";
            this.cbResourceType.Size = new System.Drawing.Size(185, 21);
            this.cbResourceType.TabIndex = 1;
            this.cbResourceType.SelectedIndexChanged += new System.EventHandler(this.cbResourceType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Resource Type:";
            // 
            // tpProducts
            // 
            this.tpProducts.BackColor = System.Drawing.SystemColors.Control;
            this.tpProducts.Controls.Add(this.lbProductUsed);
            this.tpProducts.Controls.Add(this.label13);
            this.tpProducts.Controls.Add(this.lbReqComponents);
            this.tpProducts.Controls.Add(this.label12);
            this.tpProducts.Controls.Add(this.rtbProductDesc);
            this.tpProducts.Controls.Add(this.label11);
            this.tpProducts.Controls.Add(this.tbProductTier);
            this.tpProducts.Controls.Add(this.label10);
            this.tpProducts.Controls.Add(this.tbProductVolume);
            this.tpProducts.Controls.Add(this.label9);
            this.tpProducts.Controls.Add(this.cbProductType);
            this.tpProducts.Controls.Add(this.label8);
            this.tpProducts.Location = new System.Drawing.Point(4, 22);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducts.Size = new System.Drawing.Size(332, 422);
            this.tpProducts.TabIndex = 2;
            this.tpProducts.Text = "Products";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product Type:";
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(11, 19);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(185, 21);
            this.cbProductType.TabIndex = 1;
            this.cbProductType.SelectedIndexChanged += new System.EventHandler(this.cbProductType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Volume:";
            // 
            // tbProductVolume
            // 
            this.tbProductVolume.BackColor = System.Drawing.Color.White;
            this.tbProductVolume.Location = new System.Drawing.Point(205, 20);
            this.tbProductVolume.Name = "tbProductVolume";
            this.tbProductVolume.ReadOnly = true;
            this.tbProductVolume.Size = new System.Drawing.Size(53, 20);
            this.tbProductVolume.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tier:";
            // 
            // tbProductTier
            // 
            this.tbProductTier.BackColor = System.Drawing.Color.White;
            this.tbProductTier.Location = new System.Drawing.Point(264, 20);
            this.tbProductTier.Name = "tbProductTier";
            this.tbProductTier.ReadOnly = true;
            this.tbProductTier.Size = new System.Drawing.Size(60, 20);
            this.tbProductTier.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Description:";
            // 
            // rtbProductDesc
            // 
            this.rtbProductDesc.BackColor = System.Drawing.Color.White;
            this.rtbProductDesc.Location = new System.Drawing.Point(6, 59);
            this.rtbProductDesc.Name = "rtbProductDesc";
            this.rtbProductDesc.ReadOnly = true;
            this.rtbProductDesc.Size = new System.Drawing.Size(318, 96);
            this.rtbProductDesc.TabIndex = 7;
            this.rtbProductDesc.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Required Components:";
            // 
            // lbReqComponents
            // 
            this.lbReqComponents.FormattingEnabled = true;
            this.lbReqComponents.Location = new System.Drawing.Point(8, 174);
            this.lbReqComponents.Name = "lbReqComponents";
            this.lbReqComponents.Size = new System.Drawing.Size(316, 56);
            this.lbReqComponents.TabIndex = 9;
            this.lbReqComponents.DoubleClick += new System.EventHandler(this.lbReqComponents_DoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Used to create:";
            // 
            // lbProductUsed
            // 
            this.lbProductUsed.FormattingEnabled = true;
            this.lbProductUsed.Location = new System.Drawing.Point(8, 249);
            this.lbProductUsed.Name = "lbProductUsed";
            this.lbProductUsed.Size = new System.Drawing.Size(316, 160);
            this.lbProductUsed.TabIndex = 11;
            this.lbProductUsed.DoubleClick += new System.EventHandler(this.lbProductUsed_DoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 448);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 480);
            this.MinimumSize = new System.Drawing.Size(350, 480);
            this.Name = "frmMain";
            this.Text = "PI Planner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcMain.ResumeLayout(false);
            this.tpPlanets.ResumeLayout(false);
            this.tpPlanets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tpResources.ResumeLayout(false);
            this.tpResources.PerformLayout();
            this.tpProducts.ResumeLayout(false);
            this.tpProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpPlanets;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.RichTextBox rtbPlanetDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbAvailableResources;
        private System.Windows.Forms.ComboBox cbPlanetType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpResources;
        private System.Windows.Forms.TabPage tpProducts;
        private System.Windows.Forms.TextBox tbResourceVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbResourceType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbResourceUsed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbResourceDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProductVolume;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbProductDesc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbProductTier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbProductUsed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbReqComponents;
        private System.Windows.Forms.Label label12;
    }
}

