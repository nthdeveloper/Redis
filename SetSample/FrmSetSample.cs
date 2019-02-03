using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetSample
{
    public partial class FrmSetSample : Form
    {
        public FrmSetSample()
        {
            InitializeComponent();
        }

        private IRedisClient getClient()
        {
            return new RedisClient(txtRedisHost.Text, (int)numRedisPort.Value);
        }

        private void btnAddToSet_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                var unsortedSet = client.Sets[txtSetName.Text];
                unsortedSet.Add(txtSetNewItem.Text);
            }
        }

        private void btnReadAllSetItems_Click(object sender, EventArgs e)
        {
            lbxSetItems.Items.Clear();

            using (IRedisClient client = getClient())
            {
                var unsortedSet = client.Sets[txtSetName.Text];

                foreach(string key in unsortedSet)
                    lbxSetItems.Items.Add(key);
            }
        }

        private void btnRemoveFromSet_Click(object sender, EventArgs e)
        {
            if (lbxSetItems.SelectedItem != null)
            {
                using (IRedisClient client = getClient())
                {
                    var unsortedSet = client.Sets[txtSetName.Text];

                    unsortedSet.Remove((string)lbxSetItems.SelectedItem);
                }
            }
        }

        private void btnDeleteSet_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.Remove(txtSetName.Text);

                //Another way
                //var unsortedSet = client.Sets[txtSetName.Text];
                //unsortedSet.Clear();
            }
        }
    }
}
