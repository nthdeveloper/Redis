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

namespace RedisTypedClientSample
{
    public partial class FrmTypedClientyTest : Form
    {
        public FrmTypedClientyTest()
        {
            InitializeComponent();
            dgvPerson.AutoGenerateColumns = false;
        }

        private IRedisClient getClient()
        {
            return new RedisClient(txtRedisHost.Text, (int)numRedisPort.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                var personClient = client.As<Person>();

                var newPerson = new Person { Id = personClient.GetNextSequence(), Name = txtName.Text, Surname=txtSurname.Text };

                personClient.Store(newPerson);
            }
        }

        private void btnReadAllItems_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                var personClient = client.As<Person>();

                dgvPerson.DataSource = personClient.GetAll();
            }
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = null;

            using (IRedisClient client = getClient())
            {
                var personClient = client.As<Person>();

                long id = Int64.Parse(txtId.Text.Trim());

                var person = personClient.GetById(id);
                if (person != null)
                    dgvPerson.DataSource = new List<Person>(new Person[] { person });                
            }
        }
    }
}
