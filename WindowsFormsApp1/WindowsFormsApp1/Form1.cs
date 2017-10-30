using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Button buttonlar;
        List<Button> btnList = new List<Button>();
        public Form1()
        {
            InitializeComponent();
      
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            this.buttonlar = sender as Button;

            if (this.buttonlar.BackColor.Name == "Control")
            {
                this.buttonlar.BackColor = SystemColors.GrayText;
                btnList.Add(this.buttonlar);
            }
            else
            {
                this.buttonlar.BackColor = SystemColors.Control;
                btnList.Remove(this.buttonlar);
            }
        }
        private void buy_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < btnList.ToArray().Length; i++)
                if (btnList[i].BackColor == SystemColors.GrayText)
                    btnList[i].BackColor = Color.Red;
        }
    }
}
