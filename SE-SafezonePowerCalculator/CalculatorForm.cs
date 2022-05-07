using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_SafezonePowerCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void SafezoneTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selection = false;
            switch (SafezoneTypeBox.SelectedIndex)
            {
                case 0:
                    selection = true;
                    break;
                case 1:
                    selection = false;
                    break;
            }
            RadiusLabel.Enabled = selection;
            SafezoneRadius.Enabled = selection;
            SafezoneX.Enabled = !selection;
            SafezoneY.Enabled = !selection;
            SafezoneZ.Enabled = !selection;
            SafezoneXLabel.Enabled = !selection;
            SafezoneYLabel.Enabled = !selection;
            SafezoneZLabel.Enabled = !selection;
            CalculateButton.Enabled = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            float powerDraw = 0f;
            switch (SafezoneTypeBox.SelectedIndex)
            {
                case 0:
                    SafezoneRadius.Text = SafezoneRadius.Text.Replace('.', ',');
                    float r = float.Parse(SafezoneRadius.Text);
                    powerDraw = MathF.Round(CalculateSpherical(r), 2);
                    PowerDrawLabel.Text = powerDraw + "MW";
                    break;
                case 1:
                    SafezoneX.Text = SafezoneX.Text.Replace('.', ',');
                    SafezoneY.Text = SafezoneY.Text.Replace('.', ',');
                    SafezoneX.Text = SafezoneX.Text.Replace('.', ',');
                    float x = float.Parse(SafezoneX.Text);
                    float y = float.Parse(SafezoneY.Text);
                    float z = float.Parse(SafezoneZ.Text);
                    powerDraw = MathF.Round(CalculateBox(x, y, z), 2);
                    PowerDrawLabel.Text = powerDraw + "MW";
                    break;
            }
            float hydrogens = MathF.Round(powerDraw / 0.5f, 2);
            float sReactors = MathF.Round(powerDraw / 15f, 2);
            float lReactors = MathF.Round(powerDraw / 300f, 2);

            HydrogenComparison.Text = hydrogens + " Hydrogen Engines";
            SReactorComparison.Text = sReactors + " Small Reactors";
            LReactorComparison.Text = lReactors + " Large Reactors";
        }
        static float CalculateSpherical(float radius)
        {
            float powerDraw = (radius - 10) / 490 * 295 + 5;
            return powerDraw;
        }

        static float CalculateBox(float width, float height, float depth)
        {
            float powerDraw =
                ((width - 10) / 990 / 3 +
                (height - 10) / 990 / 3 +
                (depth - 10) / 990 / 3) * 295 + 5;

            return powerDraw;
        }
    }
}
