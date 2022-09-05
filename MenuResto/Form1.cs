using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3PETP8
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 374;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment Confirmer Votre Commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                listbox.Items.Clear();
            for (int i = 0; i < ck1.CheckedItems.Count; i++)
                listbox.Items.Add(ck1.CheckedItems[i].ToString());
            for (int i = 0; i < ck2.CheckedItems.Count; i++)
                listbox.Items.Add(ck2.CheckedItems[i].ToString());
            for (int i = 0; i < ck3.CheckedItems.Count; i++)
                listbox.Items.Add(ck3.CheckedItems[i].ToString());
            for (int i = 0; i < ck4.CheckedItems.Count; i++)
                listbox.Items.Add(ck4.CheckedItems[i].ToString());
            this.Width = 540;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 374;
            for (int i = 0; i < ck1.Items.Count; i++)
                ck1.SetItemChecked(i, false);
            for (int i = 0; i < ck2.Items.Count; i++)
                ck2.SetItemChecked(i, false);
            for (int i = 0; i < ck3.Items.Count; i++)
                ck3.SetItemChecked(i, false);
           // for (int i = 0; i < ck3.Items.Count; i++)
            //    ck4.SetItemChecked(i, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                MessageBox.Show(radioButton1.Text, "Mode de paiment");
            if (radioButton2.Checked == true)
                MessageBox.Show(radioButton1.Text, "Mode de paiment");
            if (radioButton3.Checked == true)
                MessageBox.Show(radioButton1.Text, "Mode de paiment");
        }

        private void button2_DragEnter(object sender, DragEventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button2_DragLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
