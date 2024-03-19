using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP2WF
{
    public partial class Fm_Principal : Form
    {
        public Fm_Principal()
        {
            InitializeComponent();
            bt_switch1.Visible = false;
            bt_switch2.Visible = false;
            bt_switch1.Enabled = false;
            bt_switch2.Enabled = false;
        }

        private void bt_ajout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_saisie.Text))
            {
                MessageBox.Show("Veuillez saisir un élément.");
            }
            else
            {
                lb_liste1.Items.Add(tb_saisie.Text);
                tb_saisie.Clear();
                tb_saisie.Focus();
            }
        }
        private void bt_suppr_Click(object sender, EventArgs e)
        {
            lb_liste1.Items.RemoveAt(lb_liste1.SelectedIndex);
        }
        private void bt_ajout2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_saisie.Text))
            {
                MessageBox.Show("Veuillez saisir un élément.");
            }
            else
            {
                lb_liste2.Items.Add(tb_saisie.Text);
                tb_saisie.Clear();
                tb_saisie.Focus();
            }
        }

        private void bt_suppr2_Click(object sender, EventArgs e)
        {
            lb_liste2.Items.RemoveAt(lb_liste2.SelectedIndex);
        }

        private void bt_switch1_Click(object sender, EventArgs e)
        {
            if (lb_liste1.SelectedIndex != -1)
            {
                foreach (var selectedItem in lb_liste1.SelectedItems.Cast<string>().ToList())
                {
                    lb_liste2.Items.Add(selectedItem);
                    lb_liste1.Items.Remove(selectedItem);
                }
            }
        }

        private void bt_switch2_Click(object sender, EventArgs e)
        {
            if (lb_liste2.SelectedIndex != -1)
            { //switch de l'autre coté 
                foreach (var selectedItem in lb_liste2.SelectedItems.Cast<string>().ToList())
                {
                    lb_liste1.Items.Add(selectedItem);
                    lb_liste2.Items.Remove(selectedItem);
                }
            }
        }
        private void lb_liste1_DoubleClick(object sender, EventArgs e)
        {
            // Doubleclic pour tranfere

            bt_switch1.PerformClick();
        }
        private void lb_liste2_DoubleClick(object sender, EventArgs e)
        {
            bt_switch2.PerformClick();
        }

        private void lb_liste1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_switch1.Enabled = (lb_liste1.SelectedIndex != -1);
            if (lb_liste1.SelectedIndex != -1)
            {
                bt_switch1.Visible = true;
            }
            else
            {
                bt_switch1.Visible = false;
            }
        }

        private void lb_liste2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_switch2.Enabled = (lb_liste2.SelectedIndex != -1);
            if (lb_liste2.SelectedIndex != -1)
            {
                bt_switch2.Visible = true;
            }
            else
            {
                bt_switch2.Visible = false;
            }
        }
        private void btn_quitter_Click(object sender, EventArgs e)
        {
      
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

         
            if (result == DialogResult.Yes)
            {
             
                Application.Exit();
            }
            else
            {
              
             
            }
        }
    }
}
