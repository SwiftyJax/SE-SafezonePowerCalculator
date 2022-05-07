namespace SE_SafezonePowerCalculator
{
    partial class CalculatorForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SafezoneTypeBox = new System.Windows.Forms.ComboBox();
            this.SafezoneRadius = new System.Windows.Forms.TextBox();
            this.SafezoneX = new System.Windows.Forms.TextBox();
            this.SafezoneY = new System.Windows.Forms.TextBox();
            this.SafezoneZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.SafezoneXLabel = new System.Windows.Forms.Label();
            this.SafezoneYLabel = new System.Windows.Forms.Label();
            this.SafezoneZLabel = new System.Windows.Forms.Label();
            this.PowerDrawLabel = new System.Windows.Forms.Label();
            this.HydrogenComparison = new System.Windows.Forms.Label();
            this.SReactorComparison = new System.Windows.Forms.Label();
            this.LReactorComparison = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Location = new System.Drawing.Point(12, 232);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(148, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // SafezoneTypeBox
            // 
            this.SafezoneTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SafezoneTypeBox.FormattingEnabled = true;
            this.SafezoneTypeBox.Items.AddRange(new object[] {
            "Spherical",
            "Box"});
            this.SafezoneTypeBox.Location = new System.Drawing.Point(12, 27);
            this.SafezoneTypeBox.Name = "SafezoneTypeBox";
            this.SafezoneTypeBox.Size = new System.Drawing.Size(172, 23);
            this.SafezoneTypeBox.TabIndex = 2;
            this.SafezoneTypeBox.SelectedIndexChanged += new System.EventHandler(this.SafezoneTypeBox_SelectedIndexChanged);
            // 
            // SafezoneRadius
            // 
            this.SafezoneRadius.Enabled = false;
            this.SafezoneRadius.Location = new System.Drawing.Point(12, 71);
            this.SafezoneRadius.Name = "SafezoneRadius";
            this.SafezoneRadius.Size = new System.Drawing.Size(172, 23);
            this.SafezoneRadius.TabIndex = 3;
            this.SafezoneRadius.Text = "10";
            // 
            // SafezoneX
            // 
            this.SafezoneX.Enabled = false;
            this.SafezoneX.Location = new System.Drawing.Point(12, 115);
            this.SafezoneX.Name = "SafezoneX";
            this.SafezoneX.Size = new System.Drawing.Size(172, 23);
            this.SafezoneX.TabIndex = 4;
            this.SafezoneX.Text = "10";
            // 
            // SafezoneY
            // 
            this.SafezoneY.Enabled = false;
            this.SafezoneY.Location = new System.Drawing.Point(12, 159);
            this.SafezoneY.Name = "SafezoneY";
            this.SafezoneY.Size = new System.Drawing.Size(172, 23);
            this.SafezoneY.TabIndex = 5;
            this.SafezoneY.Text = "10";
            // 
            // SafezoneZ
            // 
            this.SafezoneZ.Enabled = false;
            this.SafezoneZ.Location = new System.Drawing.Point(12, 203);
            this.SafezoneZ.Name = "SafezoneZ";
            this.SafezoneZ.Size = new System.Drawing.Size(172, 23);
            this.SafezoneZ.TabIndex = 6;
            this.SafezoneZ.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Safezone Type";
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Enabled = false;
            this.RadiusLabel.Location = new System.Drawing.Point(12, 53);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(92, 15);
            this.RadiusLabel.TabIndex = 8;
            this.RadiusLabel.Text = "Safezone Radius";
            // 
            // SafezoneXLabel
            // 
            this.SafezoneXLabel.AutoSize = true;
            this.SafezoneXLabel.Enabled = false;
            this.SafezoneXLabel.Location = new System.Drawing.Point(12, 97);
            this.SafezoneXLabel.Name = "SafezoneXLabel";
            this.SafezoneXLabel.Size = new System.Drawing.Size(89, 15);
            this.SafezoneXLabel.TabIndex = 9;
            this.SafezoneXLabel.Text = "Safezone Width";
            // 
            // SafezoneYLabel
            // 
            this.SafezoneYLabel.AutoSize = true;
            this.SafezoneYLabel.Enabled = false;
            this.SafezoneYLabel.Location = new System.Drawing.Point(12, 141);
            this.SafezoneYLabel.Name = "SafezoneYLabel";
            this.SafezoneYLabel.Size = new System.Drawing.Size(93, 15);
            this.SafezoneYLabel.TabIndex = 10;
            this.SafezoneYLabel.Text = "Safezone Height";
            // 
            // SafezoneZLabel
            // 
            this.SafezoneZLabel.AutoSize = true;
            this.SafezoneZLabel.Enabled = false;
            this.SafezoneZLabel.Location = new System.Drawing.Point(12, 185);
            this.SafezoneZLabel.Name = "SafezoneZLabel";
            this.SafezoneZLabel.Size = new System.Drawing.Size(89, 15);
            this.SafezoneZLabel.TabIndex = 11;
            this.SafezoneZLabel.Text = "Safezone Depth";
            // 
            // PowerDrawLabel
            // 
            this.PowerDrawLabel.AutoSize = true;
            this.PowerDrawLabel.Location = new System.Drawing.Point(12, 278);
            this.PowerDrawLabel.Name = "PowerDrawLabel";
            this.PowerDrawLabel.Size = new System.Drawing.Size(70, 15);
            this.PowerDrawLabel.TabIndex = 12;
            this.PowerDrawLabel.Text = "Power Draw";
            // 
            // HydrogenComparison
            // 
            this.HydrogenComparison.AutoSize = true;
            this.HydrogenComparison.Location = new System.Drawing.Point(12, 293);
            this.HydrogenComparison.Name = "HydrogenComparison";
            this.HydrogenComparison.Size = new System.Drawing.Size(104, 15);
            this.HydrogenComparison.TabIndex = 13;
            this.HydrogenComparison.Text = "Hydrogen Engines";
            // 
            // SReactorComparison
            // 
            this.SReactorComparison.AutoSize = true;
            this.SReactorComparison.Location = new System.Drawing.Point(12, 308);
            this.SReactorComparison.Name = "SReactorComparison";
            this.SReactorComparison.Size = new System.Drawing.Size(84, 15);
            this.SReactorComparison.TabIndex = 14;
            this.SReactorComparison.Text = "Small Reactors";
            // 
            // LReactorComparison
            // 
            this.LReactorComparison.AutoSize = true;
            this.LReactorComparison.Location = new System.Drawing.Point(12, 323);
            this.LReactorComparison.Name = "LReactorComparison";
            this.LReactorComparison.Size = new System.Drawing.Size(84, 15);
            this.LReactorComparison.TabIndex = 15;
            this.LReactorComparison.Text = "Large Reactors";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(196, 345);
            this.Controls.Add(this.LReactorComparison);
            this.Controls.Add(this.SReactorComparison);
            this.Controls.Add(this.HydrogenComparison);
            this.Controls.Add(this.PowerDrawLabel);
            this.Controls.Add(this.SafezoneZLabel);
            this.Controls.Add(this.SafezoneYLabel);
            this.Controls.Add(this.SafezoneXLabel);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SafezoneZ);
            this.Controls.Add(this.SafezoneY);
            this.Controls.Add(this.SafezoneX);
            this.Controls.Add(this.SafezoneRadius);
            this.Controls.Add(this.SafezoneTypeBox);
            this.Controls.Add(this.CalculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CalculateButton;
        private ComboBox SafezoneTypeBox;
        private TextBox SafezoneRadius;
        private TextBox SafezoneX;
        private TextBox SafezoneY;
        private TextBox SafezoneZ;
        private Label label1;
        private Label RadiusLabel;
        private Label SafezoneXLabel;
        private Label SafezoneYLabel;
        private Label SafezoneZLabel;
        private Label PowerDrawLabel;
        private Label HydrogenComparison;
        private Label SReactorComparison;
        private Label LReactorComparison;
    }
}