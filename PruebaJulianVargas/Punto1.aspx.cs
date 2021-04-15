using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Data;

namespace PruebaJulianVargas
{
    public partial class Punto1 : System.Web.UI.Page
    {
        DPrueba dPrueba = new DPrueba();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNumeroDocumento.Text))
            {
                DataTable DtConsulta = dPrueba.cargarContratoLaboral(TxtNumeroDocumento.Text);

                if(DtConsulta.Rows.Count > 0)
                {
                    GrdContratoLaboral.DataSource = DtConsulta;
                    GrdContratoLaboral.DataBind();

                }
                else
                {
                    Response.Write("<script>alert(\"No existe ese numero de documento\");</script>");
                }

            }
            else
            {
                Response.Write("<script>alert(\"el numero de documento es requerido\");</script>");
            }
        }
    }
}