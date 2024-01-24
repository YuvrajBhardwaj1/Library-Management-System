<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AddingBook.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

<script type="text/javascript">
    $(document).ready(function () {

       // $(document).ready(function () {
         //   $('#myTable').DataTable();
        //});
        
        $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
  //  $('#myTable').DataTable();
    });
</script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder1" Runat="Server">
    
<div class="container-fluid">
<div class="row">
<div class="col-md-5">

<div class="card">
<div class="card-body">

<div class="row">
<div class="col">
<center>
    <img width="150px" src="IMG/books.png" />
    </center>
</div>
</div>

<div class="row">
<div class="col">
<center>
<h3>Adding Book</h3>
</center>
</div>
</div>


<div class = "row">
    <div class = "col">
    <hr/>
    </div>
    </div>


    <div class="row">
<div class="col">
    <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />


<div class="row">
<div class="col-md-3">
<label>Book ID</label>
<div class="form-group">
    <asp:TextBox CssClass="form-control" ID="tbId" runat="server" placeholder="Book ID"></asp:TextBox>
    <asp:Button class="form-control btn btn-primary" ID="Button3" runat="server" Text="Go" />
    </div>
    </div>
<div class="col-md-9">
<label>Book Name</label>
<div class="form-group">
    <asp:TextBox CssClass="form-control" ID="tbbname" runat="server" placeholder="Book Name"></asp:TextBox>
    </div>
    </div>

    <div class="row">
    <div class="col-md-4">
<label>Language</label>
<div class="form-group">
<asp:DropDownList class="form-control" runat="server" ID="Dropdownlist1">
 <asp:ListItem Text="English" Value="English" />
                              <asp:ListItem Text="Hindi" Value="Hindi" />
                              <asp:ListItem Text="Marathi" Value="Marathi" />
                              <asp:ListItem Text="French" Value="French" />
                              <asp:ListItem Text="German" Value="German" />
                              <asp:ListItem Text="Urdu" Value="Urdu" />

</asp:DropDownList>
</div>

<label>Publisher Name</label>
<div class="form-group">
    <asp:TextBox CssClass="form-control" ID="tbPname" runat="server" placeholder="Publisher Name"></asp:TextBox>
    </div>
    </div>

    <div class="col-md-4">
    <label>Author Name</label>
    <div class="form-group">
        <asp:TextBox CssClass="form-control" ID="tbAname" runat="server" placeholder="Author Name"></asp:TextBox>
        </div>

        <label>Publish Date</label>
        <div class="form-group">
            <asp:TextBox CssClass="form-control" ID="tbPdate" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        </div>

         <div class="col-md-4">
                        <label>Genre</label>
                        <div class="form-group">
                           <asp:ListBox CssClass="form-control" ID="ListBox1" runat="server" SelectionMode="Multiple" Rows="5">
                              <asp:ListItem Text="Action" Value="Action" />
                              <asp:ListItem Text="Adventure" Value="Adventure" />
                              <asp:ListItem Text="Comic Book" Value="Comic Book" />
                              <asp:ListItem Text="Self Help" Value="Self Help" />
                              <asp:ListItem Text="Motivation" Value="Motivation" />
                              <asp:ListItem Text="Healthy Living" Value="Healthy Living" />
                              <asp:ListItem Text="Wellness" Value="Wellness" />
                              <asp:ListItem Text="Crime" Value="Crime" />
                              <asp:ListItem Text="Drama" Value="Drama" />
                              <asp:ListItem Text="Fantasy" Value="Fantasy" />
                              <asp:ListItem Text="Horror" Value="Horror" />
                              <asp:ListItem Text="Poetry" Value="Poetry" />
                              <asp:ListItem Text="Personal Development" Value="Personal Development" />
                              <asp:ListItem Text="Romance" Value="Romance" />
                              <asp:ListItem Text="Science Fiction" Value="Science Fiction" />
                              <asp:ListItem Text="Suspense" Value="Suspense" />
                              <asp:ListItem Text="Thriller" Value="Thriller" />
                              <asp:ListItem Text="Art" Value="Art" />
                              <asp:ListItem Text="Autobiography" Value="Autobiography" />
                              <asp:ListItem Text="Encyclopedia" Value="Encyclopedia" />
                              <asp:ListItem Text="Health" Value="Health" />
                              <asp:ListItem Text="History" Value="History" />
                              <asp:ListItem Text="Math" Value="Math" />
                              <asp:ListItem Text="Textbook" Value="Textbook" />
                              <asp:ListItem Text="Science" Value="Science" />
                              <asp:ListItem Text="Travel" Value="Travel" />
                           </asp:ListBox>
                        </div>
                     </div>
                  </div>

                   <div class="row">
                     <div class="col-md-4">
                        <label>Edition</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="tbedition" runat="server" placeholder="Edition"></asp:TextBox>
                        </div>
                     </div>

                     <div class="col-md-4">
                        <label>Book Cost</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="tbBookCost" runat="server" placeholder="Book Cost(per unit)" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Pages</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="tbPages" runat="server" placeholder="Pages" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                  </div>

    
<div class="form-group">
                           <asp:Button class="btn btn-success btn-block" ID="Button1" runat="server" 
                               Text="ADD" onclick="Button1_Click" />
                        </div>

                        <div class="form-group">
                           <asp:Button class="btn btn-info btn-block" ID="Button2" runat="server" 
                               Text="Delete" onclick="Button2_Click" />
                        </div>
                        </div>


</div>
</div>
</div>


</div>


</div>

<div class="col-md-6">

<div class="card">
<div class="card-body">

<div class="row">
<div class="col">
<center>
    <img width="150px" src="IMG/book.png" />
</center>
</div>
</div>

<div class="row">
<div class="col">
<center>
<h4>Added Books</h4>
</center>
</div>
</div>

<div class="row">
    
<div class="col">
    
    

<hr />
</div>
    <div class="col">&nbsp;</div>
</div>
    <div class="row">&nbsp;
    
        <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:LMSConnectionString7 %>" ProviderName="<%$ ConnectionStrings:LMSConnectionString7.ProviderName %>" SelectCommand="SELECT * FROM [Add_book]" ID="sqlDataSource1"></asp:SqlDataSource>
        <asp:GridView runat="server" DataSourceID="sqlDataSource1" ID="gridView1" AutoGenerateColumns="False" DataKeyNames="book_Id" OnSelectedIndexChanged="gridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="book_Id" HeaderText="book_Id" ReadOnly="True" SortExpression="book_Id"></asp:BoundField>
                <asp:BoundField DataField="book_name" HeaderText="book_name" SortExpression="book_name"></asp:BoundField>
                <asp:BoundField DataField="language" HeaderText="language" SortExpression="language"></asp:BoundField>
                <asp:BoundField DataField="publisher_name" HeaderText="publisher_name" SortExpression="publisher_name"></asp:BoundField>
                <asp:BoundField DataField="author_name" HeaderText="author_name" SortExpression="author_name"></asp:BoundField>
                <asp:BoundField DataField="publish_date" HeaderText="publish_date" SortExpression="publish_date"></asp:BoundField>
                <asp:BoundField DataField="genre" HeaderText="genre" SortExpression="genre"></asp:BoundField>
                <asp:BoundField DataField="edition" HeaderText="edition" SortExpression="edition"></asp:BoundField>
                <asp:BoundField DataField="book_cost" HeaderText="book_cost" SortExpression="book_cost"></asp:BoundField>
                <asp:BoundField DataField="pages" HeaderText="pages" SortExpression="pages"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>

        <div class="row">
            
<div class="col">
</div>
</div>
    
<div class="row">
    
<div class="col">
</div>
    </div>



</div>
</div>
</div>
</div>
</div>


</asp:Content>

