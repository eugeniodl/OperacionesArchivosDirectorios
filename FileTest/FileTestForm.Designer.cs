namespace FileTest
{
    partial class FileTestForm
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
            label1 = new Label();
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca el archivo o directorio:";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(23, 50);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(268, 23);
            inputTextBox.TabIndex = 1;
            inputTextBox.KeyDown += inputTextBox_KeyDown;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(20, 95);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(271, 328);
            outputTextBox.TabIndex = 2;
            // 
            // FileTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 450);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(label1);
            Name = "FileTestForm";
            Text = "Prueba de archivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private TextBox outputTextBox;
    }
}