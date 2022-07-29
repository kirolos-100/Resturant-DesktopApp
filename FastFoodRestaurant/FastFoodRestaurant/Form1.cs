using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLb1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateLb1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if(FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void HotdogCb_CheckedChanged(object sender, EventArgs e)
        {
            if (HotdogCb.Checked == true)
            {
                HotdogTb.Enabled = true;
            }
            if (HotdogCb.Checked == false)
            {
                HotdogTb.Enabled = false;
                HotdogTb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void CoffeeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CoffeeCb.Checked == true)
            {
                CoffeeTb.Enabled = true;
            }
            if (CoffeeCb.Checked == false)
            {
                CoffeeTb.Enabled = false;
                CoffeeTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PancakeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakeCb.Checked == true)
            {
                PancakeTb.Enabled = true;
            }
            if (PancakeCb.Checked == false)
            {
                PancakeTb.Enabled = false;
                PancakeTb.Text = "0";
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void CloseLb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Declare unit price to different meal and drinks
        double friesup = 5, burgerup = 20, saladup = 10, sandwichup = 30, chickenup = 25, hotdogup = 15;

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            HotdogCb.Checked = false;
            WaterCb.Checked = false;
            TeaCb.Checked = false;
            CoffeeCb.Checked = false;
            ChocolateCb.Checked = false;
            PancakeCb.Checked = false;
            OrangeCb.Checked = false;



        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text + " Subtotal " + Subtotallb1.Text + "Tax" + Taxlb1.Text + "Grand Total" + Grdtotallb1.Text, new Font("Century Gothic" , 12 , FontStyle.Regular), Brushes.Blue , new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        double waterup = 5, teaup = 5, coffeeup = 10, chocolateup = 20, pancakeup = 30, orangeup = 10;
        // Declare variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwichtp, chickentp, hotdogtp, watertp, teatp, coffeetp, chocolatetp, pancaketp, orangetp;
        double subtotal , tax , grdtotal;
        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            hotdogtp = hotdogup * Convert.ToDouble(HotdogTb.Text);
            watertp = waterup * Convert.ToDouble(WaterTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            coffeetp = coffeeup * Convert.ToDouble(CoffeeTb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            pancaketp = pancakeup * Convert.ToDouble(PancakeTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);
            //add product to recept
            ReceiptTb.Clear();
            subtotal = 0;
            //tax = 0;
            //grdtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tCODESPACE RESRAURENT"+Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t********************************" + Environment.NewLine);
            if(FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFries:\t" + friestp + "Rs" + Environment.NewLine);
                subtotal = subtotal + friestp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + "Rs" + Environment.NewLine);
                subtotal = subtotal + burgertp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:\t" + saladtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + saladtp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:\t" + sandwichtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + sandwichtp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:\t" + chickentp + "Rs" + Environment.NewLine);
                subtotal = subtotal + chickentp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (HotdogCb.Checked == true)
            {
                ReceiptTb.AppendText("\tHotdog:\t" + hotdogtp + "Rs" + Environment.NewLine);
                subtotal = subtotal + hotdogtp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\tWater:\t" + watertp + "Rs" + Environment.NewLine);
                subtotal = subtotal + watertp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + "Rs" + Environment.NewLine);
                subtotal = subtotal + teatp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (CoffeeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCoffee:\t" + coffeetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + coffeetp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (PancakeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPancake:\t" + pancaketp + "Rs" + Environment.NewLine);
                subtotal = subtotal + pancaketp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChocolate:\t" + chocolatetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + chocolatetp;
                Subtotallb1.Text = "" + subtotal;
            }
            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tOrange:\t" + orangetp + "Rs" + Environment.NewLine);
                subtotal = subtotal + orangetp;
                Subtotallb1.Text = "" + subtotal;
            }
            tax = subtotal * 0.16; //16% tax 
            grdtotal = subtotal + tax;
            Taxlb1.Text = "Rs" + tax;
            Grdtotallb1.Text = "Rs" + grdtotal;

        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
