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

namespace SortedSetSample
{
    public partial class FrmSortedSetSample : Form
    {
        public FrmSortedSetSample()
        {
            InitializeComponent();

            dgvEntries.AutoGenerateColumns = false;
        }

        private IRedisClient getClient()
        {
            return new RedisClient(txtRedisHost.Text, (int)numRedisPort.Value);
        }

        private void btnAddToSortedSet_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.AddItemToSortedSet(txtSortedSetName.Text, txtItemKey.Text, (double)numItemScore.Value);
            }
        }

        private void btnIncrementScore_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.IncrementItemInSortedSet(txtSortedSetName.Text, txtItemKey.Text, (double)numItemScore.Value);

                //Another way
                //var sortedSet = client.SortedSets[txtSortedSetName.Text];
                //sortedSet.IncrementItemScore(txtItemKey.Text, (double)numItemScore.Value);
            }
        }

        private void btnDeleteSortedSet_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                client.Remove(txtSortedSetName.Text);
            }
        }

        private void btnReadAllItems_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                var sortedSet = client.SortedSets[txtSortedSetName.Text];

                List<string> allItems = sortedSet.GetAll();

                dgvEntries.DataSource = allItems.ConvertAll
                    (
                        name => new KeyValuePair<string, double>(name, sortedSet.GetItemScore(name)
                    ));
            }
        }

        private void btnGetByKey_Click(object sender, EventArgs e)
        {
            //Clear data grid
            dgvEntries.DataSource = null;

            using (IRedisClient client = getClient())
            {
                var sortedSet = client.SortedSets[txtSortedSetName.Text];

                if (sortedSet.Contains(txtGetItemKey.Text))
                {
                    dgvEntries.DataSource = new List<KeyValuePair<string, double>>()
                    {
                        new KeyValuePair<string, double>
                        (
                            txtGetItemKey.Text, 
                            sortedSet.GetItemScore(txtGetItemKey.Text)
                        )
                    };
                }                
            }
        }

        private void btnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            //If there is a selected row
            if (dgvEntries.SelectedRows.Count > 0)
            {
                //Get the source object for this selected row. 
                //DataBoundItem returns the source person object for the row 
                var item = (KeyValuePair<string, double>)dgvEntries.SelectedRows[0].DataBoundItem;

                using (IRedisClient client = getClient())
                {
                    var sortedSet = client.SortedSets[txtSortedSetName.Text];
                    sortedSet.Remove(item.Key);
                }
            }
        }        

        private void btnGetRangeByIndex_Click(object sender, EventArgs e)
        {
            dgvEntries.DataSource = null;

            using (IRedisClient client = getClient())
            {
                IDictionary<string, double> items = client.GetRangeWithScoresFromSortedSet(
                    txtSortedSetName.Text, 
                    (int)numStartIndex.Value, 
                    (int)numEndIndex.Value);

                dgvEntries.DataSource = items.ToList();
            }
        }

        private void btnGetRangeByScore_Click(object sender, EventArgs e)
        {
            dgvEntries.DataSource = null;

            using (IRedisClient client = getClient())
            {
                IDictionary<string, double> items = client
                    .GetRangeWithScoresFromSortedSetByHighestScore(
                    txtSortedSetName.Text,
                    (double)numStartScore.Value,
                    (double)numEndScore.Value);

                dgvEntries.DataSource = items.ToList();
            }
        }

        private void btnGetHighestScoredItem_Click(object sender, EventArgs e)
        {
            dgvEntries.DataSource = null;

            using (IRedisClient client = getClient())
            {
                var sortedSet = client.SortedSets[txtSortedSetName.Text];

                IDictionary<string, double> items = client
                    .GetRangeWithScoresFromSortedSetByHighestScore(
                    txtSortedSetName.Text,
                    double.NegativeInfinity,//min score
                    double.PositiveInfinity,//max score
                    0,//skip
                    (int)numItemCount.Value);//take

                dgvEntries.DataSource = items.ToList();
            }
        }

        private void btnGetLowestScoredItem_Click(object sender, EventArgs e)
        {
            dgvEntries.DataSource = null;

            using (IRedisClient client = getClient())
            {
                var sortedSet = client.SortedSets[txtSortedSetName.Text];

                IDictionary<string, double> items = client
                    .GetRangeWithScoresFromSortedSetByLowestScore(
                    txtSortedSetName.Text,
                    double.NegativeInfinity,//min score
                    double.PositiveInfinity,//max score
                    0,//skip
                    (int)numItemCount.Value);//take

                dgvEntries.DataSource = items.ToList();
            }
        }
    }
}
