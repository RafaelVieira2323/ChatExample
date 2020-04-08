using System.ComponentModel;

using Xamarin.Forms;

namespace ChatExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel.MainPageViewModel vm;
        public MainPage()
        {
            InitializeComponent();

            BindingContext = vm = new MainPageViewModel.MainPageViewModel();


            vm.ListMessages.CollectionChanged += (sender, e) =>
            {
                var target = vm.ListMessages[vm.ListMessages.Count - 1];
                MessagesListView.ScrollTo(target, ScrollToPosition.End, true);
            };
        }
    }
}
