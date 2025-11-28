using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePizzaOrderApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"E:\Programming_Path\Programming Advices.com\Backend Development Track\Course#14\Lessons\PizzaWall7.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeDefaultOrderState();
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMediam.Checked)
                return Convert.ToSingle(rbMediam.Tag);
            else if (rbLarge.Checked)
                return Convert.ToSingle(rbLarge.Tag);
            else
                return 0;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else if (rbThick.Checked)
                return Convert.ToSingle(rbThick.Tag);
            else
                return 0;
        }

        float GetSelectedMeatPrice()
        {
            if (chkPepperoni.Checked)
                return Convert.ToSingle(chkPepperoni.Tag);
            else if (chkChicken.Checked)
                return Convert.ToSingle(chkChicken.Tag);
            else
                return 0;
        }

        float GetSelectedCheesePrice()
        {
            if (chkExtraCheese.Checked)
                return Convert.ToSingle(chkExtraCheese.Tag);
            else if (chkParmesan.Checked)
                return Convert.ToSingle(chkParmesan.Tag);
            else
                return 0;
        }

        float GetSelectedVegetablesPrice()
        {
            if (chkOnion.Checked)
                return Convert.ToSingle(chkOnion.Tag);
            else if (chkMushroom.Checked)
                return Convert.ToSingle(chkMushroom.Tag);
            else
                return 0;
        }

        float GetSelectedFruitsPrice()
        {
            if (chkPineapple.Checked)
                return Convert.ToSingle(chkPineapple.Tag);
            else if (chkBananaBeppers.Checked)
                return Convert.ToSingle(chkBananaBeppers.Tag);
            else
                return 0;
        }

        float GetSelectedHerbsPrice()
        {
            if (chkOregano.Checked)
                return Convert.ToSingle(chkOregano.Tag);
            else if (chkThyme.Checked)
                return Convert.ToSingle(chkThyme.Tag);
            else
                return 0;
        }

        float GetSelectedSaucePrice()
        {
            if (chkBBQSauce.Checked)
                return Convert.ToSingle(chkBBQSauce.Tag);
            else if (chkAlfredoSauce.Checked)
                return Convert.ToSingle(chkAlfredoSauce.Tag);
            else if (chkHotSauce.Checked)
                return Convert.ToSingle(chkHotSauce.Tag);
            else
                return 0;
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + GetSelectedMeatPrice() + GetSelectedCheesePrice() + GetSelectedVegetablesPrice() + GetSelectedFruitsPrice() + GetSelectedHerbsPrice() + GetSelectedSaucePrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Size: Small";
            }
            else if (rbMediam.Checked)
            {
                lblSize.Text = "Size: Medium";
            }
            else if (rbLarge.Checked)
            {
                lblSize.Text = "Size: Large";
            }
            else
                lblSize.Text = "Size: Not Selected";
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
            {
                lblCrust.Text = "Crust Type: Thin";
            }
            else if (rbThick.Checked)
            {
                lblCrust.Text = "Crust Type: Thick";
            }
            else
            {
                lblCrust.Text = "Crust Type: Not Selected";
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";

            if (chkPepperoni.Checked)
            {
                Toppings += "Pepperoni, ";
            }

            if (chkChicken.Checked)
            {
                Toppings += "Chicken, ";
            }

            if (chkExtraCheese.Checked)
            {
                Toppings += "Extra Cheese, ";
            }

            if (chkParmesan.Checked)
            {
                Toppings += "Parmesan, ";
            }

            if (chkOnion.Checked)
            {
                Toppings += "Onion, ";
            }

            if (chkMushroom.Checked)
            {
                Toppings += "Mushroom, ";
            }

            if (chkPineapple.Checked)
            {
                Toppings += "Pineapple, ";
            }

            if (chkBananaBeppers.Checked)
            {
                Toppings += "Banana Pepper, ";
            }

            if (chkOregano.Checked)
            {
                Toppings += "Oregano, ";
            }

            if (chkThyme.Checked)
            {
                Toppings += "Thyme, ";
            }

            if (chkBBQSauce.Checked)
            {
                Toppings += "BBQ Sauce, ";
            }

            if (chkAlfredoSauce.Checked)
            {
                Toppings += "Alfredo Sauce, ";
            }

            if (chkHotSauce.Checked)
            {
                Toppings += "Hot Sauce, ";
            }

            if (Toppings == "")
            {
                Toppings = "No Toppings";
            }
            
            lblToppings.Text = "Toppings: " + Toppings;
        }

        void InitializeDefaultOrderState()
        {
            this.UpdateSize();
            this.UpdateCrust();
            this.UpdateToppings();
            this.UpdateTotalPrice();
            rtbBill.Visible = false;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMediam_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkParmesan_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkPineapple_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBananaBeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOregano_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkThyme_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBBQSauce_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkAlfredoSauce_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkHotSauce_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private string GetCheckedRadioButtonName(GroupBox Group)
        {
            foreach(Control control in Group.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                    return radioButton.Text;
            }
            return null;
        }

        private void PrintCheckedCheckBoxes(GroupBox Group)
        {
            foreach(Control control in Group.Controls)
            {
                if(control is CheckBox Box && Box.Checked)
                {
                    rtbBill.AppendText("      • " + Box.Text + "\n");
                }
            }
        }

        private void PrintBill()
        {
            rtbBill.Visible = true;
            rtbBill.AppendText("\t====================================\n");
            rtbBill.AppendText("           🍕 PIZZA HOUSE 🍕\n");
            rtbBill.AppendText("\t====================================\n\n");
            rtbBill.AppendText("  Size       : " + GetCheckedRadioButtonName(grSizes) + "\n");
            rtbBill.AppendText("  Crust      : " + GetCheckedRadioButtonName(grCrustTypes) + "\n");
            rtbBill.AppendText("  Eat Type   : " + GetCheckedRadioButtonName(grWhereToEat) + "\n");
            rtbBill.AppendText("\n------------ TOPPINGS --------------\n");
            PrintCheckedCheckBoxes(grMeats);
            PrintCheckedCheckBoxes(grCheeses);
            PrintCheckedCheckBoxes(grVegetables);
            PrintCheckedCheckBoxes(grFruits);
            PrintCheckedCheckBoxes(grHerbs);
            PrintCheckedCheckBoxes(grSauces);
            rtbBill.AppendText("------------------------------------\n");
            rtbBill.AppendText("  Price : $" + CalculateTotalPrice().ToString() + "\n");
            rtbBill.AppendText("------------------------------------\n");
            rtbBill.AppendText("       THANK YOU FOR YOUR ORDER!     \n");
            rtbBill.AppendText("------------------------------------\n");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to order?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control control in this.Controls) // Control keyword expresses all form's controls
                {
                    if (control is Button button && button == btnReset)
                        continue;
                    else
                        control.Enabled = false;
                }
                PrintBill();
            }
        }

        private void UncheckGroupBoxControls(GroupBox Group)
        {
            foreach(Control control in Group.Controls)
            {
                if (control is RadioButton)
                    ((RadioButton)control).Checked = false; // casting control to RadioButton
                else
                    ((CheckBox)control).Checked = false; // casting control to CheckBox
            }
        }

        void StartNewOrder()
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox group)
                {
                    UncheckGroupBoxControls(group);
                }

                else if (control is Label label && label == lblTotalPrice)
                {
                    lblTotalPrice.Text = "$0";
                }

                else if (control is RichTextBox richText)
                {
                    richText.Visible = false;
                    richText.Clear();
                }

                control.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StartNewOrder();
        }
    }
}