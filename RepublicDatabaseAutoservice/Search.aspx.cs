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
        private string selectedBrand { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            FillFields.LoadBrands(DropDownList1);
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

        protected void Button5_Click(object sender, EventArgs e)
        {
            DataTable dt = CallStoredProcedure.spGetStoByBrandAndModel(TextBox5.Text, TextBox6.Text);
            GenerateHTML(dt);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //PopulateDropDownList();
            string value = DropDownList1.SelectedItem.Text;
                DataTable dt = CallStoredProcedure.spGetStoByBrand(value);
                string st = selectedBrand + "_ss";
                //DataTable dt = CallStoredProcedure.spGetStoByBrand(/*DropDownList1*/TextBox7.Text);
                GenerateHTML(dt);
        }

        protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBrand = DropDownList1.Items[System.Convert.ToInt32(DropDownList1.SelectedValue)].Text;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            DataTable dt = CallStoredProcedure.spGetStoByAgeAuto(TextBox8.Text);
            GenerateHTML(dt);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            DataTable dt = CallStoredProcedure.spGetStoByAgeAndMakerCountry(TextBox9.Text, TextBox10.Text);
            GenerateHTML(dt);
        }
    }
}