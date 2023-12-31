﻿namespace HR_Manager.Management
{
	partial class SkillUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			label1 = new Label();
			btnSua = new Button();
			btnAdd = new Button();
			dataGridView1 = new DataGridView();
			btnLamMoi = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.SeaGreen;
			label1.Location = new Point(3, 22);
			label1.Name = "label1";
			label1.Size = new Size(385, 50);
			label1.TabIndex = 21;
			label1.Text = "Manage Skill";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnSua
			// 
			btnSua.BackColor = Color.FromArgb(1, 107, 112);
			btnSua.Cursor = Cursors.Hand;
			btnSua.FlatStyle = FlatStyle.Flat;
			btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnSua.ForeColor = Color.White;
			btnSua.Location = new Point(124, 91);
			btnSua.Margin = new Padding(3, 2, 3, 2);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(105, 42);
			btnSua.TabIndex = 18;
			btnSua.Text = "EDIT";
			btnSua.UseVisualStyleBackColor = false;
			btnSua.Click += btnEdit_Click;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(1, 107, 112);
			btnAdd.Cursor = Cursors.Hand;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point(3, 91);
			btnAdd.Margin = new Padding(3, 2, 3, 2);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(105, 42);
			btnAdd.TabIndex = 19;
			btnAdd.Text = "ADD";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnThem_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.ColumnHeadersHeight = 50;
			dataGridView1.Cursor = Cursors.Hand;
			dataGridView1.GridColor = Color.White;
			dataGridView1.Location = new Point(3, 161);
			dataGridView1.Margin = new Padding(3, 2, 3, 2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(1344, 647);
			dataGridView1.TabIndex = 17;
			// 
			// btnLamMoi
			// 
			btnLamMoi.BackColor = Color.FromArgb(1, 107, 112);
			btnLamMoi.Cursor = Cursors.Hand;
			btnLamMoi.FlatAppearance.BorderSize = 0;
			btnLamMoi.FlatStyle = FlatStyle.Flat;
			btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLamMoi.ForeColor = Color.White;
			btnLamMoi.Image = Properties.Resources.refresh_24;
			btnLamMoi.ImageAlign = ContentAlignment.MiddleRight;
			btnLamMoi.Location = new Point(246, 90);
			btnLamMoi.Margin = new Padding(0);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(107, 44);
			btnLamMoi.TabIndex = 20;
			btnLamMoi.Text = "Refesh";
			btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnLamMoi.UseVisualStyleBackColor = false;
			btnLamMoi.Click += btnLamMoi_Click;
			// 
			// SkillUserControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label1);
			Controls.Add(btnSua);
			Controls.Add(btnAdd);
			Controls.Add(dataGridView1);
			Controls.Add(btnLamMoi);
			Margin = new Padding(3, 2, 3, 2);
			Name = "SkillUserControl";
			Size = new Size(1350, 850);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Button btnSua;
		private Button btnThem;
		private DataGridView dataGridView1;
		private Button btnLamMoi;
		private Button btnAdd;
	}
}
