using ClientList_Generator;
using OrderService_DataAccess;
using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersSistem_nr._4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OrderPreviewButton_Click(object sender, EventArgs e)
        {
            ClientLisGenerator clientList = new ClientLisGenerator();
            clientList.clientListGenerator();
            textBox.AppendText("Kliengtų ataskaita sugeneruota");

            ClientRepository clientRepo = new ClientRepository();
            List<Client> clienList = clientRepo.Retrieve();
            for (int i = 0; i < clienList.Count; i++)
            {
                textBox.AppendText(clienList[i].FirstName);
                textBox.AppendText(clienList[i].LastName);
                textBox.AppendText(clienList[i].Adress);
                textBox.AppendText(clienList[i].Email);
                
            }
            
        }
    }
}
