using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remote_server;

namespace Remote_client
{
    public partial class Form1 : Form
    {
        Service remoteobj = new Service();
        public Form1()
        {
            InitializeComponent();
        }

        private void inputnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Click_Click(object sender, EventArgs e)
        {
            remoteobj = (Service)Activator.GetObject(typeof(Service), "tcp://localhost:8089/OurFirstRemoteService");
            int n1 = int.Parse(inputnum1.Text);
            int n2 = int.Parse(inputnum2.Text);
            result.Text = (remoteobj.HighestNumber(n1, n2)).ToString();
        }
    }
}
