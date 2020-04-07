using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;


namespace Course_work
{
	public partial class Main_form : Form
	{
		public List<Information> Objects = new List<Information>();
		public List<TextBox> List_Text_Box = new List<TextBox>();
		
		public Main_form()
		{
			InitializeComponent();
			List_Text_Box.Add(LN);
			List_Text_Box.Add(N);
			List_Text_Box.Add(MN);
			List_Text_Box.Add(DOB);
			List_Text_Box.Add(Pasp);
			List_Text_Box.Add(DOE);
			List_Text_Box.Add(pos);
			List_Text_Box.Add(DOD);
			List_Text_Box.Add(Reas);
		}
		private void Main_form_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "course_workDataSet.Info". При необходимости она может быть перемещена или удалена.
			this.info1TableAdapter.Fill(this.course_workDataSet.Info1);
			course_workDataSet.Tables[0].AcceptChanges();
			Base.data_recover(this.Data_Person, this.Objects);
			Base.data_update(this.Data_Person, this.Objects);
			
			ToolTip t = new ToolTip();
			t.SetToolTip(add_button, "Добавить запись");
			t.SetToolTip(edit_button, "Редактировать/добавить");
			t.SetToolTip(OK_button, "Сохранить изменения");
			t.SetToolTip(Cancel_button, "Отменить изменения");
			t.SetToolTip(DOB, "Формат даты: dd.mm.yyyy");
			t.SetToolTip(DOE, "Формат даты: dd.mm.yyyy");
			t.SetToolTip(DOD, "Формат даты: dd.mm.yyyy");
		}
		
		private void SaveButton_Click(object sender, EventArgs e)//сохранение изменений
		{
			DialogResult dr = MessageBox.Show("Сохранить изменения?",
				"сохранение",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.OK)
			{
				this.Validate();
				this.info1BindingSource.EndEdit();
				this.info1TableAdapter.Update(this.course_workDataSet.Info1);
				course_workDataSet.Tables[0].AcceptChanges();
				Base.data_update(this.Data_Person, this.Objects);
				MessageBox.Show("Изменения сохранены!");
			}
		}
		private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dr = MessageBox.Show("Сохранить?",
				"сохранение",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.OK)
			{
				this.Validate();
				this.info1BindingSource.EndEdit();
				this.info1TableAdapter.Update(this.course_workDataSet.Info1);
				course_workDataSet.Tables[0].AcceptChanges();
				Base.data_update(this.Data_Person, this.Objects);
			}
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach (DataGridViewRow row in Data_Person.Rows)
			{
				for (int i=0; i < Data_Person.ColumnCount; i++)
				{
					if (row.Cells[i].Selected == true) row.Selected = true;
				}
			}
		}
		private void Delete_button_Click(object sender, EventArgs e)//удаление
		{
			
				DialogResult dr = MessageBox.Show("Удалить запись?",
				"Удаление",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.OK)
			{
				Base.position_delete(this.Data_Person, this.Objects);
				MessageBox.Show("Запись удалена!");
			} 
			
		}

		private void Search_button_Click(object sender, EventArgs e)//поиск
		{

			if (LNcb.Checked)
			{
				if (SearchBox.Text.Length == 0) SearchBox.Text = "Вы не ввели параметр для поиска";
				else
				{
					List<Information> find_pos = new List<Information>();
					find_pos = Base.find_person_LastName(this.Objects, SearchBox.Text);
					
					if (find_pos.Count == 0)
					{
						DialogResult dr = MessageBox.Show("Записи не найдены",
						"Поиск",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning,
						MessageBoxDefaultButton.Button1);
					}
					else
					{
						Find.BringToFront();
						Find.DataSource = find_pos;
					}
				}
			}
			if (Poscb.Checked)
			{
				if (SearchBox.Text.Length == 0) SearchBox.Text = "Вы не ввели параметр для поиска";
				else
				{
					List<Information> find_pos = new List<Information>();
					find_pos = Base.find_person_position(this.Objects, SearchBox.Text);
					if (find_pos.Count == 0)
					{
						DialogResult dr = MessageBox.Show("Записи не найдены",
						"Поиск",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning,
						MessageBoxDefaultButton.Button1);
					}
					else
					{
						Find.BringToFront();
						Find.DataSource = find_pos;
					}
				}
			}
			if (Actcb.Checked)
			{
				List<Information> find_pos = new List<Information>();
				find_pos = Base.find_person_actuality(this.Objects, Convert.ToBoolean(Fired.Checked));
				if (find_pos.Count == 0)
				{
					DialogResult dr = MessageBox.Show("Записи не найдены",
					"Поиск",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning,
					MessageBoxDefaultButton.Button1);
				}
				else
				{
					Find.BringToFront();
					Find.DataSource = find_pos;
				}
			}
		}
		private void LNcb_CheckedChanged(object sender, EventArgs e)
		{
			Poscb.Enabled = false;
			Actcb.Enabled = false;
			Fired.Enabled = false;
		}
		private void Poscb_CheckedChanged(object sender, EventArgs e)
		{
			LNcb.Enabled = false;
			Actcb.Enabled = false;
			Fired.Enabled = false;
		}
		private void Actcb_CheckedChanged(object sender, EventArgs e)
		{
			LNcb.Enabled = false;
			Poscb.Enabled = false;
			SearchBox.Enabled = false;
		}
		private void off_Click(object sender, EventArgs e)//"сброс" элементов управления
		{
			Poscb.Enabled = true;
			Poscb.Checked = false;
			Actcb.Enabled = true;
			Actcb.Checked = false;
			Fired.Enabled = true;
			Fired.Checked = false;
			LNcb.Enabled = true;
			LNcb.Checked = false;
			SearchBox.Enabled = true;
			Data_Person.BringToFront();
			SearchBox.Clear();
		}
		private void button_off()
		{
			OK_button.Enabled = false;
			Cancel_button.Enabled = false;
			add_button.Enabled = false;
			LN.Enabled = false;
			N.Enabled = false;
			MN.Enabled = false;
			DOB.Enabled = false;
			pos.Enabled = false;
			Pasp.Enabled = false;
			DOD.Enabled = false;
			DOE.Enabled = false;
			Reas.Enabled = false;
			Act.Enabled = false;
		}
		private void button_on()
		{
			OK_button.Enabled = true;
			Cancel_button.Enabled = true;
			add_button.Enabled = true;
			LN.Enabled = true;
			N.Enabled = true;
			MN.Enabled = true;
			DOB.Enabled = true;
			pos.Enabled = true;
			Pasp.Enabled = true;
			DOD.Enabled = true;
			DOE.Enabled = true;
			Reas.Enabled = true;
			Act.Enabled = true;
		}
		private void Data_Person_SelectionChanged(object sender, EventArgs e)//отображение информации о выбраном сотруднике
		{
			button_off();
			foreach (DataGridViewRow row in Data_Person.SelectedRows)
			{
				Base.Show(List_Text_Box, row);
				if (Convert.ToBoolean(row.Cells["Actuality"].Value) == true) Act.Checked = true;
				if (Convert.ToBoolean(row.Cells["Actuality"].Value) == false) Act.Checked = false;
			}
			
		}
		private void edit_button_Click(object sender, EventArgs e)
		{
			button_on();
		}
		private void OK_button_Click(object sender, EventArgs e)//редактирование записи
		{
			DialogResult dr = MessageBox.Show("Изменить запись?",
			"Редактирование",
			MessageBoxButtons.OKCancel,
			MessageBoxIcon.Question,
			MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.OK)
			{
				if (LN.Text != "" && N.Text != "" && MN.Text != "" && DOB.Text != "" && pos.Text != "" && Pasp.Text != "" && DOE.Text != "")
				{
					foreach (DataGridViewRow row in Data_Person.SelectedRows)
					{
						Base.edit(List_Text_Box, Act, row);
					}
					Data_Person.Refresh();
					Base.data_update(this.Data_Person, this.Objects);
					MessageBox.Show("Изменения внесены!");
				}
				else
				{
					MessageBox.Show("Некорректный ввод! Поля пусты.",
					"Редактирование",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);
				}
			}
		}
		private void Cancel_button_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Отменить изменения?",
				"Изменение",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
			if (dr == DialogResult.OK)
			{
				foreach(DataGridViewRow row in Data_Person.SelectedRows)
				Base.Show(List_Text_Box, row);
			}
		}
		private void add_button_Click(object sender, EventArgs e)//добавление записи
		{
			if (LN.Text != "" && 
				N.Text != "" && 
				MN.Text != "" && 
				DOB.Text != "" && 
				pos.Text != "" && 
				Pasp.Text != "" && 
				DOE.Text!="")
			{
				DialogResult dr = MessageBox.Show("Добавить запись?",
				"Добавление",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2);
				if (dr == DialogResult.OK)
				{
					bool flag = false;
					for (int i=0; i < Objects.Count; i++)
					{
						if(LN.Text==Objects[i].Lastname && 
							N.Text==Objects[i].Name && 
							MN.Text==Objects[i].Midname && 
							Pasp.Text == Objects[i].passport)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						DataRow nRow = course_workDataSet.Tables[0].NewRow();
						Base.add(List_Text_Box, Act, nRow);
						course_workDataSet.Tables[0].Rows.Add(nRow);
						info1TableAdapter.Update(course_workDataSet.Info1);
						course_workDataSet.Tables[0].AcceptChanges();
						Data_Person.Refresh();
						Base.data_update(this.Data_Person, this.Objects);
						MessageBox.Show("Запись добавлена!");
						LN.Clear();
						N.Clear();
						MN.Clear();
						Pasp.Clear();
						pos.Clear();
						Reas.Clear();
					}
					if (flag)
					{
							MessageBox.Show("Такая запись уже существует!",
							"Добавление",
							MessageBoxButtons.OK,
							MessageBoxIcon.Warning,
							MessageBoxDefaultButton.Button1);
					}
				}
			}
			else
			{
				MessageBox.Show("Некорректный ввод! Поля пусты.",
				"Добавление",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information,
				MessageBoxDefaultButton.Button1);
			}

		}
		private void selected_button_Click(object sender, EventArgs e)//снятие выделение со строки в dgv о очищение tb
		{
			button_off();
			foreach (DataGridViewRow row in Data_Person.SelectedRows)
			{
				row.Selected = false;
			}
			LN.Clear();N.Clear();MN.Clear();DOB.Clear();Act.Checked = false;
			Pasp.Clear();DOE.Clear();pos.Clear();DOD.Clear();Reas.Clear(); 
		}

		private void Find_SelectionChanged(object sender, EventArgs e)//отображение выбранного сотрудника из dgv поиска
		{
			button_off();
			foreach (DataGridViewRow row in Find.SelectedRows)
			{
				Base.Show_Find(List_Text_Box, row);
				foreach(DataGridViewRow Drow in Data_Person.Rows)
				{
					if (row.Cells["Lastname"].Value.ToString() == Drow.Cells["Lastname"].Value.ToString() &&
						row.Cells["Name"].Value.ToString() == Drow.Cells["Name_"].Value.ToString() &&
						row.Cells["Midname"].Value.ToString() == Drow.Cells["Midname"].Value.ToString() &&
						row.Cells["passport"].Value.ToString() == Drow.Cells["Documents"].Value.ToString())
					{
						foreach (DataGridViewRow Drow2 in Data_Person.SelectedRows)
						{
							Drow2.Selected = false;
						}
							Drow.Selected = true;
					} 
				}
				if (Convert.ToBoolean(row.Cells["Actuality"].Value) == true) Act.Checked = true;
				if (Convert.ToBoolean(row.Cells["Actuality"].Value) == false) Act.Checked = false;
			}
			
		}
	}
}
