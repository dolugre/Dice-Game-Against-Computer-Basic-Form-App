namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;
            pictureBox1.Image = ýmageList1.Images[5];
            pictureBox2.Image = ýmageList1.Images[5];
            diceButton.Enabled = false;
        }
        public void newDice()
        {
            diceButton.Enabled = true;
            pictureBox1.Image = ýmageList1.Images[5];
            pictureBox2.Image = ýmageList1.Images[5];
            listView1.Clear();
            listView2.Clear();
            player = true;
            dicePlayer = 0;
            diceComputer = 0;
            diceTour = 1;
            label4.Text = "Toplam : 00";
            label5.Text = "Toplam : 00";
        }
        private void diceButton_Click(object sender, EventArgs e)
        {
                timer1.Start();
                diceButton.Enabled = false;
        }
        int meter = 0;
        int dice1, dice2, dicePlayer, diceComputer;
        bool player = true;
        int diceTour = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            dice1 = random.Next(0, 6);
            dice2 = random.Next(0, 6);
            pictureBox1.Image = ýmageList1.Images[dice1];
            pictureBox2.Image = ýmageList1.Images[dice2];
            meter++;
            if (meter == 15)
            {
                timer1.Stop();
                meter = 0;
                if (player == true)
                {
                    dicePlayer += dice1 + dice2 + 2;
                    listView1.Items.Add(" Zarlar: " + (1 + dice1).ToString() + " " + (1 + dice2).ToString());
                    label4.Text = "Toplam : " + dicePlayer;
                    if (dice1 == dice2)
                    {
                        //
                    }
                    else 
                    { 
                        player = false;
                    }
                }
                else
                {
                    diceComputer += dice1 + dice2 + 2;
                    listView2.Items.Add(" Zarlar: " + (1 + dice1).ToString() + " " + (1 + dice2).ToString());
                    label5.Text = "Toplam : " + diceComputer;
                    if (dice1 == dice2)
                    {
                        //
                    }
                    else
                    {
                        player = true;
                        diceTour++;
                    }
                }
                if (diceTour > 3)
                {
                    diceButton.Enabled = false;
                    if ( dicePlayer > diceComputer ) 
                    {
                        MessageBox.Show("Kazandýn!" );
                    }
                    else if ( dicePlayer < diceComputer ) 
                    {
                        MessageBox.Show("Kaybettin!");
                    }
                    else
                    {
                        MessageBox.Show("Berabere!");
                    }
                }
                else
                {
                    diceButton.Enabled = true;
                }
            }
        }
        private void newGame_Click(object sender, EventArgs e)
        {
            newDice();
        }
    }
}