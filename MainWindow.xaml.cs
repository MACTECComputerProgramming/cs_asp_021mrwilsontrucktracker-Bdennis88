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

namespace CS_ASP_21
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

        public DateTime dateLeft, dateReturned;
        public string days;
        public string pay;
        public string daysOff;
       
        public void dateLeftCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
           dateLeft = calendarDateLeft.SelectedDate.Value;
        }

        //Need to add the button click and add all the int and strings
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
           //Make variables for Social security, Phone, Start miles, and End miles 
            int socialSecurity = int.Parse(textBoxSocialSecurity.Text);

            int phone = int.Parse(textBoxPhone.Text);

            int startMiles = int.Parse(textBlockStartMiles.Text);

            int endMiles = int.Parse(textBoxEndMiles.Text);

            int milesTotal = endMiles - startMiles;

            int numberOfDays = int.Parse(labelNumberOfDaysOut.Text);

            //Need to finish the string Format information
            string driverName = string.Format("Driver - {0}", textBoxName.Text);

            string socialSecurityNumber = string.Format("Social Security Number # {0: 000-00-0000}", socialSecurity);

            string phoneNumber = string.Format("Phone Number: {0: (000)000-0000} ", phone);

            string totalMiles = string.Format("Total Miles: {0}", milesTotal);

            string numberofdays = string.Format("Number Of Days: {0}", days);

            string totalPay = string.Format("Total Pay: {0}", pay);

            string vacationDays = string.Format("Vacation Days: {0}", daysOff);

            labelDriver.Content = driverName;

            labelSecurityNumber.Content = socialSecurityNumber;

            labelPhoneNumber.Content = phoneNumber;

            labelMiles.Content = totalMiles;

            labelNumberOfDaysOut.Content = numberOfDays;

            labelTotalPay.Content = totalPay;

            labelNumberOfVacationDays.Content = vacationDays;

            //Need to fix the number of days
            //Then need to connect the labels to the text boxes
        }

    }
}