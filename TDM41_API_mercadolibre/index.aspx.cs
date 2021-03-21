using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net; //trabaja
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;


namespace TDM41_API_mercadolibre
{
    public partial class index : System.Web.UI.Page
    {
        /*
        const string apikey = "aizasycexxez9kdizsv_7ij6a3xf-o6vuthr_uo";
        static string url_api = "https://maps.googleapis.com/maps/api/geocode/json?address=";
        static string url_api_rev = "https://maps.googleapis.com/maps/api/geocode/json?latlng=";
        static string url_key = "&key=";
        string direccion = "";
        string coordenada1 = "";
        string coordenada2 = "";
        */
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String texto_tex_box = TextBox1.Text;
            var json1 = new WebClient().DownloadString("https://api.mercadolibre.com/sites/MLM/search?q=" + texto_tex_box.Replace(" ", "+"));
            mercadolibre r_json1 = JsonConvert.DeserializeObject<mercadolibre>(json1);


            for (int i = 0; i <10; i++)
            {
                System.Web.UI.WebControls.Label lbl = new System.Web.UI.WebControls.Label();
                System.Web.UI.WebControls.HyperLink hyp = new System.Web.UI.WebControls.HyperLink();
                hyp.NavigateUrl = r_json1.results[i].permalink;
                hyp.ImageUrl = r_json1.results[i].thumbnail;
                /*
                string url = url_api + r_json1.results[i].address.city_name.Replace(" ", "+") + url_key + apikey;
                var json = new WebClient().DownloadString(url);
                Resultado_Geo r_json = JsonConvert.DeserializeObject<Resultado_Geo>(json);
                */
                string tabla = "<table style=\"width:100%; border-collapse:collapse; border: 1px solid black; \" >";
                tabla += "<tr>";
                tabla += "<th padding: 15px; bgcolor=yellow>Produto</th>";
                tabla += "<td padding: 15px; bgcolor=gray>" + r_json1.results[i].title + "</td>";
                tabla += "<tr/>";
                tabla += "<tr>";
                tabla += "<th padding: 15px; bgcolor=yellow>Precio</th>";
                tabla += "<td padding: 15px; bgcolor=gray>" + r_json1.results[i].price + "</td>";
                tabla += "<tr/>";
                lbl.Text = tabla;
                this.Panel1.Controls.Add(lbl);
                this.Panel1.Controls.Add(hyp);
            }
        }
    }
}