using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyChangedEventsDemo.person;
namespace PropertyChangedEventsDemo
{
    public partial class Form1 : Form
    {
        private Person myPerson;
        public Form1()
        {
            InitializeComponent();

            myPerson = new Person("", "");
            myPerson.PropertyChanged += Person_PropertyChanged;

            myPerson.FirstName = "Joe";
            myPerson.LastName = "Smith";
        }

        private void Person_PropertyChanged (object sender, PropertyChangedEventArgs e)
        {

            
            if ("FirstName" == e.PropertyName)
            {
                updateNameButtons(button1, button2, "First Name", myPerson.FirstName);
            }
            if ("LastName" == e.PropertyName)
            {
                updateNameButtons(button3, button4, "Last Name", myPerson.LastName);
            }
            this.Text = "PropertyChangedEventsDemo " + myPerson.FirstName + " " + myPerson.LastName; 

        }

        private void updateNameButtons(Button btnName1, Button btnName2, string nameType, string nameValue)
        {
            btnName1.Text = nameType + " is currently " + nameValue + ". Click to change to " +
                btnName1.Tag.ToString() + ".";
            btnName2.Text = nameType + " is currently " + nameValue + ". Click to change to " +
                btnName2.Tag.ToString() + ".";

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            myPerson.FirstName = ((Button)sender).Tag.ToString(); 
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            myPerson.LastName = (sender as Button).Tag.ToString();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            myPerson.FirstName = ((Button)sender).Tag.ToString();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            myPerson.LastName = (sender as Button).Tag.ToString();
        }
    }
}
