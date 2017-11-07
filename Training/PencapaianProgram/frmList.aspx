<%@ Page Title="" Language="C#" MasterPageFile="~/Metronic.Master" AutoEventWireup="true" CodeBehind="frmList.aspx.cs" Inherits="Training.PencapaianProgram.frmList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class ="m-subheader">
        <!-- BEGIN: Subheader -->
    <div class="m-subheader">
        <div class="d-flex align-items-center">
            <div class="mr-auto">
                <h3 class="m-subheader_title">
                    Pencapaian Program
                </h3>
            </div>
        </div>
         
    </div>
    <!-- END: Subheader -->
    </div>
    
    <asp:HyperLink ID="btnTambah" CssClass="btn btn-primary" runat="server" NavigateUrl="~/PencapaianProgram/frmAdd.aspx">Tambah</asp:HyperLink>

    
    <asp:Repeater ID="ProgramRepeater" runat="server">
    <headerTemplate>
        <table class="table">
            <thead>
              <tr>
                <th>Kod Program</th>
                <th>Tarikh Program</th>
                <th>Bilangan Hari</th>
                <th>Lulus</th>
              </tr>
            </thead>
            <tbody>
                
            
       </headerTemplate>
    
        <ItemTemplate>
            <tr>
                    <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl=<%#"~/PencapaianProgram/frmEdit.aspx?id=" +  Eval("id") %>><%# Eval("KodProgram") %></asp:HyperLink>
                    </td>
                    <td><%# Eval("TarikhProgram") %></td>
                    <td><%# Eval("BilanganHari") %></td>
                    <td><%# Eval("Lulus") %></td>
                </tr>
        </ItemTemplate>

    <footerTemplate>
        </tbody>
        </table>
    </footerTemplate>
    </asp:Repeater>



</asp:Content>
