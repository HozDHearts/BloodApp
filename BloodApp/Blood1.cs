﻿using System;
using System.Data;

namespace BloodApp
{
    class Blood1
    {
        Connection conn = new Connection();
        public bool Loging(string User, string Password)
        {
            string query = String.Format("select * from Usrs where Usr= '{0}' and Passw='{1}'", User, Password);
            DataRow [] dt = conn.ReadQuery( query, "Usrs", true);

            if (dt.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Register(string User, string Password, string Email)
        {
            bool set = conn.SetData(String.Format("insert into Usrs (Usr, Passw, Email) values ('{0}', '{1}', '{2}')", User, Password, Email));

            return set;
        }
    }
}
