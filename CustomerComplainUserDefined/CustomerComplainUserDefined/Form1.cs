using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerComplainUserDefined
{
    public partial class custComplainForm : Form
    {
        public custComplainForm()
        {
            InitializeComponent();
        }

        private Customer customers;
        private int serial = 0;
        Queue<Customer> q = new Queue<Customer>(); 
        
        private void queueButton_Click(object sender, EventArgs e)
        {
           serial++;
           
           string name2 = nameTextBox.Text;
           string complain2 = complainTextBox.Text;
           nameTextBox.Text = "";
           complainTextBox.Text = "";

           customers = new Customer(serial, name2, complain2);
           q.Enqueue(customers);

            MessageBox.Show(@"serial number is: " + serial);
           
           ListViewItem items = new ListViewItem(customers.getSerial().ToString());
           items.SubItems.Add(customers.getName().ToString());
           items.SubItems.Add(customers.getComplain().ToString());
           listView.Items.Add(items);


        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {

            
            if (q.Count == 0)
            {
                MessageBox.Show(@"Queue empty");
            }
            else
            {
                Customer com = q.Dequeue(); 
                serialNumTextBox.Text = com.getSerial().ToString();
                nameTextBox2.Text = com.getName().ToString();
                complainTextBox2.Text = com.getComplain().ToString();

                listView.Items[0].Remove();
            }
        }
    }
}
