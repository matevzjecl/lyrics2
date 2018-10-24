using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Connection
{
    public class Class1
    {
		public static string connectString = "datasource=den1.mysql6.gear.host;username=lyrics;password=Wd40I11~-5gj;database=lyrics;";
		MySqlConnection DBconnect = new MySqlConnection(connectString);
	}
}
