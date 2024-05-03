namespace InventoryManagment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtGarment1SizeS = new TextBox();
            txtGarment1SizeM = new TextBox();
            txtGarment1SizeL = new TextBox();
            txtGarment2SizeL = new TextBox();
            txtGarment2SizeM = new TextBox();
            txtGarment2SizeS = new TextBox();
            btnShowSales = new Button();
            lblSales = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Garment 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 39);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Garment 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 87);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = " Size S";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 129);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = " Size M";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 165);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = " Size L";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 178);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 7;
            label6.Text = " Size L";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 129);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 6;
            label7.Text = " Size M";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(363, 84);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 5;
            label8.Text = " Size S";
            // 
            // txtGarment1SizeS
            // 
            txtGarment1SizeS.Location = new Point(88, 84);
            txtGarment1SizeS.Name = "txtGarment1SizeS";
            txtGarment1SizeS.Size = new Size(100, 23);
            txtGarment1SizeS.TabIndex = 8;
            // 
            // txtGarment1SizeM
            // 
            txtGarment1SizeM.Location = new Point(88, 129);
            txtGarment1SizeM.Name = "txtGarment1SizeM";
            txtGarment1SizeM.Size = new Size(100, 23);
            txtGarment1SizeM.TabIndex = 9;
            // 
            // txtGarment1SizeL
            // 
            txtGarment1SizeL.Location = new Point(88, 175);
            txtGarment1SizeL.Name = "txtGarment1SizeL";
            txtGarment1SizeL.Size = new Size(100, 23);
            txtGarment1SizeL.TabIndex = 10;
            // 
            // txtGarment2SizeL
            // 
            txtGarment2SizeL.Location = new Point(452, 173);
            txtGarment2SizeL.Name = "txtGarment2SizeL";
            txtGarment2SizeL.Size = new Size(100, 23);
            txtGarment2SizeL.TabIndex = 13;
            // 
            // txtGarment2SizeM
            // 
            txtGarment2SizeM.Location = new Point(452, 127);
            txtGarment2SizeM.Name = "txtGarment2SizeM";
            txtGarment2SizeM.Size = new Size(100, 23);
            txtGarment2SizeM.TabIndex = 12;
            // 
            // txtGarment2SizeS
            // 
            txtGarment2SizeS.Location = new Point(452, 82);
            txtGarment2SizeS.Name = "txtGarment2SizeS";
            txtGarment2SizeS.Size = new Size(100, 23);
            txtGarment2SizeS.TabIndex = 11;
            // 
            // btnShowSales
            // 
            btnShowSales.Location = new Point(22, 242);
            btnShowSales.Name = "btnShowSales";
            btnShowSales.Size = new Size(75, 23);
            btnShowSales.TabIndex = 14;
            btnShowSales.Text = "Show Sales";
            btnShowSales.UseVisualStyleBackColor = true;
            btnShowSales.Click += btnShowSales_Click;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSales.Location = new Point(125, 242);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(0, 25);
            lblSales.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 294);
            Controls.Add(lblSales);
            Controls.Add(btnShowSales);
            Controls.Add(txtGarment2SizeL);
            Controls.Add(txtGarment2SizeM);
            Controls.Add(txtGarment2SizeS);
            Controls.Add(txtGarment1SizeL);
            Controls.Add(txtGarment1SizeM);
            Controls.Add(txtGarment1SizeS);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtGarment1SizeS;
        private TextBox txtGarment1SizeM;
        private TextBox txtGarment1SizeL;
        private TextBox txtGarment2SizeL;
        private TextBox txtGarment2SizeM;
        private TextBox txtGarment2SizeS;
        private Button btnShowSales;
        private Label lblSales;
    }
}
