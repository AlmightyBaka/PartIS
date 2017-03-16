namespace PartIS
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageAdd = new System.Windows.Forms.TabPage();
			this.buttonEnter = new System.Windows.Forms.Button();
			this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
			this.checkBoxSent = new System.Windows.Forms.CheckBox();
			this.checkBoxReceived = new System.Windows.Forms.CheckBox();
			this.dateTimePickerSent = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerReceived = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPartName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPageView = new System.Windows.Forms.TabPage();
			this.listView = new System.Windows.Forms.ListView();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPageAdd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
			this.tabPageView.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageAdd);
			this.tabControl.Controls.Add(this.tabPageView);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl.Name = "tabControl";
			this.tabControl.Padding = new System.Drawing.Point(0, 0);
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(495, 231);
			this.tabControl.TabIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabPageAdd
			// 
			this.tabPageAdd.Controls.Add(this.buttonUpdate);
			this.tabPageAdd.Controls.Add(this.buttonDelete);
			this.tabPageAdd.Controls.Add(this.buttonEnter);
			this.tabPageAdd.Controls.Add(this.numericUpDownAmount);
			this.tabPageAdd.Controls.Add(this.checkBoxSent);
			this.tabPageAdd.Controls.Add(this.checkBoxReceived);
			this.tabPageAdd.Controls.Add(this.dateTimePickerSent);
			this.tabPageAdd.Controls.Add(this.dateTimePickerReceived);
			this.tabPageAdd.Controls.Add(this.label4);
			this.tabPageAdd.Controls.Add(this.label5);
			this.tabPageAdd.Controls.Add(this.label6);
			this.tabPageAdd.Controls.Add(this.textBoxPartName);
			this.tabPageAdd.Controls.Add(this.label3);
			this.tabPageAdd.Controls.Add(this.textBoxPhone);
			this.tabPageAdd.Controls.Add(this.label2);
			this.tabPageAdd.Controls.Add(this.textBoxName);
			this.tabPageAdd.Controls.Add(this.label1);
			this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
			this.tabPageAdd.Name = "tabPageAdd";
			this.tabPageAdd.Size = new System.Drawing.Size(487, 205);
			this.tabPageAdd.TabIndex = 0;
			this.tabPageAdd.Text = "Ввод";
			this.tabPageAdd.UseVisualStyleBackColor = true;
			// 
			// buttonEnter
			// 
			this.buttonEnter.Location = new System.Drawing.Point(8, 172);
			this.buttonEnter.Name = "buttonEnter";
			this.buttonEnter.Size = new System.Drawing.Size(75, 23);
			this.buttonEnter.TabIndex = 12;
			this.buttonEnter.Text = "Добавить";
			this.buttonEnter.UseVisualStyleBackColor = true;
			this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
			// 
			// numericUpDownAmount
			// 
			this.numericUpDownAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownAmount.Location = new System.Drawing.Point(83, 94);
			this.numericUpDownAmount.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
			this.numericUpDownAmount.Name = "numericUpDownAmount";
			this.numericUpDownAmount.Size = new System.Drawing.Size(396, 20);
			this.numericUpDownAmount.TabIndex = 4;
			this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// checkBoxSent
			// 
			this.checkBoxSent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSent.AutoSize = true;
			this.checkBoxSent.Location = new System.Drawing.Point(83, 149);
			this.checkBoxSent.Name = "checkBoxSent";
			this.checkBoxSent.Size = new System.Drawing.Size(15, 14);
			this.checkBoxSent.TabIndex = 7;
			this.checkBoxSent.UseVisualStyleBackColor = true;
			this.checkBoxSent.CheckedChanged += new System.EventHandler(this.checkBoxSent_CheckedChanged);
			// 
			// checkBoxReceived
			// 
			this.checkBoxReceived.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxReceived.AutoSize = true;
			this.checkBoxReceived.Checked = true;
			this.checkBoxReceived.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxReceived.Location = new System.Drawing.Point(83, 123);
			this.checkBoxReceived.Name = "checkBoxReceived";
			this.checkBoxReceived.Size = new System.Drawing.Size(15, 14);
			this.checkBoxReceived.TabIndex = 5;
			this.checkBoxReceived.UseVisualStyleBackColor = true;
			this.checkBoxReceived.CheckedChanged += new System.EventHandler(this.checkBoxReceived_CheckedChanged);
			// 
			// dateTimePickerSent
			// 
			this.dateTimePickerSent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerSent.Enabled = false;
			this.dateTimePickerSent.Location = new System.Drawing.Point(104, 146);
			this.dateTimePickerSent.Name = "dateTimePickerSent";
			this.dateTimePickerSent.Size = new System.Drawing.Size(375, 20);
			this.dateTimePickerSent.TabIndex = 8;
			this.dateTimePickerSent.Value = new System.DateTime(2016, 5, 22, 14, 56, 24, 0);
			// 
			// dateTimePickerReceived
			// 
			this.dateTimePickerReceived.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerReceived.Location = new System.Drawing.Point(104, 120);
			this.dateTimePickerReceived.Name = "dateTimePickerReceived";
			this.dateTimePickerReceived.Size = new System.Drawing.Size(375, 20);
			this.dateTimePickerReceived.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Выдали:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Пришла:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Количество:";
			// 
			// textBoxPartName
			// 
			this.textBoxPartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPartName.Location = new System.Drawing.Point(83, 68);
			this.textBoxPartName.Name = "textBoxPartName";
			this.textBoxPartName.Size = new System.Drawing.Size(396, 20);
			this.textBoxPartName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Название:";
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPhone.Location = new System.Drawing.Point(83, 42);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(396, 20);
			this.textBoxPhone.TabIndex = 2;
			this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Телефон:";
			// 
			// textBoxName
			// 
			this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxName.Location = new System.Drawing.Point(83, 16);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(396, 20);
			this.textBoxName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Фамилия:";
			// 
			// tabPageView
			// 
			this.tabPageView.Controls.Add(this.listView);
			this.tabPageView.Location = new System.Drawing.Point(4, 22);
			this.tabPageView.Name = "tabPageView";
			this.tabPageView.Size = new System.Drawing.Size(487, 205);
			this.tabPageView.TabIndex = 1;
			this.tabPageView.Text = "Обзор";
			this.tabPageView.UseVisualStyleBackColor = true;
			// 
			// listView
			// 
			this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView.Location = new System.Drawing.Point(0, 0);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(487, 205);
			this.listView.TabIndex = 0;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(170, 172);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 13;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(89, 172);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Text = "Обновить";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Visible = false;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 231);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(320, 270);
			this.Name = "FormMain";
			this.Text = "Склад";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPageAdd.ResumeLayout(false);
			this.tabPageAdd.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
			this.tabPageView.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageAdd;
		private System.Windows.Forms.TabPage tabPageView;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxPartName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePickerReceived;
		private System.Windows.Forms.DateTimePicker dateTimePickerSent;
		private System.Windows.Forms.NumericUpDown numericUpDownAmount;
		private System.Windows.Forms.CheckBox checkBoxSent;
		private System.Windows.Forms.CheckBox checkBoxReceived;
		private System.Windows.Forms.Button buttonEnter;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
	}
}

