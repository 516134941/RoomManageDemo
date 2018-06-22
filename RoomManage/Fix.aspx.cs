using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// 这一句不可少
using MySql.Data.MySqlClient;
using System.Data;

namespace RoomManage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TableCell td=new TableCell();
        TableRow tr=new TableRow();
        // 连接数据库所需要的字符串
        string connectionString = "server=localhost;user id=root;password=123456;database=room";
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Visible = false;
            DropDownList2.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            ImageButton3.Visible = false;
        }
   
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //显示所有报修
        protected void AllFix(object sender, ImageClickEventArgs e)
        {
            ListBox1.Items.Clear();
           string query = "select building,room_no,description,fix_type,user_name,id from fix_room;";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myConnection.Open();
            MySqlDataReader myReader = myCommand.ExecuteReader(); 
            
            string str1, str2, str3, str4, str5;
            while(myReader.Read())
            {
                str1 = myReader[0].ToString();
                str2 = str1+ "      "+myReader[1].ToString();
                str3 = str2 + "      " + myReader[2].ToString();
                str4 = str3 + "      " + myReader[3].ToString();
                str5 = str4 + "      " + myReader[4].ToString();
                string id;
                id= myReader[5].ToString();
               // td.Controls.Add(new LiteralControl(str5));
               // tr.Controls.Add(str5);
               // tr.Cells.Add(td);
               // Table1.Rows.Add(tr);
                ListBox1.Items.Add(new ListItem(str5, id));
            }         
            myConnection.Close();
        }
        //添加报修
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            DropDownList1.Visible = true;
            DropDownList2.Visible = true;
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            ImageButton3.Visible = true;

        }
        //报修确认按钮
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            int building = Convert.ToInt16(DropDownList1.SelectedValue);
            string fixType = DropDownList2.SelectedValue;
            string roomNo = TextBox1.Text;
            string desc = TextBox2.Text;
            string userName = TextBox3.Text;
            if (building == 0 || fixType == "" || roomNo == "" || desc == ""||userName=="")
            {
                this.Response.Write("<script>alert('每个信息都不能为空！')</script>");
                return;
            }
            string query = "insert into fix_room(building, room_no, description, fix_type,user_name) values('" + building + "','" + roomNo + "','" + desc + "','" + fixType + "','" + userName + "');";

            MySqlConnection myConnection = new MySqlConnection(connectionString);
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            this.Response.Write("<script>alert('添加成功！')</script>");
            //清除
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            //
            DropDownList1.Visible = false;
            DropDownList2.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            ImageButton3.Visible = false;
        }
    }
}