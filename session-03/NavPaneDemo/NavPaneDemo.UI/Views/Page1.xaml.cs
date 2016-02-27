using NavPaneDemo.UI.ViewModels;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace NavPaneDemo.UI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public PersonListViewModel ViewModel { get; set; }

        public Page1()
        {
            ViewModel = new PersonListViewModel();
            this.InitializeComponent();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            var page = e.Content as PersonCreate;
            // Check if the page variable is null.  If it's null, then it's not a Page2 object
            if (page != null)
            {
                //page.PersonId = number;
            }

            base.OnNavigatedFrom(e);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }
    }
}
