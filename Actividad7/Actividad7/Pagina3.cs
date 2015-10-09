using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class Pagina3: ContentPage
	{
		public Pagina3 ()
		{
			Label texto = new Label {
				Text = "Esta es la Página 3",
				TextColor = Color.Red
			};

			Button boton = new Button
			{
				Text = "Click para regresar a la página UNO"
			};

			boton.Clicked += (sender, e) => {
				this.Navigation.PushAsync(new Pagina1());
			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					texto,
					boton
				}
				};

			//Como esta clase hereda de ContentPage, podemos usar estas propiedades directamente
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);

		}
	}
}

