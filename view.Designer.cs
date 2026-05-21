
namespace DairySystem
{
    partial class View
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.txtIDResult = new System.Windows.Forms.TextBox();
            this.btnGetID = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 178);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(588, 294);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(168, 79);
            this.btnLoadAll.TabIndex = 12;
            this.btnLoadAll.Text = "Load All (Procedure)";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // txtIDResult
            // 
            this.txtIDResult.Location = new System.Drawing.Point(99, 173);
            this.txtIDResult.Name = "txtIDResult";
            this.txtIDResult.Size = new System.Drawing.Size(296, 22);
            this.txtIDResult.TabIndex = 11;
            // 
            // btnGetID
            // 
            this.btnGetID.Location = new System.Drawing.Point(446, 137);
            this.btnGetID.Name = "btnGetID";
            this.btnGetID.Size = new System.Drawing.Size(202, 58);
            this.btnGetID.TabIndex = 10;
            this.btnGetID.Text = "get max id  ";
            this.btnGetID.UseVisualStyleBackColor = true;
            this.btnGetID.Click += new System.EventHandler(this.btnGetID_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(99, 97);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(296, 22);
            this.txtEntry.TabIndex = 9;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(277, 14);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(184, 55);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load Entry";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(44, 30);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(184, 24);
            this.cmbID.TabIndex = 7;
            this.cmbID.Text = "cmbID";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.txtIDResult);
            this.Controls.Add(this.btnGetID);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbID);
            this.Name = "View";
            this.Text = "view";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.TextBox txtIDResult;
        private System.Windows.Forms.Button btnGetID;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cmbID;
    }
}