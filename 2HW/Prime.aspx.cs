using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 20;
            int b = 0, c = 0;
            for(int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    b = b + i;
                }else if (i % 3 == 0)
                {
                    c = c + i;
                }
                
            }
            Response.Write(b + c);
        }
    }
}