
namespace Minicrawler
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnFetch = new System.Windows.Forms.Button();
            this.txtboxUrl = new System.Windows.Forms.TextBox();
            this.lstboxFetched = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFetch
            // 
            this.btnFetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.btnFetch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFetch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFetch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFetch.FlatAppearance.BorderSize = 0;
            this.btnFetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetch.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetch.ForeColor = System.Drawing.Color.White;
            this.btnFetch.Location = new System.Drawing.Point(610, 13);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(162, 47);
            this.btnFetch.TabIndex = 0;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = false;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // txtboxUrl
            // 
            this.txtboxUrl.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUrl.Location = new System.Drawing.Point(13, 14);
            this.txtboxUrl.Name = "txtboxUrl";
            this.txtboxUrl.Size = new System.Drawing.Size(591, 46);
            this.txtboxUrl.TabIndex = 1;
            // 
            // lstboxFetched
            // 
            this.lstboxFetched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.lstboxFetched.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxFetched.ForeColor = System.Drawing.Color.White;
            this.lstboxFetched.FormattingEnabled = true;
            this.lstboxFetched.ItemHeight = 33;
            this.lstboxFetched.Location = new System.Drawing.Point(13, 78);
            this.lstboxFetched.Name = "lstboxFetched";
            this.lstboxFetched.Size = new System.Drawing.Size(759, 466);
            this.lstboxFetched.TabIndex = 2;
            this.lstboxFetched.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstboxFetched_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lstboxFetched);
            this.Controls.Add(this.txtboxUrl);
            this.Controls.Add(this.btnFetch);
            this.Name = "MainForm";
            this.Text = "Minicrawler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox txtboxUrl;
        private System.Windows.Forms.ListBox lstboxFetched;
    }
}

