using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upr4_6
{
    public partial class Form1 : Form
    {
        private string[] toppings = { "anchovies", "bacon", "mushrooms", "onions", "peppers", "sausage" };
        public Form1()
        {
            InitializeComponent();
            toppingCheckedListBox.Items.AddRange(toppings);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string checkedToppings = string.Empty;
                foreach (var checkedItem in toppingCheckedListBox.CheckedItems)
                {
                    checkedToppings += checkedItem.ToString() + ", ";
                }

                if (!string.IsNullOrEmpty(checkedToppings))
                {
                    checkedToppings = checkedToppings.Remove(checkedToppings.Length - 2);
                }

                string orderInfo = $"You ordered a {(smallRadioButton.Checked ? "small" : mediumRadioButton.Checked ? "medium" : "large")} {(thinRadioButton.Checked ? "thin" : "thick")} pizza{(extraCheeseCheckBox.Checked ? " with extra cheese " : " ")}and {toppingCheckedListBox.CheckedItems.Count} topping/s: {checkedToppings}.";

                // Size of pizza
                var total = smallRadioButton.Checked ? 9.25M : mediumRadioButton.Checked ? 11.5M : 17.75M;

                // Extra cheese
                total += extraCheeseCheckBox.Checked ? 1.5M : 0M;

                // Toppings
                total += toppingCheckedListBox.CheckedItems.Count;

                infoRichTextBox.Text = orderInfo + $"\nYour order total: {total}$";
            }
            catch
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            smallRadioButton.Checked = true;
            thinRadioButton.Checked = true;
        }
    }
}
