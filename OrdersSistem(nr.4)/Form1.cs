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
            ClientLisGenerator clients = new ClientLisGenerator();
            clients.clientListGenerator();
            textBox.AppendText("Kliento ataskaita sugeneruota sekimngai.");    
        }
        
        private void PrewieOrderbutton_Click(object sender, EventArgs e)
        {   
            OrderRepository orderList = new OrderRepository();
            List<Order> orders = orderList.Retrieve();
            for (int i = 0; i < orders.Count; i++)
            {
                textBox1.AppendText($"Užsakymo numeris: {orders[i].Id}.\r\n Užsakovas: {orders[i].Client.FirstName}  {orders[i].Client.LastName};\r\n Paslauga: {orders[i].Service.Name} \r\n Kaina: {orders[i].CountPrice()}\r\nPaslauga apmokėta: {orders[i].IsPaid}\r\n\r\n");
            }
            
        }

        private void PaimentButton_Click(object sender, EventArgs e)
        {
            OrderRepository orders = new OrderRepository();
            orders.GenerateClientsNotPaidList();
            MessageBox.Show("Nemokių klientų ataskaita sugeneruota sėkmingai.");
            
        }
    }
}
