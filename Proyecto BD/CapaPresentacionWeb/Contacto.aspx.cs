using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using capaEntidades;
using capaDatos;


namespace CapaPresentacionWeb
{
    public partial class Contacto : System.Web.UI.Page
    {
        Comentarios CE = new Comentarios();
        LogicaNegocioComentario CN = new LogicaNegocioComentario();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btcontacto_Click(object sender, EventArgs e)
        {
            try
            {
                
                CE.nombres = txtnombres.Value;
                CE.correo = txtnombres.Value;
                CE.telefono = txtnombres.Value;
                CE.mensaje = txtnombres.Value;

                if (CN.insertarComentarios(CE)==1)
                {
                    indicador.Text = "Enviado!!!";
                    indicador.CssClass = "label label-success";

                    txtnombres.Value = "";
                    txtcorreo.Value = "";
                    txtmensaje.Value = "";
                    txttelefono.Value = "";
                }

                else
                {
                    indicador.Text = "Error al enviar";
                    indicador.CssClass = "label label-dager";
                }
            }
            catch (Exception ex)
            {
                indicador.Text = ex.Message.ToString();
                
            }
        }
    }
}