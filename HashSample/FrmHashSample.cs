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

namespace HashSample
{
    public partial class FrmHashSample : Form
    {
        public FrmHashSample()
        {
            InitializeComponent();

            dgvEntries.AutoGenerateColumns = false;
        }

        private IRedisClient getClient()
        {
            return new RedisClient(txtRedisHost.Text, (int)numRedisPort.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.SetEntryInHash(txtHashName.Text, txtKey.Text, txtValue.Text);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.SetEntryInHash(txtHashName.Text, txtKey.Text, txtValue.Text);
            }
        }

        private void btnReadAllItems_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                Dictionary<string, string> allItems = client.GetAllEntriesFromHash(txtHashName.Text);

                dgvEntries.DataSource = allItems.ToList();
            }
        }

        private void btnGetByKey_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                string keyValue = client.GetValueFromHash(txtHashName.Text, txtItemKey.Text);

                if (!String.IsNullOrEmpty(keyValue))
                {
                    dgvEntries.DataSource = new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>(txtItemKey.Text, keyValue)
                    };
                }
                else
                    dgvEntries.DataSource = null;
            }
        }

        private void btnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            //If there is a selected row
            if (dgvEntries.SelectedRows.Count > 0)
            {
                //Get the source object for this selected row. 
                //DataBoundItem returns the source person object for the row 
                var item = (KeyValuePair<string, string>)dgvEntries.SelectedRows[0].DataBoundItem;

                using (IRedisClient client = getClient())
                {
                    client.RemoveEntryFromHash(txtHashName.Text, item.Key);
                }
            }
        }

        private void btnDeleteHash_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                //Just delete the hash
                client.Remove(txtHashName.Text);
            }
        }

        
    }
}
