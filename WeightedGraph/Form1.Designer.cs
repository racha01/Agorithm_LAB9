
namespace WeightedGraph
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.calButton = new System.Windows.Forms.Button();
            this.srcComboBox = new System.Windows.Forms.ComboBox();
            this.descComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(158, 183);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(121, 22);
            this.distanceTextBox.TabIndex = 4;
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(298, 71);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(75, 78);
            this.calButton.TabIndex = 7;
            this.calButton.Text = "button1";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // srcComboBox
            // 
            this.srcComboBox.FormattingEnabled = true;
            this.srcComboBox.Location = new System.Drawing.Point(158, 65);
            this.srcComboBox.Name = "srcComboBox";
            this.srcComboBox.Size = new System.Drawing.Size(121, 24);
            this.srcComboBox.TabIndex = 8;
            // 
            // descComboBox
            // 
            this.descComboBox.FormattingEnabled = true;
            this.descComboBox.Location = new System.Drawing.Point(158, 125);
            this.descComboBox.Name = "descComboBox";
            this.descComboBox.Size = new System.Drawing.Size(121, 24);
            this.descComboBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descComboBox);
            this.Controls.Add(this.srcComboBox);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.ComboBox srcComboBox;
        private System.Windows.Forms.ComboBox descComboBox;
    }
}

