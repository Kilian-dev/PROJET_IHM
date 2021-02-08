using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.ComponentModel;

namespace PROJETKR_2
{
    class C_BASE
    {
        public static int nbr_id;
        
        public BindingList<C_USER> Les_Users = new BindingList<C_USER>();

        public void Sauvegarde_Toi()
        {
            string Donnees_JSON = JsonSerializer.Serialize<BindingList<C_USER>>(Les_Users);
            File.WriteAllText("Users.json", Donnees_JSON);
        }

        public void Charge_Toi()
        {
            string Donnees_JSON = File.ReadAllText("Users.json");
            Les_Users = JsonSerializer.Deserialize<BindingList<C_USER>>(Donnees_JSON);
        }
    }
}
