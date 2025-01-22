namespace Buckshot_Roulette
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
            red_ammo_button_add = new Button();
            label1 = new Label();
            remove_red_button = new Button();
            label2 = new Label();
            blue_ammo_button_add = new Button();
            remove_blue_button = new Button();
            label3 = new Label();
            shot_bullets_label = new Label();
            clear_round_button = new Button();
            ammo_count_label = new Label();
            blue_percent_label = new Label();
            red_percent_label = new Label();
            blue_count_label = new Label();
            red_count_label = new Label();
            SuspendLayout();
            // 
            // red_ammo_button_add
            // 
            red_ammo_button_add.BackColor = SystemColors.ActiveCaption;
            red_ammo_button_add.Location = new Point(64, 158);
            red_ammo_button_add.Name = "red_ammo_button_add";
            red_ammo_button_add.Size = new Size(104, 43);
            red_ammo_button_add.TabIndex = 0;
            red_ammo_button_add.Text = "Add 1";
            red_ammo_button_add.UseVisualStyleBackColor = false;
            red_ammo_button_add.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(51, 120);
            label1.Name = "label1";
            label1.Size = new Size(136, 35);
            label1.TabIndex = 1;
            label1.Text = "Red ammo";
            // 
            // remove_red_button
            // 
            remove_red_button.BackColor = Color.IndianRed;
            remove_red_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            remove_red_button.Location = new Point(64, 224);
            remove_red_button.Name = "remove_red_button";
            remove_red_button.Size = new Size(104, 42);
            remove_red_button.TabIndex = 3;
            remove_red_button.Text = "Remove 1";
            remove_red_button.UseVisualStyleBackColor = false;
            remove_red_button.Click += remove_red_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(203, 120);
            label2.Name = "label2";
            label2.Size = new Size(141, 35);
            label2.TabIndex = 4;
            label2.Text = "Blue ammo";
            // 
            // blue_ammo_button_add
            // 
            blue_ammo_button_add.BackColor = SystemColors.ActiveCaption;
            blue_ammo_button_add.Location = new Point(219, 158);
            blue_ammo_button_add.Name = "blue_ammo_button_add";
            blue_ammo_button_add.Size = new Size(106, 43);
            blue_ammo_button_add.TabIndex = 5;
            blue_ammo_button_add.Text = "Add 1";
            blue_ammo_button_add.UseVisualStyleBackColor = false;
            blue_ammo_button_add.Click += blue_ammo_button_add_Click;
            // 
            // remove_blue_button
            // 
            remove_blue_button.BackColor = Color.IndianRed;
            remove_blue_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            remove_blue_button.Location = new Point(219, 223);
            remove_blue_button.Name = "remove_blue_button";
            remove_blue_button.Size = new Size(104, 44);
            remove_blue_button.TabIndex = 6;
            remove_blue_button.Text = "Remove 1";
            remove_blue_button.UseVisualStyleBackColor = false;
            remove_blue_button.Click += remove_blue_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(372, 120);
            label3.Name = "label3";
            label3.Size = new Size(171, 35);
            label3.TabIndex = 8;
            label3.Text = "Passed bullets";
            // 
            // shot_bullets_label
            // 
            shot_bullets_label.AutoSize = true;
            shot_bullets_label.Font = new Font("Segoe UI", 15F);
            shot_bullets_label.Location = new Point(347, 166);
            shot_bullets_label.Name = "shot_bullets_label";
            shot_bullets_label.Size = new Size(26, 35);
            shot_bullets_label.TabIndex = 9;
            shot_bullets_label.Text = "x";
            // 
            // clear_round_button
            // 
            clear_round_button.BackColor = Color.PaleGreen;
            clear_round_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            clear_round_button.Location = new Point(142, 306);
            clear_round_button.Name = "clear_round_button";
            clear_round_button.Size = new Size(106, 43);
            clear_round_button.TabIndex = 10;
            clear_round_button.Text = "Clear round";
            clear_round_button.UseVisualStyleBackColor = false;
            clear_round_button.Click += clear_round_button_Click;
            // 
            // ammo_count_label
            // 
            ammo_count_label.AutoSize = true;
            ammo_count_label.Font = new Font("Segoe UI", 10F);
            ammo_count_label.Location = new Point(393, 9);
            ammo_count_label.Name = "ammo_count_label";
            ammo_count_label.Size = new Size(114, 23);
            ammo_count_label.TabIndex = 11;
            ammo_count_label.Text = "Ammo count:";
            // 
            // blue_percent_label
            // 
            blue_percent_label.AutoSize = true;
            blue_percent_label.Font = new Font("Segoe UI", 10F);
            blue_percent_label.Location = new Point(221, 9);
            blue_percent_label.Name = "blue_percent_label";
            blue_percent_label.Size = new Size(62, 23);
            blue_percent_label.TabIndex = 12;
            blue_percent_label.Text = "Blue %";
            // 
            // red_percent_label
            // 
            red_percent_label.AutoSize = true;
            red_percent_label.Font = new Font("Segoe UI", 10F);
            red_percent_label.Location = new Point(64, 9);
            red_percent_label.Name = "red_percent_label";
            red_percent_label.Size = new Size(58, 23);
            red_percent_label.TabIndex = 13;
            red_percent_label.Text = "Red %";
            // 
            // blue_count_label
            // 
            blue_count_label.AutoSize = true;
            blue_count_label.Font = new Font("Segoe UI", 10F);
            blue_count_label.Location = new Point(227, 68);
            blue_count_label.Name = "blue_count_label";
            blue_count_label.Size = new Size(96, 23);
            blue_count_label.TabIndex = 14;
            blue_count_label.Text = "Blue count:";
            // 
            // red_count_label
            // 
            red_count_label.AutoSize = true;
            red_count_label.Font = new Font("Segoe UI", 10F);
            red_count_label.Location = new Point(64, 68);
            red_count_label.Name = "red_count_label";
            red_count_label.Size = new Size(92, 23);
            red_count_label.TabIndex = 15;
            red_count_label.Text = "Red count:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 450);
            Controls.Add(red_count_label);
            Controls.Add(blue_count_label);
            Controls.Add(red_percent_label);
            Controls.Add(blue_percent_label);
            Controls.Add(ammo_count_label);
            Controls.Add(clear_round_button);
            Controls.Add(shot_bullets_label);
            Controls.Add(label3);
            Controls.Add(remove_blue_button);
            Controls.Add(blue_ammo_button_add);
            Controls.Add(label2);
            Controls.Add(remove_red_button);
            Controls.Add(label1);
            Controls.Add(red_ammo_button_add);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button red_ammo_button_add;
        private Label label1;
        private Button remove_red_button;
        private Label label2;
        private Button blue_ammo_button_add;
        private Button remove_blue_button;
        private Label label3;
        private Label shot_bullets_label;
        private Button clear_round_button;
        private Label ammo_count_label;
        private Label blue_percent_label;
        private Label red_percent_label;
        private Label blue_count_label;
        private Label red_count_label;
    }
}
