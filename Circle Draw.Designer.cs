namespace Project_Graphics
{
    partial class Circle_Draw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circle_Draw));
            this.btn_backCircle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picture_midpoint = new System.Windows.Forms.PictureBox();
            this.txt_xcen = new System.Windows.Forms.TextBox();
            this.txt_radius = new System.Windows.Forms.TextBox();
            this.txt_ycen = new System.Windows.Forms.TextBox();
            this.txt_Tx_Sx = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txt_bresenhamRadius = new System.Windows.Forms.TextBox();
            this.txt_bresenhamYc = new System.Windows.Forms.TextBox();
            this.txt_bresenhamXc = new System.Windows.Forms.TextBox();
            this.btn_midpoint = new System.Windows.Forms.Button();
            this.btn_bresenhamCircle = new System.Windows.Forms.Button();
            this.btn_translate = new System.Windows.Forms.Button();
            this.btn_scale = new System.Windows.Forms.Button();
            this.btn_reflect = new System.Windows.Forms.Button();
            this.btn_bresnTransCircle = new System.Windows.Forms.Button();
            this.btn_BresenScaleCircle = new System.Windows.Forms.Button();
            this.btn_BresenReflectCircle = new System.Windows.Forms.Button();
            this.picture_BresenhamCircle = new System.Windows.Forms.PictureBox();
            this.txt_bresenhamCircle_Ty_Sy = new System.Windows.Forms.TextBox();
            this.txt_bresenhamCircle_Tx_Sx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pointCircleMidpoint = new System.Windows.Forms.DataGridView();
            this.pointBresenhamCircle = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picture_midpoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_BresenhamCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCircleMidpoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBresenhamCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backCircle
            // 
            this.btn_backCircle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_backCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backCircle.ForeColor = System.Drawing.Color.Red;
            this.btn_backCircle.Location = new System.Drawing.Point(9, 655);
            this.btn_backCircle.Name = "btn_backCircle";
            this.btn_backCircle.Size = new System.Drawing.Size(193, 46);
            this.btn_backCircle.TabIndex = 0;
            this.btn_backCircle.Text = "Back";
            this.btn_backCircle.UseVisualStyleBackColor = false;
            this.btn_backCircle.Click += new System.EventHandler(this.btn_backCircle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xcenter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ycenter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tx_Sx_Theta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ty_Sy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Xc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Radius";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2908, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // picture_midpoint
            // 
            this.picture_midpoint.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picture_midpoint.Location = new System.Drawing.Point(692, 3);
            this.picture_midpoint.Name = "picture_midpoint";
            this.picture_midpoint.Size = new System.Drawing.Size(668, 323);
            this.picture_midpoint.TabIndex = 10;
            this.picture_midpoint.TabStop = false;
            // 
            // txt_xcen
            // 
            this.txt_xcen.Location = new System.Drawing.Point(62, 5);
            this.txt_xcen.Name = "txt_xcen";
            this.txt_xcen.Size = new System.Drawing.Size(37, 20);
            this.txt_xcen.TabIndex = 11;
            // 
            // txt_radius
            // 
            this.txt_radius.Location = new System.Drawing.Point(62, 43);
            this.txt_radius.Name = "txt_radius";
            this.txt_radius.Size = new System.Drawing.Size(37, 20);
            this.txt_radius.TabIndex = 12;
            // 
            // txt_ycen
            // 
            this.txt_ycen.Location = new System.Drawing.Point(189, 5);
            this.txt_ycen.Name = "txt_ycen";
            this.txt_ycen.Size = new System.Drawing.Size(39, 20);
            this.txt_ycen.TabIndex = 13;
            // 
            // txt_Tx_Sx
            // 
            this.txt_Tx_Sx.Location = new System.Drawing.Point(100, 159);
            this.txt_Tx_Sx.Name = "txt_Tx_Sx";
            this.txt_Tx_Sx.Size = new System.Drawing.Size(37, 20);
            this.txt_Tx_Sx.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(191, 159);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(39, 20);
            this.textBox5.TabIndex = 15;
            // 
            // txt_bresenhamRadius
            // 
            this.txt_bresenhamRadius.Location = new System.Drawing.Point(70, 425);
            this.txt_bresenhamRadius.Name = "txt_bresenhamRadius";
            this.txt_bresenhamRadius.Size = new System.Drawing.Size(42, 20);
            this.txt_bresenhamRadius.TabIndex = 16;
            // 
            // txt_bresenhamYc
            // 
            this.txt_bresenhamYc.Location = new System.Drawing.Point(163, 389);
            this.txt_bresenhamYc.Name = "txt_bresenhamYc";
            this.txt_bresenhamYc.Size = new System.Drawing.Size(39, 20);
            this.txt_bresenhamYc.TabIndex = 18;
            // 
            // txt_bresenhamXc
            // 
            this.txt_bresenhamXc.Location = new System.Drawing.Point(43, 389);
            this.txt_bresenhamXc.Name = "txt_bresenhamXc";
            this.txt_bresenhamXc.Size = new System.Drawing.Size(42, 20);
            this.txt_bresenhamXc.TabIndex = 19;
            // 
            // btn_midpoint
            // 
            this.btn_midpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_midpoint.Location = new System.Drawing.Point(1, 89);
            this.btn_midpoint.Name = "btn_midpoint";
            this.btn_midpoint.Size = new System.Drawing.Size(139, 42);
            this.btn_midpoint.TabIndex = 20;
            this.btn_midpoint.Text = "Mid Point";
            this.btn_midpoint.UseVisualStyleBackColor = true;
            this.btn_midpoint.Click += new System.EventHandler(this.btn_midpoint_Click);
            // 
            // btn_bresenhamCircle
            // 
            this.btn_bresenhamCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bresenhamCircle.Location = new System.Drawing.Point(17, 466);
            this.btn_bresenhamCircle.Name = "btn_bresenhamCircle";
            this.btn_bresenhamCircle.Size = new System.Drawing.Size(194, 49);
            this.btn_bresenhamCircle.TabIndex = 21;
            this.btn_bresenhamCircle.Text = "Bresenham Circle";
            this.btn_bresenhamCircle.UseVisualStyleBackColor = true;
            this.btn_bresenhamCircle.Click += new System.EventHandler(this.btn_bresenhamCircle_Click);
            // 
            // btn_translate
            // 
            this.btn_translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_translate.Location = new System.Drawing.Point(1, 196);
            this.btn_translate.Name = "btn_translate";
            this.btn_translate.Size = new System.Drawing.Size(111, 34);
            this.btn_translate.TabIndex = 22;
            this.btn_translate.Text = "Translation";
            this.btn_translate.UseVisualStyleBackColor = true;
            this.btn_translate.Click += new System.EventHandler(this.btn_translate_Click);
            // 
            // btn_scale
            // 
            this.btn_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scale.Location = new System.Drawing.Point(118, 196);
            this.btn_scale.Name = "btn_scale";
            this.btn_scale.Size = new System.Drawing.Size(119, 34);
            this.btn_scale.TabIndex = 24;
            this.btn_scale.Text = "Scale";
            this.btn_scale.UseVisualStyleBackColor = true;
            this.btn_scale.Click += new System.EventHandler(this.btn_scale_Click);
            // 
            // btn_reflect
            // 
            this.btn_reflect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reflect.Location = new System.Drawing.Point(1, 262);
            this.btn_reflect.Name = "btn_reflect";
            this.btn_reflect.Size = new System.Drawing.Size(111, 33);
            this.btn_reflect.TabIndex = 25;
            this.btn_reflect.Text = "Reflect";
            this.btn_reflect.UseVisualStyleBackColor = true;
            this.btn_reflect.Click += new System.EventHandler(this.btn_reflect_Click);
            // 
            // btn_bresnTransCircle
            // 
            this.btn_bresnTransCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bresnTransCircle.Location = new System.Drawing.Point(1, 571);
            this.btn_bresnTransCircle.Name = "btn_bresnTransCircle";
            this.btn_bresnTransCircle.Size = new System.Drawing.Size(121, 35);
            this.btn_bresnTransCircle.TabIndex = 26;
            this.btn_bresnTransCircle.Text = "Translation";
            this.btn_bresnTransCircle.UseVisualStyleBackColor = true;
            this.btn_bresnTransCircle.Click += new System.EventHandler(this.btn_bresnTransCircle_Click);
            // 
            // btn_BresenScaleCircle
            // 
            this.btn_BresenScaleCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BresenScaleCircle.Location = new System.Drawing.Point(128, 571);
            this.btn_BresenScaleCircle.Name = "btn_BresenScaleCircle";
            this.btn_BresenScaleCircle.Size = new System.Drawing.Size(109, 35);
            this.btn_BresenScaleCircle.TabIndex = 28;
            this.btn_BresenScaleCircle.Text = "Scale";
            this.btn_BresenScaleCircle.UseVisualStyleBackColor = true;
            this.btn_BresenScaleCircle.Click += new System.EventHandler(this.btn_BresenScaleCircle_Click);
            // 
            // btn_BresenReflectCircle
            // 
            this.btn_BresenReflectCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BresenReflectCircle.Location = new System.Drawing.Point(2, 612);
            this.btn_BresenReflectCircle.Name = "btn_BresenReflectCircle";
            this.btn_BresenReflectCircle.Size = new System.Drawing.Size(120, 37);
            this.btn_BresenReflectCircle.TabIndex = 29;
            this.btn_BresenReflectCircle.Text = "Reflect";
            this.btn_BresenReflectCircle.UseVisualStyleBackColor = true;
            this.btn_BresenReflectCircle.Click += new System.EventHandler(this.btn_BresenReflectCircle_Click);
            // 
            // picture_BresenhamCircle
            // 
            this.picture_BresenhamCircle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picture_BresenhamCircle.Location = new System.Drawing.Point(692, 378);
            this.picture_BresenhamCircle.Name = "picture_BresenhamCircle";
            this.picture_BresenhamCircle.Size = new System.Drawing.Size(668, 323);
            this.picture_BresenhamCircle.TabIndex = 31;
            this.picture_BresenhamCircle.TabStop = false;
            // 
            // txt_bresenhamCircle_Ty_Sy
            // 
            this.txt_bresenhamCircle_Ty_Sy.Location = new System.Drawing.Point(163, 534);
            this.txt_bresenhamCircle_Ty_Sy.Name = "txt_bresenhamCircle_Ty_Sy";
            this.txt_bresenhamCircle_Ty_Sy.Size = new System.Drawing.Size(39, 20);
            this.txt_bresenhamCircle_Ty_Sy.TabIndex = 17;
            // 
            // txt_bresenhamCircle_Tx_Sx
            // 
            this.txt_bresenhamCircle_Tx_Sx.Location = new System.Drawing.Point(62, 534);
            this.txt_bresenhamCircle_Tx_Sx.Name = "txt_bresenhamCircle_Tx_Sx";
            this.txt_bresenhamCircle_Tx_Sx.Size = new System.Drawing.Size(39, 20);
            this.txt_bresenhamCircle_Tx_Sx.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Tx_Sx";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 537);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Ty_Sy";
            // 
            // pointCircleMidpoint
            // 
            this.pointCircleMidpoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointCircleMidpoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.pointCircleMidpoint.Location = new System.Drawing.Point(243, 3);
            this.pointCircleMidpoint.Name = "pointCircleMidpoint";
            this.pointCircleMidpoint.Size = new System.Drawing.Size(443, 323);
            this.pointCircleMidpoint.TabIndex = 36;
            // 
            // pointBresenhamCircle
            // 
            this.pointBresenhamCircle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointBresenhamCircle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pointBresenhamCircle.Location = new System.Drawing.Point(243, 378);
            this.pointBresenhamCircle.Name = "pointBresenhamCircle";
            this.pointBresenhamCircle.Size = new System.Drawing.Size(443, 323);
            this.pointBresenhamCircle.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "I";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "P";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "X";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Y";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "I";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pk";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "X";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Y";
            this.Column4.Name = "Column4";
            // 
            // Circle_Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1370, 711);
            this.Controls.Add(this.pointBresenhamCircle);
            this.Controls.Add(this.pointCircleMidpoint);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_bresenhamCircle_Tx_Sx);
            this.Controls.Add(this.picture_BresenhamCircle);
            this.Controls.Add(this.btn_BresenReflectCircle);
            this.Controls.Add(this.btn_BresenScaleCircle);
            this.Controls.Add(this.btn_bresnTransCircle);
            this.Controls.Add(this.btn_reflect);
            this.Controls.Add(this.btn_scale);
            this.Controls.Add(this.btn_translate);
            this.Controls.Add(this.btn_bresenhamCircle);
            this.Controls.Add(this.btn_midpoint);
            this.Controls.Add(this.txt_bresenhamXc);
            this.Controls.Add(this.txt_bresenhamYc);
            this.Controls.Add(this.txt_bresenhamCircle_Ty_Sy);
            this.Controls.Add(this.txt_bresenhamRadius);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txt_Tx_Sx);
            this.Controls.Add(this.txt_ycen);
            this.Controls.Add(this.txt_radius);
            this.Controls.Add(this.txt_xcen);
            this.Controls.Add(this.picture_midpoint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_backCircle);
            this.Name = "Circle_Draw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle_Draw";
            ((System.ComponentModel.ISupportInitialize)(this.picture_midpoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_BresenhamCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointCircleMidpoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBresenhamCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picture_midpoint;
        private System.Windows.Forms.TextBox txt_xcen;
        private System.Windows.Forms.TextBox txt_radius;
        private System.Windows.Forms.TextBox txt_ycen;
        private System.Windows.Forms.TextBox txt_Tx_Sx;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txt_bresenhamRadius;
        private System.Windows.Forms.TextBox txt_bresenhamYc;
        private System.Windows.Forms.TextBox txt_bresenhamXc;
        private System.Windows.Forms.Button btn_midpoint;
        private System.Windows.Forms.Button btn_bresenhamCircle;
        private System.Windows.Forms.Button btn_translate;
        private System.Windows.Forms.Button btn_scale;
        private System.Windows.Forms.Button btn_reflect;
        private System.Windows.Forms.Button btn_bresnTransCircle;
        private System.Windows.Forms.Button btn_BresenScaleCircle;
        private System.Windows.Forms.Button btn_BresenReflectCircle;
        private System.Windows.Forms.PictureBox picture_BresenhamCircle;
        private System.Windows.Forms.TextBox txt_bresenhamCircle_Ty_Sy;
        private System.Windows.Forms.TextBox txt_bresenhamCircle_Tx_Sx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView pointCircleMidpoint;
        private System.Windows.Forms.DataGridView pointBresenhamCircle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}