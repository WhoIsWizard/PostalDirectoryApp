// File: AddEntryForm.Designer.cs
namespace PostalDirectoryApp
{
    partial class AddEntryForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.TextBox txtContinent;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label lblLocality;
        private System.Windows.Forms.TextBox txtLocality;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.CheckBox chkIsSafeLocality;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.NumericUpDown numPopulation;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.NumericUpDown numArea;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        /// Метод для очищення ресурсів.
        /// </summary>
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
            this.lblContinent = new System.Windows.Forms.Label();
            this.txtContinent = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.lblLocality = new System.Windows.Forms.Label();
            this.txtLocality = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.chkIsSafeLocality = new System.Windows.Forms.CheckBox();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.numPopulation = new System.Windows.Forms.NumericUpDown();
            this.lblArea = new System.Windows.Forms.Label();
            this.numArea = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).BeginInit();
            this.SuspendLayout();

            // 
            // lblContinent
            // 
            this.lblContinent.AutoSize = true;
            this.lblContinent.Location = new System.Drawing.Point(12, 15);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(91, 20);
            this.lblContinent.TabIndex = 0;
            this.lblContinent.Text = "Континент:";
            // 
            // txtContinent
            // 
            this.txtContinent.Location = new System.Drawing.Point(150, 12);
            this.txtContinent.Name = "txtContinent";
            this.txtContinent.Size = new System.Drawing.Size(200, 26);
            this.txtContinent.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(12, 55);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(67, 20);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Країна:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(150, 52);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 26);
            this.txtCountry.TabIndex = 3;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(12, 95);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(62, 20);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Область:";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(150, 92);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(200, 26);
            this.txtRegion.TabIndex = 5;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(12, 135);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(58, 20);
            this.lblDistrict.TabIndex = 6;
            this.lblDistrict.Text = "Район:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(150, 132);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(200, 26);
            this.txtDistrict.TabIndex = 7;
            // 
            // lblLocality
            // 
            this.lblLocality.AutoSize = true;
            this.lblLocality.Location = new System.Drawing.Point(12, 175);
            this.lblLocality.Name = "lblLocality";
            this.lblLocality.Size = new System.Drawing.Size(94, 20);
            this.lblLocality.TabIndex = 8;
            this.lblLocality.Text = "Населений пункт:";
            // 
            // txtLocality
            // 
            this.txtLocality.Location = new System.Drawing.Point(150, 172);
            this.txtLocality.Name = "txtLocality";
            this.txtLocality.Size = new System.Drawing.Size(200, 26);
            this.txtLocality.TabIndex = 9;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(12, 215);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(114, 20);
            this.lblPostalCode.TabIndex = 10;
            this.lblPostalCode.Text = "Поштовий індекс:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(150, 212);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(200, 26);
            this.txtPostalCode.TabIndex = 11;
            // 
            // chkIsSafeLocality
            // 
            this.chkIsSafeLocality.AutoSize = true;
            this.chkIsSafeLocality.Location = new System.Drawing.Point(150, 252);
            this.chkIsSafeLocality.Name = "chkIsSafeLocality";
            this.chkIsSafeLocality.Size = new System.Drawing.Size(183, 24);
            this.chkIsSafeLocality.TabIndex = 12;
            this.chkIsSafeLocality.Text = "Безпечний населений пункт";
            this.chkIsSafeLocality.UseVisualStyleBackColor = true;
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(12, 295);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(93, 20);
            this.lblPopulation.TabIndex = 13;
            this.lblPopulation.Text = "Населення:";
            // 
            // numPopulation
            // 
            this.numPopulation.Location = new System.Drawing.Point(150, 292);
            this.numPopulation.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPopulation.Name = "numPopulation";
            this.numPopulation.Size = new System.Drawing.Size(200, 26);
            this.numPopulation.TabIndex = 14;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 335);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(114, 20);
            this.lblArea.TabIndex = 15;
            this.lblArea.Text = "Площа (км²):";
            // 
            // numArea
            // 
            this.numArea.DecimalPlaces = 2;
            this.numArea.Location = new System.Drawing.Point(150, 332);
            this.numArea.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numArea.Name = "numArea";
            this.numArea.Size = new System.Drawing.Size(200, 26);
            this.numArea.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 35);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEntryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.numPopulation);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.chkIsSafeLocality);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.txtLocality);
            this.Controls.Add(this.lblLocality);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtContinent);
            this.Controls.Add(this.lblContinent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додавання/Редагування Запису";
            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
