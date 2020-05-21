using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.ServiceReferencePrinter;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private ServiceReferencePrinter.GetUsersServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReferencePrinter.GetUsersServiceClient();
        }

        //Get available Amount
        private void button2_Click(object sender, EventArgs e)
        {
            var result = client.GetAvailableAmount(int.Parse(textBoxUID.Text));
            textBoxAvAmount.Text = result.ToString();
        }

        private void buttonListUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            client.ReloadMoneyUID(int.Parse(textBoxUID.Text), int.Parse(textBoxAmount.Text));
            var result = client.GetAvailableAmount(int.Parse(textBoxUID.Text));
            textBoxAvAmount.Text = result.ToString();
        }

       /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<UserAccount> users = client.GetUsers();
            //dataGridView1.Rows.Add()
        }*/

        private void buttonUsrByCard_Click(object sender, EventArgs e)
        { 
            //client.get
            //buttonUsrByCard
                //client.ge(int.Parse(textBoxUID.Text), int.Parse(textBoxAmount.Text));
            var usrname = client.getUsernameByCardID(textBoxCardID.Text);
            textBoxUsrname.Text = usrname.ToString();
        }

    }
}
