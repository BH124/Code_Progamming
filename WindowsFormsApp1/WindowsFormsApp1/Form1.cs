using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Motorcycle> motorcycles = new List<Motorcycle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up the DataGridView columns
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Make", "Make");
            dataGridView1.Columns.Add("Model", "Model");
            dataGridView1.Columns.Add("Year", "Year");
            dataGridView1.Columns.Add("Price", "Price");

            // Set up DataGridView properties
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Load sample data (You can replace this with data from a database or file)
            motorcycles.Add(new Motorcycle { Id = 1, Make = "Honda", Model = "CBR500R", Year = 2020, Price = 6000 });
            motorcycles.Add(new Motorcycle { Id = 2, Make = "Yamaha", Model = "YZF-R3", Year = 2021, Price = 5500 });

            RefreshGrid();
        }
        private void RefreshGrid()
        {
            // Clear existing rows in the DataGridView and populate it with the list of motorcycles
            dataGridView1.Rows.Clear();
            foreach (var motorcycle in motorcycles)
            {
                dataGridView1.Rows.Add(motorcycle.Id, motorcycle.Make, motorcycle.Model, motorcycle.Year, motorcycle.Price);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string make = txtMake.Text;
            string model = txtModel.Text;
            int year = int.Parse(txtYear.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            // Create a new Motorcycle object and add it to the list
            Motorcycle newMotorcycle = new Motorcycle { Id = id, Make = make, Model = model, Year = year, Price = price };
            motorcycles.Add(newMotorcycle);

            // Refresh the DataGridView
            RefreshGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected motorcycle's ID from the first cell in the selected row
                int selectedId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                // Find the motorcycle in the list based on the ID
                Motorcycle selectedMotorcycle = motorcycles.Find(m => m.Id == selectedId);

                // Update the motorcycle details based on the TextBox controls
                selectedMotorcycle.Make = txtMake.Text;
                selectedMotorcycle.Model = txtModel.Text;
                selectedMotorcycle.Year = int.Parse(txtYear.Text);
                selectedMotorcycle.Price = decimal.Parse(txtPrice.Text);

                // Refresh the DataGridView
                RefreshGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected motorcycle's ID from the first cell in the selected row
                int selectedId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                // Find and remove the motorcycle from the list based on the ID
                motorcycles.RemoveAll(m => m.Id == selectedId);

                // Refresh the DataGridView
                RefreshGrid();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
