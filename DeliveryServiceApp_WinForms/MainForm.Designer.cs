namespace DeliveryServiceApp_WinForms
{
    partial class MainForm
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
            comboBoxAreaOfTheCity = new ComboBox();
            dateTimeTimeOfTheFirstDelivery = new DateTimePicker();
            buttonFilter = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxLogFilePath = new TextBox();
            textBoxResultFilePath = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxOrdersFilePath = new TextBox();
            label6 = new Label();
            textBoxDeliveryCompletionPeriod = new TextBox();
            label3 = new Label();
            checkBoxRegister = new CheckBox();
            SuspendLayout();
            // 
            // comboBoxAreaOfTheCity
            // 
            comboBoxAreaOfTheCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAreaOfTheCity.FormattingEnabled = true;
            comboBoxAreaOfTheCity.Location = new Point(12, 27);
            comboBoxAreaOfTheCity.Name = "comboBoxAreaOfTheCity";
            comboBoxAreaOfTheCity.Size = new Size(129, 23);
            comboBoxAreaOfTheCity.TabIndex = 0;
            // 
            // dateTimeTimeOfTheFirstDelivery
            // 
            dateTimeTimeOfTheFirstDelivery.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimeTimeOfTheFirstDelivery.Format = DateTimePickerFormat.Custom;
            dateTimeTimeOfTheFirstDelivery.Location = new Point(224, 27);
            dateTimeTimeOfTheFirstDelivery.Name = "dateTimeTimeOfTheFirstDelivery";
            dateTimeTimeOfTheFirstDelivery.Size = new Size(200, 23);
            dateTimeTimeOfTheFirstDelivery.TabIndex = 1;
            dateTimeTimeOfTheFirstDelivery.Value = new DateTime(2024, 10, 23, 10, 0, 0, 0);
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(162, 262);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(90, 23);
            buttonFilter.TabIndex = 2;
            buttonFilter.Text = "Фильтровать\r\n";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 3;
            label1.Text = "Район города\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 9);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 4;
            label2.Text = "Время первой доставки\r\n";
            // 
            // textBoxLogFilePath
            // 
            textBoxLogFilePath.Location = new Point(12, 121);
            textBoxLogFilePath.Name = "textBoxLogFilePath";
            textBoxLogFilePath.Size = new Size(412, 23);
            textBoxLogFilePath.TabIndex = 5;
            textBoxLogFilePath.Text = "log.txt";
            // 
            // textBoxResultFilePath
            // 
            textBoxResultFilePath.Location = new Point(12, 174);
            textBoxResultFilePath.Name = "textBoxResultFilePath";
            textBoxResultFilePath.Size = new Size(412, 23);
            textBoxResultFilePath.TabIndex = 6;
            textBoxResultFilePath.Text = "result.txt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 7;
            label4.Text = "Путь к файлу с логами";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 156);
            label5.Name = "label5";
            label5.Size = new Size(187, 15);
            label5.TabIndex = 8;
            label5.Text = "Путь к результирующему файлу\r\n";
            // 
            // textBoxOrdersFilePath
            // 
            textBoxOrdersFilePath.Location = new Point(12, 227);
            textBoxOrdersFilePath.Name = "textBoxOrdersFilePath";
            textBoxOrdersFilePath.Size = new Size(412, 23);
            textBoxOrdersFilePath.TabIndex = 9;
            textBoxOrdersFilePath.Text = "orders.txt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 209);
            label6.Name = "label6";
            label6.Size = new Size(203, 15);
            label6.TabIndex = 10;
            label6.Text = "Путь к файлу с входными данными";
            // 
            // textBoxDeliveryCompletionPeriod
            // 
            textBoxDeliveryCompletionPeriod.Location = new Point(388, 62);
            textBoxDeliveryCompletionPeriod.MaxLength = 3;
            textBoxDeliveryCompletionPeriod.Name = "textBoxDeliveryCompletionPeriod";
            textBoxDeliveryCompletionPeriod.Size = new Size(36, 23);
            textBoxDeliveryCompletionPeriod.TabIndex = 11;
            textBoxDeliveryCompletionPeriod.Text = "30";
            textBoxDeliveryCompletionPeriod.TextAlign = HorizontalAlignment.Right;
            textBoxDeliveryCompletionPeriod.KeyPress += textBoxDeliveryCompletionPeriod_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 62);
            label3.Name = "label3";
            label3.Size = new Size(164, 30);
            label3.TabIndex = 12;
            label3.Text = "Период окончания доставки\r\n(в минутах)";
            // 
            // checkBoxRegister
            // 
            checkBoxRegister.AutoSize = true;
            checkBoxRegister.Checked = true;
            checkBoxRegister.CheckState = CheckState.Checked;
            checkBoxRegister.Location = new Point(12, 61);
            checkBoxRegister.Name = "checkBoxRegister";
            checkBoxRegister.RightToLeft = RightToLeft.Yes;
            checkBoxRegister.Size = new Size(130, 19);
            checkBoxRegister.TabIndex = 14;
            checkBoxRegister.Text = "Учитывать регистр";
            checkBoxRegister.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 302);
            Controls.Add(checkBoxRegister);
            Controls.Add(label3);
            Controls.Add(textBoxDeliveryCompletionPeriod);
            Controls.Add(label6);
            Controls.Add(textBoxOrdersFilePath);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxResultFilePath);
            Controls.Add(textBoxLogFilePath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonFilter);
            Controls.Add(dateTimeTimeOfTheFirstDelivery);
            Controls.Add(comboBoxAreaOfTheCity);
            Name = "MainForm";
            Text = "DeliveryServiceApp";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAreaOfTheCity;
        private DateTimePicker dateTimeTimeOfTheFirstDelivery;
        private Button buttonFilter;
        private Label label1;
        private Label label2;
        private TextBox textBoxLogFilePath;
        private TextBox textBoxResultFilePath;
        private Label label4;
        private Label label5;
        private TextBox textBoxOrdersFilePath;
        private Label label6;
        private TextBox textBoxDeliveryCompletionPeriod;
        private Label label3;
        private CheckBox checkBoxRegister;
    }
}
