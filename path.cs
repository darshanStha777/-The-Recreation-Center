using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreation_Centre_System
{
    public class path
    {
        public static String pathB = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString()+ "/ticketpricedetails.xml";

        public static String pathC = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString() + "/visitor_details.xml";
    }
}
