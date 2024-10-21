// File: AddEntryForm.cs
using System;
using System.Windows.Forms;

namespace PostalDirectoryApp
{
    public partial class AddEntryForm : Form
    {
        public PostalDirectoryEntry Entry { get; set; }

        public AddEntryForm()
        {
            InitializeComponent();
            Entry = new PostalDirectoryEntry();
        }

        public AddEntryForm(PostalDirectoryEntry entry) : this()
        {
            // Використовуємо переданий запис для редагування
            Entry = entry;

            // Заповнюємо поля форми існуючими даними
            txtContinent.Text = Entry.Continent;
            txtCountry.Text = Entry.Country;
            txtRegion.Text = Entry.Region;
            txtDistrict.Text = Entry.District;
            txtLocality.Text = Entry.Locality;
            txtPostalCode.Text = Entry.PostalCode;
            chkIsSafeLocality.Checked = Entry.IsSafeLocality;
            numPopulation.Value = Entry.Population;
            numArea.Value = (decimal)Entry.Area;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Валідація введених даних
            if (ValidateFields())
            {
                // Збереження даних у властивість Entry
                Entry.Continent = txtContinent.Text.Trim();
                Entry.Country = txtCountry.Text.Trim();
                Entry.Region = txtRegion.Text.Trim();
                Entry.District = txtDistrict.Text.Trim();
                Entry.Locality = txtLocality.Text.Trim();
                Entry.PostalCode = txtPostalCode.Text.Trim();
                Entry.IsSafeLocality = chkIsSafeLocality.Checked;
                Entry.Population = (int)numPopulation.Value;
                Entry.Area = (double)numArea.Value;

                // Повертаємо діалоговий результат OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            // Перевірка, чи заповнені обов'язкові поля
            if (string.IsNullOrWhiteSpace(txtContinent.Text) ||
                string.IsNullOrWhiteSpace(txtCountry.Text) ||
                string.IsNullOrWhiteSpace(txtRegion.Text) ||
                string.IsNullOrWhiteSpace(txtLocality.Text) ||
                string.IsNullOrWhiteSpace(txtPostalCode.Text))
            {
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Закриваємо форму без збереження
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
