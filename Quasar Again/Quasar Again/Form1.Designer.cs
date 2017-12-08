namespace Quasar_Again
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_die18 = new System.Windows.Forms.Button();
            this.b_stay = new System.Windows.Forms.Button();
            this.l_bet = new System.Windows.Forms.Label();
            this.nu_bet = new System.Windows.Forms.NumericUpDown();
            this.b_die47 = new System.Windows.Forms.Button();
            this.l_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nu_bet)).BeginInit();
            this.SuspendLayout();
            // 
            // b_die18
            // 
            this.b_die18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_die18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b_die18.FlatAppearance.BorderSize = 3;
            this.b_die18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_die18.Location = new System.Drawing.Point(112, 153);
            this.b_die18.Name = "b_die18";
            this.b_die18.Size = new System.Drawing.Size(75, 39);
            this.b_die18.TabIndex = 0;
            this.b_die18.Text = "1 - 8";
            this.b_die18.UseVisualStyleBackColor = false;
            this.b_die18.Click += new System.EventHandler(this.b_die18_Click);
            // 
            // b_stay
            // 
            this.b_stay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_stay.Location = new System.Drawing.Point(201, 204);
            this.b_stay.Name = "b_stay";
            this.b_stay.Size = new System.Drawing.Size(75, 46);
            this.b_stay.TabIndex = 2;
            this.b_stay.Text = "STAY";
            this.b_stay.UseVisualStyleBackColor = true;
            this.b_stay.Click += new System.EventHandler(this.b_stay_Click);
            // 
            // l_bet
            // 
            this.l_bet.AutoSize = true;
            this.l_bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_bet.Location = new System.Drawing.Point(12, 28);
            this.l_bet.Name = "l_bet";
            this.l_bet.Size = new System.Drawing.Size(47, 24);
            this.l_bet.TabIndex = 3;
            this.l_bet.Text = "BET";
            // 
            // nu_bet
            // 
            this.nu_bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_bet.Location = new System.Drawing.Point(16, 55);
            this.nu_bet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_bet.Name = "nu_bet";
            this.nu_bet.Size = new System.Drawing.Size(120, 29);
            this.nu_bet.TabIndex = 4;
            this.nu_bet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b_die47
            // 
            this.b_die47.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_die47.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b_die47.FlatAppearance.BorderSize = 3;
            this.b_die47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_die47.Location = new System.Drawing.Point(291, 153);
            this.b_die47.Name = "b_die47";
            this.b_die47.Size = new System.Drawing.Size(75, 39);
            this.b_die47.TabIndex = 5;
            this.b_die47.Text = "4 - 7";
            this.b_die47.UseVisualStyleBackColor = false;
            this.b_die47.Click += new System.EventHandler(this.b_die47_Click);
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_total.Location = new System.Drawing.Point(217, 101);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(35, 37);
            this.l_total.TabIndex = 6;
            this.l_total.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 262);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.b_die47);
            this.Controls.Add(this.nu_bet);
            this.Controls.Add(this.l_bet);
            this.Controls.Add(this.b_stay);
            this.Controls.Add(this.b_die18);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nu_bet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_die18;
        private System.Windows.Forms.Button b_stay;
        private System.Windows.Forms.Label l_bet;
        private System.Windows.Forms.NumericUpDown nu_bet;
        private System.Windows.Forms.Button b_die47;
        private System.Windows.Forms.Label l_total;
    }
}

