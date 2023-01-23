using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Updatefun();
                DelteDun();
            }

        }

        private void DelteDun()
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = @"data source=DESKTOP-YK\SQLEXPRESS; initial catalog =tsegrp_2_2022;integrated security=true";
                int counter = 0;
                cn.Open();
                string user = "Ajay";
                string pwd = "Ajay@123";
                string IPAddress = "123.213.42.2";
                string datasource = "yash database";
                string appkey = "ashf237r3";
                string connectionstring = "desktop-yk/Swwlexpress";


                cmd = new SqlCommand();
                cmd.Connection = cn;

            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message;

            }
            finally
            {
                cn.Close();
            }
        }

        private void Updatefun()
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;

            cn = new SqlConnection();
            cn.ConnectionString = @"data source=DESKTOP-YK\SQLEXPRESS; initial catalog =tsegrp_2_2022;integrated security=true";
            int counter = 0;


        }

        public class secrets
        {
            public  String APP_KEY = "jk433g34hg3";

            public String APP_SECRET = "987dwdqwdqw90";


        } 
    }
}
