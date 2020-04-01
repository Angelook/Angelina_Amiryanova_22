using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;

namespace laba_6
{
    class User
    {
        public string login, password, role, main_role;
        public static string main_login { get; set; }
        public static string main_password { get; set; }

        public static string Test(string l, string p)
        {
            StreamReader txt = new StreamReader("users.txt");
            string str;
            bool index = false;
            string[] dok = new string[2];
            while ((str = txt.ReadLine()) != null)
            {
                dok = str.Split(',');
                login = temp[0];
                password = temp[1];
                role = temp[2];
                if ((login == l) && (password == p))
                {
                    index = true;
                    main_role = role;
                    main_login = main_login;
                    main_password = main_password;
                    break;
                }
            }
            txt.Close();
            if (index == true) return main_role;
            else return "Ошибка";

        }

        public void Change(string new_p)
        {
            string[] database;
            string[] userbase = File.ReadAllLines("users.txt");
            for (int i = 0; i < userbase.Length; i++)
            {
                string[] a = userbase[i].Split(',');
                string log = a[0];
                string pass = a[1];
                if ((log == main_login) && (pass == main_password))
                {
                    database = userbase[i].Split(',');
                    database[1] = new_p;
                    userbase[i] = database[0] + ',' + database[1] + ',' + database[2];
                }
            }
            File.WriteAllLines("users.txt", userbase);
        }



    }
}
