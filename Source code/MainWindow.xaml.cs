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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldCup2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Team> Teams { get; set; } = new List<Team>();

        public MainWindow()
        {
            InitializeTeams();
            InitializeComponent();
            TeamView.ItemsSource = Teams;

        }

        //Populates the function 
        void InitializeTeams()
        {
            //Group A teams
            Teams.Add(new Team("Qatar", @"Flags\Qatar.png"));
            Teams.Add(new Team("Ecuador", @"Flags\Ecuador.png"));
            Teams.Add(new Team("Senegal", @"Flags\Senegal.png"));
            Teams.Add(new Team("Netherlands", @"\Flags\Netherlands.png"));
            //Group B teams
            Teams.Add(new Team("England", @"Flags\England.png"));
            Teams.Add(new Team("Iran", @"Flags\Iran.png"));
            Teams.Add(new Team("United States", @"Flags\United States.png"));
            Teams.Add(new Team("Wales", @"\Flags\Wales.png"));
            //Group C teams
            Teams.Add(new Team("Argentina", @"Flags\Argentina.png"));
            Teams.Add(new Team("Saudi Arabia", @"\Flags\Saudi Arabia.png"));
            Teams.Add(new Team("Mexico", @"Flags\Mexico.png"));
            Teams.Add(new Team("Poland", @"Flags\Poland.png"));
            //Group D teams
            Teams.Add(new Team("France", @"Flags\France.png"));
            Teams.Add(new Team("Australia", @"Flags\Australia.png"));
            Teams.Add(new Team("Denmark", @"Flags\Denmark.png"));
            Teams.Add(new Team("Tunisia", @"\Flags\Tunisia.png"));
            //Group E teams
            Teams.Add(new Team("Spain", @"Flags\Spain.png"));
            Teams.Add(new Team("Costa Rica", @"Flags\Costa Rica.png"));
            Teams.Add(new Team("Germany", @"Flags\Germany.png"));
            Teams.Add(new Team("Japan", @"\Flags\Japan.png"));
            //Group F teams
            Teams.Add(new Team("Belgium", @"Flags\Belgium.png"));
            Teams.Add(new Team("Canada", @"Flags\Canada.png"));
            Teams.Add(new Team("Morocco", @"Flags\Morocco.png"));
            Teams.Add(new Team("Croatia", @"\Flags\Croatia.png"));
            //Group G teams
            Teams.Add(new Team("Brazil", @"Flags\Brazil.png"));
            Teams.Add(new Team("Serbia", @"Flags\Serbia.png"));
            Teams.Add(new Team("Switzerland", @"Flags\Switzerland.png"));
            Teams.Add(new Team("Cameroon", @"\Flags\Cameroon.png"));
            //Group H teams
            Teams.Add(new Team("Portugal", @"Flags\Portugal.png"));
            Teams.Add(new Team("Ghana", @"Flags\Ghana.png"));
            Teams.Add(new Team("Urugray", @"Flags\Uruguay.png"));
            Teams.Add(new Team("South Korea", @"\Flags\South Korea.png"));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("All flags are public domain and are sourced from flagpedia.net", "Credits");
        }
    }
}
