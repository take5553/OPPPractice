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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendingMachine vm = new VendingMachine();

            Drink drink = vm.Buy(500, Drink.COKE);
            int charge = vm.Refund();

            if (drink != null && drink.getKind() == Drink.COKE)
            {
                Console.WriteLine("コーラを購入しました。");
                Console.WriteLine("おつりは" + charge + "円です。");
            } else
            {
                Console.WriteLine("コーラ買えんかった(´ﾟдﾟ｀)");
            }
        }
    }
}
