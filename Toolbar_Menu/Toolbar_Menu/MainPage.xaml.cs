using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Toolbar_Menu
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ToolbarItem tb = new ToolbarItem
            {
                Text = "Позвонить",
                Order = ToolbarItemOrder.Primary,
                Priority = 0,
                Icon = new FileImageSource
                {
                    File = "icom.png"
                }

            };

            tb.Clicked += async (s, e) =>
            {
                await DisplayAlert("Вызов","Идет набор номера...","Сбросить");
            };

            ToolbarItems.Add(tb);

            ToolbarItem tb1 = new ToolbarItem
            {
                Text = "Создать новый контакт",
                Order = ToolbarItemOrder.Secondary,
                Priority = 1,
            };

            ToolbarItem tb2 = new ToolbarItem
            {
                Text = "Удалить",
                Order = ToolbarItemOrder.Secondary,
                Priority = 2,
               

            };

            ToolbarItem tb3 = new ToolbarItem
            {
                Text = "О программе",
                Order = ToolbarItemOrder.Secondary,
                Priority = 3,
                

            };

            ToolbarItems.Add(tb1);
            ToolbarItems.Add(tb2);
            ToolbarItems.Add(tb3);

        }
    }
}
