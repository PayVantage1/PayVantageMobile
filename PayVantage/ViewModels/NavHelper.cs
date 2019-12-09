using PayVantage.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PayVantage.ViewModels
{
    public static class NavHelper
    {
        public static Page CurrentPage => Application.Current.MainPage;

        private static INavigation Navigation => CurrentPage.Navigation;

        public static async Task PopAsync()
        {
            var masterDetailPage = CurrentPage as MasterDetailPage;

            if (masterDetailPage != null)
                await masterDetailPage.Detail.Navigation.PopAsync();
            else
                await Navigation.PopAsync();
        }

        //public static void PushBack()
        //{
        //    Navigation.InsertPageBefore(CurrentP, Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
        //}

        public static void RemovePage()     //remove page before current page
        {
            Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
        }

        public static async Task PopModalAsync()
        {
            var masterDetailPage = CurrentPage as MasterDetailPage;

            if (masterDetailPage != null)
                await masterDetailPage.Detail.Navigation.PopModalAsync();
            else
                await Navigation.PopModalAsync();
        }

        public static async Task PushModalAsync(Page page)
        {
            var masterDetailPage = CurrentPage as MasterDetailPage;

            if (masterDetailPage != null)
                await masterDetailPage.Detail.Navigation.PushModalAsync(page);
            else
                await Navigation.PushModalAsync(page);
        }

        public static async Task PushAsync(Page page)
        {
            var masterDetailPage = CurrentPage as MasterDetailPage;

            if (masterDetailPage != null)
                await masterDetailPage.Detail.Navigation.PushAsync(page);
            else
                await Navigation.PushAsync(page);
        }

        internal static void InserPageBefore(Page page)
        {
            Navigation.InsertPageBefore(page, Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
        }
    }
}
