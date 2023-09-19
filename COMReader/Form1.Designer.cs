namespace COMReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbPorts = new ComboBox();
            cmbBaudrate = new ComboBox();
            cmbParity = new ComboBox();
            cmbStopbits = new ComboBox();
            nmDataBit = new NumericUpDown();
            btnOpen = new Button();
            btnClose = new Button();
            txtData = new RichTextBox();
            lblStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmDataBit).BeginInit();
            SuspendLayout();
            // 
            // cmbPorts
            // 
            cmbPorts.FormattingEnabled = true;
            cmbPorts.Location = new Point(12, 27);
            cmbPorts.Name = "cmbPorts";
            cmbPorts.Size = new Size(121, 23);
            cmbPorts.TabIndex = 0;
            // 
            // cmbBaudrate
            // 
            cmbBaudrate.FormattingEnabled = true;
            cmbBaudrate.Location = new Point(139, 27);
            cmbBaudrate.Name = "cmbBaudrate";
            cmbBaudrate.Size = new Size(121, 23);
            cmbBaudrate.TabIndex = 1;
            // 
            // cmbParity
            // 
            cmbParity.FormattingEnabled = true;
            cmbParity.Location = new Point(266, 27);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(121, 23);
            cmbParity.TabIndex = 2;
            // 
            // cmbStopbits
            // 
            cmbStopbits.FormattingEnabled = true;
            cmbStopbits.Location = new Point(393, 27);
            cmbStopbits.Name = "cmbStopbits";
            cmbStopbits.Size = new Size(121, 23);
            cmbStopbits.TabIndex = 3;
            // 
            // nmDataBit
            // 
            nmDataBit.Location = new Point(520, 27);
            nmDataBit.Name = "nmDataBit";
            nmDataBit.Size = new Size(65, 23);
            nmDataBit.TabIndex = 4;
            nmDataBit.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(12, 56);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(192, 23);
            btnOpen.TabIndex = 5;
            btnOpen.Text = "Connect";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(393, 56);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(192, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Disconnect";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(12, 85);
            txtData.Name = "txtData";
            txtData.ReadOnly = true;
            txtData.Size = new Size(573, 275);
            txtData.TabIndex = 7;
            txtData.Text = "";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(266, 60);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Disconnected";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Baudrate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 11;
            label3.Text = "Parity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 12;
            label4.Text = "Stopbits";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(520, 9);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 13;
            label5.Text = "Databit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 370);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(txtData);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Controls.Add(nmDataBit);
            Controls.Add(cmbStopbits);
            Controls.Add(cmbParity);
            Controls.Add(cmbBaudrate);
            Controls.Add(cmbPorts);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(613, 409);
            MinimizeBox = false;
            MinimumSize = new Size(613, 409);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COM Test";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmDataBit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPorts;
        private ComboBox cmbBaudrate;
        private ComboBox cmbParity;
        private ComboBox cmbStopbits;
        private NumericUpDown nmDataBit;
        private Button btnOpen;
        private Button btnClose;
        private RichTextBox txtData;
        private Label lblStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}