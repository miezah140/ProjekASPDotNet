using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training.PencapaianProgram
{
    public partial class frmList : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            BindProgram(); //new methode
        }

        protected void BindProgram()
        {
            const string sql = @"SELECT * FROM PencapaianProgram";

            //get connection string from web.config
            var connection = ConfigurationManager.ConnectionStrings["DBTraining"].ToString();

            using (var c = new SqlConnection(connection))
            {
                var data = c.Query<Entities.PencapaianProgram>(sql);
                ProgramRepeater.DataSource = data;
                ProgramRepeater.DataBind();
            }
        }

    }
}