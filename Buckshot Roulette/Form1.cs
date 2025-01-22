using System.Diagnostics.Metrics;

namespace Buckshot_Roulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int blue = 0;
        public int red = 0;
        public int ammoCount = 0;
        public double bluePercent = 0;
        public double redPercent = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            red++;
            ammoCount++;


            UpdateLabel("");
        }

        private void blue_ammo_button_add_Click(object sender, EventArgs e)
        {
            blue++;
            ammoCount++;


            UpdateLabel("");
        }

        private void UpdateLabel(string? shotBullet)
        {
            if (blue > 0)
            {
                bluePercent = ((double)blue / (double)ammoCount) * 100;
            }
            else
            {
                bluePercent = 0;
            }

            if (red > 0)
            {
                redPercent = ((double)red / (double)ammoCount) * 100;
            }
            else
            {
                redPercent = 0;
            }

            ammo_count_label.Text = $"Ammo count: {ammoCount}";
            blue_percent_label.Text = $"Blue % {bluePercent.ToString("f2")}";
            red_percent_label.Text = $"Red % {redPercent.ToString("f2")}";
            blue_count_label.Text = $"Blue count: {blue}";
            red_count_label.Text = $"Red count: {red}";

            if (!string.IsNullOrEmpty(shotBullet))
            {
                shot_bullets_label.Text = shot_bullets_label.Text + shotBullet;
            }

        }

        private void clear_round_button_Click(object sender, EventArgs e)
        {
            blue = 0;
            red = 0;
            ammoCount = 0;
            bluePercent = 0;
            redPercent = 0;
            shot_bullets_label.Text = "";

            UpdateLabel("");
        }

        private void remove_blue_button_Click(object sender, EventArgs e)
        {
            if (blue > 0)
            {
                blue--;
                ammoCount--;

                UpdateLabel("B");
            }
        }

        private void remove_red_button_Click(object sender, EventArgs e)
        {
            if (red > 0)
            {
                red--;
                ammoCount--;

                UpdateLabel("R");
            }
        }
    }
}
