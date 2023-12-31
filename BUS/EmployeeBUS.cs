﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        EmployeeDAO edao;
        public EmployeeBUS() {
            edao = EmployeeDAO.getInstance();
        }
        public List<EmployeeDTO> GetAll()
        {
            return edao.GetAll();
        }
		public EmployeeDTO GetById(int id)
        {
            return edao.GetById(id);
        }
        public bool Delete(int id)
        {
            return edao.Delete(id);
        }
        public bool Add(EmployeeDTO dto)
        {
            return edao.Add(dto);
        }
        public bool Update(int id, EmployeeDTO dto)
        {
            return edao.Update(id, dto);
        }
        
        public List<EmployeeDTO> GetEmployeeHaveContractRunning()
        {
            return edao.GetEmployeeHaveContractRunning();
        }
        public List<EmployeeDTO> SearchByName(string name)
        {
            return edao.searchByName(name);
        }
        public List<EmployeeDTO> GetAllByDepartmentId(int id)
        {
            return edao.GetAllByDepartmentID(id);
        }
        public int GetIDByName(string name)
        {
            return edao.GetIDByName(name);
        }
    }

}
