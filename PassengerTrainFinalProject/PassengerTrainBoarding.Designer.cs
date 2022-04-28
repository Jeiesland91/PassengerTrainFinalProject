namespace PassengerTrainFinalProject
{
    partial class PassengerTrainBoarding
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
            this.exitButton = new System.Windows.Forms.Button();
            this.queue1ListBox = new System.Windows.Forms.ListBox();
            this.generatePassengersButton = new System.Windows.Forms.Button();
            this.queueButton = new System.Windows.Forms.Button();
            this.passengerListBox = new System.Windows.Forms.ListBox();
            this.sortFirstNameButton = new System.Windows.Forms.Button();
            this.sortLastNameButton = new System.Windows.Forms.Button();
            this.sortSeatButton = new System.Windows.Forms.Button();
            this.firstClassRadio = new System.Windows.Forms.RadioButton();
            this.standardClassRadio = new System.Windows.Forms.RadioButton();
            this.trainGroupBox = new System.Windows.Forms.GroupBox();
            this.queue2ListBox = new System.Windows.Forms.ListBox();
            this.queue3ListBox = new System.Windows.Forms.ListBox();
            this.standardClassPictureBox = new System.Windows.Forms.PictureBox();
            this.firstClassPictureBox = new System.Windows.Forms.PictureBox();
            this.trainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardClassPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstClassPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1158, 689);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // queue1ListBox
            // 
            this.queue1ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queue1ListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.queue1ListBox.FormattingEnabled = true;
            this.queue1ListBox.ItemHeight = 16;
            this.queue1ListBox.Location = new System.Drawing.Point(278, 250);
            this.queue1ListBox.Margin = new System.Windows.Forms.Padding(4);
            this.queue1ListBox.Name = "queue1ListBox";
            this.queue1ListBox.Size = new System.Drawing.Size(253, 324);
            this.queue1ListBox.TabIndex = 2;
            // 
            // generatePassengersButton
            // 
            this.generatePassengersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generatePassengersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePassengersButton.ForeColor = System.Drawing.Color.Black;
            this.generatePassengersButton.Location = new System.Drawing.Point(16, 582);
            this.generatePassengersButton.Margin = new System.Windows.Forms.Padding(4);
            this.generatePassengersButton.Name = "generatePassengersButton";
            this.generatePassengersButton.Size = new System.Drawing.Size(253, 28);
            this.generatePassengersButton.TabIndex = 3;
            this.generatePassengersButton.Text = "Generate Passengers";
            this.generatePassengersButton.UseVisualStyleBackColor = false;
            this.generatePassengersButton.Click += new System.EventHandler(this.generatePassengersButton_Click);
            // 
            // queueButton
            // 
            this.queueButton.BackColor = System.Drawing.Color.DarkOrange;
            this.queueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueButton.ForeColor = System.Drawing.Color.Black;
            this.queueButton.Location = new System.Drawing.Point(277, 582);
            this.queueButton.Margin = new System.Windows.Forms.Padding(4);
            this.queueButton.Name = "queueButton";
            this.queueButton.Size = new System.Drawing.Size(253, 28);
            this.queueButton.TabIndex = 5;
            this.queueButton.Text = "Queue Passengers";
            this.queueButton.UseVisualStyleBackColor = false;
            this.queueButton.Click += new System.EventHandler(this.queueButton_Click);
            // 
            // passengerListBox
            // 
            this.passengerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passengerListBox.FormattingEnabled = true;
            this.passengerListBox.ItemHeight = 16;
            this.passengerListBox.Location = new System.Drawing.Point(16, 250);
            this.passengerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.passengerListBox.Name = "passengerListBox";
            this.passengerListBox.Size = new System.Drawing.Size(252, 324);
            this.passengerListBox.TabIndex = 6;
            // 
            // sortFirstNameButton
            // 
            this.sortFirstNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortFirstNameButton.Location = new System.Drawing.Point(16, 618);
            this.sortFirstNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortFirstNameButton.Name = "sortFirstNameButton";
            this.sortFirstNameButton.Size = new System.Drawing.Size(253, 28);
            this.sortFirstNameButton.TabIndex = 7;
            this.sortFirstNameButton.Text = "Sort by First Name";
            this.sortFirstNameButton.UseVisualStyleBackColor = true;
            this.sortFirstNameButton.Click += new System.EventHandler(this.sortFirstNameButton_Click);
            // 
            // sortLastNameButton
            // 
            this.sortLastNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLastNameButton.Location = new System.Drawing.Point(16, 654);
            this.sortLastNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortLastNameButton.Name = "sortLastNameButton";
            this.sortLastNameButton.Size = new System.Drawing.Size(253, 28);
            this.sortLastNameButton.TabIndex = 8;
            this.sortLastNameButton.Text = "Sort by Last Name";
            this.sortLastNameButton.UseVisualStyleBackColor = true;
            this.sortLastNameButton.Click += new System.EventHandler(this.sortLastNameButton_Click);
            // 
            // sortSeatButton
            // 
            this.sortSeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortSeatButton.Location = new System.Drawing.Point(16, 689);
            this.sortSeatButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortSeatButton.Name = "sortSeatButton";
            this.sortSeatButton.Size = new System.Drawing.Size(253, 28);
            this.sortSeatButton.TabIndex = 9;
            this.sortSeatButton.Text = "Sort by Seat";
            this.sortSeatButton.UseVisualStyleBackColor = true;
            this.sortSeatButton.Click += new System.EventHandler(this.sortSeatButton_Click);
            // 
            // firstClassRadio
            // 
            this.firstClassRadio.AutoSize = true;
            this.firstClassRadio.Checked = true;
            this.firstClassRadio.Location = new System.Drawing.Point(8, 23);
            this.firstClassRadio.Margin = new System.Windows.Forms.Padding(4);
            this.firstClassRadio.Name = "firstClassRadio";
            this.firstClassRadio.Size = new System.Drawing.Size(148, 21);
            this.firstClassRadio.TabIndex = 13;
            this.firstClassRadio.TabStop = true;
            this.firstClassRadio.Text = "First Class Train";
            this.firstClassRadio.UseVisualStyleBackColor = true;
            this.firstClassRadio.CheckedChanged += new System.EventHandler(this.trainFirstRadio_CheckedChanged);
            // 
            // standardClassRadio
            // 
            this.standardClassRadio.AutoSize = true;
            this.standardClassRadio.Location = new System.Drawing.Point(8, 52);
            this.standardClassRadio.Margin = new System.Windows.Forms.Padding(4);
            this.standardClassRadio.Name = "standardClassRadio";
            this.standardClassRadio.Size = new System.Drawing.Size(138, 21);
            this.standardClassRadio.TabIndex = 12;
            this.standardClassRadio.Text = "Standard Train";
            this.standardClassRadio.UseVisualStyleBackColor = true;
            this.standardClassRadio.CheckedChanged += new System.EventHandler(this.trainStandardRadio_CheckedChanged);
            // 
            // trainGroupBox
            // 
            this.trainGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.trainGroupBox.Controls.Add(this.standardClassRadio);
            this.trainGroupBox.Controls.Add(this.firstClassRadio);
            this.trainGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainGroupBox.ForeColor = System.Drawing.Color.Black;
            this.trainGroupBox.Location = new System.Drawing.Point(1059, 251);
            this.trainGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.trainGroupBox.Name = "trainGroupBox";
            this.trainGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.trainGroupBox.Size = new System.Drawing.Size(199, 103);
            this.trainGroupBox.TabIndex = 15;
            this.trainGroupBox.TabStop = false;
            this.trainGroupBox.Text = "Type of Train";

            // 
            // queue2ListBox
            // 
            this.queue2ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queue2ListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.queue2ListBox.FormattingEnabled = true;
            this.queue2ListBox.ItemHeight = 16;
            this.queue2ListBox.Location = new System.Drawing.Point(539, 250);
            this.queue2ListBox.Margin = new System.Windows.Forms.Padding(4);
            this.queue2ListBox.Name = "queue2ListBox";
            this.queue2ListBox.Size = new System.Drawing.Size(252, 324);
            this.queue2ListBox.TabIndex = 17;
            // 
            // queue3ListBox
            // 
            this.queue3ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queue3ListBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.queue3ListBox.FormattingEnabled = true;
            this.queue3ListBox.ItemHeight = 16;
            this.queue3ListBox.Location = new System.Drawing.Point(799, 251);
            this.queue3ListBox.Margin = new System.Windows.Forms.Padding(4);
            this.queue3ListBox.Name = "queue3ListBox";
            this.queue3ListBox.Size = new System.Drawing.Size(252, 324);
            this.queue3ListBox.TabIndex = 18;
            // 
            // standardClassPictureBox
            // 
            this.standardClassPictureBox.Image = global::PassengerTrainFinalProject.Properties.Resources.Standard_Train;
            this.standardClassPictureBox.InitialImage = global::PassengerTrainFinalProject.Properties.Resources.Standard_Train;
            this.standardClassPictureBox.Location = new System.Drawing.Point(16, 15);
            this.standardClassPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.standardClassPictureBox.Name = "standardClassPictureBox";
            this.standardClassPictureBox.Size = new System.Drawing.Size(1242, 228);
            this.standardClassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.standardClassPictureBox.TabIndex = 16;
            this.standardClassPictureBox.TabStop = false;
            this.standardClassPictureBox.Visible = false;
            // 
            // firstClassPictureBox
            // 
            this.firstClassPictureBox.Image = global::PassengerTrainFinalProject.Properties.Resources.First_Class_Train;
            this.firstClassPictureBox.InitialImage = global::PassengerTrainFinalProject.Properties.Resources.First_Class_Train;
            this.firstClassPictureBox.Location = new System.Drawing.Point(16, 15);
            this.firstClassPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstClassPictureBox.Name = "firstClassPictureBox";
            this.firstClassPictureBox.Size = new System.Drawing.Size(1242, 228);
            this.firstClassPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstClassPictureBox.TabIndex = 1;
            this.firstClassPictureBox.TabStop = false;
            // 
            // PassengerTrainBoarding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1341, 767);
            this.Controls.Add(this.queue3ListBox);
            this.Controls.Add(this.queue2ListBox);
            this.Controls.Add(this.standardClassPictureBox);
            this.Controls.Add(this.trainGroupBox);
            this.Controls.Add(this.sortSeatButton);
            this.Controls.Add(this.sortLastNameButton);
            this.Controls.Add(this.sortFirstNameButton);
            this.Controls.Add(this.passengerListBox);
            this.Controls.Add(this.queueButton);
            this.Controls.Add(this.generatePassengersButton);
            this.Controls.Add(this.queue1ListBox);
            this.Controls.Add(this.firstClassPictureBox);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PassengerTrainBoarding";
            this.Text = "Passenger Train Boarding";
            this.trainGroupBox.ResumeLayout(false);
            this.trainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardClassPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstClassPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox firstClassPictureBox;
        private System.Windows.Forms.ListBox queue1ListBox;
        private System.Windows.Forms.Button generatePassengersButton;
        private System.Windows.Forms.Button queueButton;
        private System.Windows.Forms.ListBox passengerListBox;
        private System.Windows.Forms.Button sortFirstNameButton;
        private System.Windows.Forms.Button sortLastNameButton;
        private System.Windows.Forms.Button sortSeatButton;
        private System.Windows.Forms.RadioButton firstClassRadio;
        private System.Windows.Forms.RadioButton standardClassRadio;
        private System.Windows.Forms.GroupBox trainGroupBox;
        private System.Windows.Forms.PictureBox standardClassPictureBox;
        private System.Windows.Forms.ListBox queue2ListBox;
        private System.Windows.Forms.ListBox queue3ListBox;
    }
}

