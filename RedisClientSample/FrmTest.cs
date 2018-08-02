using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Redis;

namespace RedisClientSample
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();

            IRedisClient client = new RedisClient();
        }

        private IRedisClient getClient()
        {
            return new RedisClient(txtRedisHost.Text, (int)numRedisPort.Value);
        }

        private void btnSimpleSet_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.SetValue(txtSimpleSetKey.Text, txtSimpleSetValue.Text);
            }
        }

        private void btnSimpleGet_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                txtSimpleGetValue.Text = client.GetValue(txtSimpleGetKey.Text);
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                var list = client.Lists[txtListName.Text];
                list.Add(txtListNewItem.Text);
            }
        }

        private void btnReadAllListItems_Click(object sender, EventArgs e)
        {
            lbxListItems.Items.Clear();

            using (IRedisClient client = getClient())
            {
                List<string> listItems = client.GetAllItemsFromList(txtListName.Text);

                foreach(var item in listItems)
                {
                    lbxListItems.Items.Add(item);
                }
            }
        }

        private void btnCreateCounter_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.SetValue(txtCounterName.Text, txtCounterValue.Text);
            }
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.IncrementValueBy(txtCounterName.Text, 1);

                txtCounterValue.Text = client.GetValue(txtCounterName.Text);
            }
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.IncrementValueBy(txtCounterName.Text, -1);
                txtCounterValue.Text = client.GetValue(txtCounterName.Text);
            }
        }
    }
}
