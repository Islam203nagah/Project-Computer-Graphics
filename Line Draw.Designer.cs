namespace Project_Graphics
{
    partial class Line_Draw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line_Draw));
            this.btn_backLine = new System.Windows.Forms.Button();
            this.txt_X1 = new System.Windows.Forms.TextBox();
            this.txt_Y2 = new System.Windows.Forms.TextBox();
            this.txt_X2 = new System.Windows.Forms.TextBox();
            this.txt_Y1 = new System.Windows.Forms.TextBox();
            this.txt_Tx_Sx_Theta = new System.Windows.Forms.TextBox();
            this.picture_DDA = new System.Windows.Forms.PictureBox();
            this.btn_DDA = new System.Windows.Forms.Button();
            this.btn_bresenham = new System.Windows.Forms.Button();
            this.txt_Ty_Sy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picture_Bresnham = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_yb1 = new System.Windows.Forms.TextBox();
            this.txt_xb2 = new System.Windows.Forms.TextBox();
            this.txt_yb2 = new System.Windows.Forms.TextBox();
            this.txt_xb1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bTy_bSy = new System.Windows.Forms.TextBox();
            this.bTx_bSx_bTheta = new System.Windows.Forms.TextBox();
            this.btn_reflectDDA = new System.Windows.Forms.Button();
            this.btn_rotateDDA = new System.Windows.Forms.Button();
            this.btn_scaleDDA = new System.Windows.Forms.Button();
            this.btn_translateDDA = new System.Windows.Forms.Button();
            this.btn_reflectbresenham = new System.Windows.Forms.Button();
            this.btn_rotatebresenham = new System.Windows.Forms.Button();
            this.btn_Scalebresenham = new System.Windows.Forms.Button();
            this.btn_Transbresenham = new System.Windows.Forms.Button();
            this.pointdda = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointham = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cliping = new System.Windows.Forms.Button();
            this.txt_x_min = new System.Windows.Forms.TextBox();
            this.txt_y_min = new System.Windows.Forms.TextBox();
            this.txt_y_max = new System.Windows.Forms.TextBox();
            this.txt_x_max = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_DDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Bresnham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointdda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointham)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backLine
            // 
            this.btn_backLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_backLine.BackColor = System.Drawing.Color.Navy;
            this.btn_backLine.CausesValidation = false;
            this.btn_backLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_backLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backLine.ForeColor = System.Drawing.Color.Red;
            this.btn_backLine.Location = new System.Drawing.Point(54, 662);
            this.btn_backLine.Name = "btn_backLine";
            this.btn_backLine.Size = new System.Drawing.Size(187, 32);
            this.btn_backLine.TabIndex = 0;
            this.btn_backLine.Text = "Back";
            this.btn_backLine.UseVisualStyleBackColor = false;
            this.btn_backLine.Click += new System.EventHandler(this.btn_backLine_Click);
            // 
            // txt_X1
            // 
            this.txt_X1.Location = new System.Drawing.Point(68, 12);
            this.txt_X1.Name = "txt_X1";
            this.txt_X1.Size = new System.Drawing.Size(38, 20);
            this.txt_X1.TabIndex = 1;
            this.txt_X1.Text = "160";
            // 
            // txt_Y2
            // 
            this.txt_Y2.Location = new System.Drawing.Point(185, 69);
            this.txt_Y2.Name = "txt_Y2";
            this.txt_Y2.Size = new System.Drawing.Size(38, 20);
            this.txt_Y2.TabIndex = 2;
            this.txt_Y2.Text = "110";
            // 
            // txt_X2
            // 
            this.txt_X2.Location = new System.Drawing.Point(185, 12);
            this.txt_X2.Name = "txt_X2";
            this.txt_X2.Size = new System.Drawing.Size(38, 20);
            this.txt_X2.TabIndex = 3;
            this.txt_X2.Text = "200";
            // 
            // txt_Y1
            // 
            this.txt_Y1.Location = new System.Drawing.Point(68, 69);
            this.txt_Y1.Name = "txt_Y1";
            this.txt_Y1.Size = new System.Drawing.Size(38, 20);
            this.txt_Y1.TabIndex = 4;
            this.txt_Y1.Text = "90";
            // 
            // txt_Tx_Sx_Theta
            // 
            this.txt_Tx_Sx_Theta.Location = new System.Drawing.Point(110, 178);
            this.txt_Tx_Sx_Theta.Name = "txt_Tx_Sx_Theta";
            this.txt_Tx_Sx_Theta.Size = new System.Drawing.Size(41, 20);
            this.txt_Tx_Sx_Theta.TabIndex = 5;
            // 
            // picture_DDA
            // 
            this.picture_DDA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picture_DDA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_DDA.Location = new System.Drawing.Point(733, 12);
            this.picture_DDA.Name = "picture_DDA";
            this.picture_DDA.Size = new System.Drawing.Size(625, 317);
            this.picture_DDA.TabIndex = 6;
            this.picture_DDA.TabStop = false;
            // 
            // btn_DDA
            // 
            this.btn_DDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DDA.Location = new System.Drawing.Point(21, 123);
            this.btn_DDA.Name = "btn_DDA";
            this.btn_DDA.Size = new System.Drawing.Size(145, 34);
            this.btn_DDA.TabIndex = 7;
            this.btn_DDA.Text = "DDA Draw";
            this.btn_DDA.UseVisualStyleBackColor = true;
            this.btn_DDA.Click += new System.EventHandler(this.btn_DDA_Click);
            // 
            // btn_bresenham
            // 
            this.btn_bresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bresenham.Location = new System.Drawing.Point(17, 467);
            this.btn_bresenham.Name = "btn_bresenham";
            this.btn_bresenham.Size = new System.Drawing.Size(116, 37);
            this.btn_bresenham.TabIndex = 8;
            this.btn_bresenham.Text = "Bresenham";
            this.btn_bresenham.UseVisualStyleBackColor = true;
            this.btn_bresenham.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Ty_Sy
            // 
            this.txt_Ty_Sy.Location = new System.Drawing.Point(247, 178);
            this.txt_Ty_Sy.Name = "txt_Ty_Sy";
            this.txt_Ty_Sy.Size = new System.Drawing.Size(41, 20);
            this.txt_Ty_Sy.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Y2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ty_Sy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tx_Sx_Theta";
            // 
            // picture_Bresnham
            // 
            this.picture_Bresnham.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picture_Bresnham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_Bresnham.Location = new System.Drawing.Point(733, 377);
            this.picture_Bresnham.Name = "picture_Bresnham";
            this.picture_Bresnham.Size = new System.Drawing.Size(625, 317);
            this.picture_Bresnham.TabIndex = 26;
            this.picture_Bresnham.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2747, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Y2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Y1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(168, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "X2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "X1";
            // 
            // txt_yb1
            // 
            this.txt_yb1.Location = new System.Drawing.Point(92, 432);
            this.txt_yb1.Name = "txt_yb1";
            this.txt_yb1.Size = new System.Drawing.Size(38, 20);
            this.txt_yb1.TabIndex = 40;
            // 
            // txt_xb2
            // 
            this.txt_xb2.Location = new System.Drawing.Point(209, 384);
            this.txt_xb2.Name = "txt_xb2";
            this.txt_xb2.Size = new System.Drawing.Size(38, 20);
            this.txt_xb2.TabIndex = 39;
            // 
            // txt_yb2
            // 
            this.txt_yb2.Location = new System.Drawing.Point(209, 432);
            this.txt_yb2.Name = "txt_yb2";
            this.txt_yb2.Size = new System.Drawing.Size(38, 20);
            this.txt_yb2.TabIndex = 38;
            // 
            // txt_xb1
            // 
            this.txt_xb1.Location = new System.Drawing.Point(92, 384);
            this.txt_xb1.Name = "txt_xb1";
            this.txt_xb1.Size = new System.Drawing.Size(38, 20);
            this.txt_xb1.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 538);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Tx_Sx_Theta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(199, 542);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Ty_Sy";
            // 
            // bTy_bSy
            // 
            this.bTy_bSy.Location = new System.Drawing.Point(247, 539);
            this.bTy_bSy.Name = "bTy_bSy";
            this.bTy_bSy.Size = new System.Drawing.Size(41, 20);
            this.bTy_bSy.TabIndex = 46;
            // 
            // bTx_bSx_bTheta
            // 
            this.bTx_bSx_bTheta.Location = new System.Drawing.Point(110, 535);
            this.bTx_bSx_bTheta.Name = "bTx_bSx_bTheta";
            this.bTx_bSx_bTheta.Size = new System.Drawing.Size(41, 20);
            this.bTx_bSx_bTheta.TabIndex = 45;
            // 
            // btn_reflectDDA
            // 
            this.btn_reflectDDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reflectDDA.Location = new System.Drawing.Point(172, 251);
            this.btn_reflectDDA.Name = "btn_reflectDDA";
            this.btn_reflectDDA.Size = new System.Drawing.Size(127, 31);
            this.btn_reflectDDA.TabIndex = 52;
            this.btn_reflectDDA.Text = "Reflecte";
            this.btn_reflectDDA.UseVisualStyleBackColor = true;
            this.btn_reflectDDA.Click += new System.EventHandler(this.btn_reflect_Click);
            // 
            // btn_rotateDDA
            // 
            this.btn_rotateDDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rotateDDA.Location = new System.Drawing.Point(6, 251);
            this.btn_rotateDDA.Name = "btn_rotateDDA";
            this.btn_rotateDDA.Size = new System.Drawing.Size(127, 31);
            this.btn_rotateDDA.TabIndex = 51;
            this.btn_rotateDDA.Text = "Rotate";
            this.btn_rotateDDA.UseVisualStyleBackColor = true;
            this.btn_rotateDDA.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // btn_scaleDDA
            // 
            this.btn_scaleDDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scaleDDA.Location = new System.Drawing.Point(171, 214);
            this.btn_scaleDDA.Name = "btn_scaleDDA";
            this.btn_scaleDDA.Size = new System.Drawing.Size(128, 31);
            this.btn_scaleDDA.TabIndex = 50;
            this.btn_scaleDDA.Text = "Scale";
            this.btn_scaleDDA.UseVisualStyleBackColor = true;
            this.btn_scaleDDA.Click += new System.EventHandler(this.btn_scale_Click);
            // 
            // btn_translateDDA
            // 
            this.btn_translateDDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_translateDDA.Location = new System.Drawing.Point(6, 214);
            this.btn_translateDDA.Name = "btn_translateDDA";
            this.btn_translateDDA.Size = new System.Drawing.Size(127, 31);
            this.btn_translateDDA.TabIndex = 49;
            this.btn_translateDDA.Text = "Translate";
            this.btn_translateDDA.UseVisualStyleBackColor = true;
            this.btn_translateDDA.Click += new System.EventHandler(this.btn_translate_Click);
            // 
            // btn_reflectbresenham
            // 
            this.btn_reflectbresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reflectbresenham.Location = new System.Drawing.Point(17, 604);
            this.btn_reflectbresenham.Name = "btn_reflectbresenham";
            this.btn_reflectbresenham.Size = new System.Drawing.Size(116, 32);
            this.btn_reflectbresenham.TabIndex = 58;
            this.btn_reflectbresenham.Text = "Reflecte";
            this.btn_reflectbresenham.UseVisualStyleBackColor = true;
            this.btn_reflectbresenham.Click += new System.EventHandler(this.btn_reflectbresenham_Click);
            // 
            // btn_rotatebresenham
            // 
            this.btn_rotatebresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rotatebresenham.Location = new System.Drawing.Point(139, 604);
            this.btn_rotatebresenham.Name = "btn_rotatebresenham";
            this.btn_rotatebresenham.Size = new System.Drawing.Size(108, 32);
            this.btn_rotatebresenham.TabIndex = 57;
            this.btn_rotatebresenham.Text = "Rotate";
            this.btn_rotatebresenham.UseVisualStyleBackColor = true;
            this.btn_rotatebresenham.Click += new System.EventHandler(this.btn_rotatebresenham_Click);
            // 
            // btn_Scalebresenham
            // 
            this.btn_Scalebresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Scalebresenham.Location = new System.Drawing.Point(139, 566);
            this.btn_Scalebresenham.Name = "btn_Scalebresenham";
            this.btn_Scalebresenham.Size = new System.Drawing.Size(108, 32);
            this.btn_Scalebresenham.TabIndex = 56;
            this.btn_Scalebresenham.Text = "Scale";
            this.btn_Scalebresenham.UseVisualStyleBackColor = true;
            this.btn_Scalebresenham.Click += new System.EventHandler(this.btn_Scalebresenham_Click);
            // 
            // btn_Transbresenham
            // 
            this.btn_Transbresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Transbresenham.Location = new System.Drawing.Point(17, 566);
            this.btn_Transbresenham.Name = "btn_Transbresenham";
            this.btn_Transbresenham.Size = new System.Drawing.Size(116, 32);
            this.btn_Transbresenham.TabIndex = 55;
            this.btn_Transbresenham.Text = "Translate";
            this.btn_Transbresenham.UseVisualStyleBackColor = true;
            this.btn_Transbresenham.Click += new System.EventHandler(this.btn_Transbresenham_Click);
            // 
            // pointdda
            // 
            this.pointdda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pointdda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pointdda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointdda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.pointdda.Location = new System.Drawing.Point(387, 12);
            this.pointdda.Name = "pointdda";
            this.pointdda.Size = new System.Drawing.Size(340, 317);
            this.pointdda.TabIndex = 61;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "I";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "XPloted";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "YPloted";
            this.Column4.Name = "Column4";
            // 
            // pointham
            // 
            this.pointham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pointham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pointham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column6,
            this.Column7,
            this.Column8});
            this.pointham.Location = new System.Drawing.Point(387, 377);
            this.pointham.Name = "pointham";
            this.pointham.Size = new System.Drawing.Size(340, 317);
            this.pointham.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "I";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "P";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "X+1";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Y+1";
            this.Column8.Name = "Column8";
            // 
            // btn_cliping
            // 
            this.btn_cliping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliping.Location = new System.Drawing.Point(6, 293);
            this.btn_cliping.Name = "btn_cliping";
            this.btn_cliping.Size = new System.Drawing.Size(127, 36);
            this.btn_cliping.TabIndex = 63;
            this.btn_cliping.Text = "Cliping";
            this.btn_cliping.UseVisualStyleBackColor = true;
            this.btn_cliping.Click += new System.EventHandler(this.btn_cliping_Click);
            // 
            // txt_x_min
            // 
            this.txt_x_min.Location = new System.Drawing.Point(229, 288);
            this.txt_x_min.Name = "txt_x_min";
            this.txt_x_min.Size = new System.Drawing.Size(38, 20);
            this.txt_x_min.TabIndex = 65;
            this.txt_x_min.Text = "160";
            // 
            // txt_y_min
            // 
            this.txt_y_min.Location = new System.Drawing.Point(229, 314);
            this.txt_y_min.Name = "txt_y_min";
            this.txt_y_min.Size = new System.Drawing.Size(39, 20);
            this.txt_y_min.TabIndex = 66;
            this.txt_y_min.Text = "90";
            // 
            // txt_y_max
            // 
            this.txt_y_max.Location = new System.Drawing.Point(337, 314);
            this.txt_y_max.Name = "txt_y_max";
            this.txt_y_max.Size = new System.Drawing.Size(32, 20);
            this.txt_y_max.TabIndex = 67;
            this.txt_y_max.Text = "110";
            // 
            // txt_x_max
            // 
            this.txt_x_max.Location = new System.Drawing.Point(337, 288);
            this.txt_x_max.Name = "txt_x_max";
            this.txt_x_max.Size = new System.Drawing.Size(32, 20);
            this.txt_x_max.TabIndex = 68;
            this.txt_x_max.Text = "180";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "y_max";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(182, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "y_min";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(182, 293);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 71;
            this.label16.Text = "x_min";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(290, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "x_max";
            // 
            // Line_Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1370, 698);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_x_max);
            this.Controls.Add(this.txt_y_max);
            this.Controls.Add(this.txt_y_min);
            this.Controls.Add(this.txt_x_min);
            this.Controls.Add(this.btn_cliping);
            this.Controls.Add(this.pointham);
            this.Controls.Add(this.pointdda);
            this.Controls.Add(this.btn_reflectbresenham);
            this.Controls.Add(this.btn_rotatebresenham);
            this.Controls.Add(this.btn_Scalebresenham);
            this.Controls.Add(this.btn_Transbresenham);
            this.Controls.Add(this.btn_reflectDDA);
            this.Controls.Add(this.btn_rotateDDA);
            this.Controls.Add(this.btn_scaleDDA);
            this.Controls.Add(this.btn_translateDDA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bTy_bSy);
            this.Controls.Add(this.bTx_bSx_bTheta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_yb1);
            this.Controls.Add(this.txt_xb2);
            this.Controls.Add(this.txt_yb2);
            this.Controls.Add(this.txt_xb1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picture_Bresnham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ty_Sy);
            this.Controls.Add(this.btn_bresenham);
            this.Controls.Add(this.btn_DDA);
            this.Controls.Add(this.picture_DDA);
            this.Controls.Add(this.txt_Tx_Sx_Theta);
            this.Controls.Add(this.txt_Y1);
            this.Controls.Add(this.txt_X2);
            this.Controls.Add(this.txt_Y2);
            this.Controls.Add(this.txt_X1);
            this.Controls.Add(this.btn_backLine);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Line_Draw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line_Draw";
            ((System.ComponentModel.ISupportInitialize)(this.picture_DDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Bresnham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointdda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backLine;
        private System.Windows.Forms.TextBox txt_X1;
        private System.Windows.Forms.TextBox txt_Y2;
        private System.Windows.Forms.TextBox txt_X2;
        private System.Windows.Forms.TextBox txt_Y1;
        private System.Windows.Forms.TextBox txt_Tx_Sx_Theta;
        private System.Windows.Forms.PictureBox picture_DDA;
        private System.Windows.Forms.Button btn_DDA;
        private System.Windows.Forms.Button btn_bresenham;
        private System.Windows.Forms.TextBox txt_Ty_Sy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picture_Bresnham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_yb1;
        private System.Windows.Forms.TextBox txt_xb2;
        private System.Windows.Forms.TextBox txt_yb2;
        private System.Windows.Forms.TextBox txt_xb1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox bTy_bSy;
        private System.Windows.Forms.TextBox bTx_bSx_bTheta;
        private System.Windows.Forms.Button btn_reflectDDA;
        private System.Windows.Forms.Button btn_rotateDDA;
        private System.Windows.Forms.Button btn_scaleDDA;
        private System.Windows.Forms.Button btn_translateDDA;
        private System.Windows.Forms.Button btn_reflectbresenham;
        private System.Windows.Forms.Button btn_rotatebresenham;
        private System.Windows.Forms.Button btn_Scalebresenham;
        private System.Windows.Forms.Button btn_Transbresenham;
        private System.Windows.Forms.DataGridView pointdda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView pointham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btn_cliping;
        private System.Windows.Forms.TextBox txt_x_min;
        private System.Windows.Forms.TextBox txt_y_min;
        private System.Windows.Forms.TextBox txt_y_max;
        private System.Windows.Forms.TextBox txt_x_max;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}