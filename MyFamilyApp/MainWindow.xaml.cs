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

namespace MyFamilyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Member> member = new List<Member>();

            member.Add(new Member() { FirstName = First_Name_TextBox.Text, LastName = Last_Name_TextBox.Text, Age = Age_TextBoc.Text, Occupation = Occupation_TextBox.Text, Relation = RelationType.Text, Gender = GenderMale.Name });

            FamilyTableGrid.ItemsSource = member;
        }

       public class Member
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Occupation { get; set; }

            public string Age { get; set; }

            public string Relation { get; set; }

            public string Gender { get; set; }
        }
        
    }
}
