
namespace GameRental_sys
{
    partial class AddGame
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
            this.components = new System.ComponentModel.Container();
            this.gameID = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.gameN = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesrentalDataSet = new GameRental_sys.gamesrentalDataSet();
            this.gameTableAdapter = new GameRental_sys.gamesrentalDataSetTableAdapters.gameTableAdapter();
            this.gameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gamenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vendorID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesrentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameID
            // 
            this.gameID.Location = new System.Drawing.Point(303, 125);
            this.gameID.Name = "gameID";
            this.gameID.Size = new System.Drawing.Size(321, 20);
            this.gameID.TabIndex = 25;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(303, 162);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(321, 20);
            this.category.TabIndex = 24;
            // 
            // gameN
            // 
            this.gameN.Location = new System.Drawing.Point(303, 88);
            this.gameN.Name = "gameN";
            this.gameN.Size = new System.Drawing.Size(321, 20);
            this.gameN.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Teal;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(121, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 25);
            this.label20.TabIndex = 22;
            this.label20.Text = "Game ID";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Teal;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(121, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 25);
            this.label19.TabIndex = 21;
            this.label19.Text = "Gategory";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(121, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Game Name";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(534, 185);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 17);
            this.label22.TabIndex = 37;
            this.label22.Text = "Year";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(431, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 17);
            this.label21.TabIndex = 36;
            this.label21.Text = "Month";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(327, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Day";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(422, 199);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(87, 20);
            this.month.TabIndex = 34;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(525, 199);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(87, 20);
            this.year.TabIndex = 33;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(319, 199);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(87, 20);
            this.day.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Teal;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(121, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 25);
            this.label18.TabIndex = 31;
            this.label18.Text = "Date of adding";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(313, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 52);
            this.label1.TabIndex = 38;
            this.label1.Text = "Add New Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(411, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 39;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "game";
            this.gameBindingSource.DataSource = this.gamesrentalDataSet;
            // 
            // gamesrentalDataSet
            // 
            this.gamesrentalDataSet.DataSetName = "gamesrentalDataSet";
            this.gamesrentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // gameBindingSource1
            // 
            this.gameBindingSource1.DataMember = "game";
            this.gameBindingSource1.DataSource = this.gamesrentalDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gamenameDataGridViewTextBoxColumn,
            this.gameIDDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(661, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 173);
            this.dataGridView1.TabIndex = 43;
            // 
            // gamenameDataGridViewTextBoxColumn
            // 
            this.gamenameDataGridViewTextBoxColumn.DataPropertyName = "game_name";
            this.gamenameDataGridViewTextBoxColumn.HeaderText = "game_name";
            this.gamenameDataGridViewTextBoxColumn.Name = "gamenameDataGridViewTextBoxColumn";
            // 
            // gameIDDataGridViewTextBoxColumn
            // 
            this.gameIDDataGridViewTextBoxColumn.DataPropertyName = "game_ID";
            this.gameIDDataGridViewTextBoxColumn.HeaderText = "game_ID";
            this.gameIDDataGridViewTextBoxColumn.Name = "gameIDDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // gameBindingSource2
            // 
            this.gameBindingSource2.DataMember = "game";
            this.gameBindingSource2.DataSource = this.gamesrentalDataSet;
            // 
            // vendorN
            // 
            this.vendorN.Location = new System.Drawing.Point(303, 235);
            this.vendorN.Name = "vendorN";
            this.vendorN.Size = new System.Drawing.Size(321, 20);
            this.vendorN.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(121, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Vendor Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vendorID
            // 
            this.vendorID.Location = new System.Drawing.Point(303, 270);
            this.vendorID.Name = "vendorID";
            this.vendorID.Size = new System.Drawing.Size(321, 20);
            this.vendorID.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(121, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Vendor ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(303, 309);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(321, 20);
            this.country.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(121, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Vendor Country";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 414);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vendorID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vendorN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gameID);
            this.Controls.Add(this.category);
            this.Controls.Add(this.gameN);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Name = "AddGame";
            this.Text = "AddGame";
            this.Load += new System.EventHandler(this.AddGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesrentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameID;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox gameN;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private gamesrentalDataSet gamesrentalDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private gamesrentalDataSetTableAdapters.gameTableAdapter gameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gameBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gameBindingSource2;
        private System.Windows.Forms.TextBox vendorN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vendorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label4;
    }
}