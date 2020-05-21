using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_KR_2
{
    class mess_s
    {
        messEntities ms = new messEntities();
        public void Add_f(string name, string adres)
        {
            int num_f = ms.fromm.Max(n => n.code_f) + 1;

            fromm new_f = new fromm
            {
                code_f = num_f,
                name_f = name,
                ad_f = adres
            };
            ms.fromm.Add(new_f);
            ms.SaveChanges();
        }

        public void Add_w(string name, string adres)
        {
            int num_w = ms.whom.Max(n => n.code_w) + 1;

            whom new_w = new whom
            {
                code_w = num_w,
                name_w = name,
                ad_w = adres
            };
            ms.whom.Add(new_w);
            ms.SaveChanges();
        }

        public void Add_t(string tx)
        {
            int num_w = ms.messagee.Max(n => n.code_w) + 1;
            int num_f = ms.messagee.Max(n => n.code_f) + 1;
            messagee new_m = new messagee
            {
                code_f = num_f,
                code_w = num_w,
                texxt = tx
            };
            ms.messagee.Add(new_m);
            ms.SaveChanges();
        }
    }
}

