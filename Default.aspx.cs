using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace API_OpenLibrary
{
    public partial class _Default : Page
    {
        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            {
                string titulo = Titulo.Text;
                string apiUrl = $"https://openlibrary.org/search.json?title={titulo}";

                using (WebClient client = new WebClient())
                {
                    string jsonResponse = client.DownloadString(apiUrl);
                    dynamic data = JsonConvert.DeserializeObject(jsonResponse);

                    if (data?.docs.Count > 0)
                    {
                        string Titulo = data.docs[0].title;
                        string Autor = data.docs[0].author_name[0];
                        string coverId = data.docs[0].cover_i;

                        string coverUrl = !string.IsNullOrEmpty(coverId)
                            ? $"https://covers.openlibrary.org/b/id/{coverId}-M.jpg"
                            : "https://via.placeholder.com/150";

                        LblResultado.Text = $"Título: {Titulo}, Autor: {Autor}<br/>";
                        Portada.ImageUrl = coverUrl;
                    }
                    else
                    {
                        LblResultado.Text = "No se encontraron resultados.";
                        Portada.ImageUrl = "";
                    }
                }
            }
        }
    }
}