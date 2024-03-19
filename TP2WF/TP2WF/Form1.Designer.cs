namespace TP2WF
{
    partial class Fm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_liste1 = new ListBox();
            tb_saisie = new TextBox();
            bt_ajout = new Button();
            bt_suppr = new Button();
            label1 = new Label();
            lb_liste2 = new ListBox();
            bt_suppr2 = new Button();
            bt_ajout2 = new Button();
            bt_switch1 = new Button();
            bt_switch2 = new Button();
            SuspendLayout();
            // 
            // lb_liste1
            // 
            lb_liste1.BackColor = SystemColors.ButtonFace;
            lb_liste1.FormattingEnabled = true;
            lb_liste1.ItemHeight = 20;
            lb_liste1.Location = new Point(12, 72);
            lb_liste1.Name = "lb_liste1";
            lb_liste1.Size = new Size(546, 444);
            lb_liste1.TabIndex = 0;
            lb_liste1.SelectedIndexChanged += lb_liste1_SelectedIndexChanged;
            lb_liste1.DoubleClick += lb_liste1_DoubleClick;
            // 
            // tb_saisie
            // 
            tb_saisie.BackColor = SystemColors.ButtonFace;
            tb_saisie.Cursor = Cursors.Hand;
            tb_saisie.Location = new Point(269, 532);
            tb_saisie.Name = "tb_saisie";
            tb_saisie.Size = new Size(592, 27);
            tb_saisie.TabIndex = 1;
            // 
            // bt_ajout
            // 
            bt_ajout.BackColor = SystemColors.Control;
            bt_ajout.Cursor = Cursors.Hand;
            bt_ajout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_ajout.Location = new Point(12, 522);
            bt_ajout.Name = "bt_ajout";
            bt_ajout.Size = new Size(94, 37);
            bt_ajout.TabIndex = 2;
            bt_ajout.Text = "+";
            bt_ajout.UseVisualStyleBackColor = false;
            bt_ajout.Click += bt_ajout_Click;
            // 
            // bt_suppr
            // 
            bt_suppr.BackColor = SystemColors.Control;
            bt_suppr.Cursor = Cursors.Hand;
            bt_suppr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_suppr.Location = new Point(112, 522);
            bt_suppr.Name = "bt_suppr";
            bt_suppr.Size = new Size(94, 37);
            bt_suppr.TabIndex = 3;
            bt_suppr.Text = "-";
            bt_suppr.UseVisualStyleBackColor = false;
            bt_suppr.Click += bt_suppr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(516, 22);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 5;
            label1.Text = "LISTE";
            // 
            // lb_liste2
            // 
            lb_liste2.BackColor = SystemColors.ButtonFace;
            lb_liste2.FormattingEnabled = true;
            lb_liste2.ItemHeight = 20;
            lb_liste2.Location = new Point(562, 72);
            lb_liste2.Name = "lb_liste2";
            lb_liste2.Size = new Size(546, 444);
            lb_liste2.TabIndex = 6;
            lb_liste2.SelectedIndexChanged += lb_liste2_SelectedIndexChanged;
            lb_liste2.DoubleClick += lb_liste2_DoubleClick;
            // 
            // bt_suppr2
            // 
            bt_suppr2.BackColor = SystemColors.Control;
            bt_suppr2.Cursor = Cursors.Hand;
            bt_suppr2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_suppr2.ImageAlign = ContentAlignment.TopLeft;
            bt_suppr2.Location = new Point(914, 522);
            bt_suppr2.Name = "bt_suppr2";
            bt_suppr2.Size = new Size(94, 37);
            bt_suppr2.TabIndex = 7;
            bt_suppr2.Text = "-";
            bt_suppr2.UseVisualStyleBackColor = false;
            bt_suppr2.Click += bt_suppr2_Click;
            // 
            // bt_ajout2
            // 
            bt_ajout2.BackColor = SystemColors.Control;
            bt_ajout2.Cursor = Cursors.Hand;
            bt_ajout2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_ajout2.ImageAlign = ContentAlignment.TopCenter;
            bt_ajout2.Location = new Point(1014, 522);
            bt_ajout2.Name = "bt_ajout2";
            bt_ajout2.Size = new Size(94, 37);
            bt_ajout2.TabIndex = 8;
            bt_ajout2.Text = "+";
            bt_ajout2.UseVisualStyleBackColor = false;
            bt_ajout2.Click += bt_ajout2_Click;
            // 
            // bt_switch1
            // 
            bt_switch1.Cursor = Cursors.Hand;
            bt_switch1.Location = new Point(63, 565);
            bt_switch1.Name = "bt_switch1";
            bt_switch1.Size = new Size(94, 29);
            bt_switch1.TabIndex = 9;
            bt_switch1.Text = ">>";
            bt_switch1.UseVisualStyleBackColor = true;
            bt_switch1.Click += bt_switch1_Click;
            // 
            // bt_switch2
            // 
            bt_switch2.Cursor = Cursors.Hand;
            bt_switch2.Location = new Point(965, 565);
            bt_switch2.Name = "bt_switch2";
            bt_switch2.Size = new Size(94, 29);
            bt_switch2.TabIndex = 10;
            bt_switch2.Text = "<<";
            bt_switch2.UseVisualStyleBackColor = true;
            bt_switch2.Click += bt_switch2_Click;
            // 
            // Fm_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1120, 632);
            Controls.Add(bt_switch2);
            Controls.Add(bt_switch1);
            Controls.Add(bt_ajout2);
            Controls.Add(bt_suppr2);
            Controls.Add(lb_liste2);
            Controls.Add(label1);
            Controls.Add(bt_suppr);
            Controls.Add(bt_ajout);
            Controls.Add(tb_saisie);
            Controls.Add(lb_liste1);
            ForeColor = Color.Black;
            Name = "Fm_Principal";
            Text = "Premier programme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lb_liste1;
        private TextBox tb_saisie;
        private Button bt_ajout;
        private Button bt_suppr;
        private Label label1;
        private ListBox lb_liste2;
        private Button bt_suppr2;
        private Button bt_ajout2;
        private Button bt_switch1;
        private Button bt_switch2;
    }
}
