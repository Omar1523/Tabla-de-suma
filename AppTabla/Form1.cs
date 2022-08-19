using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {
            if (txtnum1.Text != "" && txtnum2.Text != "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text) + int.Parse(txtnum3.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text != "" && txtnum3.Text == "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text != "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum3.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text == "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum3.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text == "" && txtnum3.Text == "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
           
            else if (txtnum1.Text == "" && txtnum2.Text != "" && txtnum3.Text == "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum2.Text));

            }
            else if (txtnum1.Text == "" && txtnum2.Text == "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum3.Text));

            }
            else if (txtnum1.Text == "" && txtnum2.Text == "" && txtnum3.Text == "")
            {
                txtfila1.Text = "";

            }




            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
           else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }










        }

        private void txtnum2_TextChanged(object sender, EventArgs e)
        {
            if (txtnum1.Text != "" && txtnum2.Text != "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text) + int.Parse(txtnum3.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text != "" && txtnum3.Text == "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text != "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum3.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text == "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum3.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text == "" && txtnum3.Text == "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }

            else if (txtnum1.Text == "" && txtnum2.Text != "" && txtnum3.Text == "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum2.Text));

            }
            else if (txtnum1.Text == "" && txtnum2.Text == "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum3.Text));

            }
            else if (txtnum1.Text == "" && txtnum2.Text == "" && txtnum3.Text == "")
            {
                txtfila1.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }
        }

        private void txtfila1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnum3_TextChanged(object sender, EventArgs e)
        {
            if (txtnum1.Text != "" && txtnum2.Text != "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text) + int.Parse(txtnum3.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text != "" && txtnum3.Text == "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum2.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text != "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum3.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text == "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum3.Text));
            }
            else if (txtnum1.Text != "" && txtnum2.Text == "" && txtnum3.Text == "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }

            else if (txtnum1.Text == "" && txtnum2.Text != "" && txtnum3.Text == "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum2.Text));

            }
            else if (txtnum1.Text == "" && txtnum2.Text == "" && txtnum3.Text != "")
            {
                txtfila1.Text = Convert.ToString(int.Parse(txtnum3.Text));

            }
            else if (txtnum1.Text == "" && txtnum2.Text == "" && txtnum3.Text == "")
            {
                txtfila1.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }
        }


        private void txtnum4_TextChanged(object sender, EventArgs e)
        {
            if (txtnum4.Text != "" && txtnum5.Text != "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum6.Text));
            }
            else if (txtnum4.Text != "" && txtnum5.Text == "" && txtnum6.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum4.Text == "" && txtnum5.Text != "" && txtnum6.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum5.Text));

            }
            else if (txtnum4.Text == "" && txtnum5.Text == "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum6.Text));

            }
            else if (txtnum4.Text == "" && txtnum5.Text == "" && txtnum6.Text == "")
            {
                txtfila2.Text = "";

            }
            else if (txtnum4.Text != "" && txtnum5.Text != "" && txtnum6.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text) + int.Parse(txtnum5.Text));
            }
            else if (txtnum4.Text != "" && txtnum5.Text != "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum5.Text) + int.Parse(txtnum6.Text));
            }
            else if (txtnum4.Text != "" && txtnum5.Text == "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text) + int.Parse(txtnum6.Text));
            }
            else if (txtnum4.Text != "" && txtnum2.Text == "" && txtnum3.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }


        }

        private void txtnum5_TextChanged(object sender, EventArgs e)
        {
            if (txtnum4.Text != "" && txtnum5.Text != "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum6.Text));
            }
            else if (txtnum4.Text != "" && txtnum5.Text == "" && txtnum6.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum4.Text == "" && txtnum5.Text != "" && txtnum6.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum5.Text));

            }
            else if (txtnum4.Text == "" && txtnum5.Text == "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum6.Text));

            }
            else if (txtnum4.Text == "" && txtnum5.Text == "" && txtnum6.Text == "")
            {
                txtfila2.Text = "";

            }
            else if (txtnum4.Text != "" && txtnum5.Text != "" && txtnum6.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text) + int.Parse(txtnum5.Text));
            }
            else if (txtnum4.Text != "" && txtnum5.Text != "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum5.Text) + int.Parse(txtnum6.Text));
            }
            else if (txtnum4.Text != "" && txtnum5.Text == "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text) + int.Parse(txtnum6.Text));
            }
            else if (txtnum4.Text != "" && txtnum2.Text == "" && txtnum3.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }

        }

        private void txtnum6_TextChanged(object sender, EventArgs e)
        {
            if (txtnum4.Text != "" && txtnum5.Text != "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum6.Text));
            }
            else if (txtnum4.Text != "" && txtnum5.Text == "" && txtnum6.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum4.Text == "" && txtnum5.Text != "" && txtnum6.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum5.Text));

            }
            else if (txtnum4.Text == "" && txtnum5.Text == "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum6.Text));

            }
            else if (txtnum4.Text == "" && txtnum5.Text == "" && txtnum6.Text == "")
            {
                txtfila2.Text = "";

            }

            else if (txtnum4.Text != "" && txtnum5.Text != "" && txtnum6.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text) + int.Parse(txtnum5.Text));
            }
            else if (txtnum4.Text != "" && txtnum5.Text != "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum5.Text) + int.Parse(txtnum6.Text));
            }
            else if (txtnum4.Text != "" && txtnum5.Text == "" && txtnum6.Text != "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text) + int.Parse(txtnum6.Text));
            }
            else if (txtnum4.Text != "" && txtnum2.Text == "" && txtnum3.Text == "")
            {
                txtfila2.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }


            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }
        }

        private void txtnum7_TextChanged(object sender, EventArgs e)
        {
            if (txtnum7.Text != "" && txtnum8.Text != "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum9.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text == "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum7.Text == "" && txtnum8.Text != "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum8.Text));

            }
            else if (txtnum7.Text == "" && txtnum8.Text == "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum9.Text));

            }
            else if (txtnum7.Text == "" && txtnum8.Text == "" && txtnum9.Text == "")
            {
                txtfila3.Text = "";

            }

            else if (txtnum7.Text != "" && txtnum8.Text != "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum8.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text != "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum9.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text == "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum9.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text == "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }



            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }

        }

        private void txtnum8_TextChanged(object sender, EventArgs e)
        {
            if (txtnum7.Text != "" && txtnum8.Text != "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum9.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text == "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum7.Text == "" && txtnum8.Text != "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum8.Text));

            }
            else if (txtnum7.Text == "" && txtnum8.Text == "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum9.Text));

            }
            else if (txtnum7.Text != "" && txtnum8.Text != "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum8.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text != "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum9.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text == "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum9.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text == "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum7.Text == "" && txtnum8.Text == "" && txtnum9.Text == "")
            {
                txtfila3.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }
        }

        private void txtnum9_TextChanged(object sender, EventArgs e)
        {
            if (txtnum7.Text != "" && txtnum8.Text != "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum9.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text == "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum7.Text == "" && txtnum8.Text != "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum8.Text));

            }
            else if (txtnum7.Text == "" && txtnum8.Text == "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum9.Text));

            }
            else if (txtnum7.Text != "" && txtnum8.Text != "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum8.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text != "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum9.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text == "" && txtnum9.Text != "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text) + int.Parse(txtnum9.Text));
            }
            else if (txtnum7.Text != "" && txtnum8.Text == "" && txtnum9.Text == "")
            {
                txtfila3.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum7.Text == "" && txtnum8.Text == "" && txtnum9.Text == "")
            {
                txtfila3.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }
        }

        private void txtnum10_TextChanged(object sender, EventArgs e)
        {
            if (txtnum10.Text != "" && txtnum11.Text != "" && txtnum12.Text != "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum10.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum10.Text != "" && txtnum11.Text == "" && txtnum12.Text == "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum10.Text == "" && txtnum11.Text != "" && txtnum12.Text == "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum11.Text));

            }
            else if (txtnum10.Text == "" && txtnum11.Text == "" && txtnum12.Text != "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum12.Text));

            }
            else if (txtnum10.Text == "" && txtnum11.Text == "" && txtnum12.Text == "")
            {
                txtfila4.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }

        }

        private void txtnum11_TextChanged(object sender, EventArgs e)
        {
            if (txtnum10.Text != "" && txtnum11.Text != "" && txtnum12.Text != "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum10.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum10.Text != "" && txtnum11.Text == "" && txtnum12.Text == "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum10.Text == "" && txtnum11.Text != "" && txtnum12.Text == "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum11.Text));

            }
            else if (txtnum10.Text == "" && txtnum11.Text == "" && txtnum12.Text != "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum12.Text));

            }
            else if (txtnum10.Text == "" && txtnum11.Text == "" && txtnum12.Text == "")
            {
                txtfila4.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }
        }

        private void txtnum12_TextChanged(object sender, EventArgs e)
        {
            if (txtnum10.Text != "" && txtnum11.Text != "" && txtnum12.Text != "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum10.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum10.Text != "" && txtnum11.Text == "" && txtnum12.Text == "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum10.Text == "" && txtnum11.Text != "" && txtnum12.Text == "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum11.Text));

            }
            else if (txtnum10.Text == "" && txtnum11.Text == "" && txtnum12.Text != "")
            {
                txtfila4.Text = Convert.ToString(int.Parse(txtnum12.Text));

            }
            else if (txtnum10.Text == "" && txtnum11.Text == "" && txtnum12.Text == "")
            {
                txtfila4.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }
        }

        private void txtnum13_TextChanged(object sender, EventArgs e)
        {
            if (txtnum13.Text != "" && txtnum14.Text != "" && txtnum15.Text != "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum13.Text) + int.Parse(txtnum14.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum13.Text != "" && txtnum14.Text == "" && txtnum15.Text == "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum13.Text == "" && txtnum14.Text != "" && txtnum15.Text == "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum14.Text));

            }
            else if (txtnum13.Text == "" && txtnum14.Text == "" && txtnum15.Text != "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum15.Text));

            }
            else if (txtnum13.Text == "" && txtnum14.Text == "" && txtnum15.Text == "")
            {
                txtfila5.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }

        }

        private void txtnum14_TextChanged(object sender, EventArgs e)
        {
            if (txtnum13.Text != "" && txtnum14.Text != "" && txtnum15.Text != "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum13.Text) + int.Parse(txtnum14.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum13.Text != "" && txtnum14.Text == "" && txtnum15.Text == "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum13.Text == "" && txtnum14.Text != "" && txtnum15.Text == "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum14.Text));

            }
            else if (txtnum13.Text == "" && txtnum14.Text == "" && txtnum15.Text != "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum15.Text));

            }
            else if (txtnum13.Text == "" && txtnum14.Text == "" && txtnum15.Text == "")
            {
                txtfila5.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }
        }

        private void txtnum15_TextChanged(object sender, EventArgs e)
        {
            if (txtnum13.Text != "" && txtnum14.Text != "" && txtnum15.Text != "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum13.Text) + int.Parse(txtnum14.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum13.Text != "" && txtnum14.Text == "" && txtnum15.Text == "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum13.Text == "" && txtnum14.Text != "" && txtnum15.Text == "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum14.Text));

            }
            else if (txtnum13.Text == "" && txtnum14.Text == "" && txtnum15.Text != "")
            {
                txtfila5.Text = Convert.ToString(int.Parse(txtnum15.Text));

            }
            else if (txtnum13.Text == "" && txtnum14.Text == "" && txtnum15.Text == "")
            {
                txtfila5.Text = "";

            }
            if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }

            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum4.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum7.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum4.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text != "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = Convert.ToString(int.Parse(txtnum1.Text) + int.Parse(txtnum7.Text) + int.Parse(txtnum10.Text) + int.Parse(txtnum13.Text));
            }
            else if (txtnum1.Text != "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum1.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text != "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum4.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text != "" && txtnum10.Text == "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum7.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text != "" && txtnum13.Text == "")
            {
                txtcolumna1.Text = txtnum10.Text;
            }
            else if (txtnum1.Text == "" && txtnum4.Text == "" && txtnum7.Text == "" && txtnum10.Text == "" && txtnum13.Text != "")
            {
                txtcolumna1.Text = txtnum13.Text;
            }


            // Columna2

            if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }

            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum5.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum8.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum5.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text != "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = Convert.ToString(int.Parse(txtnum2.Text) + int.Parse(txtnum8.Text) + int.Parse(txtnum11.Text) + int.Parse(txtnum14.Text));
            }
            else if (txtnum2.Text != "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum2.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text != "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum5.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text != "" && txtnum11.Text == "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum8.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text != "" && txtnum14.Text == "")
            {
                txtcolumna2.Text = txtnum11.Text;
            }
            else if (txtnum2.Text == "" && txtnum5.Text == "" && txtnum8.Text == "" && txtnum11.Text == "" && txtnum14.Text != "")
            {
                txtcolumna2.Text = txtnum14.Text;
            }

            // Columna 3

            if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }

            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum6.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum9.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum6.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text != "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = Convert.ToString(int.Parse(txtnum3.Text) + int.Parse(txtnum9.Text) + int.Parse(txtnum12.Text) + int.Parse(txtnum15.Text));
            }
            else if (txtnum3.Text != "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum3.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text != "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum6.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text != "" && txtnum12.Text == "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum9.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text != "" && txtnum15.Text == "")
            {
                txtcolumna3.Text = txtnum12.Text;
            }
            else if (txtnum3.Text == "" && txtnum6.Text == "" && txtnum9.Text == "" && txtnum12.Text == "" && txtnum15.Text != "")
            {
                txtcolumna3.Text = txtnum15.Text;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "0";
            txtnum2.Text = "0";
            txtnum3.Text = "0";
            txtnum4.Text = "0";
            txtnum5.Text = "0";
            txtnum6.Text = "0";
            txtnum7.Text = "0";
            txtnum8.Text = "0";
            txtnum9.Text = "0";
            txtnum10.Text = "0";
            txtnum11.Text = "0";
            txtnum12.Text = "0";
            txtnum13.Text = "0";
            txtnum14.Text = "0";
            txtnum15.Text = "0";
            txtfila1.Text = "0";
            txtfila2.Text = "0";
            txtfila3.Text = "0";
            txtfila4.Text = "0";
            txtfila5.Text = "0";
            txtcolumna1.Text = "0";
            txtcolumna2.Text = "0";
            txtcolumna3.Text = "0";




        }
    }
}
