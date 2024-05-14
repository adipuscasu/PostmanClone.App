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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            callApi = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            httpMethodSelection = new ComboBox();
            callData = new TabControl();
            bodyTab = new TabPage();
            resultsTab = new TabPage();
            resultsText = new TextBox();
            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            resultsTab.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("CaskaydiaCove NF", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(12, 16);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(291, 41);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(43, 71);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(278, 28);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "Method and API URL:";
            // 
            // apiText
            // 
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(171, 102);
            apiText.Name = "apiText";
            apiText.Size = new Size(1059, 35);
            apiText.TabIndex = 2;
            apiText.KeyDown += apiText_KeyDown;
            // 
            // callApi
            // 
            callApi.Location = new Point(1236, 102);
            callApi.Name = "callApi";
            callApi.Size = new Size(112, 36);
            callApi.TabIndex = 3;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.White;
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 703);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1371, 35);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(72, 30);
            systemStatus.Text = "Ready";
            // 
            // httpMethodSelection
            // 
            httpMethodSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpMethodSelection.FormattingEnabled = true;
            httpMethodSelection.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE", "HEAD", "OPTIONS" });
            httpMethodSelection.Location = new Point(43, 102);
            httpMethodSelection.Name = "httpMethodSelection";
            httpMethodSelection.Size = new Size(122, 36);
            httpMethodSelection.TabIndex = 7;
            // 
            // callData
            // 
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(resultsTab);
            callData.Location = new Point(31, 144);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(1328, 556);
            callData.TabIndex = 8;
            // 
            // bodyTab
            // 
            bodyTab.Location = new Point(4, 37);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(1320, 515);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            // 
            // resultsTab
            // 
            resultsTab.Controls.Add(resultsText);
            resultsTab.Location = new Point(4, 24);
            resultsTab.Name = "resultsTab";
            resultsTab.Padding = new Padding(3);
            resultsTab.Size = new Size(1320, 528);
            resultsTab.TabIndex = 1;
            resultsTab.Text = "Results";
            resultsTab.UseVisualStyleBackColor = true;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Dock = DockStyle.Fill;
            resultsText.Location = new Point(3, 3);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(1314, 522);
            resultsText.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1371, 738);
            Controls.Add(callData);
            Controls.Add(httpMethodSelection);
            Controls.Add(statusStrip);
            Controls.Add(callApi);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("CaskaydiaCove NF", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "Dashboard";
            Text = "Postman Clone by Adrian Puscasu";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            callData.ResumeLayout(false);
            resultsTab.ResumeLayout(false);
            resultsTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApi;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private ComboBox httpMethodSelection;
        private TabControl callData;
        private TabPage bodyTab;
        private TabPage resultsTab;
        private TextBox resultsText;
    }
}
