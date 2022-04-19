using ClientList_Generator;
using OrderService_DataAccess;
using OrderSistem_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            ClientRepository clientRepo = new ClientRepository();
            clientRepo.Deserialaizer();
            textBox.AppendText("Kliento ataskaita sugeneruota sekimngai.");//nebaigta         
            
        }

        private void PrewieOrderbutton_Click(object sender, EventArgs e)
        {   
            OrderRepository orderList = new OrderRepository();
            List<Order> orders = orderList.Retrieve();
            for (int i = 0; i < orders.Count; i++)
            {
                textBox1.AppendText($"Užsakymo numeris: {orders[i].Id}.\r\n Užsakovas: {orders[i].Client.FirstName}  {orders[i].Client.LastName};\r\n Paslauga: {orders[i].Service.Name} \r\n Kaina: {orders[i].CountPrice()}\r\n\r\n");
            }
            
        }
    }
}
