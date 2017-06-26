using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Text;
using RepublicDatabaseAutoservice.Logic;

namespace RepublicDatabaseAutoservice
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }        

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = CallStoredProcedure.spGetStoByRegion(TextBox1.Text);
            GenerateHTML(dt);        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = CallStoredProcedure.spGetStoByDistrict(TextBox2.Text);
            GenerateHTML(dt);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataTable dt = CallStoredProcedure.spGetStoByCity(TextBox3.Text);
            GenerateHTML(dt);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataTable dt = CallStoredProcedure.spGetStoByCategory(TextBox4.Text);
            GenerateHTML(dt);
        }

        private void GenerateHTML(DataTable _dt)
        {            
            StringBuilder html = new StringBuilder();
            html.Append("<table border = '1'>");

            html.Append("<tr>");
            foreach (DataColumn column in _dt.Columns)
            {
                html.Append("<th>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");

            foreach (DataRow row in _dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in _dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            html.Append("</table>");

            PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
        }
    }
}