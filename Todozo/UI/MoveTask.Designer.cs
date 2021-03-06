﻿namespace Todozo.UI
{
    partial class Todozo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Todozo));
            this.selectListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selectAList = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectListFlowLayoutPanel
            // 
            this.selectListFlowLayoutPanel.AutoScroll = true;
            this.selectListFlowLayoutPanel.Location = new System.Drawing.Point(148, 56);
            this.selectListFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectListFlowLayoutPanel.Name = "selectListFlowLayoutPanel";
            this.selectListFlowLayoutPanel.Size = new System.Drawing.Size(357, 233);
            this.selectListFlowLayoutPanel.TabIndex = 0;
            // 
            // selectAList
            // 
            this.selectAList.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectAList.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.selectAList.Location = new System.Drawing.Point(0, 0);
            this.selectAList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectAList.Name = "selectAList";
            this.selectAList.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.selectAList.Size = new System.Drawing.Size(602, 54);
            this.selectAList.TabIndex = 1;
            this.selectAList.Text = "Select List";
            this.selectAList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(253, 299);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 62);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Todozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectAList);
            this.Controls.Add(this.selectListFlowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "Todozo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todozo";
            this.Load += new System.EventHandler(this.MoveTask_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel selectListFlowLayoutPanel;
        private System.Windows.Forms.Label selectAList;
        private System.Windows.Forms.Button button1;
    }
}