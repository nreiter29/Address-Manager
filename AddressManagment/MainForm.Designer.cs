namespace AddressManagment {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameTextfield = new System.Windows.Forms.TextBox();
            this.secondNameTextfield = new System.Windows.Forms.TextBox();
            this.companyTextfield = new System.Windows.Forms.TextBox();
            this.streetTextfield = new System.Windows.Forms.TextBox();
            this.plzTextfield = new System.Windows.Forms.TextBox();
            this.cityTextfield = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Straße";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "PLZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ort";
            // 
            // firstNameTextfield
            // 
            this.firstNameTextfield.Location = new System.Drawing.Point(175, 65);
            this.firstNameTextfield.Name = "firstNameTextfield";
            this.firstNameTextfield.Size = new System.Drawing.Size(150, 31);
            this.firstNameTextfield.TabIndex = 6;
            // 
            // secondNameTextfield
            // 
            this.secondNameTextfield.Location = new System.Drawing.Point(331, 65);
            this.secondNameTextfield.Name = "secondNameTextfield";
            this.secondNameTextfield.Size = new System.Drawing.Size(150, 31);
            this.secondNameTextfield.TabIndex = 7;
            // 
            // companyTextfield
            // 
            this.companyTextfield.Location = new System.Drawing.Point(487, 65);
            this.companyTextfield.Name = "companyTextfield";
            this.companyTextfield.Size = new System.Drawing.Size(150, 31);
            this.companyTextfield.TabIndex = 8;
            // 
            // streetTextfield
            // 
            this.streetTextfield.Location = new System.Drawing.Point(175, 130);
            this.streetTextfield.Name = "streetTextfield";
            this.streetTextfield.Size = new System.Drawing.Size(150, 31);
            this.streetTextfield.TabIndex = 9;
            // 
            // plzTextfield
            // 
            this.plzTextfield.Location = new System.Drawing.Point(331, 130);
            this.plzTextfield.Name = "plzTextfield";
            this.plzTextfield.Size = new System.Drawing.Size(150, 31);
            this.plzTextfield.TabIndex = 10;
            // 
            // cityTextfield
            // 
            this.cityTextfield.Location = new System.Drawing.Point(487, 130);
            this.cityTextfield.Name = "cityTextfield";
            this.cityTextfield.Size = new System.Drawing.Size(150, 31);
            this.cityTextfield.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(345, 178);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 240);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 179);
            this.listBox1.TabIndex = 13;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeButton.Location = new System.Drawing.Point(676, 200);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(112, 34);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cityTextfield);
            this.Controls.Add(this.plzTextfield);
            this.Controls.Add(this.streetTextfield);
            this.Controls.Add(this.companyTextfield);
            this.Controls.Add(this.secondNameTextfield);
            this.Controls.Add(this.firstNameTextfield);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox firstNameTextfield;
        private TextBox secondNameTextfield;
        private TextBox companyTextfield;
        private TextBox streetTextfield;
        private TextBox plzTextfield;
        private TextBox cityTextfield;
        private Button addButton;
        private ListBox listBox1;
        private Button removeButton;
    }
}