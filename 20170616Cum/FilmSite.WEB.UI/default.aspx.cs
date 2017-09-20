using FilmSite.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmSite.WEB.UI
{
    public partial class _default : System.Web.UI.Page
    {
        FilmListeleController flc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate( /*Control Validation Group Name Optional*/ );
                if (Page.IsValid)
                {
                    return;
                }
            }
           flc = new FilmListeleController();
           GridView1.DataSource = flc.VeriGetir();
           GridView1.DataBind();
           //FilmGetir();
        }

        private void FilmGetir()
        {
        
        }

        protected void rptFilmler_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //string ıd = e.CommandArgument.ToString();
            //Response.Redirect("İzle.aspx?ID=" + ıd);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            Response.Redirect("İzle.aspx?ID" + id);
        }

    

  

    }
}