namespace Project_Graphics
{
    partial class Frm_Home
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
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Ellips = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.Navy;
            this.btn_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_line.ForeColor = System.Drawing.Color.Red;
            this.btn_line.Location = new System.Drawing.Point(315, 132);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(423, 63);
            this.btn_line.TabIndex = 0;
            this.btn_line.Text = "Line Drawing";
            this.btn_line.UseMnemonic = false;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Circle.ForeColor = System.Drawing.Color.Red;
            this.btn_Circle.Location = new System.Drawing.Point(315, 239);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(423, 56);
            this.btn_Circle.TabIndex = 1;
            this.btn_Circle.Text = "Circle Drawing";
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Ellips
            // 
            this.btn_Ellips.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Ellips.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ellips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Ellips.Location = new System.Drawing.Point(315, 336);
            this.btn_Ellips.Name = "btn_Ellips";
            this.btn_Ellips.Size = new System.Drawing.Size(423, 58);
            this.btn_Ellips.TabIndex = 2;
            this.btn_Ellips.Text = "Ellips Drawing";
            this.btn_Ellips.UseVisualStyleBackColor = false;
            this.btn_Ellips.Click += new System.EventHandler(this.btn_Ellips_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(378, 44);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(309, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choice your Sheap to Draw";
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Project_Graphics.Properties.Resources.mon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ellips);
            this.Controls.Add(this.btn_Circle);
            this.Controls.Add(this.btn_line);
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphic Design";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Ellips;
        private System.Windows.Forms.Label label1;
    }
}

