using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Web.UI.WebControls;

namespace RepublicDatabaseAutoservice.Logic
{
    public class FillFields
    {
        private static string connStr = "RDAConnection";

        public static void LoadBrands(DropDownList _ddl)
        {
            DataTable brands = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings[connStr].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("EXEC GetAllBrands", conn);
                    adapter.Fill(brands);

                    _ddl.DataSource = brands;
                    _ddl.DataTextField = "brand_title";
                    _ddl.DataValueField = "brand_id";
                    _ddl.DataBind();
                }
                catch (Exception) { }
            }

            _ddl.Items.Insert(0, new ListItem("<Выберите марку автомобиля>", "0"));
            _ddl.SelectedIndex = 0;
        }
    }
}