using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Telephonebook : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;
        public Telephonebook()
        {
            InitializeComponent();
        }

        private void Telephonebook_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Phone");
            contacts.Columns.Add("E-mail");
            contacts.Columns.Add("Birthday");


            ContactsDataGrid.DataSource = contacts;
        }


        private void FieldButt_Click(object sender, EventArgs e)
        {
            FirstNameBox.Text = "";
            LastNameBox.Text = "";
            PhoneBox.Text = "";
            EmailBox.Text = "";
            BirthdayBox.Text = "";
        }

        private void SaveButt_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex]["First Name"] = FirstNameBox.Text;
                contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex]["Last Name"] = LastNameBox.Text;
                contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex]["Phone"] = PhoneBox.Text;
                contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex]["E-mail"] = EmailBox.Text;
                contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex]["Birthday"] = BirthdayBox.Text;
            }
            else
            {
                contacts.Rows.Add(FirstNameBox.Text, LastNameBox.Text, PhoneBox.Text, EmailBox.Text, BirthdayBox.Text);
            }

            FirstNameBox.Text = "";
            LastNameBox.Text = "";
            PhoneBox.Text = "";
            EmailBox.Text = "";
            BirthdayBox.Text = "";
            editing = false;
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ypu made a mistake while writting info in a row");
            }
            FirstNameBox.Text = "";
            LastNameBox.Text = "";
            PhoneBox.Text = "";
            EmailBox.Text = "";
            BirthdayBox.Text = "";
        }

        private void ContactsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FirstNameBox.Text = contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            LastNameBox.Text = contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            PhoneBox.Text = contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            EmailBox.Text = contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            BirthdayBox.Text = contacts.Rows[ContactsDataGrid.CurrentCell.RowIndex].ItemArray[4].ToString();
            editing = true;
        }

    }
}

