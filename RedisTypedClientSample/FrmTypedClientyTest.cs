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

                var newPerson = new Person
                {
                    Id = personClient.GetNextSequence(),
                    Name = txtName.Text,
                    Surname = txtSurname.Text
                };

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

        private void btnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            //If there is a selected row
            if(dgvPerson.SelectedRows.Count > 0)
            {
                //Get the person object for this selected row. 
                //DataBoundItem returns the source person object for the row 
                Person person = (Person)dgvPerson.SelectedRows[0].DataBoundItem;

                using (IRedisClient client = getClient())
                {
                    var personClient = client.As<Person>();
                    personClient.Delete(person);

                    //You can also delete by id
                    //personClient.DeleteById(person.Id);
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                var personClient = client.As<Person>();
                personClient.DeleteAll();
            }
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            using (IRedisClient client = getClient())
            {
                var personClient = client.As<Person>();

                //Get the key for the automatically created sequence for Person type
                //Then remove this key from Redis
                client.Remove(personClient.SequenceKey);
            }
        }
    }
}
