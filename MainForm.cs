// File: MainForm.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace PostalDirectoryApp
{
    public partial class MainForm : Form
    {
        private PostalDirectory postalDirectory;

        public MainForm()
        {
            InitializeComponent();
            postalDirectory = new PostalDirectory();

            // Додаємо 15 прикладів записів
            AddSampleEntries();

            // Відображаємо записи
            PopulateDataGridView();
        }

        // Метод для додавання прикладів записів
        private void AddSampleEntries()
        {
            postalDirectory.AddEntry(new PostalDirectoryEntry("Євразія", "Україна", "Київська", "Києво-Святошинський", "Київ", "01001", true, 2968000, 847.66));
            postalDirectory.AddEntry(new PostalDirectoryEntry("Євразія", "Франція", "Іль-де-Франс", "Париж", "Париж", "75000", true, 2148000, 105.4));
            postalDirectory.AddEntry(new PostalDirectoryEntry("Євразія", "Німеччина", "Баварія", "Мюнхен", "Мюнхен", "80331", true, 1472000, 310.7));
            postalDirectory.AddEntry(new PostalDirectoryEntry("Північна Америка", "США", "Каліфорнія", "Лос-Анджелес", "Лос-Анджелес", "90001", true, 3971000, 1302));
            postalDirectory.AddEntry(new PostalDirectoryEntry("Азія", "Японія", "Канто", "Токіо", "Токіо", "100-0001", true, 13960000, 2191));
            // Додайте ще 10 записів за аналогією
        }

        // Метод для оновлення DataGridView
        private void PopulateDataGridView()
        {
            dgvAllEntries.DataSource = null;
            dgvAllEntries.DataSource = postalDirectory.GetAllEntries();
        }

        // Кнопка "Додати"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEntryForm addForm = new AddEntryForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                postalDirectory.AddEntry(addForm.Entry);
                PopulateDataGridView();
            }
        }

        // Кнопка "Редагувати"
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAllEntries.CurrentRow != null)
            {
                // Отримуємо обраний запис
                PostalDirectoryEntry selectedEntry = (PostalDirectoryEntry)dgvAllEntries.CurrentRow.DataBoundItem;

                // Створюємо копію запису для редагування
                PostalDirectoryEntry entryCopy = new PostalDirectoryEntry(
                    selectedEntry.Continent,
                    selectedEntry.Country,
                    selectedEntry.Region,
                    selectedEntry.District,
                    selectedEntry.Locality,
                    selectedEntry.PostalCode,
                    selectedEntry.IsSafeLocality,
                    selectedEntry.Population,
                    selectedEntry.Area
                );

                // Відкриваємо форму редагування з копією запису
                AddEntryForm editForm = new AddEntryForm(entryCopy);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Оновлюємо оригінальний запис
                    selectedEntry.Continent = entryCopy.Continent;
                    selectedEntry.Country = entryCopy.Country;
                    selectedEntry.Region = entryCopy.Region;
                    selectedEntry.District = entryCopy.District;
                    selectedEntry.Locality = entryCopy.Locality;
                    selectedEntry.PostalCode = entryCopy.PostalCode;
                    selectedEntry.IsSafeLocality = entryCopy.IsSafeLocality;
                    selectedEntry.Population = entryCopy.Population;
                    selectedEntry.Area = entryCopy.Area;

                    // Оновлюємо DataGridView
                    PopulateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Оберіть запис для редагування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Кнопка "Видалити"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAllEntries.CurrentRow != null)
            {
                PostalDirectoryEntry entry = (PostalDirectoryEntry)dgvAllEntries.CurrentRow.DataBoundItem;
                if (MessageBox.Show("Видалити поточний запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    postalDirectory.RemoveEntry(entry);
                    PopulateDataGridView();
                }
            }
        }

        // Кнопка "Очистити"
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити всі записи?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                postalDirectory.ClearEntries();
                PopulateDataGridView();
            }
        }

        // Кнопка "Вихід"
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вийти з програми?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Кнопка "Зберегти як Текст"
        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            // Реалізація збереження в текстовий файл
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                {
                    foreach (var entry in postalDirectory.GetAllEntries())
                    {
                        sw.WriteLine($"{entry.Continent}\t{entry.Country}\t{entry.Region}\t{entry.District}\t{entry.Locality}\t{entry.PostalCode}\t{entry.IsSafeLocality}\t{entry.Population}\t{entry.Area}");
                    }
                }
            }
        }

        // Кнопка "Зберегти як Бінарний"
        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            // Реалізація збереження в бінарний файл
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Бінарні файли (*.bin)|*.bin|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.Create)))
                {
                    foreach (var entry in postalDirectory.GetAllEntries())
                    {
                        bw.Write(entry.Continent);
                        bw.Write(entry.Country);
                        bw.Write(entry.Region);
                        bw.Write(entry.District);
                        bw.Write(entry.Locality);
                        bw.Write(entry.PostalCode);
                        bw.Write(entry.IsSafeLocality);
                        bw.Write(entry.Population);
                        bw.Write(entry.Area);
                    }
                }
            }
        }

        // Кнопка "Відкрити з Тексту"
        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            // Реалізація відкриття з текстового файлу
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Відкрити дані з текстового файлу";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                postalDirectory.ClearEntries();

                using (StreamReader sr = new StreamReader(openFileDialog.FileName, System.Text.Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\t');
                        if (parts.Length >= 9)
                        {
                            PostalDirectoryEntry entry = new PostalDirectoryEntry
                            {
                                Continent = parts[0],
                                Country = parts[1],
                                Region = parts[2],
                                District = parts[3],
                                Locality = parts[4],
                                PostalCode = parts[5],
                                IsSafeLocality = bool.Parse(parts[6]),
                                Population = int.Parse(parts[7]),
                                Area = double.Parse(parts[8])
                            };
                            postalDirectory.AddEntry(entry);
                        }
                    }
                }

                PopulateDataGridView();
            }
        }

        // Кнопка "Відкрити з Бінарного"
        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            // Реалізація відкриття з бінарного файлу
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Бінарні файли (*.bin)|*.bin|All files (*.*)|*.*";
            openFileDialog.Title = "Відкрити дані з бінарного файлу";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                postalDirectory.ClearEntries();

                using (BinaryReader br = new BinaryReader(File.Open(openFileDialog.FileName, FileMode.Open)))
                {
                    while (br.BaseStream.Position != br.BaseStream.Length)
                    {
                        PostalDirectoryEntry entry = new PostalDirectoryEntry
                        {
                            Continent = br.ReadString(),
                            Country = br.ReadString(),
                            Region = br.ReadString(),
                            District = br.ReadString(),
                            Locality = br.ReadString(),
                            PostalCode = br.ReadString(),
                            IsSafeLocality = br.ReadBoolean(),
                            Population = br.ReadInt32(),
                            Area = br.ReadDouble()
                        };
                        postalDirectory.AddEntry(entry);
                    }
                }

                PopulateDataGridView();
            }
        }

        // Обробники для пошуку та зворотного пошуку
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string continent = txtSearchContinent.Text.Trim();
            string country = txtSearchCountry.Text.Trim();
            string region = txtSearchRegion.Text.Trim();
            string district = txtSearchDistrict.Text.Trim();
            string locality = txtSearchLocality.Text.Trim();
            bool? isSafeLocality = null;

            if (chkSearchIsSafeLocality.Checked)
                isSafeLocality = true;

            List<PostalDirectoryEntry> results = postalDirectory.Search(
                continent: string.IsNullOrEmpty(continent) ? null : continent,
                country: string.IsNullOrEmpty(country) ? null : country,
                region: string.IsNullOrEmpty(region) ? null : region,
                district: string.IsNullOrEmpty(district) ? null : district,
                locality: string.IsNullOrEmpty(locality) ? null : locality,
                isSafeLocality: isSafeLocality
            );

            dgvSearchResults.DataSource = null;
            dgvSearchResults.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("Немає записів, що відповідають критеріям пошуку.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReverseLookup_Click(object sender, EventArgs e)
        {
            string postalCode = txtReversePostalCode.Text.Trim();

            if (string.IsNullOrEmpty(postalCode))
            {
                MessageBox.Show("Будь ласка, введіть поштовий індекс.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<PostalDirectoryEntry> results = postalDirectory.ReverseLookup(postalCode);

            dgvReverseLookupResults.DataSource = null;
            dgvReverseLookupResults.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("Поштовий індекс не знайдено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
