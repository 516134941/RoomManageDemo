using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;
using System.Data;
namespace RoomManage
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        // 连接数据库所需要的字符串
        string connectionString = "server=localhost;user id=root;password=123456;database=room";
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox3.Visible = false;
            ImageButton3.Visible = false;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            TextBox3.Visible = true;
            ImageButton3.Visible = true;
        }

        protected void Search(object sender, ImageClickEventArgs e)
        {
            Int64 cno = Convert.ToInt64(TextBox1.Text);
            if (cno == 0)
            {
                this.Response.Write("<script>alert('每个信息都不能为空！')</script>");
                return;
            }
            string query = "select money from water_card where cno = '" + cno + "';";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myConnection.Open();
            MySqlDataReader myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                TextBox2.Text = myReader[0].ToString();
            }         
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            double moneyAdd = Convert.ToDouble(TextBox3.Text);
            if (moneyAdd == 0)
            {
                this.Response.Write("<script>alert('每个信息都不能为空！')</script>");
                return;
            }
            //获取水卡钱
            double oldMoney = Convert.ToDouble(TextBox2.Text);
            double money = oldMoney + moneyAdd;
            //获取学号
            Int64 cno = Convert.ToInt64(TextBox1.Text);
            string query = "update water_card set money = ' " + money + "' where cno = '" + cno + "' ;";
            //执行
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            //清除textbox
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            //
            TextBox3.Visible = false;
            ImageButton3.Visible = false;
        }
    }
}