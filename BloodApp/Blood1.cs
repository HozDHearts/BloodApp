using System;
using System.Data;

namespace BloodApp
{
    class Blood1
    {
        Connection conn = new Connection();
        public void Loging ()
        {
            DataRow [] dt = conn.ReadQuery("select * from Usrs", "Usrs", true);

            if (dt.Length == 1)
            {
                Console.WriteLine("Usser Found");
            }
            else
            {
                Console.WriteLine("Usser Not Found");
            }
        }
        public void Register()
        {
            bool set = conn.SetData(String.Format("insert into Usrs (Usr, Passw, Email) values ('{0}', '{1}', '{2}')","Josue","8529173", "josuedebermudez@gmail.com"));
            if(set)
            {
                Console.WriteLine("Succesful");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
