using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// ReSharper disable InconsistentNaming

namespace Dota_2_MMR_Stake_Calculator
{
    public partial class MainForm : Form
    {
        private Dictionary<int, int> MMRGainByDifference;

        public MainForm()
        {
            InitializeComponent();
            InitializeMMRDictionary();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var allyMMRInput = AllyTextBox.Text;
            var enemyMMRInput = EnemyTextBox.Text;

            int allyMMR;
            int enemyMMR;

            if (!int.TryParse(allyMMRInput, out allyMMR) || !int.TryParse(enemyMMRInput, out enemyMMR) ||
                string.IsNullOrEmpty(allyMMRInput) || string.IsNullOrEmpty(enemyMMRInput)) return;
            var MMRDifference = allyMMR - enemyMMR;

            if (Math.Abs(MMRDifference) > 677)
            {
                MMRDifference = MMRDifference > 0 ? 677 : -677;
            }

            var MMRGain = MMRGainByDifference.Where(x => x.Key <= MMRDifference)
                .OrderByDescending(x => x.Key)
                .First().Value;

            var MMRLoss = 50 - MMRGain;

            MMRGainLabel.Text = @"+" + MMRGain;
            MMRLossLabel.Text = @"-" + MMRLoss;
        }

        private void InitializeMMRDictionary()
        {
            MMRGainByDifference = new Dictionary<int, int>()
            {
                { 677, 1 },
                { 553, 2 },
                { 478, 3 },
                { 425, 4 },
                { 382, 5 },
                { 347, 6 },
                { 316, 7 },
                { 289, 8 },
                { 264, 9 },
                { 241, 10 },
                { 220, 11 },
                { 201, 12 },
                { 182, 13 },
                { 165, 14 },
                { 148, 15 },
                { 131, 16 },
                { 116, 17 },
                { 100, 18 },
                { 86, 19 },
                { 71, 20 },
                { 57, 21 },
                { 42, 22 },
                { 28, 23 },
                { 14, 24 },
                { 0, 25 },
                { -14, 26 },
                { -28, 27 },
                { -42, 28 },
                { -57, 29 },
                { -71, 30 },
                { -86, 31 },
                { -100, 32 },
                { -116, 33 },
                { -131, 34 },
                { -148, 35 },
                { -165, 36 },
                { -182, 37 },
                { -201, 38 },
                { -220, 39 },
                { -241, 40 },
                { -264, 41 },
                { -289, 42 },
                { -316, 43 },
                { -347, 44 },
                { -382, 45 },
                { -425, 46 },
                { -478, 47 },
                { -553, 48 },
                { -677, 49 }
            };
        }
    }
}
