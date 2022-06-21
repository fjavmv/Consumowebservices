
using ServicioClientePublico.modelo;
using ServicioClientePublico.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServicioClientePublico
{
    public partial class Home : System.Web.UI.Page
    {
        ServiceReference2.WebServiceEjemploSoapClient servicio = new ServiceReference2.WebServiceEjemploSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bt1_Click(object sender, EventArgs e)
        {
            
           var us = servicio.getData(TxtB1.Text);
           Lbl1.Text = us.nombre;
           Lbl2.Text = us.apellidoP;
           Lbl3.Text = us.apellidoM;
        }

        protected void BtnAll_Click(object sender, EventArgs e)
        {
            List<UsuarioC> usuarios = new List<UsuarioC>();
            //var data = servicio.getDataAll();
            foreach (var servic in servicio.getDataAll())
            {
                usuarios.Add(new UsuarioC(servic.nombre,servic.apellidoP,servic.apellidoM));
            }

            GridView1.DataSource = usuarios;
            GridView1.DataBind();

        }
    }
}