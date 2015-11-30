﻿using CMOVStockApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CMOVStockApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shares : Page
    {
        private List<Company> companyList { get; set; }//all companies

        public List<Company> searchedList { get; set; }//companies in the search field
       
        private ObservableCollection<Company> observingList { get; set; }//companies selected



        public Shares()
        {
            this.InitializeComponent();

            observingList = new ObservableCollection<Company>();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            loadCompanies();

        }

        //loads companies to be searched, hardcoded at the moment
        private async void loadCompanies()
        {
            companyList = await StockNameLoad.getList();
            searchedList = companyList;
            searchList.ItemsSource = companyList;
        }

        //sow modal window ativated by add stock button
        private async void addStock(object sender, RoutedEventArgs e)
        {
            await contentDialog.ShowAsync();
        }

        //searchs the companies from a list activates every time user writes something in the modal window
        private void searchCompanies(object sender, TextChangedEventArgs e)
        {
            searchText.Text = SearchBar.Text;
            searchedList = new List<Company>();

            foreach (Company cmp in companyList)
            {
                if (cmp.symbol.IndexOf(searchText.Text)!=-1)
                {
                    searchedList.Add(cmp);
                }
            }
            searchList.ItemsSource = searchedList;
        }

        //adds company to observing list 8activated by add button in modal window)
        private void addCompany(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            int test = searchList.SelectedIndex;
            
            Company cmp = searchedList.ElementAt(searchList.SelectedIndex);
            observingList.Add(cmp);
            observingCompanyList.ItemsSource = observingList;
        }

        private void TextBlock_PointerEntered(object sender, PointerRoutedEventArgs e)
        {

        }
    }
}