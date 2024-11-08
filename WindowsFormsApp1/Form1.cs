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
        public Form1()
        {
            this.Size = new Size(400, 400);

            // Button
            Button btn = new Button();
            btn.Text = "Click me!";
            btn.Click += (sender, e) => MessageBox.Show("Button clicked");
            btn.Location = new Point(10, 60);
            Controls.Add(btn);

            // Checkbox
            CheckBox chk = new CheckBox();
            chk.Text = "Accept terms";
            chk.CheckedChanged += (sender, e) => MessageBox.Show(chk.Checked ? "Accepted" : "Not accepted");
            chk.Location = new Point(10, 100);
            Controls.Add(chk);

            // Label
            Label lbl = new Label();
            lbl.Text = "dime tu nombre:";
            lbl.Location = new Point(10, 10);
            Controls.Add(lbl);

            // RadioButton
            RadioButton rb1 = new RadioButton();
            rb1.Text = "Option 1";
            rb1.CheckedChanged += (sender, e) => MessageBox.Show("Option 1 selected");
            rb1.Location = new Point(10, 140);
            Controls.Add(rb1);

            // ComboBox
            ComboBox cmb = new ComboBox();
            cmb.Location = new Point(10, 180);
            cmb.Items.Add("Option 1");
            cmb.Items.Add("Option 2");
            cmb.SelectedIndexChanged += (sender, e) => MessageBox.Show(cmb.SelectedItem.ToString());
            Controls.Add(cmb);

            // TextBox
            TextBox txt = new TextBox();
            txt.Location = new Point(10, 30);
            Controls.Add(txt);

            // DataGridView
            DataGridView dgv = new DataGridView();
            dgv.Columns.Add("ID", "Nombre");
            dgv.Rows.Add(1);
            Controls.Add(dgv);
            dgv.Location = new Point(10, 220);
            dgv.Size = new Size(300, 150);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
