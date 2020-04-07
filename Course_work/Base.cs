using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace Course_work
{
	public static class Base
	{
		public static void data_recover(DataGridView a, List<Information> l)//запись из БД в List
		{
			foreach (DataGridViewRow row in a.Rows)
			{
				Information buf = new Information();
				buf.ToInformation(row);
				l.Add(buf);
			}
		}
		public static void edit (List<TextBox> list, CheckBox ch, DataGridViewRow row)//редактирование
		{
			char lit = list[0].Text[0];
			list[0].Text = list[0].Text.Insert(0, lit.ToString().ToUpper()).Remove(1, 1);
			row.Cells["Lastname"].Value = list[0].Text;
			lit = list[1].Text[0];
			list[1].Text = list[1].Text.Insert(0, lit.ToString().ToUpper()).Remove(1, 1);
			row.Cells["Name_"].Value = list[1].Text;
			lit = list[2].Text[0];
			list[2].Text = list[2].Text.Insert(0, lit.ToString().ToUpper()).Remove(1, 1);
			row.Cells["Midname"].Value = list[2].Text;
			row.Cells["DateOfBirth"].Value = list[3].Text;
			row.Cells["Documents"].Value = list[4].Text;
			row.Cells["DateOfEmployment"].Value = list[5].Text;
			row.Cells["Position"].Value = list[6].Text;
			row.Cells["Actuality"].Value = Convert.ToBoolean(ch.Checked);
			if (!Convert.ToBoolean(ch.Checked))
			{
				row.Cells["DateOfDismissal"].Value = list[7].Text;
				row.Cells["Reason"].Value = list[8].Text;
			}
		}
		public static void add(List<TextBox> list, CheckBox ch, DataRow row)//добавление
		{
			char lit = list[0].Text[0];
			list[0].Text = list[0].Text.Insert(0, lit.ToString().ToUpper()).Remove(1,1);
			row["Lastname"] = list[0].Text;
			lit = list[1].Text[0];
			list[1].Text = list[1].Text.Insert(0, lit.ToString().ToUpper()).Remove(1, 1);
			row["Name_"] = list[1].Text;
			lit = list[2].Text[0];
			list[2].Text = list[2].Text.Insert(0, lit.ToString().ToUpper()).Remove(1, 1);
			row["Midname"] = list[2].Text;
			row["DateOfBirth"] = list[3].Text;
			row["Documents"] = list[4].Text;
			row["DateOfEmployment"] = list[5].Text;
			row["Position"] = list[6].Text;
			row["Actuality"] = Convert.ToBoolean(ch.Checked);
			if (!Convert.ToBoolean(ch.Checked))
			{
				row["DateOfDismissal"] = list[7].Text;
				row["Reason"] = list[8].Text;
			}
		}
		public static void data_update(DataGridView a, List<Information> l)//Обновление данных в List
		{
			
			l.Clear();
			foreach(DataGridViewRow row in a.Rows)
			{
				Information buf = new Information();
				buf.ToInformation(row);
				l.Add(buf);
			}
		}
		public static void position_delete(DataGridView a, List<Information> l)//Удаление из БД
		{
			foreach (DataGridViewRow row in a.SelectedRows)
			{
				a.Rows.Remove(row);
			}
			Base.data_update(a, l);
		}
		public static List<Information> find_person_LastName(List<Information> l, string s)//Поиск по фамилии
		{
			List<Information> find = new List<Information>();
			foreach (Information person in l)
			{
				if (person.Lastname.ToLower().Contains(s.ToLower()))
				{
					find.Add(person);
				}
			}
			return find;
		}
		public static List<Information> find_person_position(List<Information> l, string s)//Поиск по должности
		{
			List<Information> find = new List<Information>();
			foreach (Information person in l)
			{
				if (person.position.ToLower().Contains(s.ToLower()))
				{
					find.Add(person);
				}
			}
			return find;
		}
		public static List<Information> find_person_actuality(List<Information> l, bool des)//поиск уволеных/неуволеных сотрудников
		{
			List<Information> find = new List<Information>();
			foreach (Information person in l)
			{
				if (person.actuality==des)
				{
					find.Add(person);
				}
			}
			return find;
		}
		public static void Show(List<TextBox> f, DataGridViewRow row)
		{
			f[0].Text = row.Cells["Lastname"].Value.ToString();
			f[1].Text = row.Cells["Name_"].Value.ToString();
			f[2].Text = row.Cells["Midname"].Value.ToString();
			f[3].Text = row.Cells["DateOfBirth"].Value.ToString();
			f[4].Text = row.Cells["Documents"].Value.ToString();
			f[5].Text = row.Cells["DateOfEmployment"].Value.ToString();
			f[6].Text = row.Cells["Position"].Value.ToString();
			if (Convert.ToBoolean(row.Cells["Actuality"].Value) == true)
			{
				f[7].Text = "Сотрудник не уволен";
				f[8].Text = "Сотрудник не уволен";
			}
			if (Convert.ToBoolean(row.Cells["Actuality"].Value) == false)
			{
				f[7].Text = row.Cells["DateOfDismissal"].Value.ToString();
				f[8].Text = row.Cells["Reason"].Value.ToString();
			}
		}
		public static void Show_Find(List<TextBox> f, DataGridViewRow row)
		{
			f[0].Text = row.Cells["Lastname"].Value.ToString();
			f[1].Text = row.Cells["Name"].Value.ToString();
			f[2].Text = row.Cells["Midname"].Value.ToString();
			f[3].Text = row.Cells["DateOfBirth"].Value.ToString();
			f[4].Text = row.Cells["passport"].Value.ToString();
			f[5].Text = row.Cells["DateOfEmployment"].Value.ToString();
			f[6].Text = row.Cells["position"].Value.ToString();
			if (Convert.ToBoolean(row.Cells["actuality"].Value) == true)
			{
				f[7].Text = "Сотрудник не уволен";
				f[8].Text = "Сотрудник не уволен";
			}
			if (Convert.ToBoolean(row.Cells["Actuality"].Value) == false)
			{
				f[7].Text = row.Cells["DateOfDismissal"].Value.ToString();
				f[8].Text = row.Cells["reasons"].Value.ToString();
			}
		}
	}
}
