using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartIS
{
	public partial class FormMain : Form
	{
		private static string filePath = "parts.csv";
		private Writer writer = new Writer(filePath);
		private int count;
		private int selected;
		private bool viewInitialized = false;

		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			dateTimePickerReceived.Value = DateTime.Today;
			dateTimePickerSent.Value = DateTime.Today;

			try
			{
				count = Convert.ToInt32(File.ReadAllLines(filePath).Last().Split(',')[0]) + 1;
			}
			catch (Exception)
			{
				count = 1;
			}
		}

		#region change tab
		#region input controls
		private void checkBoxReceived_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxReceived.Checked)
			{
				dateTimePickerReceived.Enabled = true;
			}
			else
			{
				dateTimePickerReceived.Enabled = false;
			}
		}

		private void checkBoxSent_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxSent.Checked)
			{
				dateTimePickerSent.Enabled = true;
			}
			else
			{
				dateTimePickerSent.Enabled = false;
			}
		}

		private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
				&& (e.KeyChar != '-') && (e.KeyChar != '(') && (e.KeyChar != ')')
				&& (e.KeyChar != '+') && (e.KeyChar != ' '))
			{
				e.Handled = true;
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			var tempFile = Path.GetTempFileName();
			var linesToKeep = File.ReadLines(filePath).Where(l => l.Split(',')[0] != selected.ToString());

			File.WriteAllLines(tempFile, linesToKeep, Encoding.UTF8);

			File.Delete(filePath);
			File.Move(tempFile, filePath);

			textBoxName.Text = "";
			textBoxPhone.Text = "";
			textBoxPartName.Text = "";
			numericUpDownAmount.Value = 1;
			checkBoxReceived.Checked = true;
			checkBoxSent.Checked = false;
			dateTimePickerReceived.Value = DateTime.Now;
			dateTimePickerSent.Value = DateTime.Now;

			tabControl.SelectedIndex = 1;
			buttonDelete.Visible = false;
			buttonUpdate.Visible = false;

			try
			{
				count = Convert.ToInt32(File.ReadAllLines(filePath).Last().Split(',')[0]) + 1;
			}
			catch (Exception)
			{
				count = 1;
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var tempFile = Path.GetTempFileName();
			var linesToKeep = File.ReadLines(filePath).Where(l => l.Split(',')[0] != selected.ToString());

			File.WriteAllLines(tempFile, linesToKeep, Encoding.UTF8);

			File.Delete(filePath);
			File.Move(tempFile, filePath);

			try
			{
				count = Convert.ToInt32(File.ReadAllLines(filePath).Last().Split(',')[0]) + 1;
			}
			catch (Exception)
			{
				count = 1;
			}

			writer.Append(new Part
			{
				Count = count,
				Name = textBoxName.Text,
				Phone = textBoxPhone.Text,
				PartName = textBoxPartName.Text,
				Amount = (int?)numericUpDownAmount.Value,
				Received = checkBoxReceived.Checked ? dateTimePickerReceived.Value : (DateTime?)null,
				Sent = checkBoxSent.Checked ? dateTimePickerSent.Value : (DateTime?)null
			});

			tabControl.SelectedIndex = 1;
			buttonDelete.Visible = false;
			buttonUpdate.Visible = false;

			textBoxName.Text = "";
			textBoxPhone.Text = "";
			textBoxPartName.Text = "";
			numericUpDownAmount.Value = 1;
			checkBoxReceived.Checked = true;
			checkBoxSent.Checked = false;
			dateTimePickerReceived.Value = DateTime.Now;
			dateTimePickerSent.Value = DateTime.Now;
			tabControl.SelectedIndex = 1;

			count++;
		}

		private void buttonEnter_Click(object sender, EventArgs e)
		{
			writer.Append(new Part
			{
				Count = count,
				Name = textBoxName.Text,
				Phone = textBoxPhone.Text,
				PartName = textBoxPartName.Text,
				Amount = (int?)numericUpDownAmount.Value,
				Received = checkBoxReceived.Checked ? dateTimePickerReceived.Value : (DateTime?)null,
				Sent = checkBoxSent.Checked ? dateTimePickerSent.Value : (DateTime?)null
			});

			tabControl.SelectedIndex = 1;

			textBoxName.Text = "";
			textBoxPhone.Text = "";
			textBoxPartName.Text = "";
			numericUpDownAmount.Value = 1;
			checkBoxReceived.Checked = true;
			checkBoxSent.Checked = false;
			dateTimePickerReceived.Value = DateTime.Now;
			dateTimePickerSent.Value = DateTime.Now;

			buttonDelete.Visible = false;
			buttonUpdate.Visible = false;

			count++;
		}
		#endregion


		#endregion

		#region view tab

		#region view controls
		private void listView_DoubleClick(object sender, EventArgs e)
		{
			if (listView.SelectedIndices[0] >= 0)
			{
				selected = Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text);

				textBoxName.Text = listView.SelectedItems[0].SubItems[1].Text;
				textBoxPhone.Text = listView.SelectedItems[0].SubItems[2].Text;
				textBoxPartName.Text = listView.SelectedItems[0].SubItems[3].Text;
				numericUpDownAmount.Value = Convert.ToInt32(listView.SelectedItems[0].SubItems[4].Text);

				string value = listView.SelectedItems[0].SubItems[5].Text;
				if (String.IsNullOrEmpty(value))
				{
					dateTimePickerSent.Value = DateTime.Now;
					checkBoxReceived.Checked = false;
				}
				else
				{
					dateTimePickerReceived.Value = Convert.ToDateTime(value);
					checkBoxReceived.Checked = true;
				}

				value = listView.SelectedItems[0].SubItems[6].Text;
				if (String.IsNullOrEmpty(value))
				{
					dateTimePickerSent.Value = DateTime.Now;
					checkBoxSent.Checked = false;
				}
				else
				{
					dateTimePickerSent.Value = Convert.ToDateTime(value);
					checkBoxSent.Checked = true;
				}

				buttonDelete.Visible = true;
				buttonUpdate.Visible = true;

				tabControl.SelectedIndex = 0;
			}
		}
		#endregion

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl.SelectedIndex == 1 && !viewInitialized)
			{
				viewInitialized = true;

				ListInitialize();
			}

			listView.Items.Clear();
			ListPopulate();
		}

		private void ListInitialize()
		{
			listView.Columns.Add("№");
			listView.Columns.Add("Фамилия");
			listView.Columns.Add("Телефон");
			listView.Columns.Add("Название");
			listView.Columns.Add("Количество");
			listView.Columns.Add("Пришла");
			listView.Columns.Add("Выдали");

			listView.Dock = DockStyle.Fill;
			listView.View = View.Details;

			listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

			listView.FullRowSelect = true;
			listView.MultiSelect = false;
		}

		private void ListPopulate()
		{
			foreach (Part part in writer.Read())
			{
				listView.Items.Add(new ListViewItem(new string[] {
					part.Count.ToString() ?? String.Empty,
					part.Name ?? String.Empty,
					part.Phone ?? String.Empty,
					part.PartName ?? String.Empty,
					part.Amount?.ToString() ?? String.Empty,
					part.Received?.ToString("g") ?? String.Empty,
					part.Sent?.ToString("g") ?? String.Empty
				}));
			}
			listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		#endregion
	}
}
