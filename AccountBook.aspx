<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AccountBook.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" Runat="Server">
    <div class="container">
<div class="row">
<div class="col-md-8 mx-auto">

<div class="card">
<div class="card-body">


<div class = "row">
    <div class = "col">
    <center><img width="120px" src="IMG/adminuser.png" /> </center>
    </div>
    </div>


    <div class = "row">
    <div class = "col">
    <center>
    <h4> Add Account </h4>
    </center>
    </div>
    </div>

    <div class = "row">
    <div class = "col">
   <hr />
    </div>
    </div>

    <div class="row">
    <div class="col">
    <label>Name</label>
    <div class="form-group">
        <asp:TextBox CssClass="form-control" ID="tbname" runat="server" Placeholder="Name"></asp:TextBox>
        </div>
        </div>
        </div>


        <div class="row">
    <div class="col-md-6">
        <asp:Panel ID="Panel1" runat="server">
        <label>Type</label>
        <div class="form-group">
            <asp:RadioButton CssClass="form-control" ID="RadioTeacher" runat="server"
                GroupName="T" OnCheckedChanged="Teacher_CheckedChanged" Text="Teacher"
                AutoPostBack="True" />
            </div>

            <div class="form-group">
                <asp:RadioButton CssClass="form-control" ID="RadioStudent" runat="server" GroupName="T"
                    OnCheckedChanged="Student_CheckedChanged" Text="Student"
                    AutoPostBack="True" />
            </div>

  </asp:Panel>
        </div>
        </div>
        </div>

        <div class="row">
        <div class="col">
        <asp:Panel ID="Panel2" runat="server">
        <label>Teacher ID</label>
        <div class="form-group">
            <asp:TextBox CssClass="form-control" ID="tbTID" runat="server" placeholder="Teacher ID"></asp:TextBox>
            </div>

            <label>Date</label>
        <div class="form-group">
            <asp:TextBox CssClass="form-control" ID="tbDate" runat="server" placeholder="Date" TextMode="Date"></asp:TextBox>
            </div>

        </asp:Panel>
        </div>
        </div>


        <div class="row">
        <div class="col">
            <asp:Panel ID="Panel3" runat="server">
            <label>Student Roll Number</label>
            <div class="form-group">
                <asp:TextBox CssClass="form-control" ID="tbSRN" runat="server" placeholder="Student Roll Number"></asp:TextBox>
                </div>

                <label>Student Class</label>
            <div class="form-group">
                <asp:TextBox CssClass="form-control" ID="tbClass" runat="server" placeholder="Student Class"></asp:TextBox>
                </div>

                <label>Date</label>
            <div class="form-group">
                <asp:TextBox CssClass="form-control" ID="tbDate1" runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </asp:Panel>
            </div>
            </div>

            <div class="row">
            <div class="col-6 mx-auto">
            <asp:Button class="btn btn-primary btn-block" ID="Button1" runat="server" 
                    Text="ADD" onclick="Button1_Click" />
            </div>
            </div>
</div>
</div>
</div>
</div>
</div>
</asp:Content>

