namespace ROISelection
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picUL = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.picDR = new System.Windows.Forms.PictureBox();
            this.txtDR = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picDL = new System.Windows.Forms.PictureBox();
            this.txtDL = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picCenter = new System.Windows.Forms.PictureBox();
            this.txtCenter = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picUR = new System.Windows.Forms.PictureBox();
            this.txtUR = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUL = new System.Windows.Forms.TextBox();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCenterUp = new System.Windows.Forms.Button();
            this.btnCenterDown = new System.Windows.Forms.Button();
            this.btnCenterRight = new System.Windows.Forms.Button();
            this.btnCenterLeft = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMove = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtROIH = new System.Windows.Forms.TextBox();
            this.txtROIW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.lblInform = new System.Windows.Forms.Label();
            this.imgMain = new Emgu.CV.UI.ImageBox();
            this.lblMousePos = new System.Windows.Forms.Label();
            this.lblImagePos = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUL)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDR)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDL)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUR)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpen.Location = new System.Drawing.Point(13, 588);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(122, 42);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "One Picture";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picUL
            // 
            this.picUL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUL.Location = new System.Drawing.Point(3, 3);
            this.picUL.Name = "picUL";
            this.picUL.Size = new System.Drawing.Size(110, 110);
            this.picUL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUL.TabIndex = 2;
            this.picUL.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(790, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 433);
            this.panel1.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.picDR);
            this.panel6.Controls.Add(this.txtDR);
            this.panel6.Location = new System.Drawing.Point(349, 299);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 125);
            this.panel6.TabIndex = 13;
            // 
            // picDR
            // 
            this.picDR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDR.Location = new System.Drawing.Point(3, 3);
            this.picDR.Name = "picDR";
            this.picDR.Size = new System.Drawing.Size(110, 110);
            this.picDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDR.TabIndex = 2;
            this.picDR.TabStop = false;
            // 
            // txtDR
            // 
            this.txtDR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDR.ForeColor = System.Drawing.Color.Blue;
            this.txtDR.Location = new System.Drawing.Point(119, 3);
            this.txtDR.Multiline = true;
            this.txtDR.Name = "txtDR";
            this.txtDR.Size = new System.Drawing.Size(200, 110);
            this.txtDR.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.picDL);
            this.panel5.Controls.Add(this.txtDL);
            this.panel5.Location = new System.Drawing.Point(16, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 125);
            this.panel5.TabIndex = 12;
            // 
            // picDL
            // 
            this.picDL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDL.Location = new System.Drawing.Point(3, 3);
            this.picDL.Name = "picDL";
            this.picDL.Size = new System.Drawing.Size(110, 110);
            this.picDL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDL.TabIndex = 2;
            this.picDL.TabStop = false;
            // 
            // txtDL
            // 
            this.txtDL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDL.ForeColor = System.Drawing.Color.Blue;
            this.txtDL.Location = new System.Drawing.Point(119, 3);
            this.txtDL.Multiline = true;
            this.txtDL.Name = "txtDL";
            this.txtDL.Size = new System.Drawing.Size(200, 110);
            this.txtDL.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.picCenter);
            this.panel4.Controls.Add(this.txtCenter);
            this.panel4.Location = new System.Drawing.Point(132, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 125);
            this.panel4.TabIndex = 11;
            // 
            // picCenter
            // 
            this.picCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCenter.Location = new System.Drawing.Point(3, 3);
            this.picCenter.Name = "picCenter";
            this.picCenter.Size = new System.Drawing.Size(110, 110);
            this.picCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCenter.TabIndex = 2;
            this.picCenter.TabStop = false;
            // 
            // txtCenter
            // 
            this.txtCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCenter.Location = new System.Drawing.Point(119, 3);
            this.txtCenter.Multiline = true;
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(200, 110);
            this.txtCenter.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picUR);
            this.panel3.Controls.Add(this.txtUR);
            this.panel3.Location = new System.Drawing.Point(349, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 125);
            this.panel3.TabIndex = 10;
            // 
            // picUR
            // 
            this.picUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUR.Location = new System.Drawing.Point(3, 3);
            this.picUR.Name = "picUR";
            this.picUR.Size = new System.Drawing.Size(110, 110);
            this.picUR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUR.TabIndex = 2;
            this.picUR.TabStop = false;
            // 
            // txtUR
            // 
            this.txtUR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUR.ForeColor = System.Drawing.Color.Blue;
            this.txtUR.Location = new System.Drawing.Point(119, 3);
            this.txtUR.Multiline = true;
            this.txtUR.Name = "txtUR";
            this.txtUR.Size = new System.Drawing.Size(200, 110);
            this.txtUR.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picUL);
            this.panel2.Controls.Add(this.txtUL);
            this.panel2.Location = new System.Drawing.Point(13, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 125);
            this.panel2.TabIndex = 9;
            // 
            // txtUL
            // 
            this.txtUL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUL.ForeColor = System.Drawing.Color.Blue;
            this.txtUL.Location = new System.Drawing.Point(119, 3);
            this.txtUL.Multiline = true;
            this.txtUL.Name = "txtUL";
            this.txtUL.Size = new System.Drawing.Size(200, 110);
            this.txtUL.TabIndex = 8;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIncrease.Location = new System.Drawing.Point(135, 97);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(40, 40);
            this.btnIncrease.TabIndex = 8;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDecrease.Location = new System.Drawing.Point(181, 97);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(40, 40);
            this.btnDecrease.TabIndex = 9;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUp.Location = new System.Drawing.Point(44, 28);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(35, 35);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLeft.Location = new System.Drawing.Point(3, 44);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(35, 35);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRight.Location = new System.Drawing.Point(83, 44);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(35, 35);
            this.btnRight.TabIndex = 12;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDown.Location = new System.Drawing.Point(44, 64);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(35, 35);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.txtMove);
            this.panel7.Location = new System.Drawing.Point(510, 588);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(263, 150);
            this.panel7.TabIndex = 14;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.btnCenterUp);
            this.panel12.Controls.Add(this.btnCenterDown);
            this.panel12.Controls.Add(this.btnCenterRight);
            this.panel12.Controls.Add(this.btnCenterLeft);
            this.panel12.Location = new System.Drawing.Point(134, 35);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(122, 110);
            this.panel12.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(34, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Center";
            // 
            // btnCenterUp
            // 
            this.btnCenterUp.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCenterUp.Location = new System.Drawing.Point(43, 28);
            this.btnCenterUp.Name = "btnCenterUp";
            this.btnCenterUp.Size = new System.Drawing.Size(35, 35);
            this.btnCenterUp.TabIndex = 10;
            this.btnCenterUp.Text = "↑";
            this.btnCenterUp.UseVisualStyleBackColor = true;
            this.btnCenterUp.Click += new System.EventHandler(this.btnCenterUp_Click);
            // 
            // btnCenterDown
            // 
            this.btnCenterDown.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCenterDown.Location = new System.Drawing.Point(43, 64);
            this.btnCenterDown.Name = "btnCenterDown";
            this.btnCenterDown.Size = new System.Drawing.Size(35, 35);
            this.btnCenterDown.TabIndex = 13;
            this.btnCenterDown.Text = "↓";
            this.btnCenterDown.UseVisualStyleBackColor = true;
            this.btnCenterDown.Click += new System.EventHandler(this.btnCenterDown_Click);
            // 
            // btnCenterRight
            // 
            this.btnCenterRight.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCenterRight.Location = new System.Drawing.Point(83, 44);
            this.btnCenterRight.Name = "btnCenterRight";
            this.btnCenterRight.Size = new System.Drawing.Size(35, 35);
            this.btnCenterRight.TabIndex = 12;
            this.btnCenterRight.Text = "→";
            this.btnCenterRight.UseVisualStyleBackColor = true;
            this.btnCenterRight.Click += new System.EventHandler(this.btnCenterRight_Click);
            // 
            // btnCenterLeft
            // 
            this.btnCenterLeft.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCenterLeft.Location = new System.Drawing.Point(3, 44);
            this.btnCenterLeft.Name = "btnCenterLeft";
            this.btnCenterLeft.Size = new System.Drawing.Size(35, 35);
            this.btnCenterLeft.TabIndex = 11;
            this.btnCenterLeft.Text = "←";
            this.btnCenterLeft.UseVisualStyleBackColor = true;
            this.btnCenterLeft.Click += new System.EventHandler(this.btnCenterLeft_Click);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.btnUp);
            this.panel11.Controls.Add(this.btnDown);
            this.panel11.Controls.Add(this.btnRight);
            this.panel11.Controls.Add(this.btnLeft);
            this.panel11.Location = new System.Drawing.Point(5, 35);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(122, 110);
            this.panel11.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(35, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Corner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Move Step (px)";
            // 
            // txtMove
            // 
            this.txtMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMove.Location = new System.Drawing.Point(156, 3);
            this.txtMove.Name = "txtMove";
            this.txtMove.Size = new System.Drawing.Size(49, 25);
            this.txtMove.TabIndex = 21;
            this.txtMove.Text = "5";
            this.txtMove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnIncrease);
            this.panel8.Controls.Add(this.btnDecrease);
            this.panel8.Controls.Add(this.txtRatio);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.txtROIH);
            this.panel8.Controls.Add(this.txtROIW);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.txtStep);
            this.panel8.Location = new System.Drawing.Point(272, 588);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(233, 150);
            this.panel8.TabIndex = 15;
            // 
            // txtRatio
            // 
            this.txtRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRatio.Location = new System.Drawing.Point(157, 43);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(49, 25);
            this.txtRatio.TabIndex = 26;
            this.txtRatio.Text = "1";
            this.txtRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(7, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Aspect Ratio (W/H)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(7, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "ROI H";
            // 
            // txtROIH
            // 
            this.txtROIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtROIH.Location = new System.Drawing.Point(67, 114);
            this.txtROIH.Name = "txtROIH";
            this.txtROIH.Size = new System.Drawing.Size(49, 25);
            this.txtROIH.TabIndex = 23;
            this.txtROIH.Text = "80";
            this.txtROIH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtROIW
            // 
            this.txtROIW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtROIW.Location = new System.Drawing.Point(67, 77);
            this.txtROIW.Name = "txtROIW";
            this.txtROIW.Size = new System.Drawing.Size(49, 25);
            this.txtROIW.TabIndex = 22;
            this.txtROIW.Text = "80";
            this.txtROIW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "ROI W";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Step (px)";
            // 
            // txtStep
            // 
            this.txtStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStep.Location = new System.Drawing.Point(88, 6);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(49, 25);
            this.txtStep.TabIndex = 19;
            this.txtStep.Text = "5";
            this.txtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInform
            // 
            this.lblInform.AutoSize = true;
            this.lblInform.Location = new System.Drawing.Point(7, 37);
            this.lblInform.Name = "lblInform";
            this.lblInform.Size = new System.Drawing.Size(118, 15);
            this.lblInform.TabIndex = 16;
            this.lblInform.Text = "Image Information:";
            // 
            // imgMain
            // 
            this.imgMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgMain.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imgMain.Location = new System.Drawing.Point(13, 12);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(760, 570);
            this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMain.TabIndex = 2;
            this.imgMain.TabStop = false;
            this.imgMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgMain_MouseMove);
            // 
            // lblMousePos
            // 
            this.lblMousePos.AutoSize = true;
            this.lblMousePos.ForeColor = System.Drawing.Color.Blue;
            this.lblMousePos.Location = new System.Drawing.Point(7, 59);
            this.lblMousePos.Name = "lblMousePos";
            this.lblMousePos.Size = new System.Drawing.Size(99, 15);
            this.lblMousePos.TabIndex = 17;
            this.lblMousePos.Text = "Mouse Position:";
            // 
            // lblImagePos
            // 
            this.lblImagePos.AutoSize = true;
            this.lblImagePos.ForeColor = System.Drawing.Color.Green;
            this.lblImagePos.Location = new System.Drawing.Point(7, 81);
            this.lblImagePos.Name = "lblImagePos";
            this.lblImagePos.Size = new System.Drawing.Size(96, 15);
            this.lblImagePos.TabIndex = 18;
            this.lblImagePos.Text = "Image Position:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(140, 588);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 42);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFolder.Location = new System.Drawing.Point(12, 636);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(122, 42);
            this.btnFolder.TabIndex = 20;
            this.btnFolder.Text = "All Pictures";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPath.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblPath.Location = new System.Drawing.Point(7, 10);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(36, 15);
            this.lblPath.TabIndex = 21;
            this.lblPath.Text = "Path:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblPath);
            this.panel9.Controls.Add(this.lblInform);
            this.panel9.Controls.Add(this.lblMousePos);
            this.panel9.Controls.Add(this.lblImagePos);
            this.panel9.Location = new System.Drawing.Point(790, 451);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(688, 109);
            this.panel9.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus.Location = new System.Drawing.Point(12, 697);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(119, 25);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Status: Idle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 753);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.imgMain);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "ROI_Selection_YongTeng";
            ((System.ComponentModel.ISupportInitialize)(this.picUL)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDR)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDL)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCenter)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUR)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picUL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUL;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox picDL;
        private System.Windows.Forms.TextBox txtDL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picCenter;
        private System.Windows.Forms.TextBox txtCenter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picUR;
        private System.Windows.Forms.TextBox txtUR;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox picDR;
        private System.Windows.Forms.TextBox txtDR;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblInform;
        private Emgu.CV.UI.ImageBox imgMain;
        private System.Windows.Forms.Label lblMousePos;
        private System.Windows.Forms.Label lblImagePos;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtROIW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCenterUp;
        private System.Windows.Forms.Button btnCenterDown;
        private System.Windows.Forms.Button btnCenterRight;
        private System.Windows.Forms.Button btnCenterLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtROIH;
        private System.Windows.Forms.TextBox txtRatio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblStatus;
    }
}

