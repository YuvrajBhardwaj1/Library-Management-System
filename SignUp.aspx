<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" Runat="Server">


<div class = "container">
    <div class = "row">
    <div class = "col-md-8 mx-auto">
        <asp:GridView runat="server"></asp:GridView>

    <div class = "card">
    <div class = "card-body">

    <div class = "row">
    <div class = "col">
    <center><img width="120px" src="IMG/generaluser.png" /> </center>
    </div>
    </div>

        <div class = "row">
    <div class = "col">
    <center>
    <h4>  User Registration</h4>
    </center>
    </div>
    </div>

        <div class = "row">
    <div class = "col">
   <hr />
    </div>
    </div>

    <div class = "row">
    <div class = "col-md-6">
    <label>Full Name</label>
    <div class ="form-group">
        <asp:TextBox CssClass="form-control" ID="Full_name" runat="server" placeholder="Full Name" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </div>
    </div>
    

    
    <div class = "col-md-6">
   <label>Date of Birth</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="DOB" runat="server" placeholder="Password" TextMode="Date"></asp:TextBox>
                        </div>
    </div>
    </div>


    <div class = "row">
    <div class = "col-md-6">
    <label>Contact No</label>
    <div class ="form-group">
        <asp:TextBox CssClass="form-control" ID="Contactno" runat="server" placeholder="Contact No " TextMode="Number"></asp:TextBox>
    </div>
    </div>
    

    
    <div class = "col-md-6">
   <label>Email ID</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="Email_id" runat="server" placeholder="Email" TextMode="Email"> </asp:TextBox>
                        </div>
    </div>
    </div>

    <div class = "row">
    <div class = "col-md-4">
    <label>State</label>
    <div class ="form-group">
        <asp:DropDownList class ="form-group" ID="DropDownList1" runat="server">
        <asp:ListItem Text="Select" value="Select"/>
        <asp:ListItem Text="Andhra Pradesh" Value="Andhra Pradesh" />
                              <asp:ListItem Text="Arunachal Pradesh" Value="Arunachal Pradesh" />
                              <asp:ListItem Text="Assam" Value="Assam" />
                              <asp:ListItem Text="Bihar" Value="Bihar" />
                              <asp:ListItem Text="Chhattisgarh" Value="Chhattisgarh" />
                              <asp:ListItem Text="Rajasthan" Value="Rajasthan" />
                              <asp:ListItem Text="Goa" Value="Goa" />
                              <asp:ListItem Text="Gujarat" Value="Gujarat" />
                              <asp:ListItem Text="Haryana" Value="Haryana" />
                              <asp:ListItem Text="Himachal Pradesh" Value="Himachal Pradesh" />
                              <asp:ListItem Text="Jammu and Kashmir" Value="Jammu and Kashmir" />
                              <asp:ListItem Text="Jharkhand" Value="Jharkhand" />
                              <asp:ListItem Text="Karnataka" Value="Karnataka" />
                              <asp:ListItem Text="Kerala" Value="Kerala" />
                              <asp:ListItem Text="Madhya Pradesh" Value="Madhya Pradesh" />
                              <asp:ListItem Text="Maharashtra" Value="Maharashtra" />
                              <asp:ListItem Text="Manipur" Value="Manipur" />
                              <asp:ListItem Text="Meghalaya" Value="Meghalaya" />
                              <asp:ListItem Text="Mizoram" Value="Mizoram" />
                              <asp:ListItem Text="Nagaland" Value="Nagaland" />
                              <asp:ListItem Text="Odisha" Value="Odisha" />
                              <asp:ListItem Text="Punjab" Value="Punjab" />
                              <asp:ListItem Text="Rajasthan" Value="Rajasthan" />
                              <asp:ListItem Text="Sikkim" Value="Sikkim" />
                              <asp:ListItem Text="Tamil Nadu" Value="Tamil Nadu" />
                              <asp:ListItem Text="Telangana" Value="Telangana" />
                              <asp:ListItem Text="Tripura" Value="Tripura" />
                              <asp:ListItem Text="Uttar Pradesh" Value="Uttar Pradesh" />
                              <asp:ListItem Text="Uttarakhand" Value="Uttarakhand" />
                              <asp:ListItem Text="West Bengal" Value="West Bengal" />
        </asp:DropDownList>
        
    </div>
    </div>
   

    
    <div class = "col-md-4">
   <label>City</label>
                        <div class="form-group">
                            <asp:TextBox Class="form-group" ID="tbCity" runat="server" placeholder="City"> </asp:TextBox>
                        </div>
    </div>
    <div class = "col-md-4">
   <label>Pincode</label>
                        <div class="form-group">
                            <asp:TextBox Class="form-group" ID="tbPincode" runat="server" placeholder="Pincode" TextMode="Number"> </asp:TextBox>
                        </div>
    </div>
    </div>
    
    <div class = "row">
    <div class = "col">
    <label>Full Address</label>
    <div class ="form-group">
        <asp:TextBox CssClass="form-control" ID="tbFA" runat="server" placeholder="Full address " TextMode="MultiLine" Rows="2"></asp:TextBox>
    </div>
    </div>
    </div>

    <div class="row">
                     <div class="col">
                     <center>
                         <asp:GridView runat="server"></asp:GridView>
                        <span class="badge badge-pill badge-info">Login Credentials</span>
                        </center>
                         </div>
        </div>

    <div class = "row">
    <div class = "col-md-6">
    <label> User ID </label>
    <div class ="form-group">
        <asp:TextBox CssClass="form-control" ID="tbUsername" runat="server" placeholder="User ID "></asp:TextBox>
    </div>
    </div>
    

    
    <div class = "col-md-6">
   <label>Password</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="tbPassword" runat="server" placeholder="Password" TextMode="Password"> </asp:TextBox>
                        </div>
    </div>
    </div>
    
    
        <div class = "row">
    <div class = "col">
        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block" ID="Button1" runat="server" 
                               Text="Login" onclick="Button1_Click" />
                        </div>
    </div>
    </div>
    
    </div>
    
    </div>

        <a href="HomePage.aspx"><< Back to Home</a><br><br>

        
    </div>
        <div class="col-md-8 mx-auto">&nbsp;</div>
    </div>
    </div>
</asp:Content>

