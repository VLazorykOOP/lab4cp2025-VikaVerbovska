using System;
using System.Data;
using System.Windows.Forms;

namespace ComputerSalesApp
{
    public partial class Form1 : Form
    {
        private Database db;

        public Form1()
        {
            InitializeComponent();
            db = new Database();
            LoadComputers();

            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnSearch.Click += btnSearch_Click;
            btnExit.Click += btnExit_Click;

            dataGridViewComputers.CellClick += DataGridViewComputers_CellClick;
        }

        private void LoadComputers()
        {
            dataGridViewComputers.DataSource = db.GetAllComputers();
        }

        private void DataGridViewComputers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewComputers.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtCPU.Text = row.Cells["cpu"].Value.ToString();
                txtFrequency.Text = row.Cells["frequency"].Value.ToString();
                txtGPU.Text = row.Cells["gpu"].Value.ToString();
                txtRAM.Text = row.Cells["ram"].Value.ToString();
                txtSoundcard.Text = row.Cells["soundcard"].Value.ToString();
                txtHDD.Text = row.Cells["hdd"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.AddComputer(txtName.Text, txtCPU.Text, txtFrequency.Text, txtGPU.Text, txtRAM.Text, txtSoundcard.Text, txtHDD.Text);
            LoadComputers();
            ClearInputFields();
            MessageBox.Show("Комп’ютер додано!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                db.UpdateComputer(id, txtName.Text, txtCPU.Text, txtFrequency.Text, txtGPU.Text, txtRAM.Text, txtSoundcard.Text, txtHDD.Text);
                LoadComputers();
                ClearInputFields();
                MessageBox.Show("Комп’ютер оновлено!");
            }
            else
            {
                MessageBox.Show("Оберіть комп’ютер для редагування.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                db.DeleteComputer(id);
                LoadComputers();
                ClearInputFields();
                MessageBox.Show("Комп’ютер видалено!");
            }
            else
            {
                MessageBox.Show("Оберіть комп’ютер для видалення.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                dataGridViewComputers.DataSource = db.SearchComputersByName(searchText);
            }
            else
            {
                LoadComputers();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearInputFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtCPU.Clear();
            txtFrequency.Clear();
            txtGPU.Clear();
            txtRAM.Clear();
            txtSoundcard.Clear();
            txtHDD.Clear();
        }
    }
}
