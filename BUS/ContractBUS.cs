﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class ContractBUS
	{
		private ContractDAO contractDAO;
		public ContractBUS()
		{
			contractDAO = ContractDAO.GetInstance();
		}
		public bool Add(Contract t)
		{
			if(contractDAO.Add(t))
			{
				return true;
			}
			return false;
		}
	}
}