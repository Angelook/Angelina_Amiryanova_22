using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;

namespace laba_6
{
    class Users
    {
        public bool index;
        public string login, password, role;
        public string rolee;
        public static string loginn { get; set; }
        public static string passwordd { get; set; }
        public string Check(string l, string p)
        {
            string line;
            StreamReader s = new StreamReader("Users.txt");
            string[] lin = new string[2];
            while ((line = s.ReadLine()) != null)
            {
                lin = line.Split(' ');
                login = lin[0];
                password = lin[1];
                role = lin[2];
                if ((login == l) && (password == p))
                {
                    index = true;
                    rolee = role;
                    loginn = login;
                    passwordd = password;
                    break;
                }
            }
            s.Close();
            if (index == true) return rolee;
            else return "Неверный логин или пароль";
        }

        public void Edit(string edit_p)
        {
            string[] db;
            string[] lin = File.ReadAllLines("Users.txt");
            for (int i = 0; i < lin.Length; i++)
            {
                string[] a = lin[i].Split(' ');
                string l = a[0];
                string p = a[1];
                if ((l == loginn) && (p == passwordd))
                {
                    db = lin[i].Split(' ');
                    db[1] = edit_p;
                    lin[i] = db[0] + ' ' + db[1] + ' ' + db[2];
                }
            }
            File.WriteAllLines("Users.txt", lin);
        }
    }
}
