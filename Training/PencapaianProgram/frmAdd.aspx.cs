using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace Training.PencapaianProgram
{
    public partial class frmAdd : System.Web.UI.Page
    {
        

        public object TarikhProgram { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Insert ke table PencapaianProgram

            const string sql = @"
            INSERT INTO PencapaianProgram (KodProgram, TarikhProgram, BilanganHari, Lulus) 
            VALUES (@KodProgram, @TarikhProgram, @BilanganHari, @Lulus)"; //1. define sqlstatement

            //2. get connection string from web.config
            //note: utk on suggestion; CTRL + SPACE
            var connection = ConfigurationManager.ConnectionStrings["DBTraining"].ToString();

            // 3. Buka connection
            using (var c = new SqlConnection(connection))
            {
                var PencapaianProgram = new Entities.PencapaianProgram
                {
                    KodProgram = TxtKodProgram.Text,
                    TarikhProgram = DateTime.Parse(TxtTkhProgram.Text),
                    BilanganHari = int.Parse(TxtBilHari.Text),
                    Lulus = CheckBox1.Checked
                };

                c.Execute(sql, PencapaianProgram); // run sql then var pencapaian program

                Response.Redirect("~/PencapaianProgram/frmList.aspx");

            }
        }
    }
}