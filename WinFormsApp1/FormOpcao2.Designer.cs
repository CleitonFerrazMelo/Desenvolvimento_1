namespace WinFormsApp1
{
    partial class FormOpcao2
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
            btnNota2 = new Button();
            SuspendLayout();
            // 
            // btnNota2
            // 
            btnNota2.Location = new Point(27, 31);
            btnNota2.Name = "btnNota2";
            btnNota2.Size = new Size(153, 62);
            btnNota2.TabIndex = 0;
            btnNota2.Text = "Nota Fiscal";
            btnNota2.UseVisualStyleBackColor = true;
            btnNota2.Click += btnNota2_Click;
            // 
            // FormOpcao2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNota2);
            Name = "FormOpcao2";
            Text = "Opção 2";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNota2;
    }
}