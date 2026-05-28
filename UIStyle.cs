using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public static class UIStyle
    {
        // Police globale
        public static Font MainFont;

        // Couleurs
        public static Color BackgroundColor = Color.FromArgb(20, 20, 30);
        public static Color ForeColor = Color.White;
        public static Color AccentColor = Color.FromArgb(0, 120, 215);

        // Initialisation de la police personnalisée
        public static void LoadFont(string fontPath, float size = 12f)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(fontPath);

            MainFont = new Font(pfc.Families[0], size);
        }

        // Appliquer style à un formulaire
        public static void Apply(Form form)
        {
            form.BackColor = BackgroundColor;
            form.Font = MainFont;

            ApplyToControls(form.Controls);
        }

        // Appliquer récursivement aux contrôles
        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                c.Font = MainFont;
                c.ForeColor = ForeColor;

                if (c is Button btn)
                {
                    StyleButton(btn);
                }

                if (c is Panel || c is GroupBox)
                {
                    c.BackColor = BackgroundColor;
                }

                if (c.Controls.Count > 0)
                {
                    ApplyToControls(c.Controls);
                }
            }
        }

        // Style des boutons
        private static void StyleButton(Button btn)
        {
            btn.BackColor = AccentColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }
    }
}
