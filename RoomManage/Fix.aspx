<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Fix.aspx.cs" Inherits="RoomManage.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ImageButton ID="ImageButton1" runat="server" Height="37px" ImageUrl="~/Images2/resizeApi.png" Width="46px" onclick="AllFix"/>
<asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" Font-Size="Large" Text="查询所有报修列表"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:ImageButton ID="ImageButton2" runat="server" Height="41px" ImageUrl="~/Images2/add.png" OnClick="ImageButton2_Click" Width="46px" />
&nbsp;<asp:Label ID="Label2" runat="server" BackColor="#CCCCCC" Font-Size="Large" Text="添加报修信息"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
<asp:ListBox ID="ListBox1" runat="server" Height="138px" Width="360px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" Height="45px">
    <asp:ListItem>1</asp:ListItem>
    <asp:ListItem>2</asp:ListItem>
    <asp:ListItem>3</asp:ListItem>
    <asp:ListItem>4</asp:ListItem>
    <asp:ListItem>5</asp:ListItem>
    <asp:ListItem>6</asp:ListItem>
    <asp:ListItem>7</asp:ListItem>
    <asp:ListItem>8</asp:ListItem>
    <asp:ListItem>9</asp:ListItem>
    <asp:ListItem>10</asp:ListItem>
    <asp:ListItem>11</asp:ListItem>
    <asp:ListItem>12</asp:ListItem>
    <asp:ListItem>13</asp:ListItem>
    <asp:ListItem>14</asp:ListItem>
    <asp:ListItem>15</asp:ListItem>
</asp:DropDownList>
&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server" Font-Size="Large" ForeColor="#CCCCCC" Height="36px" ToolTip="房间号" Width="69px">房间号</asp:TextBox>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox2" runat="server" Font-Size="Large" ForeColor="#CCCCCC" Height="36px" ToolTip="问题描述" Width="185px">问题描述</asp:TextBox>
&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList2" runat="server" Height="45px">
    <asp:ListItem>木工</asp:ListItem>
    <asp:ListItem>泥工</asp:ListItem>
    <asp:ListItem>电工</asp:ListItem>
</asp:DropDownList>
&nbsp;&nbsp;
<asp:TextBox ID="TextBox3" runat="server" Font-Size="Large" ForeColor="#CCCCCC" Height="36px" ToolTip="报修人" Width="69px">报修人</asp:TextBox>
    &nbsp;&nbsp;&nbsp;
<asp:ImageButton ID="ImageButton3" runat="server" Height="30px" ImageUrl="~/Images2/okkk.png" OnClick="ImageButton3_Click" Width="34px" />
<br />
<br />
<br />
<br />
<br />
</asp:Content>
