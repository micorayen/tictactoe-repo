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
    public partial class frm_TicTacToe_5x5 : Form
    {
        public frm_TicTacToe_5x5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //add action to all buttons inside grid_panel
            foreach (Control c in grid_panel.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
        }

        int XorO = 0;
        //
        //create action for buttton
        //
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {    
                if(XorO % 2 == 0)
                {
                    XorO++;
                    btn.Text = "X";
                    btn.ForeColor = Color.Red;
                    lbl_player1.ForeColor = Color.PaleGoldenrod;
                    lbl_player2.ForeColor = Color.Yellow;
                    getTheWinner();
                }else 
                {
                    XorO++;
                    btn.Text = "O";
                    btn.ForeColor = Color.White;
                    lbl_player1.ForeColor = Color.Yellow;
                    lbl_player2.ForeColor = Color.PaleGoldenrod;
                    getTheWinner();
                }
            }
        }
        //
        // Winning patterns
        // 
        Boolean h1, h2, h3, h4, h5, h6, h7, h8, h9, h10, h11, h12, h13, h14, h15;
        Boolean v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15;
        Boolean ds1_1, ds1_2, ds1_3, ds1_4, ds1_5, ds1_6, ds1_7, ds1_8, ds1_9;
        Boolean ds2_1, ds2_2, ds2_3, ds2_4, ds2_5, ds2_6, ds2_7, ds2_8, ds2_9;
        //
        // Detect winning patterns
        //
        public void getTheWinner()
        {
            //
            // Start horizontal
            //
            if (h1 == false && !btn1.Text.Equals("") && btn1.Text.Equals(btn2.Text) && btn1.Text.Equals(btn3.Text))// 1st Line
            {
                h1 = true;
                WinningPattern_Effect(btn1, btn2, btn3);
            }

            if (h2 == false && !btn2.Text.Equals("") && btn2.Text.Equals(btn3.Text) && btn2.Text.Equals(btn4.Text))
            {
                h2 = true;
                WinningPattern_Effect(btn2, btn3, btn4);
            }

            if (h3 == false && !btn3.Text.Equals("") && btn3.Text.Equals(btn4.Text) && btn3.Text.Equals(btn5.Text))
            {
                h3 = true;
                WinningPattern_Effect(btn3, btn4, btn5);
            }
            if (h4 == false && !btn6.Text.Equals("") && btn6.Text.Equals(btn7.Text) && btn6.Text.Equals(btn8.Text))// 2nd Line
            {
                h4 = true;
                WinningPattern_Effect(btn6, btn7, btn8);
            }
            if (h5 == false && !btn7.Text.Equals("") && btn7.Text.Equals(btn8.Text) && btn7.Text.Equals(btn9.Text))
            {
                h5 = true;
                WinningPattern_Effect(btn7, btn8, btn9);
            }
            if (h6 == false && !btn8.Text.Equals("") && btn8.Text.Equals(btn9.Text) && btn8.Text.Equals(btn10.Text))
            {
                h6 = true;
                WinningPattern_Effect(btn8, btn9, btn10);
            }
            if (h7 == false && !btn11.Text.Equals("") && btn11.Text.Equals(btn12.Text) && btn11.Text.Equals(btn13.Text))// 3rd Line
            {
                h7 = true;
                WinningPattern_Effect(btn11, btn12, btn13);
            }
            if (h8 == false && !btn12.Text.Equals("") && btn12.Text.Equals(btn13.Text) && btn12.Text.Equals(btn14.Text))
            {
                h8 = true;
                WinningPattern_Effect(btn12, btn13, btn14);
            }
            if (h9 == false && !btn13.Text.Equals("") && btn13.Text.Equals(btn14.Text) && btn13.Text.Equals(btn15.Text))
            {
                h9 = true;
                WinningPattern_Effect(btn13, btn14, btn15);
            }
            if (h10 == false && !btn16.Text.Equals("") && btn16.Text.Equals(btn17.Text) && btn16.Text.Equals(btn18.Text))// 4th Line 
            {
                h10 = true;
                WinningPattern_Effect(btn16, btn17, btn18);
            }
            if (h11 == false && !btn17.Text.Equals("") && btn17.Text.Equals(btn18.Text) && btn17.Text.Equals(btn19.Text)) 
            {
                h11 = true;
                WinningPattern_Effect(btn17, btn18, btn19);
            }
            if (h12 == false && !btn18.Text.Equals("") && btn18.Text.Equals(btn19.Text) && btn18.Text.Equals(btn20.Text))
            {
                h12 = true;
                WinningPattern_Effect(btn18, btn19, btn20);
            }
            if (h13 == false && !btn21.Text.Equals("") && btn21.Text.Equals(btn22.Text) && btn21.Text.Equals(btn23.Text))// 5th Line
            {
                h13 = true;
                WinningPattern_Effect(btn21, btn22, btn23);
            }
            if (h14 == false && !btn22.Text.Equals("") && btn22.Text.Equals(btn23.Text) && btn22.Text.Equals(btn24.Text))
            {
                h14 = true;
                WinningPattern_Effect(btn22, btn23, btn24);
            }
            if (h15 == false && !btn23.Text.Equals("") && btn23.Text.Equals(btn24.Text) && btn23.Text.Equals(btn25.Text))
            {
                h15 = true;
                WinningPattern_Effect(btn23, btn24, btn25);
            }
            //
            // Start Vertical
            //
            if (v1 == false && !btn1.Text.Equals("") && btn1.Text.Equals(btn6.Text) && btn1.Text.Equals(btn11.Text))// 1st Line
            {
                v1 = true;
                WinningPattern_Effect(btn1, btn6, btn11);
            }
            if (v2 == false && !btn6.Text.Equals("") && btn6.Text.Equals(btn11.Text) && btn6.Text.Equals(btn16.Text))
            {
                v2 = true;
                WinningPattern_Effect(btn6, btn11, btn16);
            }
            if (v3 == false && !btn11.Text.Equals("") && btn11.Text.Equals(btn16.Text) && btn11.Text.Equals(btn21.Text))
            {
                v3 = true;
                WinningPattern_Effect(btn11, btn16, btn21);;
            }
            if (v4 == false && !btn2.Text.Equals("") && btn2.Text.Equals(btn7.Text) && btn2.Text.Equals(btn12.Text))// 2nd Line
            {
                v4 = true;
                WinningPattern_Effect(btn2, btn7, btn12);
            }
            if (v5 == false && !btn7.Text.Equals("") && btn7.Text.Equals(btn12.Text) && btn7.Text.Equals(btn17.Text))
            {
                v5 = true;
                WinningPattern_Effect(btn7, btn12, btn17);
            }
            if (v6 == false && !btn12.Text.Equals("") && btn12.Text.Equals(btn17.Text) && btn12.Text.Equals(btn22.Text))
            {
                v6 = true;
                WinningPattern_Effect(btn12, btn17, btn22);
            }
            if (v7 == false && !btn3.Text.Equals("") && btn3.Text.Equals(btn8.Text) && btn3.Text.Equals(btn13.Text))// 3rd Line
            {
                v7 = true;
                WinningPattern_Effect(btn3, btn8, btn13);
            }
            if (v8 == false && !btn8.Text.Equals("") && btn8.Text.Equals(btn13.Text) && btn8.Text.Equals(btn18.Text))
            {
                v8 = true;
                WinningPattern_Effect(btn8, btn13, btn18);
            }
            if (v9 == false && !btn13.Text.Equals("") && btn13.Text.Equals(btn18.Text) && btn13.Text.Equals(btn23.Text))
            {
                v9 = true;
                WinningPattern_Effect(btn13, btn18, btn23);
            }
            if (v10 == false && !btn4.Text.Equals("") && btn4.Text.Equals(btn9.Text) && btn4.Text.Equals(btn14.Text))// 4th Line
            {
                v10 = true;
                WinningPattern_Effect(btn4, btn9, btn14);
            }
            if (v11 == false && !btn9.Text.Equals("") && btn9.Text.Equals(btn14.Text) && btn9.Text.Equals(btn19.Text))
            {
                v11 = true;
                WinningPattern_Effect(btn9, btn14, btn19);
            }
            if (v12 == false && !btn14.Text.Equals("") && btn14.Text.Equals(btn19.Text) && btn14.Text.Equals(btn24.Text))
            {
                v12 = true;
                WinningPattern_Effect(btn14, btn19, btn24);
            }
            if (v13 == false && !btn5.Text.Equals("") && btn5.Text.Equals(btn10.Text) && btn5.Text.Equals(btn15.Text))// 5th Line
            {
                v13 = true;
                WinningPattern_Effect(btn5, btn10, btn15);
            }
            if (v14 == false && !btn10.Text.Equals("") && btn10.Text.Equals(btn15.Text) && btn10.Text.Equals(btn20.Text))
            {
                v14 = true;
                WinningPattern_Effect(btn10, btn15, btn20);
            }
            if (v15 == false && !btn15.Text.Equals("") && btn15.Text.Equals(btn20.Text) && btn15.Text.Equals(btn25.Text))
            {
                v15 = true;
                WinningPattern_Effect(btn15, btn20, btn25);
            }
            //
            // Start Diagonal 1st Set
            //
            if (ds1_1 == false && !btn11.Text.Equals("") && btn11.Text.Equals(btn17.Text) && btn11.Text.Equals(btn23.Text))
            {
                ds1_1 = true;
                WinningPattern_Effect(btn11, btn17, btn23);
            }
            if (ds1_2 == false && !btn6.Text.Equals("") && btn6.Text.Equals(btn12.Text) && btn6.Text.Equals(btn18.Text))
            {
                ds1_2 = true;
                WinningPattern_Effect(btn6, btn12, btn18);
            }
            if (ds1_3 == false && !btn12.Text.Equals("") && btn12.Text.Equals(btn18.Text) && btn12.Text.Equals(btn24.Text))
            {
                ds1_3 = true;
                WinningPattern_Effect(btn12, btn18, btn24);
            }
            if (ds1_4 == false && !btn1.Text.Equals("") && btn1.Text.Equals(btn7.Text) && btn1.Text.Equals(btn13.Text))
            {
                ds1_4 = true;
                WinningPattern_Effect(btn1, btn7, btn13);
            }
            if (ds1_5 == false && !btn7.Text.Equals("") && btn7.Text.Equals(btn13.Text) && btn7.Text.Equals(btn19.Text))
            {
                ds1_5 = true;
                WinningPattern_Effect(btn7, btn13, btn19);
            }
            if (ds1_6 == false && !btn13.Text.Equals("") && btn13.Text.Equals(btn19.Text) && btn13.Text.Equals(btn25.Text))
            {
                ds1_6 = true;
                WinningPattern_Effect(btn13, btn19, btn25);
            }
            if (ds1_7 == false && !btn2.Text.Equals("") && btn2.Text.Equals(btn8.Text) && btn2.Text.Equals(btn14.Text))
            {
                ds1_7 = true;
                WinningPattern_Effect(btn2, btn8, btn14);
            }
            if (ds1_8 == false && !btn8.Text.Equals("") && btn8.Text.Equals(btn14.Text) && btn8.Text.Equals(btn20.Text))
            {
                ds1_8 = true;
                WinningPattern_Effect(btn8, btn14, btn20);
            }
            if (ds1_9 == false && !btn3.Text.Equals("") && btn3.Text.Equals(btn9.Text) && btn3.Text.Equals(btn15.Text))
            {
                ds1_9 = true;
                WinningPattern_Effect(btn3, btn9, btn15);
            }
            //
            // Start Diagonal 2nd Set
            //
            if (ds2_1 == false && !btn3.Text.Equals("") && btn3.Text.Equals(btn7.Text) && btn3.Text.Equals(btn11.Text))
            {
                ds2_1 = true;
                WinningPattern_Effect(btn3, btn7, btn11);
            }
            if (ds2_2 == false && !btn4.Text.Equals("") && btn4.Text.Equals(btn8.Text) && btn4.Text.Equals(btn12.Text))
            {
                ds2_2 = true;
                WinningPattern_Effect(btn4, btn8, btn12);
            }
            if (ds2_3 == false && !btn8.Text.Equals("") && btn8.Text.Equals(btn12.Text) && btn8.Text.Equals(btn16.Text))
            {
                ds2_3 = true;
                WinningPattern_Effect(btn8, btn12, btn16);
            }
            if (ds2_4 == false && !btn5.Text.Equals("") && btn5.Text.Equals(btn9.Text) && btn5.Text.Equals(btn13.Text))
            {
                ds2_4 = true;
                WinningPattern_Effect(btn5, btn9, btn13);
            }
            if (ds2_5 == false && !btn9.Text.Equals("") && btn9.Text.Equals(btn13.Text) && btn9.Text.Equals(btn17.Text))
            {
                ds2_5 = true;
                WinningPattern_Effect(btn9, btn13, btn17);
            }
            if (ds2_6 == false && !btn13.Text.Equals("") && btn13.Text.Equals(btn17.Text) && btn13.Text.Equals(btn21.Text))
            {
                ds2_6 = true;
                WinningPattern_Effect(btn13, btn17, btn21);
            }
            if (ds2_7 == false && !btn10.Text.Equals("") && btn10.Text.Equals(btn14.Text) && btn10.Text.Equals(btn18.Text))
            {
                ds2_7 = true;
                WinningPattern_Effect(btn10, btn14, btn18);
            }
            if (ds2_8 == false && !btn14.Text.Equals("") && btn14.Text.Equals(btn18.Text) && btn14.Text.Equals(btn22.Text))
            {
                ds2_8 = true;
                WinningPattern_Effect(btn14, btn18, btn22);
            }
            if (ds2_9 == false && !btn15.Text.Equals("") && btn15.Text.Equals(btn19.Text) && btn15.Text.Equals(btn23.Text))
            {
                ds2_9 = true;
                WinningPattern_Effect(btn15, btn19, btn23);
            }
            //
            // detect if grid are full / game end in draw
            //
            if (Grid_Is_Full() == 25)
            {
                if (plyr1 > plyr2)
                {
                    Declare_Winner = "Player 1 Win!";
                    frm_declare_winner dclr = new frm_declare_winner(Declare_Winner);
                    dclr.ShowDialog();
                    reset_game();
                }
                else if (plyr2 > plyr1)
                {
                    Declare_Winner = "Player 2 Win!";
                    frm_declare_winner dclr = new frm_declare_winner(Declare_Winner);
                    dclr.ShowDialog();
                    reset_game();
                }
                else
                {
                    Declare_Winner = "Draw!";
                    frm_declare_winner dclr = new frm_declare_winner(Declare_Winner);
                    dclr.ShowDialog();
                    reset_game();
                }
            }
        }

        public int Grid_Is_Full()//Detect if grid are full
        {
            int AllButtons = 0;
            foreach (Control c in grid_panel.Controls)
            {
                if (c is Button)
                {
                    AllButtons += c.Text.Length;
                }
            }
            return AllButtons;
        }

        int plyr1 = 0;
        int plyr2 = 0;
        String Declare_Winner;
        //
        //add effect to all winning patterns inside grid_panel
        //
        public void WinningPattern_Effect(Button b1, Button b2, Button b3)
        {  
            b1.BackColor = Color.PaleGreen;
            b2.BackColor = Color.PaleGreen;
            b3.BackColor = Color.PaleGreen;

            if (b1.Text.Equals("X"))
            {
                    plyr1++;
                    if (plyr1 == 1)
                    {
                        lblp1_score_1.ForeColor = Color.Yellow;
                    }
                    else if (plyr1 == 2)
                    {
                        lblp1_score_2.ForeColor = Color.Yellow;
                    }
                    else if (plyr1 == 3)
                    {
                        lblp1_score_3.ForeColor = Color.Yellow;
                        Declare_Winner = "Player 1 Win!";
                        frm_declare_winner dclr = new frm_declare_winner(Declare_Winner);
                        dclr.ShowDialog();
                        reset_game();
                    }
            }
            if (b1.Text.Equals("O"))
            {
                    plyr2++;
                    if (plyr2 == 1)
                    {
                        lblp2_score_1.ForeColor = Color.Yellow;
                    }
                    else if (plyr2 == 2)
                    {
                        lblp2_score_2.ForeColor = Color.Yellow;
                    }
                    else if (plyr2 == 3)
                    {
                        lblp2_score_3.ForeColor = Color.Yellow;
                        Declare_Winner = "Player 2 Win!";
                        frm_declare_winner dclr = new frm_declare_winner(Declare_Winner);
                        dclr.ShowDialog();
                        reset_game();
                    }
            }
        }

        private void pbReset1_MouseMove(object sender, MouseEventArgs e)
        {
            pbReset2.BringToFront();
        }

        private void pbReset2_MouseLeave(object sender, EventArgs e)
        {
            pbReset1.BringToFront();
        }

        private void pbReset2_MouseClick(object sender, MouseEventArgs e)
        {
            reset_game();
        }
        //
        // Reset Game
        //
        public void reset_game()
        {
            XorO = 0;
            lbl_player1.ForeColor = Color.Yellow;
            lblp1_score_1.ForeColor = Color.PaleGoldenrod;
            lblp1_score_2.ForeColor = Color.PaleGoldenrod;
            lblp1_score_3.ForeColor = Color.PaleGoldenrod;

            lbl_player2.ForeColor = Color.PaleGoldenrod;
            lblp2_score_1.ForeColor = Color.PaleGoldenrod;
            lblp2_score_2.ForeColor = Color.PaleGoldenrod;
            lblp2_score_3.ForeColor = Color.PaleGoldenrod;

            plyr1 = 0;
            plyr2 = 0;
            reset_occupied_pattern();
            foreach (Control c in grid_panel.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.BackColor = Color.Transparent;
                }
            }
        }

        public void reset_occupied_pattern()
        {
            h1 = false;// horintal winning patterns
            h2 = false;
            h3 = false;
            h4 = false;
            h5 = false;
            h6 = false;
            h7 = false;
            h8 = false;
            h9 = false;
            h10 = false;
            h11 = false;
            h12 = false;
            h13 = false;
            h14 = false;
            h15 = false;
            v1 = false;// vertical winning patterns
            v2 = false;
            v3 = false;
            v4 = false;
            v5 = false;
            v6 = false;
            v7 = false;
            v8 = false;
            v9 = false;
            v10 = false;
            v11 = false;
            v12 = false;
            v13 = false;
            v14 = false;
            v15 = false;
            ds1_1 = false;// diagonal 1st set winning patterns
            ds1_2 = false;
            ds1_3 = false;
            ds1_4 = false;
            ds1_5 = false;
            ds1_6 = false;
            ds1_7 = false;
            ds1_8 = false;
            ds1_9 = false;
            ds2_1 = false;// diagonal 2nd set winning patterns
            ds2_2 = false;
            ds2_3 = false;
            ds2_4 = false;
            ds2_5 = false;
            ds2_6 = false;
            ds2_7 = false;
            ds2_8 = false;
            ds2_9 = false;
        }
        //
        // Close application
        //
        private void pbExit1_MouseMove(object sender, MouseEventArgs e)
        {
            pbExit2.BringToFront();
        }

        private void pbExit2_MouseLeave(object sender, EventArgs e)
        {
            pbExit1.BringToFront();
        }

        private void pbExit2_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Close Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
