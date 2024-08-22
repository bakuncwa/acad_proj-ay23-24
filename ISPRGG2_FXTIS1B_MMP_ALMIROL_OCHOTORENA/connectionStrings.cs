using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMP.ConnectionSettings
{
    public class connectionStrings
    {
        // Atrium Connections

        public static string onlineConnect = "server=atrium-istpc; database=almirol_ochotorena_midtermmachineproject;" +
            "uid=sa; pwd=stbenilde; trustservercertificate=true";
        public static string onlineConnect2 = "server=atrium-islab05; database=almirol_ochotorena_midtermmachineproject;" +
            "uid=sa; pwd=stbenilde; trustservercertificate=true";
        public static string onlineConnect3 = "server=atrium-islab07; database=almirol_ochotorena_midtermmachineproject;" +
            "uid=sa; pwd=stbenilde; trustservercertificate=true";
        public static string onlineConnect4 = "server=atrium-islab08; database=almirol_ochotorena_midtermmachineproject;" +
                  "uid=sa; pwd=stbenilde; trustservercertificate=true";

        // Local Connections

        public static string homeConnect = "server=GYALAPTOP\\SQLEXPRESS;" +
            "database=isprgg2_mmp-testing; integrated security=sspi; trustservercertificate=true";
        public static string homeConnect2 = "server=APOL\\SQLEXPRESS;" +
            "database=isprgg2_mmp-testing; integrated security=sspi; trustservercertificate=true";
    }
}