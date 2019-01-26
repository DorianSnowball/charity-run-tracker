namespace Spendenlauf
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Eingabe: 280"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ausgabe: 18"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Admin: 99"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "top10: 31"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login = new System.Windows.Forms.Panel();
            this.loginbutton = new System.Windows.Forms.Button();
            this.pinbox = new System.Windows.Forms.TextBox();
            this.pinlabel = new System.Windows.Forms.Label();
            this.eingabe = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            this.nr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ausgabe = new System.Windows.Forms.Panel();
            this.formatlabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ausgabeaccept = new System.Windows.Forms.Button();
            this.ausgabe_in = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.klasse = new System.Windows.Forms.ComboBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.nachname = new System.Windows.Forms.TextBox();
            this.vorname = new System.Windows.Forms.TextBox();
            this.nachnamelabel = new System.Windows.Forms.Label();
            this.vornamelabel = new System.Windows.Forms.Label();
            this.outbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ausgabeout = new System.Windows.Forms.ListBox();
            this.last = new System.Windows.Forms.GroupBox();
            this.last_nr = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.last_runden = new System.Windows.Forms.Label();
            this.last_klasse = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.login.SuspendLayout();
            this.eingabe.SuspendLayout();
            this.ausgabe.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.last.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.Controls.Add(this.loginbutton);
            this.login.Controls.Add(this.pinbox);
            this.login.Controls.Add(this.pinlabel);
            this.login.Location = new System.Drawing.Point(323, 208);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(118, 106);
            this.login.TabIndex = 0;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(15, 53);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(67, 28);
            this.loginbutton.TabIndex = 2;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // pinbox
            // 
            this.pinbox.Location = new System.Drawing.Point(6, 27);
            this.pinbox.Name = "pinbox";
            this.pinbox.Size = new System.Drawing.Size(87, 25);
            this.pinbox.TabIndex = 1;
            this.pinbox.UseSystemPasswordChar = true;
            // 
            // pinlabel
            // 
            this.pinlabel.AutoSize = true;
            this.pinlabel.Location = new System.Drawing.Point(3, 4);
            this.pinlabel.Name = "pinlabel";
            this.pinlabel.Size = new System.Drawing.Size(35, 20);
            this.pinlabel.TabIndex = 0;
            this.pinlabel.Text = "Pin:";
            // 
            // eingabe
            // 
            this.eingabe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eingabe.Controls.Add(this.add);
            this.eingabe.Controls.Add(this.nr);
            this.eingabe.Controls.Add(this.label1);
            this.eingabe.Location = new System.Drawing.Point(266, 179);
            this.eingabe.Name = "eingabe";
            this.eingabe.Size = new System.Drawing.Size(262, 171);
            this.eingabe.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(29, 66);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(184, 31);
            this.add.TabIndex = 2;
            this.add.Text = "Runde hinzufügen";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // nr
            // 
            this.nr.Location = new System.Drawing.Point(88, 35);
            this.nr.Name = "nr";
            this.nr.Size = new System.Drawing.Size(77, 25);
            this.nr.TabIndex = 1;
            this.nr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nr_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nummer des Läufers:";
            // 
            // ausgabe
            // 
            this.ausgabe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ausgabe.Controls.Add(this.formatlabel);
            this.ausgabe.Controls.Add(this.listBox1);
            this.ausgabe.Controls.Add(this.label4);
            this.ausgabe.Controls.Add(this.ausgabeaccept);
            this.ausgabe.Controls.Add(this.ausgabe_in);
            this.ausgabe.Location = new System.Drawing.Point(266, 179);
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.Size = new System.Drawing.Size(258, 182);
            this.ausgabe.TabIndex = 2;
            // 
            // formatlabel
            // 
            this.formatlabel.AutoSize = true;
            this.formatlabel.Location = new System.Drawing.Point(8, 66);
            this.formatlabel.Name = "formatlabel";
            this.formatlabel.Size = new System.Drawing.Size(140, 20);
            this.formatlabel.TabIndex = 8;
            this.formatlabel.Text = "[Name], [Vorname]";
            this.formatlabel.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Nummer",
            "Name",
            "Klasse"});
            this.listBox1.Location = new System.Drawing.Point(189, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(69, 58);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Suche nach:";
            // 
            // ausgabeaccept
            // 
            this.ausgabeaccept.Location = new System.Drawing.Point(69, 137);
            this.ausgabeaccept.Name = "ausgabeaccept";
            this.ausgabeaccept.Size = new System.Drawing.Size(95, 31);
            this.ausgabeaccept.TabIndex = 5;
            this.ausgabeaccept.Text = "Bestätigen";
            this.ausgabeaccept.UseVisualStyleBackColor = true;
            this.ausgabeaccept.Click += new System.EventHandler(this.ausgabeaccept_Click);
            // 
            // ausgabe_in
            // 
            this.ausgabe_in.Location = new System.Drawing.Point(12, 35);
            this.ausgabe_in.Name = "ausgabe_in";
            this.ausgabe_in.Size = new System.Drawing.Size(95, 25);
            this.ausgabe_in.TabIndex = 4;
            this.ausgabe_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ausgabenr_KeyPress);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.klasse);
            this.groupBox.Controls.Add(this.addbutton);
            this.groupBox.Controls.Add(this.nachname);
            this.groupBox.Controls.Add(this.vorname);
            this.groupBox.Controls.Add(this.nachnamelabel);
            this.groupBox.Controls.Add(this.vornamelabel);
            this.groupBox.Location = new System.Drawing.Point(25, 179);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(235, 178);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Person anlegen:";
            this.groupBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Klasse:";
            // 
            // klasse
            // 
            this.klasse.FormattingEnabled = true;
            this.klasse.Items.AddRange(new object[] {
            "5a",
            "5b",
            "5c",
            "5d",
            "5e",
            "5f",
            "6a",
            "6b",
            "6c",
            "6d",
            "6e",
            "7a",
            "7b",
            "7c",
            "7d",
            "7e",
            "8a",
            "8b",
            "8c",
            "8d",
            "8e",
            "9a",
            "9b",
            "9c",
            "9d",
            "9e",
            "10a",
            "10b",
            "10c",
            "10d",
            "10e",
            "1a",
            "1b",
            "1c",
            "1d",
            "1e",
            "BESUCHER",
            "LEHRER"});
            this.klasse.Location = new System.Drawing.Point(105, 94);
            this.klasse.Name = "klasse";
            this.klasse.Size = new System.Drawing.Size(100, 26);
            this.klasse.TabIndex = 5;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(67, 139);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(94, 29);
            this.addbutton.TabIndex = 4;
            this.addbutton.Text = "Bestätigen";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // nachname
            // 
            this.nachname.Location = new System.Drawing.Point(105, 63);
            this.nachname.Name = "nachname";
            this.nachname.Size = new System.Drawing.Size(100, 25);
            this.nachname.TabIndex = 3;
            // 
            // vorname
            // 
            this.vorname.Location = new System.Drawing.Point(105, 32);
            this.vorname.Name = "vorname";
            this.vorname.Size = new System.Drawing.Size(100, 25);
            this.vorname.TabIndex = 2;
            // 
            // nachnamelabel
            // 
            this.nachnamelabel.AutoSize = true;
            this.nachnamelabel.Location = new System.Drawing.Point(9, 63);
            this.nachnamelabel.Name = "nachnamelabel";
            this.nachnamelabel.Size = new System.Drawing.Size(90, 20);
            this.nachnamelabel.TabIndex = 1;
            this.nachnamelabel.Text = "Nachname:";
            // 
            // vornamelabel
            // 
            this.vornamelabel.AutoSize = true;
            this.vornamelabel.Location = new System.Drawing.Point(21, 32);
            this.vornamelabel.Name = "vornamelabel";
            this.vornamelabel.Size = new System.Drawing.Size(78, 20);
            this.vornamelabel.TabIndex = 0;
            this.vornamelabel.Text = "Vorname:";
            // 
            // outbox
            // 
            this.outbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outbox.Location = new System.Drawing.Point(12, 452);
            this.outbox.Multiline = true;
            this.outbox.Name = "outbox";
            this.outbox.ReadOnly = true;
            this.outbox.Size = new System.Drawing.Size(339, 60);
            this.outbox.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ausgabeout
            // 
            this.ausgabeout.FormattingEnabled = true;
            this.ausgabeout.ItemHeight = 18;
            this.ausgabeout.Location = new System.Drawing.Point(266, 32);
            this.ausgabeout.Name = "ausgabeout";
            this.ausgabeout.Size = new System.Drawing.Size(258, 130);
            this.ausgabeout.Sorted = true;
            this.ausgabeout.TabIndex = 6;
            this.ausgabeout.Visible = false;
            this.ausgabeout.SelectedIndexChanged += new System.EventHandler(this.ausgabeout_SelectedIndexChanged);
            // 
            // last
            // 
            this.last.Controls.Add(this.last_nr);
            this.last.Controls.Add(this.label12);
            this.last.Controls.Add(this.last_runden);
            this.last.Controls.Add(this.last_klasse);
            this.last.Controls.Add(this.last_name);
            this.last.Controls.Add(this.label7);
            this.last.Controls.Add(this.label6);
            this.last.Controls.Add(this.label5);
            this.last.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.last.Location = new System.Drawing.Point(534, 191);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(262, 136);
            this.last.TabIndex = 9;
            this.last.TabStop = false;
            this.last.Text = "Letztes Suchergebniss";
            this.last.Visible = false;
            // 
            // last_nr
            // 
            this.last_nr.AutoSize = true;
            this.last_nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.last_nr.Location = new System.Drawing.Point(85, 74);
            this.last_nr.Name = "last_nr";
            this.last_nr.Size = new System.Drawing.Size(31, 20);
            this.last_nr.TabIndex = 7;
            this.last_nr.Text = "n/a";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nummer:";
            // 
            // last_runden
            // 
            this.last_runden.AutoSize = true;
            this.last_runden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.last_runden.Location = new System.Drawing.Point(161, 103);
            this.last_runden.Name = "last_runden";
            this.last_runden.Size = new System.Drawing.Size(31, 20);
            this.last_runden.TabIndex = 5;
            this.last_runden.Text = "n/a";
            // 
            // last_klasse
            // 
            this.last_klasse.AutoSize = true;
            this.last_klasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.last_klasse.Location = new System.Drawing.Point(67, 53);
            this.last_klasse.Name = "last_klasse";
            this.last_klasse.Size = new System.Drawing.Size(31, 20);
            this.last_klasse.TabIndex = 4;
            this.last_klasse.Text = "n/a";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.last_name.Location = new System.Drawing.Point(67, 28);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(31, 20);
            this.last_name.TabIndex = 3;
            this.last_name.Text = "n/a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gelaufene Runden:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Klasse:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listView1.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(25, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(205, 114);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(808, 524);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.last);
            this.Controls.Add(this.ausgabeout);
            this.Controls.Add(this.ausgabe);
            this.Controls.Add(this.outbox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.eingabe);
            this.Controls.Add(this.login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSG-SMV Spendenlauf";
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.eingabe.ResumeLayout(false);
            this.eingabe.PerformLayout();
            this.ausgabe.ResumeLayout(false);
            this.ausgabe.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.last.ResumeLayout(false);
            this.last.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox pinbox;
        private System.Windows.Forms.Label pinlabel;
        private System.Windows.Forms.Panel eingabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox nr;
        private System.Windows.Forms.Panel ausgabe;
        private System.Windows.Forms.Button ausgabeaccept;
        private System.Windows.Forms.TextBox ausgabe_in;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox nachname;
        private System.Windows.Forms.TextBox vorname;
        private System.Windows.Forms.Label nachnamelabel;
        private System.Windows.Forms.Label vornamelabel;
        private System.Windows.Forms.TextBox outbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox klasse;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label formatlabel;
        private System.Windows.Forms.ListBox ausgabeout;
        private System.Windows.Forms.GroupBox last;
        private System.Windows.Forms.Label last_nr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label last_runden;
        private System.Windows.Forms.Label last_klasse;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
    }
}

