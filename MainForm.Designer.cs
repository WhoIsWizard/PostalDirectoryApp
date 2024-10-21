// File: MainForm.Designer.cs
namespace PostalDirectoryApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabViewEntries;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.DataGridView dgvAllEntries;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveAsText;
        private System.Windows.Forms.Button btnSaveAsBinary;
        private System.Windows.Forms.Button btnOpenFromText;
        private System.Windows.Forms.Button btnOpenFromBinary;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label lblSearchContinent;
        private System.Windows.Forms.TextBox txtSearchContinent;
        private System.Windows.Forms.Label lblSearchCountry;
        private System.Windows.Forms.TextBox txtSearchCountry;
        private System.Windows.Forms.Label lblSearchRegion;
        private System.Windows.Forms.TextBox txtSearchRegion;
        private System.Windows.Forms.Label lblSearchDistrict;
        private System.Windows.Forms.TextBox txtSearchDistrict;
        private System.Windows.Forms.Label lblSearchLocality;
        private System.Windows.Forms.TextBox txtSearchLocality;
        private System.Windows.Forms.CheckBox chkSearchIsSafeLocality;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.GroupBox groupBoxReverseLookup;
        private System.Windows.Forms.Label lblReversePostalCode;
        private System.Windows.Forms.TextBox txtReversePostalCode;
        private System.Windows.Forms.Button btnReverseLookup;
        private System.Windows.Forms.DataGridView dgvReverseLookupResults;

        /// <summary>
        /// Метод для очищення ресурсів.
        /// </summary>
        /// <param name="disposing">true, якщо керовані ресурси слід утилізувати; інакше, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, згенерований Конструктором Форм Windows

        /// <summary>
        /// Метод, необхідний для підтримки конструктора — не змінюйте
        /// його вміст за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabViewEntries = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenFromBinary = new System.Windows.Forms.Button();
            this.btnOpenFromText = new System.Windows.Forms.Button();
            this.btnSaveAsBinary = new System.Windows.Forms.Button();
            this.btnSaveAsText = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAllEntries = new System.Windows.Forms.DataGridView();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.groupBoxReverseLookup = new System.Windows.Forms.GroupBox();
            this.lblReversePostalCode = new System.Windows.Forms.Label();
            this.txtReversePostalCode = new System.Windows.Forms.TextBox();
            this.btnReverseLookup = new System.Windows.Forms.Button();
            this.dgvReverseLookupResults = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchContinent = new System.Windows.Forms.Label();
            this.txtSearchContinent = new System.Windows.Forms.TextBox();
            this.lblSearchCountry = new System.Windows.Forms.Label();
            this.txtSearchCountry = new System.Windows.Forms.TextBox();
            this.lblSearchRegion = new System.Windows.Forms.Label();
            this.txtSearchRegion = new System.Windows.Forms.TextBox();
            this.lblSearchDistrict = new System.Windows.Forms.Label();
            this.txtSearchDistrict = new System.Windows.Forms.TextBox();
            this.lblSearchLocality = new System.Windows.Forms.Label();
            this.txtSearchLocality = new System.Windows.Forms.TextBox();
            this.chkSearchIsSafeLocality = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabViewEntries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEntries)).BeginInit();
            this.tabSearch.SuspendLayout();
            this.groupBoxReverseLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReverseLookupResults)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabViewEntries);
            this.tabControl.Controls.Add(this.tabSearch);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 637);
            this.tabControl.TabIndex = 0;
            // 
            // tabViewEntries
            // 
            this.tabViewEntries.Controls.Add(this.btnExit);
            this.tabViewEntries.Controls.Add(this.btnOpenFromBinary);
            this.tabViewEntries.Controls.Add(this.btnOpenFromText);
            this.tabViewEntries.Controls.Add(this.btnSaveAsBinary);
            this.tabViewEntries.Controls.Add(this.btnSaveAsText);
            this.tabViewEntries.Controls.Add(this.btnClear);
            this.tabViewEntries.Controls.Add(this.btnDelete);
            this.tabViewEntries.Controls.Add(this.btnEdit);
            this.tabViewEntries.Controls.Add(this.btnAdd);
            this.tabViewEntries.Controls.Add(this.dgvAllEntries);
            this.tabViewEntries.Location = new System.Drawing.Point(4, 29);
            this.tabViewEntries.Name = "tabViewEntries";
            this.tabViewEntries.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewEntries.Size = new System.Drawing.Size(952, 604);
            this.tabViewEntries.TabIndex = 0;
            this.tabViewEntries.Text = "Перегляд Записів";
            this.tabViewEntries.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(825, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenFromBinary
            // 
            this.btnOpenFromBinary.Location = new System.Drawing.Point(825, 180);
            this.btnOpenFromBinary.Name = "btnOpenFromBinary";
            this.btnOpenFromBinary.Size = new System.Drawing.Size(110, 50);
            this.btnOpenFromBinary.TabIndex = 8;
            this.btnOpenFromBinary.Text = "Відкрити з Бінарного";
            this.btnOpenFromBinary.UseVisualStyleBackColor = true;
            this.btnOpenFromBinary.Click += new System.EventHandler(this.btnOpenFromBinary_Click);
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.Location = new System.Drawing.Point(825, 120);
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Size = new System.Drawing.Size(110, 50);
            this.btnOpenFromText.TabIndex = 7;
            this.btnOpenFromText.Text = "Відкрити з Тексту";
            this.btnOpenFromText.UseVisualStyleBackColor = true;
            this.btnOpenFromText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.Location = new System.Drawing.Point(825, 60);
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            this.btnSaveAsBinary.Size = new System.Drawing.Size(110, 50);
            this.btnSaveAsBinary.TabIndex = 6;
            this.btnSaveAsBinary.Text = "Зберегти як Бінарний";
            this.btnSaveAsBinary.UseVisualStyleBackColor = true;
            this.btnSaveAsBinary.Click += new System.EventHandler(this.btnSaveAsBinary_Click);
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.Location = new System.Drawing.Point(825, 6);
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Size = new System.Drawing.Size(110, 50);
            this.btnSaveAsText.TabIndex = 5;
            this.btnSaveAsText.Text = "Зберегти як Текст";
            this.btnSaveAsText.UseVisualStyleBackColor = true;
            this.btnSaveAsText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(700, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(575, 550);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(450, 550);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(325, 550);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAllEntries
            // 
            this.dgvAllEntries.AllowUserToAddRows = false;
            this.dgvAllEntries.AllowUserToDeleteRows = false;
            this.dgvAllEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllEntries.Location = new System.Drawing.Point(6, 6);
            this.dgvAllEntries.MultiSelect = false;
            this.dgvAllEntries.Name = "dgvAllEntries";
            this.dgvAllEntries.ReadOnly = true;
            this.dgvAllEntries.RowHeadersWidth = 62;
            this.dgvAllEntries.RowTemplate.Height = 28;
            this.dgvAllEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllEntries.Size = new System.Drawing.Size(800, 530);
            this.dgvAllEntries.TabIndex = 0;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.groupBoxReverseLookup);
            this.tabSearch.Controls.Add(this.groupBoxSearch);
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(952, 604);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Пошук";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // groupBoxReverseLookup
            // 
            this.groupBoxReverseLookup.Controls.Add(this.lblReversePostalCode);
            this.groupBoxReverseLookup.Controls.Add(this.txtReversePostalCode);
            this.groupBoxReverseLookup.Controls.Add(this.btnReverseLookup);
            this.groupBoxReverseLookup.Controls.Add(this.dgvReverseLookupResults);
            this.groupBoxReverseLookup.Location = new System.Drawing.Point(480, 6);
            this.groupBoxReverseLookup.Name = "groupBoxReverseLookup";
            this.groupBoxReverseLookup.Size = new System.Drawing.Size(460, 590);
            this.groupBoxReverseLookup.TabIndex = 1;
            this.groupBoxReverseLookup.TabStop = false;
            this.groupBoxReverseLookup.Text = "Зворотний Пошук за Поштовим Індексом";
            // 
            // lblReversePostalCode
            // 
            this.lblReversePostalCode.AutoSize = true;
            this.lblReversePostalCode.Location = new System.Drawing.Point(20, 30);
            this.lblReversePostalCode.Name = "lblReversePostalCode";
            this.lblReversePostalCode.Size = new System.Drawing.Size(114, 20);
            this.lblReversePostalCode.TabIndex = 0;
            this.lblReversePostalCode.Text = "Поштовий індекс:";
            // 
            // txtReversePostalCode
            // 
            this.txtReversePostalCode.Location = new System.Drawing.Point(140, 27);
            this.txtReversePostalCode.Name = "txtReversePostalCode";
            this.txtReversePostalCode.Size = new System.Drawing.Size(200, 26);
            this.txtReversePostalCode.TabIndex = 1;
            // 
            // btnReverseLookup
            // 
            this.btnReverseLookup.Location = new System.Drawing.Point(350, 25);
            this.btnReverseLookup.Name = "btnReverseLookup";
            this.btnReverseLookup.Size = new System.Drawing.Size(100, 30);
            this.btnReverseLookup.TabIndex = 2;
            this.btnReverseLookup.Text = "Пошук";
            this.btnReverseLookup.UseVisualStyleBackColor = true;
            this.btnReverseLookup.Click += new System.EventHandler(this.btnReverseLookup_Click);
            // 
            // dgvReverseLookupResults
            // 
            this.dgvReverseLookupResults.AllowUserToAddRows = false;
            this.dgvReverseLookupResults.AllowUserToDeleteRows = false;
            this.dgvReverseLookupResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReverseLookupResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReverseLookupResults.Location = new System.Drawing.Point(6, 70);
            this.dgvReverseLookupResults.Name = "dgvReverseLookupResults";
            this.dgvReverseLookupResults.ReadOnly = true;
            this.dgvReverseLookupResults.RowHeadersWidth = 62;
            this.dgvReverseLookupResults.RowTemplate.Height = 28;
            this.dgvReverseLookupResults.Size = new System.Drawing.Size(448, 514);
            this.dgvReverseLookupResults.TabIndex = 3;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.lblSearchContinent);
            this.groupBoxSearch.Controls.Add(this.txtSearchContinent);
            this.groupBoxSearch.Controls.Add(this.lblSearchCountry);
            this.groupBoxSearch.Controls.Add(this.txtSearchCountry);
            this.groupBoxSearch.Controls.Add(this.lblSearchRegion);
            this.groupBoxSearch.Controls.Add(this.txtSearchRegion);
            this.groupBoxSearch.Controls.Add(this.lblSearchDistrict);
            this.groupBoxSearch.Controls.Add(this.txtSearchDistrict);
            this.groupBoxSearch.Controls.Add(this.lblSearchLocality);
            this.groupBoxSearch.Controls.Add(this.txtSearchLocality);
            this.groupBoxSearch.Controls.Add(this.chkSearchIsSafeLocality);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.dgvSearchResults);
            this.groupBoxSearch.Location = new System.Drawing.Point(6, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(460, 590);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Пошук за Критеріями";
            // 
            // lblSearchContinent
            // 
            this.lblSearchContinent.AutoSize = true;
            this.lblSearchContinent.Location = new System.Drawing.Point(20, 30);
            this.lblSearchContinent.Name = "lblSearchContinent";
            this.lblSearchContinent.Size = new System.Drawing.Size(91, 20);
            this.lblSearchContinent.TabIndex = 0;
            this.lblSearchContinent.Text = "Континент:";
            // 
            // txtSearchContinent
            // 
            this.txtSearchContinent.Location = new System.Drawing.Point(150, 27);
            this.txtSearchContinent.Name = "txtSearchContinent";
            this.txtSearchContinent.Size = new System.Drawing.Size(200, 26);
            this.txtSearchContinent.TabIndex = 1;
            // 
            // lblSearchCountry
            // 
            this.lblSearchCountry.AutoSize = true;
            this.lblSearchCountry.Location = new System.Drawing.Point(20, 70);
            this.lblSearchCountry.Name = "lblSearchCountry";
            this.lblSearchCountry.Size = new System.Drawing.Size(67, 20);
            this.lblSearchCountry.TabIndex = 2;
            this.lblSearchCountry.Text = "Країна:";
            // 
            // txtSearchCountry
            // 
            this.txtSearchCountry.Location = new System.Drawing.Point(150, 67);
            this.txtSearchCountry.Name = "txtSearchCountry";
            this.txtSearchCountry.Size = new System.Drawing.Size(200, 26);
            this.txtSearchCountry.TabIndex = 3;
            // 
            // lblSearchRegion
            // 
            this.lblSearchRegion.AutoSize = true;
            this.lblSearchRegion.Location = new System.Drawing.Point(20, 110);
            this.lblSearchRegion.Name = "lblSearchRegion";
            this.lblSearchRegion.Size = new System.Drawing.Size(62, 20);
            this.lblSearchRegion.TabIndex = 4;
            this.lblSearchRegion.Text = "Область:";
            // 
            // txtSearchRegion
            // 
            this.txtSearchRegion.Location = new System.Drawing.Point(150, 107);
            this.txtSearchRegion.Name = "txtSearchRegion";
            this.txtSearchRegion.Size = new System.Drawing.Size(200, 26);
            this.txtSearchRegion.TabIndex = 5;
            // 
            // lblSearchDistrict
            // 
            this.lblSearchDistrict.AutoSize = true;
            this.lblSearchDistrict.Location = new System.Drawing.Point(20, 150);
            this.lblSearchDistrict.Name = "lblSearchDistrict";
            this.lblSearchDistrict.Size = new System.Drawing.Size(58, 20);
            this.lblSearchDistrict.TabIndex = 6;
            this.lblSearchDistrict.Text = "Район:";
            // 
            // txtSearchDistrict
            // 
            this.txtSearchDistrict.Location = new System.Drawing.Point(150, 147);
            this.txtSearchDistrict.Name = "txtSearchDistrict";
            this.txtSearchDistrict.Size = new System.Drawing.Size(200, 26);
            this.txtSearchDistrict.TabIndex = 7;
            // 
            // lblSearchLocality
            // 
            this.lblSearchLocality.AutoSize = true;
            this.lblSearchLocality.Location = new System.Drawing.Point(20, 190);
            this.lblSearchLocality.Name = "lblSearchLocality";
            this.lblSearchLocality.Size = new System.Drawing.Size(94, 20);
            this.lblSearchLocality.TabIndex = 8;
            this.lblSearchLocality.Text = "Населений пункт:";
            // 
            // txtSearchLocality
            // 
            this.txtSearchLocality.Location = new System.Drawing.Point(150, 187);
            this.txtSearchLocality.Name = "txtSearchLocality";
            this.txtSearchLocality.Size = new System.Drawing.Size(200, 26);
            this.txtSearchLocality.TabIndex = 9;
            // 
            // chkSearchIsSafeLocality
            // 
            this.chkSearchIsSafeLocality.AutoSize = true;
            this.chkSearchIsSafeLocality.Location = new System.Drawing.Point(150, 227);
            this.chkSearchIsSafeLocality.Name = "chkSearchIsSafeLocality";
            this.chkSearchIsSafeLocality.Size = new System.Drawing.Size(183, 24);
            this.chkSearchIsSafeLocality.TabIndex = 10;
            this.chkSearchIsSafeLocality.Text = "Безпечний населений пункт";
            this.chkSearchIsSafeLocality.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(150, 267);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(6, 320);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersWidth = 62;
            this.dgvSearchResults.RowTemplate.Height = 28;
            this.dgvSearchResults.Size = new System.Drawing.Size(448, 264);
            this.dgvSearchResults.TabIndex = 12;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Довідник Поштової Індексації";
            this.tabControl.ResumeLayout(false);
            this.tabViewEntries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEntries)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.groupBoxReverseLookup.ResumeLayout(false);
            this.groupBoxReverseLookup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReverseLookupResults)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
