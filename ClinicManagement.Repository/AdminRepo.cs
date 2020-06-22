﻿using System;
using ClinicManagement.Entities;
using ClinicManagement.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Repository
{
    public class AdminRepo: IAdminRepo
    {
        public void AddDoctorInfromation(Doctor dc)
        {
            try
            {
                string sql = @"insert into doctor (userid,username,gender,phone,email,dateOfBirth,specialty,degree,bmdcregno,description,divission,district,thana) 
values ('" + dc.Userid + "','" + dc.Username + "','" + dc.Gender + "','" + dc.Phone + "','" + dc.Email + "','" + dc.DateOfBirth + "','" + dc.Specialty + "','" + dc.Degree + "','" + dc.BMDCRegno + "','" + dc.Description + "','" + dc.Divission + "','" + dc.District + "','" + dc.Thana + "');";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error: " + exc.Message);

            }
        }
        public void AddUserInfromation(User u)
        {
            try
            {
                string sql = @"Insert into login (userid,password,status) values ('" + u.Userid + "','" + u.Password + "','" + u.Status + "');";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        
    }
}
