namespace PostmanClone.UI
{
    partial class Dashboard
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
            SuspendLayout();
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(21F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 738);
            Font = new Font("CaskaydiaCove NF", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Dashboard";
            Text = "Postman Clone by Adrian Puscasu";
            ResumeLayout(false);
        }

        #endregion
    }
}
