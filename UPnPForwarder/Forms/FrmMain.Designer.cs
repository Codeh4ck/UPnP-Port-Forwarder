namespace UPnPForwarder.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdRemoveSelected = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdForward = new System.Windows.Forms.Button();
            this.cmdCheckPorts = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkIp = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listPorts = new System.Windows.Forms.ListView();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a number of ports to forward:";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.Image")));
            this.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAdd.Location = new System.Drawing.Point(266, 204);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(80, 23);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Add port";
            this.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdRemoveSelected
            // 
            this.cmdRemoveSelected.Image = ((System.Drawing.Image)(resources.GetObject("cmdRemoveSelected.Image")));
            this.cmdRemoveSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRemoveSelected.Location = new System.Drawing.Point(129, 204);
            this.cmdRemoveSelected.Name = "cmdRemoveSelected";
            this.cmdRemoveSelected.Size = new System.Drawing.Size(131, 23);
            this.cmdRemoveSelected.TabIndex = 3;
            this.cmdRemoveSelected.Text = "Remove selected";
            this.cmdRemoveSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdRemoveSelected.UseVisualStyleBackColor = true;
            this.cmdRemoveSelected.Click += new System.EventHandler(this.cmdRemoveSelected_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Image = ((System.Drawing.Image)(resources.GetObject("cmdClear.Image")));
            this.cmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClear.Location = new System.Drawing.Point(59, 204);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(64, 23);
            this.cmdClear.TabIndex = 4;
            this.cmdClear.Text = "Clear";
            this.cmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 10);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cmdForward
            // 
            this.cmdForward.Image = ((System.Drawing.Image)(resources.GetObject("cmdForward.Image")));
            this.cmdForward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdForward.Location = new System.Drawing.Point(232, 250);
            this.cmdForward.Name = "cmdForward";
            this.cmdForward.Size = new System.Drawing.Size(114, 23);
            this.cmdForward.TabIndex = 6;
            this.cmdForward.Text = "Forward ports";
            this.cmdForward.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdForward.UseVisualStyleBackColor = true;
            this.cmdForward.Click += new System.EventHandler(this.cmdForward_Click);
            // 
            // cmdCheckPorts
            // 
            this.cmdCheckPorts.Image = ((System.Drawing.Image)(resources.GetObject("cmdCheckPorts.Image")));
            this.cmdCheckPorts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCheckPorts.Location = new System.Drawing.Point(121, 250);
            this.cmdCheckPorts.Name = "cmdCheckPorts";
            this.cmdCheckPorts.Size = new System.Drawing.Size(105, 23);
            this.cmdCheckPorts.TabIndex = 7;
            this.cmdCheckPorts.Text = "Check ports";
            this.cmdCheckPorts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCheckPorts.UseVisualStyleBackColor = true;
            this.cmdCheckPorts.Click += new System.EventHandler(this.cmdCheckPorts_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(358, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(118, 17);
            this.labelStatus.Text = "toolStripStatusLabel1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your public IP:";
            // 
            // linkIp
            // 
            this.linkIp.AutoSize = true;
            this.linkIp.Location = new System.Drawing.Point(108, 10);
            this.linkIp.Name = "linkIp";
            this.linkIp.Size = new System.Drawing.Size(12, 13);
            this.linkIp.TabIndex = 10;
            this.linkIp.TabStop = true;
            this.linkIp.Text = "-";
            this.linkIp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIp_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 10);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // listPorts
            // 
            this.listPorts.Location = new System.Drawing.Point(15, 65);
            this.listPorts.Name = "listPorts";
            this.listPorts.Size = new System.Drawing.Size(331, 133);
            this.listPorts.TabIndex = 11;
            this.listPorts.UseCompatibleStateImageBehavior = false;
            this.listPorts.View = System.Windows.Forms.View.List;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 305);
            this.Controls.Add(this.listPorts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.linkIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdCheckPorts);
            this.Controls.Add(this.cmdForward);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdRemoveSelected);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPnP Forwarder";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdRemoveSelected;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdForward;
        private System.Windows.Forms.Button cmdCheckPorts;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listPorts;
    }
}

