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
    public partial class Punto2 : System.Web.UI.Page
    {
        DPrueba dPrueba = new DPrueba();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                CboContrato.DataTextField = "idcontrato";
                CboContrato.DataValueField = "idcontrato";
                CboContrato.DataSource = dPrueba.cargarContratos();
                CboContrato.DataBind();
            }
        }
               

        protected void BtnGrabar_Click(object sender, EventArgs e)
        {
            if(TxtNumeroDocumento.Text == "")
            {
                Response.Write("<script>alert(\"El campo Numero de documento es requerido\");</script>");
                return;
            }
            else if(TxtHorasTotalLaboradas.Text == "")
            {
                Response.Write("<script>alert(\"El campo horas total laboradas es requerida\");</script>");
                return;
            }
            else if(TxtHorasExtrasDiurnas.Text == "")
            {
                Response.Write("<script>alert(\"El campo horas extras diurnas es requerida\");</script>");
                return;
            }
            else if (TxtHorasExtrasNocturnas.Text == "")
            {
                Response.Write("<script>alert(\"El campo horas extras nocturnas es requerida\");</script>");
                return;
            }
            else if (TxtHorasExtrasDominicales.Text == "")
            {
                Response.Write("<script>alert(\"El campo horas extras dominicales es requerida\");</script>");
                return;
            }
            else if (TxtNumeroFestivas.Text == "")
            {
                Response.Write("<script>alert(\"El campo horas extras festivas es requerida\");</script>");
                return;
            }
            else if (TxtPeriodoLaborado.Text == "")
            {
                Response.Write("<script>alert(\"El campo periodo laborado es requerido\");</script>");
                return;
            }
            else if (TxtDescuentosNomina.Text == "")
            {
                Response.Write("<script>alert(\"El campo descuento nomina es requerido\");</script>");
                return;
            }

            DataTable DtNovedad = dPrueba.cargarNovedadPorId(Convert.ToInt32(TxtNumeroDocumento.Text));

            if (DtNovedad.Rows.Count > 0)
            {
                Response.Write("<script>alert(\"El numero de documento ya existe en novedades nomina\");</script>");
            }
            else
            {

                dPrueba.insertarNomina(Convert.ToInt32(TxtNumeroDocumento.Text), Convert.ToInt32(CboContrato.SelectedValue),
                    Convert.ToInt32(TxtHorasTotalLaboradas.Text),
                    Convert.ToInt32(TxtHorasExtrasDiurnas.Text), Convert.ToInt32(TxtHorasExtrasNocturnas.Text),
                    Convert.ToInt32(TxtHorasExtrasDominicales.Text),
                    Convert.ToInt32(TxtNumeroFestivas.Text), TxtPeriodoLaborado.Text, Convert.ToDouble(TxtDescuentosNomina.Text));

                Response.Write("<script>alert(\"Se guardo con exito\");</script>");
            }
        }
    }
}