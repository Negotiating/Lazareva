using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Course_work
{
	public class Information
	{
		private int index_;
		private string Lastname_;
		private string Name_;
		private string Midname_;
		private DateTime DateOfBirth_;
		private string passport_;
		private DateTime DateOfEmployment_;
		private string position_;
		private bool actuality_;
		private DateTime DateOfDismissal_;
		private string reasons_;
		public int index
		{
			get { return index_; }
			set { index_ = value; }
		}
		public string Lastname
		{
			get { return Lastname_; }
			set { Lastname_ = value; }
		}
		public string Name
		{
			get { return Name_; }
			set { Name_ = value; }
		}
		public string Midname
		{
			get { return Midname_; }
			set { Midname_ = value; }
		}
		public DateTime DateOfBirth
		{
			get { return DateOfBirth_; }
			set { DateOfBirth_ = value; }
		}
		public string passport
		{
			get { return passport_; }
			set { passport_ = value; }
		}
		public DateTime DateOfEmployment
		{
			get { return DateOfEmployment_; }
			set { DateOfEmployment_ = value; }
		}
		public string position
		{
			get { return position_; }
			set { position_ = value; }
		}
		public bool actuality
		{
			get { return actuality_; }
			set { actuality_ = value; }
		}
		public DateTime DateOfDismissal
		{
			get { return DateOfDismissal_; }
			set { DateOfDismissal_ = value; }
		}
		public string reasons
		{
			get { return reasons_; }
			set { reasons_ = value; }
		}
		public Information(){}
		public void ToInformation(DataGridViewRow row)
		{
			this.index = Convert.ToInt32(row.Cells["Index"].Value);
			this.Name = row.Cells["Name_"].Value.ToString();
			this.Lastname = row.Cells["Lastname"].Value.ToString();
			this.Midname = row.Cells["Midname"].Value.ToString();
			this.DateOfBirth = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
			this.passport = row.Cells["Documents"].Value.ToString();
			this.DateOfEmployment = Convert.ToDateTime(row.Cells["DateOfEmployment"].Value);
			this.position = row.Cells["Position"].Value.ToString();
			this.actuality = Convert.ToBoolean(row.Cells["Actuality"].Value);
			if (!this.actuality)
			{
				this.DateOfDismissal = Convert.ToDateTime(row.Cells["DateOfDismissal"].Value);
				this.reasons = row.Cells["Reason"].Value.ToString();
			}
		}
	}
}
