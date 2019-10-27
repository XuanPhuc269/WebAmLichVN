using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAmLichVN.Models;

namespace WebAmLichVN
{
    public partial class TestAL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // for Examle here:
            int dd = DateTime.Now.Day;
            int mm = DateTime.Now.Month;
            int yy = DateTime.Now.Year;
            int[] listAL = VietCalendar.convertSolar2Lunar(dd, mm, yy, 7);
            Response.Write("Ngay Am lich: " + listAL[0] + "/" + listAL[1] + "/" + listAL[2]);
            AmLich a = new AmLich();

            int mAL = Convert.ToInt32("" + listAL[1]);
            int yAL = Convert.ToInt32("" + listAL[2]);
            Response.Write("<br />Nam _ " + a.getCanNam(yy) + " " + a.getChiNam(yy));
            Response.Write("<br />Thang _" + a.getCanThang(mAL, yAL));
            Response.Write("<br />Ngay _ " + a.getCanNgay(dd, mm, yy));
            

        }
    }
}