﻿using BUS;
using DAO;
using DTO;
using HR_Manager.Employee;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HR_Manager.DepartmentF
{
	public partial class DepartmentUserControl : UserControl
	{
		private int counter = 1;
		private int id;
		DepartmentBUS deBus;
		DTO.Department deDTO;
		List<Department> deList;
		List<EmployeeDTO> eList;
		EmployeeBUS eBus;
		EmployeeDTO eDTO;
		DataTable dtDepartment; // DataTable for Department
		DataTable dtEmployee;   // DataTable for Employee
		List<string> cb = new List<string> { "ID", "Name" };
		DataTable searchData = new DataTable();

		public DepartmentUserControl()
		{
			InitializeComponent();
			deBus = new DepartmentBUS();
			eBus = new EmployeeBUS();
			eDTO = new EmployeeDTO();
			dtDepartment = new DataTable();
			dtEmployee = new DataTable();
			dtDepartment.Columns.Add("ID");
			dtDepartment.Columns.Add("Name");
			dtDepartment.Columns.Add("Address Detail");
			dtEmployee.Columns.Add("ID");
			dtEmployee.Columns.Add("Name");
			dtEmployee.Columns.Add("Gender");
			dtEmployee.Columns.Add("Date Of Birth");
			dtEmployee.Columns.Add("Phone");
			dtEmployee.Columns.Add("Email");
			dtEmployee.Columns.Add("Image");
			dtEmployee.Columns.Add("Status");
			loadDepartment();
			dgvDepartment.Columns["ID"].Width = 60;
			dgvDepartment.Columns["Name"].Width = 200;
			dgvDepartment.Columns["Address Detail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			loadcb();
		}

		public void loadDepartment()
		{
			// Load department data from database
			deList = deBus.GetAll();
			dtDepartment.Clear();

			int stt = 1;
			foreach (Department de in deList)
			{
				DataRow row = dtDepartment.NewRow();
				row["ID"] = de.ID;
				row["Name"] = de.Name;
				row["Address Detail"] = de.Address_Detail;
				dtDepartment.Rows.Add(row);
				stt++;
			}

			dgvDepartment.DataSource = dtDepartment;
		}
		private void loadcb()
		{
			cbTimKiem.DataSource = cb;
		}
		public void loadEmployee(int id)
		{
			eList = eBus.GetAllByDepartmentId(id);
			dtEmployee.Clear();


			int stt = 1;
			foreach (EmployeeDTO e in eList)
			{
				DataRow row = dtEmployee.NewRow();
				row["ID"] = e.ID;
				row["Name"] = e.Name;
				row["Gender"] = e.Gender;
				row["Date Of Birth"] = e.Date_of_Birth.ToShortDateString();
				row["Phone"] = e.Phone;
				row["Email"] = e.Email;
				row["Image"] = e.img_path;
				row["Status"] = e.Status;

				dtEmployee.Rows.Add(row);
				stt++;
			}
			dgvEmployees.DataSource = dtEmployee;
			dgvEmployees.Columns["Date Of Birth"].Width = 180;
			dgvEmployees.Columns["ID"].Width = 60;
			dgvEmployees.Columns["Email"].Width = 180;
			dgvEmployees.Columns["Status"].Width = 180;
			dgvEmployees.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0)
				{
					id = Convert.ToInt32(dgvDepartment.Rows[e.RowIndex].Cells["ID"].Value);

					// Hiển thị danh sách nhân viên tương ứng
					loadEmployee(id);
				}
			}
			catch (Exception ex)
			{

			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			AddDepartment add = new AddDepartment(this);
			add.Show();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgvDepartment.SelectedRows.Count > 0)
			{
				int idSelected = Convert.ToInt32(dgvDepartment.SelectedRows[0].Cells["ID"].Value);
				deDTO = deBus.getById(idSelected);
				AddDepartment update = new AddDepartment(this, deDTO);
				update.Show();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvDepartment.SelectedCells.Count > 0)
			{
				DialogResult dr = MessageBox.Show("Are you sure you want to delete?", SD.tb, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					int id;
					int rowIndex = dgvDepartment.SelectedCells[0].RowIndex;
					if (int.TryParse(dgvDepartment.Rows[rowIndex].Cells["ID"].Value.ToString(), out id))
					{
						deBus.Delete(id);
						dgvDepartment.Rows.RemoveAt(rowIndex);
					}
					else
					{
						MessageBox.Show("Invalid ID!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("You have not selected any rows to delete.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			loadDepartment();
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			loadDepartment();
		}
		private DataTable SearchByUsername(DataTable dataTable, string username)
		{
			searchData = dataTable.Clone();
			// Lặp qua từng dòng trong DataTable để tìm kiếm
			foreach (DataRow row in dataTable.Rows)
			{
				string currentUsername = row["Name"].ToString();
				if (currentUsername.ToLower().Contains(username.ToLower()))
				{
					searchData.ImportRow(row);
				}
			}
			return searchData;
		}
		private DataTable SearchByID(DataTable dataTable, int id)
		{
			DataTable searchData = dataTable.Clone();
			foreach (DataRow row in dataTable.Rows)
			{
				int currentID;
				if (int.TryParse(row["ID"].ToString(), out currentID))
				{
					if (currentID == id)
					{
						searchData.ImportRow(row);
					}
				}
			}

			return searchData;
		}
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string searchValue = txtTimKiem.Text.Trim();
			DataTable searchResult = null;
			try
			{
				if (string.IsNullOrEmpty(searchValue))
				{
					MessageBox.Show("Please enter search content.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				if (cbTimKiem.SelectedValue.ToString() == "Name")
				{
					searchResult = SearchByUsername(dtDepartment, searchValue);
				}
				else if (cbTimKiem.SelectedValue.ToString() == "ID")
				{
					if (!int.TryParse(searchValue, out int searchID))
					{
						MessageBox.Show("Please enter a valid numeric ID.", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					searchResult = SearchByID(dtDepartment, Convert.ToInt32(searchValue));
				}

			}
			catch (Exception ex)
			{

			}
			// Gán kết quả tìm kiếm vào DataGridView
			dgvDepartment.DataSource = searchResult;
			dgvDepartment.Refresh();
		}

		private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btnTimKiem.PerformClick();
			}
		}
	}
}