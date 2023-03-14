namespace WinFormsApp3
{
    partial class index
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
            components = new System.ComponentModel.Container();
            ReceiveBox = new TextBox();
            ComPortName = new Label();
            BuadrateName = new Label();
            DateBitsName = new Label();
            CheckBitName = new Label();
            StopBitName = new Label();
            ComPortSelect = new ComboBox();
            serialPortBindingSource = new BindingSource(components);
            BuadrateSelect = new ComboBox();
            DataBitSelect = new ComboBox();
            StopBitSelect = new ComboBox();
            CheckBitSelect = new ComboBox();
            OpenSerial = new Button();
            TextBoxPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)serialPortBindingSource).BeginInit();
            TextBoxPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ReceiveBox
            // 
            ReceiveBox.BackColor = Color.FromArgb(199, 199, 199);
            ReceiveBox.Dock = DockStyle.Fill;
            ReceiveBox.Location = new Point(0, 0);
            ReceiveBox.Multiline = true;
            ReceiveBox.Name = "ReceiveBox";
            ReceiveBox.ScrollBars = ScrollBars.Vertical;
            ReceiveBox.Size = new Size(450, 200);
            ReceiveBox.TabIndex = 0;
            ReceiveBox.TextChanged += ReceiveBox_TextChanged;
            // 
            // ComPortName
            // 
            ComPortName.Location = new Point(12, 220);
            ComPortName.Name = "ComPortName";
            ComPortName.Size = new Size(50, 20);
            ComPortName.TabIndex = 1;
            ComPortName.Text = "串口号";
            ComPortName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BuadrateName
            // 
            BuadrateName.Location = new Point(12, 250);
            BuadrateName.Name = "BuadrateName";
            BuadrateName.Size = new Size(50, 20);
            BuadrateName.TabIndex = 2;
            BuadrateName.Text = "波特率";
            BuadrateName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateBitsName
            // 
            DateBitsName.Location = new Point(12, 280);
            DateBitsName.Name = "DateBitsName";
            DateBitsName.Size = new Size(50, 20);
            DateBitsName.TabIndex = 3;
            DateBitsName.Text = "数据位";
            DateBitsName.TextAlign = ContentAlignment.MiddleCenter;
            DateBitsName.Click += DateBitsName_Click;
            // 
            // CheckBitName
            // 
            CheckBitName.Location = new Point(12, 340);
            CheckBitName.Name = "CheckBitName";
            CheckBitName.Size = new Size(50, 20);
            CheckBitName.TabIndex = 4;
            CheckBitName.Text = "校验";
            CheckBitName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StopBitName
            // 
            StopBitName.Location = new Point(12, 310);
            StopBitName.Name = "StopBitName";
            StopBitName.Size = new Size(50, 20);
            StopBitName.TabIndex = 5;
            StopBitName.Text = "停止位";
            StopBitName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComPortSelect
            // 
            ComPortSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ComPortSelect.FormattingEnabled = true;
            ComPortSelect.Location = new Point(70, 217);
            ComPortSelect.Name = "ComPortSelect";
            ComPortSelect.Size = new Size(100, 25);
            ComPortSelect.TabIndex = 6;
            ComPortSelect.DropDown += ComPortSelect_SelectedIndexChanged;
            ComPortSelect.SelectedIndexChanged += ComPortSelect_SelectedIndexChanged;
            // 
            // serialPortBindingSource
            // 
            serialPortBindingSource.DataSource = typeof(System.IO.Ports.SerialPort);
            // 
            // BuadrateSelect
            // 
            BuadrateSelect.Cursor = Cursors.Hand;
            BuadrateSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            BuadrateSelect.FormattingEnabled = true;
            BuadrateSelect.Items.AddRange(new object[] { "9600", "38400", "115200" });
            BuadrateSelect.Location = new Point(70, 247);
            BuadrateSelect.Name = "BuadrateSelect";
            BuadrateSelect.Size = new Size(100, 25);
            BuadrateSelect.TabIndex = 7;
            BuadrateSelect.DropDown += BuadrateSelect_DropDown;
            BuadrateSelect.SelectedIndexChanged += BuadrateSelect_SelectedIndexChanged;
            // 
            // DataBitSelect
            // 
            DataBitSelect.FormattingEnabled = true;
            DataBitSelect.Location = new Point(70, 277);
            DataBitSelect.Name = "DataBitSelect";
            DataBitSelect.Size = new Size(100, 25);
            DataBitSelect.TabIndex = 8;
            DataBitSelect.SelectedIndexChanged += DataBitSelect_SelectedIndexChanged;
            // 
            // StopBitSelect
            // 
            StopBitSelect.FormattingEnabled = true;
            StopBitSelect.Location = new Point(70, 307);
            StopBitSelect.Name = "StopBitSelect";
            StopBitSelect.Size = new Size(100, 25);
            StopBitSelect.TabIndex = 9;
            // 
            // CheckBitSelect
            // 
            CheckBitSelect.FormattingEnabled = true;
            CheckBitSelect.Location = new Point(70, 337);
            CheckBitSelect.Name = "CheckBitSelect";
            CheckBitSelect.Size = new Size(100, 25);
            CheckBitSelect.TabIndex = 10;
            // 
            // OpenSerial
            // 
            OpenSerial.Location = new Point(180, 217);
            OpenSerial.Name = "OpenSerial";
            OpenSerial.Size = new Size(50, 25);
            OpenSerial.TabIndex = 11;
            OpenSerial.Text = "open";
            OpenSerial.UseMnemonic = false;
            OpenSerial.UseVisualStyleBackColor = true;
            OpenSerial.Click += OpenSerial_Click;
            // 
            // TextBoxPanel
            // 
            TextBoxPanel.AutoScroll = true;
            TextBoxPanel.Controls.Add(ReceiveBox);
            TextBoxPanel.Location = new Point(12, 12);
            TextBoxPanel.Margin = new Padding(0);
            TextBoxPanel.Name = "TextBoxPanel";
            TextBoxPanel.Size = new Size(450, 200);
            TextBoxPanel.TabIndex = 12;
            TextBoxPanel.Paint += TextBoxPanel_Paint;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(TextBoxPanel);
            Controls.Add(OpenSerial);
            Controls.Add(CheckBitSelect);
            Controls.Add(StopBitSelect);
            Controls.Add(DataBitSelect);
            Controls.Add(BuadrateSelect);
            Controls.Add(ComPortSelect);
            Controls.Add(StopBitName);
            Controls.Add(CheckBitName);
            Controls.Add(DateBitsName);
            Controls.Add(BuadrateName);
            Controls.Add(ComPortName);
            Name = "index";
            Text = "串口助手";
            Load += index_Load;
            ((System.ComponentModel.ISupportInitialize)serialPortBindingSource).EndInit();
            TextBoxPanel.ResumeLayout(false);
            TextBoxPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox ReceiveBox;
        private Label ComPortName;
        private Label BuadrateName;
        private Label DateBitsName;
        private Label CheckBitName;
        private Label StopBitName;
        private ComboBox ComPortSelect;
        private ComboBox BuadrateSelect;
        private ComboBox DataBitSelect;
        private ComboBox StopBitSelect;
        private ComboBox CheckBitSelect;
        private Button OpenSerial;
        private Panel TextBoxPanel;
        private BindingSource serialPortBindingSource;
    }
}