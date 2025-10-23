using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form2 : Form
    {
        private PictureBox f1pbox;
        private MaskedTextBox f1mtbox;
        private TextBox f1t1box;
        private TextBox f1t2box;
        private RadioButton f1r1btn;
        private RadioButton f1r2btn;
        private ComboBox f1cbox;
        private DateTimePicker f1dtp;
        private TextBox f1t3box;
        public Form2(PictureBox pbox, MaskedTextBox mtbox, TextBox t1box, TextBox t2box, RadioButton r1btn, RadioButton r2btn,ComboBox cbox, DateTimePicker dtp, TextBox t3box)
        {
            InitializeComponent();
            f1pbox = pbox;
            f1mtbox = mtbox;
            f1t1box = t1box;
            f1t2box = t2box;
            f1r1btn = r1btn;
            f1r2btn = r2btn;
            f1cbox = cbox;
            f1dtp = dtp;
            f1t3box = t3box;

            pictureBox1.Image = f1pbox.Image;
            maskedTextBox1.Text = f1mtbox.Text;
            textBox1.Text = f1t1box.Text;
            textBox2.Text = f1t2box.Text;
            radioButton1.Checked = f1r1btn.Checked;
            radioButton2.Checked = f1r2btn.Checked;
            comboBox1.SelectedItem = f1cbox;
            dateTimePicker1.Value = f1dtp.Value;
            textBox3.Text = f1t3box.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            f1pbox.Image = pictureBox1.Image;
            f1mtbox.Text = maskedTextBox1.Text;
            f1t1box.Text = textBox1.Text;
            f1t2box.Text = textBox2.Text;
            f1r1btn.Checked = radioButton1.Checked;
            f1r2btn.Checked = radioButton2.Checked;
            f1dtp.Value = dateTimePicker1.Value;
            f1t3box.Text = textBox3.Text;

            foreach (var item in f1cbox.Items)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedItem = f1cbox.SelectedItem;
        }
    }
}
