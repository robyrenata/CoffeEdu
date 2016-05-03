using System;
using System.Collections.Generic;
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
using SQLite.Net.Attributes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CoffeEdu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class About : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;

        public About()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<Form>();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var add = conn.Insert(new Form()
            {
                firstname = FirstTextBox.Text,
                lastname = LastTextBox.Text,
                email = EmailTextBox.Text,
                idea = IdeaTextBox.Text
            });

            SendButton.Visibility = Visibility.Collapsed;
            ThankYou.Visibility = Visibility.Visible;
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<Form>();
            string id = "";
            string firstname = "";
            string lastname = "";
            string email = "";
            string idea = "";

            foreach (var message in query)
            {
                id = id + " " + message.Id;
                firstname = firstname + " " + message.firstname;
                lastname = lastname + " " + message.lastname;
                email = email + " " + message.email;
                idea = idea + " " + message.idea;
            }
            ShowDB.Text = "ID: " + id +
                          "\nFirst Name: " + firstname +
                          "\nLast Name: " + lastname +
                          "\nEmail: " + email +
                          "\nIdea: " + idea;
        }
    }

    public class Form
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string idea { get; set; }
    }
}
