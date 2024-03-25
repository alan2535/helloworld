namespace helloworld
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
            btnGo = new Button();
            txtShow = new TextBox();
            SuspendLayout();
            // 
            // btnGo
            // 
            btnGo.Location = new Point(473, 231);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(94, 29);
            btnGo.TabIndex = 0;
            btnGo.Text = "開始";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // txtShow
            // 
            txtShow.Location = new Point(279, 231);
            txtShow.Name = "txtShow";
            txtShow.Size = new Size(125, 27);
            txtShow.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtShow);
            Controls.Add(btnGo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGo;
        private TextBox txtShow;
    }
}
