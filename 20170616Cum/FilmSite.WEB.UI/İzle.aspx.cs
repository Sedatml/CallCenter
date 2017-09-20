using FilmSite.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmSite.WEB.UI
{
    public partial class İzle : System.Web.UI.Page
    {
        FilmUrlController fuc = new FilmUrlController();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (IsPostBack)
            {
                return;
            }

            int musteriID = Convert.ToInt32(Request.QueryString["ID"]);


            rptIzle.DataSource = fuc.VeriGetir(musteriID);
            rptIzle.DataBind();

        }
        
    }
}