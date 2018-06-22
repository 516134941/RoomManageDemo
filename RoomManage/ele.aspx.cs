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
    public partial class WebForm2 : System.Web.UI.Page
    {
        // 连接数据库所需要的字符串
        string connectionString = "server=localhost;user id=root;password=123456;database=room";
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox3.Visible = false;
            ImageButton3.Visible = false;
        }
        //查询
        protected void Search(object sender, ImageClickEventArgs e)
        {
            int building = Convert.ToInt16(DropDownList1.SelectedValue);
            string roomNo = TextBox1.Text;
            if (building == 0 ||  roomNo == "" )
            {
                this.Response.Write("<script>alert('每个信息都不能为空！')</script>");
                return;
            }
            string query = "select ele from room where building = '" + building + "' and room_no = '" + roomNo + "';";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myConnection.Open();
            MySqlDataReader myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                TextBox2.Text = myReader[0].ToString();
            }         
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            TextBox3.Visible = true;
            ImageButton3.Visible = true;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //充值按钮
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            double eleAdd = Convert.ToDouble(TextBox3.Text);
            if (eleAdd == 0)
            {
                this.Response.Write("<script>alert('每个信息都不能为空！')</script>");
                return;
            }
            //获取原电量
            double oldEle = Convert.ToDouble(TextBox2.Text);
            double ele = eleAdd + oldEle;
            //获取寝室号 楼栋
            int building = Convert.ToInt16(DropDownList1.SelectedValue);
            string roomNo = TextBox1.Text;
            string query = "update room set ele = ' "+ele+"' where building = '" + building + "' and room_no = '" + roomNo + "';";
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