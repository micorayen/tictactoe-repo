using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe__CSharp_
{
    public partial class frm_declare_winner : Form
    {
        public frm_declare_winner()
        {
            InitializeComponent();
        }

        // pass parameter - declare winner
        public frm_declare_winner(String a)
        {
            InitializeComponent();
            btn1.Text = a;
        }

        public void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
