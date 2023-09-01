namespace Dice
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            newGame = new Button();
            diceButton = new Button();
            listView1 = new ListView();
            listView2 = new ListView();
            label3 = new Label();
            ımageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Oyuncu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 10);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Bilgisayar";
            // 
            // newGame
            // 
            newGame.Location = new Point(169, 35);
            newGame.Name = "newGame";
            newGame.Size = new Size(94, 60);
            newGame.TabIndex = 2;
            newGame.Text = "Yeni Oyun";
            newGame.UseVisualStyleBackColor = true;
            newGame.Click += newGame_Click;
            // 
            // diceButton
            // 
            diceButton.Location = new Point(169, 96);
            diceButton.Name = "diceButton";
            diceButton.Size = new Size(94, 60);
            diceButton.TabIndex = 3;
            diceButton.Text = "Zar At";
            diceButton.UseVisualStyleBackColor = true;
            diceButton.Click += diceButton_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 121);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(269, 35);
            listView2.Name = "listView2";
            listView2.Size = new Size(151, 121);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 10);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 6;
            label3.Text = "Kurallar";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Dice-1-b.png");
            ımageList1.Images.SetKeyName(1, "Dice-2-b.png");
            ımageList1.Images.SetKeyName(2, "Dice-3-b.png");
            ımageList1.Images.SetKeyName(3, "Dice-4-b.png");
            ımageList1.Images.SetKeyName(4, "Dice-5-b.png");
            ımageList1.Images.SetKeyName(5, "Dice-6-b.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(86, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(219, 183);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 125);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(436, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(144, 265);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "- Oyun toplam üç turdan oluşur.\n- Zarların çift gelmesi durumunda tekrardan zar atılır.\n- Toplam puana göre kazanan belirlenir.\n\n- İyi Şanslar -";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 10;
            label4.Text = "Toplam : 00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 159);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 11;
            label5.Text = "Toplam : 00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 320);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(diceButton);
            Controls.Add(newGame);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button newGame;
        private Button diceButton;
        private ListView listView1;
        private ListView listView2;
        private Label label3;
        private ImageList ımageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox richTextBox1;
        private Label label4;
        private Label label5;
    }
}