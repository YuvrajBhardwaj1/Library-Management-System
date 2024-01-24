<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BookIssue.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" Runat="Server">

<div class = "container">
    <div class = "row">
    <div class = "col-md-8 mx-auto">

    <div class = "card">
    <div class = "card-body">

    <div class = "row">
    <div class = "col">
    <center><img width="120px" src="IMG/books1.png" /> </center>
    </div>
    </div>

        <div class = "row">
    <div class = "col">
    <center>
    <h4> Issue Book </h4>
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
    <label>Book Name</label>
    <div class ="form-group">
        <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="DropDownList2" runat="server" 
            placeholder="Select Book name" 
            onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
            AutoPostBack="True" data-bs-toggle="dropdown" aria-expanded="false">
        </asp:DropDownList>
        <ul class="dropdown-menu dropdown-menu-dark" aria-labelledby="dropdownMenuButton2">
        </ul>
    </div>
    </div>
    

    
    <div class = "col-md-6">
   <label>Book ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" 
                                placeholder="Book ID" AutoPostBack="True" ></asp:TextBox>
                        </div>
    </div>
    </div>


    <div class = "row">
    <div class = "col-md-4">
    <label>Account No</label>
    <div class ="form-group">
         <asp:TextBox CssClass ="form-control" ID="TextBox3" runat="server" 
            placeholder ="Account No" TextMode="Number" 
            ontextchanged="TextBox3_TextChanged" AutoPostBack="True"></asp:TextBox>
    </div>
    </div>

    <div class = "col-md-4">
   <label>Type</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Account Type"> </asp:TextBox>
                        </div>
    </div>
    
    <div class = "col-md-4">
   <label>Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Name"> </asp:TextBox>
                        </div>
    </div>
    </div>

    <div class = "row">
    <div class = "col-md-6">
    <label>Issue Date</label>
    <div class ="form-group">
        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" 
            TextMode="Date" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        
    </div>
    </div>
   

    
    <div class = "col-md-6">
   <label>Due Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" TextMode="Date"> </asp:TextBox>
                        </div>
    </div>
    </div>


    <div class="row">
    <div class = "col-md-6">
   <label>Return Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" TextMode="Date"> </asp:TextBox>
                        </div>
    </div>

    <div class = "col-md-6">
   <label>Reissue Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" TextMode="Date"> </asp:TextBox>
                        </div>
    </div>
    </div>
    
    <div class="col-md-6">
    
    <label>Fine</label>
    <div class ="form-group">
        <asp:TextBox CssClass ="form-control" ID="TextBox7" runat="server" placeholder ="Fine " TextMode="Number" ></asp:TextBox>
    
    </div>
    </div>
    

    <div class = "row">
    <div class = "col">
        <div class="form-group">
                           
            <asp:Button class="btn btn-outline-primary btn-block" ID="Button1" runat="server" 
                Text="Issue" onclick="Button1_Click" />   
                        </div>
        

                         <div class="form-group">
                             <asp:Button class="btn btn-outline-success btn-block" ID="Button2" runat="server" 
                                 Text="Return" onclick="Button2_Click" />
                        </div>
    </div>
    </div>
  
    </div>

        
    
    </div>
    
    </div>

        <a href="HomePage.aspx"><< Back to Home</a><br><br>

        
    </div>
    </div>
    


</asp:Content>

