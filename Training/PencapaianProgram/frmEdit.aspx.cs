using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training.PencapaianProgram
{
    public partial class frmEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if  (!IsPostBack) //1st time db papar data, kalau ada org klik submit btn baru update
            {
                BindProgram();
            }
            
        }

        protected void BindProgram() //ambil data dlm db dan papar dlm txtbox
        {
            var id = Request.QueryString["Id"];

            const string sql = "SELECT * FROM PencapaianProgram WHERE id = @Id";

            using (var c = connectionManager.GetConnection())
            {
                var data = c.QueryFirstOrDefault<Entities.PencapaianProgram>(sql, new { Id = id });

                TxtKodProgram.Text = data.KodProgram; //set kodProgram dlm db ke textbox
                TxtTkhProgram.Text = data.TarikhProgram.ToString(); //kena letak .ToString convert datetime kepada string
                TxtBilHari.Text = data.BilanganHari.ToString(); //sama spt line 28
                CheckBox1.Checked = (bool)data.Lulus;
                //checkbox1 dlm db declare as int
                //int dlm c# xboleh null either true or false
                //jadi gunakan bool
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e) //new add method after 2x click button
        {
            

            const string sql = @"
            UPDATE PencapaianProgram
            SET KodProgram = @kodProgram,
                TarikhProgram = @TarikhProgram,
                BilanganHari = @BilanganHari,
                Lulus = @Lulus
            WHERE Id = @Id";

            using (var c = connectionManager.GetConnection())
            {
                var id = Request.QueryString["Id"];

                var pencapaian = new Entities.PencapaianProgram
                {
                    KodProgram = TxtKodProgram.Text,
                    TarikhProgram = DateTime.Parse(TxtTkhProgram.Text),
                    BilanganHari = int.Parse(TxtBilHari.Text),
                    Lulus = CheckBox1.Checked,
                    Id = int.Parse(id)
                };

                c.Execute(sql, pencapaian); // run sql then var pencapaian

                Response.Redirect("~/PencapaianProgram/frmList.aspx");
            }
            
        }
    }
}