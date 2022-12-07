using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D3_Homework_Backend
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalcoloPreventivo(object sender, EventArgs e)
        {
            double prezzoMacchina = Convert.ToDouble(ListaAuto.SelectedValue);
            double prezzoAccessori = 0;

            for (int i = 0; i < ListaOptional.Items.Count; i++)
            {
                if (ListaOptional.Items[i].Selected)
                {
                    prezzoAccessori += Convert.ToDouble(ListaOptional.Items[i].Value);
                }
            }

            int anniGaranzia = Convert.ToInt32(ListaAnniGaranzia.SelectedValue);

            Auto automobile = new Auto();
            automobile.Nome = ListaAuto.SelectedItem.Text;
            automobile.Prezzo = prezzoMacchina;
            automobile.CostoOptional = prezzoAccessori;
            automobile.AnniGaranzia = anniGaranzia;

            LabelPreventivo.Text = $"Il preventivo della tua auto è {automobile.CostoAuto().ToString("c")}";
        }

        protected void ImageSelect(object sender, EventArgs e)
        {
            string auto = ListaAuto.SelectedItem.Text;
            if (auto == "Macchina di Paperino")
            {
                ImmagineAuto.ImageUrl = "https://netrinoimages.s3.eu-west-2.amazonaws.com/2016/08/13/419091/127287/donald_duck_car_313_3d_model_c4d_max_obj_fbx_ma_lwo_3ds_3dm_stl_1516263_o.jpg";
                PrezzoImmagine.Text = $"Il costo dell'auto è di {Convert.ToDouble(ListaAuto.SelectedValue).ToString("c")}";
            }
            else if (auto == "Macchina dei Flintstones")
            {
                ImmagineAuto.ImageUrl = "https://i.pinimg.com/564x/92/93/a4/9293a4f74903befbf93046e4ee20250b.jpg";
                PrezzoImmagine.Text = $"Il costo dell'auto è di {Convert.ToDouble(ListaAuto.SelectedValue).ToString("c")}";
            }
            else if (auto == "Batmobile")
            {
                ImmagineAuto.ImageUrl = "https://robbreport.com/wp-content/uploads/2022/02/Electric_Batmobile6.jpg";
                PrezzoImmagine.Text = $"Il costo dell'auto è di {Convert.ToDouble(ListaAuto.SelectedValue).ToString("c")}";
            }
            else if (auto == "DeLorean DMC-12")
            {
                ImmagineAuto.ImageUrl = "https://www.tomshw.it/images/images/2021/01/delorean-138306.jpg";
                PrezzoImmagine.Text = $"Il costo dell'auto è di {Convert.ToDouble(ListaAuto.SelectedValue).ToString("c")}";
            }
            else
            {
                ImmagineAuto.ImageUrl = "";
                PrezzoImmagine.Text = "";
            }
        }
    }
}