namespace lab_6_1
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
            this.Bill_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserInputTextbox = new System.Windows.Forms.TextBox();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.GetTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bill_Label
            // 
            this.Bill_Label.AutoSize = true;
            this.Bill_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Label.Location = new System.Drawing.Point(166, 155);
            this.Bill_Label.Name = "Bill_Label";
            this.Bill_Label.Size = new System.Drawing.Size(81, 51);
            this.Bill_Label.TabIndex = 0;
            this.Bill_Label.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "$";
            // 
            // UserInputTextbox
            // 
            this.UserInputTextbox.Location = new System.Drawing.Point(362, 155);
            this.UserInputTextbox.Name = "UserInputTextbox";
            this.UserInputTextbox.Size = new System.Drawing.Size(100, 31);
            this.UserInputTextbox.TabIndex = 2;
            this.UserInputTextbox.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(362, 273);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(100, 31);
            this.OutputTextbox.TabIndex = 3;
            // 
            // GetTotal
            // 
            this.GetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetTotal.Location = new System.Drawing.Point(560, 369);
            this.GetTotal.Name = "GetTotal";
            this.GetTotal.Size = new System.Drawing.Size(211, 69);
            this.GetTotal.TabIndex = 4;
            this.GetTotal.Text = "GetTotal";
            this.GetTotal.UseVisualStyleBackColor = true;
            this.GetTotal.Click += new System.EventHandler(this.GetTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetTotal);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.UserInputTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bill_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bill_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserInputTextbox;
        private System.Windows.Forms.TextBox OutputTextbox;
        private System.Windows.Forms.Button GetTotal;
    }
}

