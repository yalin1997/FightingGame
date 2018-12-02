using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FightingGame
{
    public partial class selectTeamForm : Form
    {
        List<Character.Character> battleMember = new List<Character.Character>();
        Character.Character Bananice;
        public selectTeamForm()
        {
            InitializeComponent();
            Bananice = new Character.Bananice();
            pictureBox6.Parent = flowLayoutPanel1;
            pictureBox6.Image = Image.FromFile(Bananice.getSmallAddress());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (battleMember.Count!=0)
            {
                BattleForm bf = new BattleForm();
                bf.Owner = this;
                bf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("choose your character", "Message",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!pictureBox6.BorderStyle.Equals(BorderStyle.Fixed3D))
            {
                battleMember.Add(Bananice);
                pictureBox1.Image = Image.FromFile(Bananice.getBigAddress());
                pictureBox6.BorderStyle = BorderStyle.Fixed3D;
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                battleMember.Remove(Bananice);
                pictureBox1.Image = null;
                pictureBox6.BorderStyle = BorderStyle.None;
                pictureBox1.BorderStyle = BorderStyle.None;
            }
        }
    }
}
