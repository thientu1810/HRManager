﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BonusAndFinesBUS
    {
        BonusAndFinesDAO bonusAndFinesDAO;
        public BonusAndFinesBUS()
        {
            bonusAndFinesDAO = new BonusAndFinesDAO();
        }
        public List<BonusAndFines> GetAll()
        {
            return bonusAndFinesDAO.GetAll();
        }

        public string Add(DTO.BonusAndFines bonusAndFines)
        {
            if(bonusAndFinesDAO.Add(bonusAndFines))
            {
                return "thêm thành công!";
            }
            else
            {
                return "thêm thất bại!";
            }
        }

        public Decimal getAllBonusOfEmployee(int employeeID, string date) 
        {
            return bonusAndFinesDAO.getAllBonusOfEmployee(employeeID, date);
        }

        public Decimal getAllFinesOfEmployee(int employeeID, string date)
        {
            return bonusAndFinesDAO.getAllFinesOfEmployee(employeeID, date);
        }
    }
}