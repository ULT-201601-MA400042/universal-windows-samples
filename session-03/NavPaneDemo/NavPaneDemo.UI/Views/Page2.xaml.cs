using NavPaneDemo.UI.ViewModels;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace NavPaneDemo.UI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PersonCreate : Page
    {
        public PersonCreateViewModel ViewModel { get; set; }

        public PersonCreate()
        {
            ViewModel = new PersonCreateViewModel();
            this.InitializeComponent();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void createPerson_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel.AddPerson();
        }
    }
}
