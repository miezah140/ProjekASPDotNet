<%@ Page Title="" Language="C#" MasterPageFile="~/Metronic.Master" AutoEventWireup="true" CodeBehind="frmAdd.aspx.cs" Inherits="Training.PencapaianProgram.frmAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="m-subheader">
        <!-- BEGIN: Subheader -->
    <div class="m-subheader">
        <div class="d-flex align-items-center">
            <div class="mr-auto">
                <h3 class="m-subheader_title">
                    Tambah Pencapaian Program
                </h3>
            </div>
        </div>
         
    </div>
    <!-- END: Subheader -->
    </div>

    <div class="form-group">
    <label>Kod Program</label>
    <asp:TextBox ID="TxtKodProgram" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
    <label>Tarikh Program</label>
    <asp:TextBox ID="TxtTkhProgram" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
    <label>Bilangan Hari</label>
    <asp:TextBox ID="TxtBilHari" CssClass="form-control" runat="server" ></asp:TextBox>
    </div>

    <div class="form-check">
    <asp:CheckBox ID="CheckBox1"  Cssclass="form-control"  runat="server" Text="Lulus"/>
    </div>
    <asp:Button ID="btnSubmit"  CssClass="btn btn-primary" runat="server" Text="Simpan" OnClick="btnSubmit_Click" />
</asp:Content>
