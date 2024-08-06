using System;
using System.Windows.Forms;

namespace busfares_exercise
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //Creae your variables and pass data to them
            Single percentDisc, ash, dun = 0;
            string discountText = "";

            string name = txtName.Text;
            int age = Convert.ToInt16(txtAge.Text);
            ash = Convert.ToSingle(txtAshFare.Text);
            dun = Convert.ToSingle(txtDunFare.Text);

            //gives 20% discount
            percentDisc = 0.2f;

            if ((cbxDisabled.Checked || age <= 12 || age > 65) && age > 0)
            {
                //people get a discount = true

                //calculate the discount
                ash = Convert.ToSingle(string.Format("{0:0.00}", ash - (ash * percentDisc)));
                dun = Convert.ToSingle(string.Format("{0:0.00}", dun - (dun * percentDisc)));
                discountText = " - includes Age or Disabled Discount";
            }
            else
            {
                discountText = " - no discount";
            }

            //display the output
            //insert the listbox at the top
            lboutput.Items.Insert(0, name + "   Ash: $" + ash + "   Dun: $" + dun + discountText);
        }
    }
}
