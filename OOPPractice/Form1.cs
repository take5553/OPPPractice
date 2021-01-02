using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPractice
{
    public partial class Form1 : Form
    {
        private VendingMachine vm = new VendingMachine();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Drink drink = vm.Buy(new Coin(CoinType.ONE_HUNDRED), DrinkType.COKE);
            Change change = vm.Refund();

            if (drink != null && drink.Kind == DrinkType.COKE)
            {
                label1.Text = "コーラを購入しました。\r";
                label1.Text = label1.Text + "おつりは" + change.GetAmount().ToString() + "円です。";
            } else
            {
                label1.Text = "コーラ買えんかった(´ﾟдﾟ｀)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drink drink = vm.Buy(new Coin(CoinType.FIVE_HUNDRED), DrinkType.COKE);
            Change change = vm.Refund();

            if (drink != null && drink.Kind == DrinkType.COKE)
            {
                label2.Text = "コーラを購入しました。\r";
                label2.Text = label2.Text + "おつりは" + change.GetAmount().ToString() + "円です。";
            }
            else
            {
                label2.Text = "コーラ買えんかった(´ﾟдﾟ｀)";
            }
        }
    }
}
