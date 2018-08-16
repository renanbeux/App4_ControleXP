using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App4_ControleXP.Modelo;

namespace App4_ControleXP.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();
            
            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "José", Idade = "20" });
            lista.Add(new Pessoa { Nome = "Felipe", Idade = "22" });
            lista.Add(new Pessoa { Nome = "Renan", Idade = "23" });
            lista.Add(new Pessoa { Nome = "Ana", Idade = "80" });
            lista.Add(new Pessoa { Nome = "Ecléia", Idade = "21" });

            ListaPessoas.ItemsSource = lista;
        }
	}
}