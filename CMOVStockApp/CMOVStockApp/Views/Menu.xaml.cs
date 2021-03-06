﻿using CMOVStockApp.Models;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CMOVStockApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Menu : Page
    {
        private DispatcherTimer dispatch;

        public Menu()
        {
            this.InitializeComponent();
            
        }

        private void loadQuotesTask(object sender, object e)
        { 
            PushNotifications.checkIntervals();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SplitViewFrame.Navigate(typeof(StockPortefolio));
            loadQuotesTask(null, null);
            dispatch = new DispatcherTimer();
            dispatch.Interval = new TimeSpan(0, 0, 2);
            dispatch.Tick += loadQuotesTask;
            dispatch.Start();
        }



        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void goToAddStockPage(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            if (MySplitView.Content != null)
                SplitViewFrame.Navigate(typeof(Shares));
        }

        private void goToHistoryPage(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            if (MySplitView.Content != null)
                SplitViewFrame.Navigate(typeof(StockHistory));
        }

        private void goToStockPortefolio(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            if (MySplitView.Content != null)
                SplitViewFrame.Navigate(typeof(StockPortefolio));
        }
    }
}
