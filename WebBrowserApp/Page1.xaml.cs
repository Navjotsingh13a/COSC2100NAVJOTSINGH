// Name: Navjot Singh
// Student Id: 100931376
// Assignment 06 -> .NET TOPIC ASSIGNMENT
// Date: December 08, 2024
// Modified: December 08, 2024
// Description: This code creates a simple WPF-based web browser application with basic functionality
// like navigating, bookmarking, handling file downloads, and managing web page history.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebBrowserApp
{
    public partial class MainWindow : Window
    {
        // Default home page URL...
        private const string HomePage = "http://www.google.com";

        public MainWindow()
        {
            InitializeComponent();

            // Registering events for navigating and loading the browser...
            WebBrowserControl.Navigating += WebBrowserControl_Navigating;
            WebBrowserControl.Navigated += WebBrowserControl_Navigated;
            WebBrowserControl.LoadCompleted += WebBrowserControl_LoadCompleted;

            // Navigate to the home page on app start...
            WebBrowserControl.Navigate(HomePage);
        }

        // Go button: Navigate to the URL entered in the address bar...
        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToUrl(AddressBar.Text);
        }

        // Back button: Go to the previous page...
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (WebBrowserControl.CanGoBack)
                WebBrowserControl.GoBack();
        }

        // Refresh button: Reload the current page...
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserControl.Refresh();
        }

        // Home button: Navigate to the home page...
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserControl.Navigate(HomePage);
        }

        // Add a bookmark of the current page...
        private void AddBookmarkButton_Click(object sender, RoutedEventArgs e)
        {
            string url = WebBrowserControl.Source?.ToString();
            if (!string.IsNullOrWhiteSpace(url))
                BookmarksList.Items.Add(url);
        }

        // Go to the bookmark selected in the list...
        private void BookmarksList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BookmarksList.SelectedItem != null)
                NavigateToUrl(BookmarksList.SelectedItem.ToString());
        }

        // function to navigate to a URL....
        private void NavigateToUrl(string url)
        {
            if (!string.IsNullOrWhiteSpace(url))
            {
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                    url = "http://" + url;

                WebBrowserControl.Navigate(url);
                AddressBar.Text = url;
            }
        }

        // Handle page navigation events like loading status update...
        private void WebBrowserControl_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            StatusText.Text = "Loading...";
            string url = e.Uri.ToString();

            // If it is a file in PDF or EXE, cancel the navigation and download the file
            if (url.EndsWith(".pdf") || url.EndsWith(".exe") || url.EndsWith(".zip"))
            {
                e.Cancel = true;
                using (var client = new WebClient())
                {
                    string fileName = new Uri(url).Segments.Last();
                    client.DownloadFile(url, fileName);
                    MessageBox.Show($"Downloaded: {fileName}", "Download Complete");
                }
            }
        }

        // After navigation completes, update the status text and address bar...
        private void WebBrowserControl_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            StatusText.Text = "Completed";
            AddressBar.Text = WebBrowserControl.Source?.ToString();
        }

        // Handle completion of page load ...
        private void WebBrowserControl_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            WebBrowserControl.Navigating += (s, args) =>
            {
                if (args.Uri != null && args.Uri.AbsoluteUri.Contains("newwindow"))
                {
                    args.Cancel = true;
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = args.Uri.AbsoluteUri,
                        UseShellExecute = true
                    });
                }
            };
        }

        // Allow navigation using the Enter key in the address bar...
        private void AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                NavigateToUrl(AddressBar.Text);
        }
    }
}
