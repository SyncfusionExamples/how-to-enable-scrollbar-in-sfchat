using Syncfusion.XForms.Chat;
using System;
using Xamarin.Forms;
using System.Reflection;
using Xamarin.Forms.Xaml;
using System.Linq;
using Syncfusion.ListView.XForms;

namespace GettingStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
            (this.sfChat.GetType().GetRuntimeProperties().FirstOrDefault(x => x.Name.Equals("ChatListView")).GetValue(this.sfChat) as SfListView).IsScrollBarVisible = true;

        }
    }
}