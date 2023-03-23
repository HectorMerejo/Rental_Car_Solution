
namespace RentCarSolution
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
            this.SUV = new System.Windows.Forms.RadioButton();
            this.compact = new System.Windows.Forms.RadioButton();
            this.SportsCar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.place_Rental = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.licensePlate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fill_Button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SUV
            // 
            this.SUV.AutoSize = true;
            this.SUV.Location = new System.Drawing.Point(125, 273);
            this.SUV.Name = "SUV";
            this.SUV.Size = new System.Drawing.Size(183, 29);
            this.SUV.TabIndex = 0;
            this.SUV.TabStop = true;
            this.SUV.Text = "SUV ($40/day)";
            this.SUV.UseVisualStyleBackColor = true;
            // 
            // compact
            // 
            this.compact.AutoSize = true;
            this.compact.Location = new System.Drawing.Point(125, 193);
            this.compact.Name = "compact";
            this.compact.Size = new System.Drawing.Size(219, 29);
            this.compact.TabIndex = 0;
            this.compact.TabStop = true;
            this.compact.Text = "Compact($25/day)";
            this.compact.UseVisualStyleBackColor = true;
            // 
            // SportsCar
            // 
            this.SportsCar.AutoSize = true;
            this.SportsCar.Location = new System.Drawing.Point(125, 351);
            this.SportsCar.Name = "SportsCar";
            this.SportsCar.Size = new System.Drawing.Size(236, 29);
            this.SportsCar.TabIndex = 0;
            this.SportsCar.TabStop = true;
            this.SportsCar.Text = "Sports Car($60/day)";
            this.SportsCar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Rental Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rent Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(752, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(408, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(752, 351);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(408, 31);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1502, 183);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(283, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "ExtraDriver Charge ($25)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // place_Rental
            // 
            this.place_Rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place_Rental.Location = new System.Drawing.Point(724, 503);
            this.place_Rental.Name = "place_Rental";
            this.place_Rental.Size = new System.Drawing.Size(393, 56);
            this.place_Rental.TabIndex = 5;
            this.place_Rental.Text = "PLACE RENTAL";
            this.place_Rental.UseVisualStyleBackColor = true;
            this.place_Rental.Click += new System.EventHandler(this.place_Rental_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "License Plate";
            // 
            // licensePlate
            // 
            this.licensePlate.Location = new System.Drawing.Point(752, 626);
            this.licensePlate.Name = "licensePlate";
            this.licensePlate.Size = new System.Drawing.Size(340, 31);
            this.licensePlate.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 740);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1503, 473);
            this.dataGridView1.TabIndex = 8;
            // 
            // fill_Button
            // 
            this.fill_Button.Location = new System.Drawing.Point(31, 786);
            this.fill_Button.Name = "fill_Button";
            this.fill_Button.Size = new System.Drawing.Size(159, 46);
            this.fill_Button.TabIndex = 9;
            this.fill_Button.Text = "Fill";
            this.fill_Button.UseVisualStyleBackColor = true;
            this.fill_Button.Click += new System.EventHandler(this.fill_Button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 1049);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2280, 1610);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fill_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.licensePlate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.place_Rental);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compact);
            this.Controls.Add(this.SportsCar);
            this.Controls.Add(this.SUV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SUV;
        private System.Windows.Forms.RadioButton compact;
        private System.Windows.Forms.RadioButton SportsCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button place_Rental;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox licensePlate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button fill_Button;
        private System.Windows.Forms.Button button3;
    }
}

