namespace SA_ID
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
            validateButton = new Button();
            resultLabel = new Label();
            idNumberTextBox = new TextBox();
            SuspendLayout();
            // 
            // validateButton
            // 
            validateButton.BackColor = SystemColors.ControlLightLight;
            validateButton.Location = new Point(335, 259);
            validateButton.Name = "validateButton";
            validateButton.Size = new Size(198, 34);
            validateButton.TabIndex = 0;
            validateButton.Text = "Validate ID";
            validateButton.UseVisualStyleBackColor = false;
            validateButton.Click += validateButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(174, 156);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(102, 25);
            resultLabel.TabIndex = 1;
            resultLabel.Text = "Enter SA ID";
            // 
            // idNumberTextBox
            // 
            idNumberTextBox.Location = new Point(335, 156);
            idNumberTextBox.Name = "idNumberTextBox";
            idNumberTextBox.Size = new Size(198, 31);
            idNumberTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(idNumberTextBox);
            Controls.Add(resultLabel);
            Controls.Add(validateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button validateButton;
        private Label resultLabel;
        private TextBox idNumberTextBox;
    }
}