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
            List<Client> clientList = clientRepo.Deserialaizer();
            //nepamirsk sita perkelti i metoda, ir pataisyti, kad viena dokumenta sugeneruotu, o ne 500 su vienu klientu.
            for (int i = 0; i < clientList.Count; i++)
            {
                var report = $"Vardas: {clientList[i].FirstName};\r\n Pavarde: {clientList[i].LastName}; \r\n Gyvenamasis adresas: {clientList[i].Adress}; \r\n Elektroninio pasto adresas: {clientList[i].Email}\r\n";
                var fileName = "ClientReport.txt";
                var path = @$"C:\Users\Vartotojas\source\repos\Lesson-15\OrdersSistem(nr.4)\{fileName}";
                File.WriteAllText(path, report);
            }
            

        }
    }
}
