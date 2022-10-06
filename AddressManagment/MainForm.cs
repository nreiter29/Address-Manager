using Address_Manager.Class;
using System.Security.Cryptography.X509Certificates;

namespace AddressManagment {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        public List<Address> Addressdata { get; set; } = new();

        public void Data() {

            Address addressData = new Address(
                firstName: firstNameTextfield.Text,
                lastName: secondNameTextfield.Text,
                company: companyTextfield.Text,
                street: streetTextfield.Text,
                postalCode: plzTextfield.Text,
                city: cityTextfield.Text
           );

            Addressdata.Add(addressData);
        }

        private void clear() {
            firstNameTextfield.Text = "";
            secondNameTextfield.Text = "";
            companyTextfield.Text = "";
            streetTextfield.Text = "";
            plzTextfield.Text = "";
            cityTextfield.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e) {
            Data();
            foreach(Address address in Addressdata) {
                listBox1.Items.Add(address.FirstName + " " + address.LastName + " | " + address.Company + " | " + address.Street + " " + address.PostalCode + " " + address.City);
            }
            clear();
        }

        private void removeButton_Click(object sender, EventArgs e) {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}