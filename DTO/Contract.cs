﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Contract
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int EmployeeId { get; set; }
		public DateTime FormDate { get; set; }
		public DateTime ToDate { get; set; }
		public string Status { get; set; }
		public int JobId { get; set; }
		public string Detail { get; set; }
		public int RequiredDay { get; set; }
		public Decimal BasePay { get; set; }
		public Contract()
		{

		}
		// Get, Update
		public Contract(int id, string name, int employeeId, DateTime formDate, DateTime toDate, string status, int jobId, string detail, int requiredDay, decimal basePay)
		{
			Id = id;
			Name = name;
			EmployeeId = employeeId;
			FormDate = formDate;
			ToDate = toDate;
			Status = status;
			JobId = jobId;
			Detail = detail;
			RequiredDay = requiredDay;
			BasePay = basePay;
		}
		// Add
		public Contract(string name, int employeeId, DateTime formDate, DateTime toDate, string status, int jobId, string detail, int requiredDay, decimal basePay)
		{
			Name = name;
			EmployeeId = employeeId;
			FormDate = formDate;
			ToDate = toDate;
			Status = status;
			JobId = jobId;
			Detail = detail;
			RequiredDay = requiredDay;
			BasePay = basePay;
		}
	}
}
