
namespace GameRental_sys
{
    partial class Rent_And_Return
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
            this.month = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gameid = new System.Windows.Forms.TextBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.gamename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.vendorN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vendorID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(380, 380);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(208, 20);
            this.month.TabIndex = 63;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(468, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 60;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(214, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 59;
            this.button1.Text = "Rent";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(184, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 52);
            this.label4.TabIndex = 58;
            this.label4.Text = "Rent And Return Games";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameid
            // 
            this.gameid.Location = new System.Drawing.Point(380, 154);
            this.gameid.Name = "gameid";
            this.gameid.Size = new System.Drawing.Size(209, 20);
            this.gameid.TabIndex = 57;
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(380, 201);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(209, 20);
            this.cname.TabIndex = 56;
            // 
            // gamename
            // 
            this.gamename.Location = new System.Drawing.Point(380, 102);
            this.gamename.Name = "gamename";
            this.gamename.Size = new System.Drawing.Size(209, 20);
            this.gamename.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(211, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 34);
            this.label2.TabIndex = 54;
            this.label2.Text = "Your Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(211, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 34);
            this.label1.TabIndex = 53;
            this.label1.Text = "Game ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(211, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 34);
            this.label11.TabIndex = 52;
            this.label11.Text = "Game Name";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vendorN
            // 
            this.vendorN.Location = new System.Drawing.Point(379, 292);
            this.vendorN.Name = "vendorN";
            this.vendorN.Size = new System.Drawing.Size(209, 20);
            this.vendorN.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(210, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 34);
            this.label5.TabIndex = 68;
            this.label5.Text = "Vendor Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(379, 248);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(209, 20);
            this.cid.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(210, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 34);
            this.label6.TabIndex = 70;
            this.label6.Text = "Your ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vendorID
            // 
            this.vendorID.Location = new System.Drawing.Point(379, 339);
            this.vendorID.Name = "vendorID";
            this.vendorID.Size = new System.Drawing.Size(209, 20);
            this.vendorID.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(210, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 34);
            this.label7.TabIndex = 72;
            this.label7.Text = "Vendor ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(211, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 34);
            this.label3.TabIndex = 67;
            this.label3.Text = "Rent/Return Month";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rent_And_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.vendorID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vendorN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.month);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gameid);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.gamename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "Rent_And_Return";
            this.Text = "Rent_And_Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gameid;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.TextBox gamename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vendorN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vendorID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}