using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Elemendid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Tbl_btn = new Button { Text = "Table Page" };
            Button Tbl_btn1 = new Button { Text = "Esmaspäev" };
            Button Tbl_btn2 = new Button { Text = "Teisipäev" };
            Button Tbl_btn3 = new Button { Text = "Kolmapäev" };
            Button Tbl_btn4 = new Button { Text = "Neljapäev" };
            Button Tbl_btn5 = new Button { Text = "Reede" };
            Button Tbl_btn6 = new Button { Text = "Laupäev" };
            Button Tbl_btn7 = new Button { Text = "Pühapäev" };

            StackLayout st = new StackLayout();

            st.Children.Add(Tbl_btn);
            Tbl_btn.Clicked += Tbl_btn_Clicked;

            st.Children.Add(Tbl_btn1);
            Tbl_btn1.Clicked += Tbl_btn1_Clicked;

            st.Children.Add(Tbl_btn2);
            Tbl_btn2.Clicked += Tbl_btn2_Clicked;

            st.Children.Add(Tbl_btn3);
            Content = st;
            Tbl_btn3.Clicked += Tbl_btn3_Clicked;

            st.Children.Add(Tbl_btn4);
            Tbl_btn4.Clicked += Tbl_btn4_Clicked;

            st.Children.Add(Tbl_btn5);
            Tbl_btn5.Clicked += Tbl_btn5_Clicked;

            st.Children.Add(Tbl_btn6);
            Tbl_btn6.Clicked += Tbl_btn6_Clicked;

            st.Children.Add(Tbl_btn7);
            Tbl_btn7.Clicked += Tbl_btn7_Clicked;

            Content = st;

            //InitializeComponent();
            //Массив-план на день
            //string[] tasks = new string[] { "Tõusen püsti", "Söön putru", "Jalutan", "Söön" };
            //ListView list = new ListView();//список для отображения массива
            //list.ItemsSource = tasks;
            //Content = new StackLayout { Children = { list } };
        }

        private async void Tbl_btn7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table_Page());
        }

        private async void Tbl_btn6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table_Page());
        }

        private async void Tbl_btn5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table_Page());
        }

        private async void Tbl_btn4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table_Page());
        }

        private async void Tbl_btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table_Page());
        }

        private async void Tbl_btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table_Page());
        }

        private async void Tbl_btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table_Page());
        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table_Page());
        }


        //string kell;
        //private string Text;

        //private async void List_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        //{
            //if (e.SelectedItem != null)
            //{
               // string text = e.SelectedItem.ToString();
                //if (e.SelectedItemIndex == 0)//если выбран первый элемент списка
                //{
                   // kell = "7:00";
               // }
               // else if(e.SelectedItemIndex == 1)//если выбран второй элемент списка
                //{
                    //kell = "8:00";
             //  }
                //...дальше надо перечислить все индекси из массива tasks
                //появляется всплывающее окно, где вместо переменных ktll, text отображаеются соответствующие значения
                //await DisplayAlert(kell, text, "Jah");
            //}
        }
    }
//}
