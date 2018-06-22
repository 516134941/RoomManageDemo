<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="RoomManage.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>江西师大宿舍简介（瑶湖校区）</h2>
    </hgroup>

    <article>
        <p>        
            江西师大宿舍共分1-15栋学生宿舍，2栋周转房宿舍.
        </p>

        <p>        
            宿舍内除6栋外，均有独立卫生间，6栋宿舍为澡堂设计.</p>

        <p>        
            宿舍内含有空调，为上床下桌结构，十分适合学生居住与学习.</p>
    </article>

    <aside>
        <h3>Aside Title</h3>
        <p>        
            Use this area to provide additional information.
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/About">About</a></li>
            <li><a runat="server" href="~/Contact">Contact</a></li>
        </ul>
    </aside>
</asp:Content>