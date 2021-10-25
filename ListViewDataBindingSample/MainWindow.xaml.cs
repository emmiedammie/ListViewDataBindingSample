using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ListViewDataBindingSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Bike bike001 = new Bike()
            {
                BikeID = 001,
                DailyRate = 1,
                Deposit = 100
            };

            Bike bike002 = new Bike()
            {
                BikeID = 002,
                DailyRate = 2,
                Deposit = 200
            };
            Bike bike003 = new Bike()
            {
                BikeID = 003
               
            };
            List<User> users = new List<User>();
            User userA = new User
            {
                Name = "John Doe",
                Age = 42,
                Hire = bike001
                
            };

            User userB = new User
            {
                Name = "Jane Doe",
                Age = 39,
                Hire = bike002
            };


            User userC = new User
            {
                Name = "Sammy Doe",
                Age = 13,
                Hire = bike003
                

            };


            users.Add(userA);
            users.Add(userB);
            users.Add(userC);

            lvDataBinding.ItemsSource = users;

    
        }
    }
}
