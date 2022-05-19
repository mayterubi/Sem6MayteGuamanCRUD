using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml;
//using Xamarin.Formsusing Newtonsoft.Json;


namespace Sem6MayteGuamanCRUD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eliminar : ContentPage
    {
        private const string Url = "http://192.168.100.173/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Sem6MayteGuamanCRUD.Datos> _post;
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                    DisplayAlert("Alerta", "Por favor ingrese un código de estudiante.", "Ok");
                else
                {
                    WebClient cliente = new WebClient();

                    string parametros = "";

                    parametros += "?codigo=" + txtCodigo.Text;

                    var urlCompleta = new Uri(Url + parametros);

                    cliente.UploadString(urlCompleta, "DELETE", "");

                    DisplayAlert("Alerta", "Registro eliminado satisfactoriamente.", "Ok");

                    txtCodigo.Text = "";
                    //txtNombre.Text = "";
                    //txtApellido.Text = "";
                    //txtEdad.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", "Mensaje de alerta " + ex.Message, "Ok");
            }
        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {

        }
    }
}