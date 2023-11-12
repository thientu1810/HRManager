﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PaySlipBUS
    {
        PaySlipDAO paySlipDAO;
        public PaySlipBUS()
        {
            paySlipDAO = new PaySlipDAO();
        }
        public List<PaySlipDTO> getAll()
        {
            return paySlipDAO.GetAll();
        }

        public string Add(PaySlipDTO paySlipDTO)
        {
            if(paySlipDAO.Add(paySlipDTO))
            {
                return "thêm thành công!";
            }
            else
            {
                return "thêm thất bại!";
            }
        }
    }
}