using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;

namespace Sem6MayteGuamanCRUD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opcion : ContentPage
    {
        private const string Url = "http://192.168.100.173/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Sem6MayteGuamanCRUD.Datos> _post;
        public Opcion()
        {
            InitializeComponent();
        }

        private async void btnNuevo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Modificar());
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Eliminar());
        }

        private async void btnConsutar_Clicked(object sender, EventArgs e)
        {
            //var content = await client.GetStringAsync(Url);
            //List<Sem6MayteGuamanCRUD.Datos> posts = JsonConvert.DeserializeObject<List<Sem6MayteGuamanCRUD.Datos>>(content);
            //_post = new ObservableCollection<Sem6MayteGuamanCRUD.Datos>(posts);

            //MyListView.ItemsSource = _post;

            await Navigation.PushAsync(new Actualizar());
        }
    }
}