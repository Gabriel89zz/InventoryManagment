namespace InventoryManagment
{
    public partial class Form1 : Form
    {
        int[,] sales;
        public Form1()
        {
            InitializeComponent();
            sales = new int[2, 3];
        }

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            try
            {
                sales[0, 0] = Convert.ToInt16(txtGarment1SizeS.Text);
                sales[0, 1] = Convert.ToInt16(txtGarment1SizeM.Text);
                sales[0, 2] = Convert.ToInt16(txtGarment1SizeL.Text);
                sales[1, 0] = Convert.ToInt16(txtGarment2SizeS.Text);
                sales[1, 1] = Convert.ToInt16(txtGarment2SizeM.Text);
                sales[1, 2] = Convert.ToInt16(txtGarment2SizeL.Text);

                int[] SalesTotalGarment = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        SalesTotalGarment[i] += sales[i, j];
                    }
                }
                string messageSalesGarment = "";
                for (int i = 0; i < 2; i++)
                {
                    messageSalesGarment += "Garment " + (i + 1) + ": " + SalesTotalGarment[i] + " sold units\n";
                }
                lblSales.Text = messageSalesGarment;

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer values for sales data.");
            }
           

        }

      
    }
}

