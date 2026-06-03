using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    /// <summary>
    /// Classe statique de style centralisé pour WinForms.
    /// Modifie les valeurs dans la région "=== THÈME ===" pour personnaliser l'apparence.
    /// </summary>
    public static class UIStyle
    {
        // =========================================================
        // === THÈME — Modifie ces valeurs selon tes envies ========
        // =========================================================

        // --- Couleurs générales ---
        public static Color BackgroundColor = Color.FromArgb(18, 18, 28);   // fond des fenêtres/panels
        public static Color SurfaceColor = Color.FromArgb(30, 30, 45);   // fond des inputs / groupbox
        public static Color AccentColor = Color.FromArgb(82, 130, 255); // boutons, bordures actives
        public static Color AccentHoverColor = Color.FromArgb(110, 155, 255);// bouton survolé
        public static Color AccentPressColor = Color.FromArgb(55, 100, 220); // bouton cliqué

        // --- Couleurs de texte ---
        public static Color ForeColor = Color.FromArgb(230, 230, 240); // texte général
        public static Color InputForeColor = Color.FromArgb(230, 230, 240); // texte dans les inputs (contraste fort)
        public static Color PlaceholderColor = Color.FromArgb(120, 120, 140); // texte placeholder
        public static Color LabelForeColor = Color.FromArgb(180, 180, 200); // labels

        // --- Bordures ---
        public static Color BorderColor = Color.FromArgb(60, 60, 90);
        public static Color FocusBorderColor = AccentColor;
        public static int BorderRadius = 6;   // arrondi des coins (0 = carré)
        public static int BorderSize = 1;

        // --- Typographie ---
        public static float FontSizeBase = 10f;
        public static float FontSizeSmall = 8.5f;
        public static float FontSizeLarge = 13f;
        public static FontStyle FontStyleBase = FontStyle.Regular;

        // --- Espacements / tailles ---
        public static int ControlHeight = 34;  // hauteur standard des inputs/boutons
        public static Padding ControlPadding = new Padding(8, 4, 8, 4);

        // =========================================================
        // === POLICE ===============================================
        // =========================================================

        private static Font _mainFont;
        private static Font _smallFont;
        private static Font _largeFont;
        private static PrivateFontCollection _pfc;

        public static Font MainFont => _mainFont ?? SystemFonts.DefaultFont;
        public static Font SmallFont => _smallFont ?? SystemFonts.SmallCaptionFont;
        public static Font LargeFont => _largeFont ?? SystemFonts.CaptionFont;

        /// <summary>
        /// Charge une police depuis un fichier .ttf/.otf.
        /// Si le fichier est introuvable, on retombe sur la police système.
        /// </summary>
        public static void LoadFont(string fontPath)
        {
            try
            {
                _pfc = new PrivateFontCollection();
                _pfc.AddFontFile(fontPath);
                var family = _pfc.Families[0];
                _mainFont = new Font(family, FontSizeBase, FontStyleBase, GraphicsUnit.Point);
                _smallFont = new Font(family, FontSizeSmall, FontStyleBase, GraphicsUnit.Point);
                _largeFont = new Font(family, FontSizeLarge, FontStyleBase, GraphicsUnit.Point);
            }
            catch
            {
                // police système de secours
                _mainFont = new Font(SystemFonts.DefaultFont.FontFamily, FontSizeBase, FontStyleBase, GraphicsUnit.Point);
                _smallFont = new Font(SystemFonts.DefaultFont.FontFamily, FontSizeSmall, FontStyleBase, GraphicsUnit.Point);
                _largeFont = new Font(SystemFonts.DefaultFont.FontFamily, FontSizeLarge, FontStyleBase, GraphicsUnit.Point);
            }
        }

        // =========================================================
        // === APPLICATION DU THÈME ================================
        // =========================================================

        /// <summary>Applique le thème à tout un formulaire.</summary>
        public static void Apply(Form form)
        {
            form.BackColor = BackgroundColor;
            form.ForeColor = ForeColor;
            form.Font = MainFont;

            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                StyleControl(c);

                if (c.Controls.Count > 0)
                    ApplyToControls(c.Controls);
            }
        }

        /// <summary>Aiguille chaque contrôle vers son styleur spécifique.</summary>
        public static void StyleControl(Control c)
        {
            c.Font = MainFont;

            switch (c)
            {
                case Button btn: StyleButton(btn); break;
                case TextBox tb: StyleTextBox(tb); break;
                case RichTextBox rtb: StyleRichTextBox(rtb); break;
                case ComboBox cb: StyleComboBox(cb); break;
                case ListBox lb: StyleListBox(lb); break;
                case ListView lv: StyleListView(lv); break;
                case DataGridView dgv: StyleDataGridView(dgv); break;
                case CheckBox chk: StyleCheckBox(chk); break;
                case RadioButton rb: StyleRadioButton(rb); break;
                case Label lbl: StyleLabel(lbl); break;
                case GroupBox gb: StyleGroupBox(gb); break;
                case Panel pnl: StylePanel(pnl); break;
                case TabControl tc: StyleTabControl(tc); break;
                case ProgressBar pb: StyleProgressBar(pb); break;
                case NumericUpDown nud: StyleNumericUpDown(nud); break;
                case DateTimePicker dtp: StyleDateTimePicker(dtp); break;
                case TrackBar trk: StyleTrackBar(trk); break;
                default:
                    c.ForeColor = ForeColor;
                    break;
            }
        }

        // =========================================================
        // === STYLEURS PAR TYPE ===================================
        // =========================================================

        public static void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = AccentColor;
            btn.BackColor = AccentColor;
            btn.ForeColor = Color.White;
            btn.Font = MainFont;
            btn.Cursor = Cursors.Hand;
            btn.Height = ControlHeight;
            btn.TextAlign = ContentAlignment.MiddleCenter;

            // Effet hover / press via les events (sans OwnerDraw)
            btn.MouseEnter -= Btn_MouseEnter;
            btn.MouseLeave -= Btn_MouseLeave;
            btn.MouseDown -= Btn_MouseDown;
            btn.MouseUp -= Btn_MouseUp;
            btn.MouseEnter += Btn_MouseEnter;
            btn.MouseLeave += Btn_MouseLeave;
            btn.MouseDown += Btn_MouseDown;
            btn.MouseUp += Btn_MouseUp;
        }

        private static void Btn_MouseEnter(object s, EventArgs e) => ((Button)s).BackColor = AccentHoverColor;
        private static void Btn_MouseLeave(object s, EventArgs e) => ((Button)s).BackColor = AccentColor;
        private static void Btn_MouseDown(object s, MouseEventArgs e) => ((Button)s).BackColor = AccentPressColor;
        private static void Btn_MouseUp(object s, MouseEventArgs e) => ((Button)s).BackColor = AccentHoverColor;

        // --- TextBox ---
        public static void StyleTextBox(TextBox tb)
        {
            tb.BackColor = SurfaceColor;
            tb.ForeColor = InputForeColor;   // ← contraste fort sur fond sombre
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = MainFont;
            tb.Height = ControlHeight;

            // Bordure focus via Paint du parent ou événements
            tb.Enter -= Input_Enter;
            tb.Leave -= Input_Leave;
            tb.Enter += Input_Enter;
            tb.Leave += Input_Leave;
        }

        // --- RichTextBox ---
        public static void StyleRichTextBox(RichTextBox rtb)
        {
            rtb.BackColor = SurfaceColor;
            rtb.ForeColor = InputForeColor;
            rtb.BorderStyle = BorderStyle.FixedSingle;
            rtb.Font = MainFont;

            rtb.Enter -= Input_Enter;
            rtb.Leave -= Input_Leave;
            rtb.Enter += Input_Enter;
            rtb.Leave += Input_Leave;
        }

        // --- ComboBox ---
        public static void StyleComboBox(ComboBox cb)
        {
            cb.BackColor = SurfaceColor;
            cb.ForeColor = InputForeColor;
            cb.FlatStyle = FlatStyle.Flat;
            cb.Font = MainFont;
            cb.Height = ControlHeight;

            cb.Enter -= Input_Enter;
            cb.Leave -= Input_Leave;
            cb.Enter += Input_Enter;
            cb.Leave += Input_Leave;
        }

        // --- ListBox ---
        public static void StyleListBox(ListBox lb)
        {
            lb.BackColor = SurfaceColor;
            lb.ForeColor = InputForeColor;
            lb.BorderStyle = BorderStyle.FixedSingle;
            lb.Font = MainFont;
        }

        // --- ListView ---
        public static void StyleListView(ListView lv)
        {
            lv.BackColor = SurfaceColor;
            lv.ForeColor = InputForeColor;
            lv.BorderStyle = BorderStyle.FixedSingle;
            lv.Font = MainFont;
            lv.FullRowSelect = true;
            lv.GridLines = false;
        }

        // --- DataGridView ---
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = BackgroundColor;
            dgv.ForeColor = ForeColor;
            dgv.GridColor = BorderColor;
            dgv.BorderStyle = BorderStyle.None;
            dgv.Font = MainFont;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 38);

            dgv.DefaultCellStyle.BackColor = SurfaceColor;
            dgv.DefaultCellStyle.ForeColor = InputForeColor;
            dgv.DefaultCellStyle.SelectionBackColor = AccentColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 60);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = ForeColor;
            dgv.ColumnHeadersDefaultCellStyle.Font = MainFont;
            dgv.ColumnHeadersHeight = ControlHeight;
        }

        // --- CheckBox ---
        public static void StyleCheckBox(CheckBox chk)
        {
            chk.ForeColor = LabelForeColor;
            chk.Font = MainFont;
            chk.BackColor = Color.Transparent;
            chk.Cursor = Cursors.Hand;
        }

        // --- RadioButton ---
        public static void StyleRadioButton(RadioButton rb)
        {
            rb.ForeColor = LabelForeColor;
            rb.Font = MainFont;
            rb.BackColor = Color.Transparent;
            rb.Cursor = Cursors.Hand;
        }

        // --- Label ---
        public static void StyleLabel(Label lbl)
        {
            lbl.ForeColor = LabelForeColor;
            lbl.Font = MainFont;
            lbl.BackColor = Color.Transparent;
        }

        // --- GroupBox ---
        public static void StyleGroupBox(GroupBox gb)
        {
            gb.BackColor = BackgroundColor;
            gb.ForeColor = LabelForeColor;
            gb.Font = MainFont;
        }

        // --- Panel ---
        public static void StylePanel(Panel pnl)
        {
            pnl.BackColor = BackgroundColor;
        }

        // --- TabControl ---
        public static void StyleTabControl(TabControl tc)
        {
            tc.DrawMode = TabDrawMode.OwnerDrawFixed;
            tc.Font = MainFont;

            tc.DrawItem -= Tc_DrawItem;
            tc.DrawItem += Tc_DrawItem;
        }

        private static void Tc_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tc = (TabControl)sender;
            var page = tc.TabPages[e.Index];
            bool selected = (tc.SelectedIndex == e.Index);

            /*using var bgBrush = new SolidBrush(selected ? AccentColor : SurfaceColor);
            e.Graphics.FillRectangle(bgBrush, e.Bounds);

            using var textBrush = new SolidBrush(Color.White);
            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString(page.Text, tc.Font, textBrush, e.Bounds, sf);*/
        }

        // --- ProgressBar ---
        public static void StyleProgressBar(ProgressBar pb)
        {
            pb.Style = ProgressBarStyle.Continuous;
            pb.BackColor = SurfaceColor;
            pb.ForeColor = AccentColor;
            pb.Height = 8;
        }

        // --- NumericUpDown ---
        public static void StyleNumericUpDown(NumericUpDown nud)
        {
            nud.BackColor = SurfaceColor;
            nud.ForeColor = InputForeColor;
            nud.Font = MainFont;
            nud.BorderStyle = BorderStyle.FixedSingle;
        }

        // --- DateTimePicker ---
        public static void StyleDateTimePicker(DateTimePicker dtp)
        {
            dtp.CalendarForeColor = InputForeColor;
            dtp.CalendarMonthBackground = SurfaceColor;
            dtp.CalendarTitleBackColor = AccentColor;
            dtp.CalendarTitleForeColor = Color.White;
            dtp.ForeColor = InputForeColor;
            dtp.Font = MainFont;
        }

        // --- TrackBar ---
        public static void StyleTrackBar(TrackBar trk)
        {
            trk.BackColor = BackgroundColor;
        }

        // =========================================================
        // === EVENTS FOCUS / BLUR =================================
        // =========================================================

        private static void Input_Enter(object sender, EventArgs e)
        {
            if (sender is Control c)
            {
                // Souligne visuellement le focus via la bordure du parent si possible
                c.Tag = c.Parent;   // réservé pour extension future
            }
        }

        private static void Input_Leave(object sender, EventArgs e) { }

        // =========================================================
        // === UTILITAIRES =========================================
        // =========================================================

        /// <summary>
        /// Dessine un rectangle aux coins arrondis — utile pour l'OnPaint de contrôles custom.
        /// </summary>
        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.X + bounds.Width - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.X + bounds.Width - d, bounds.Y + bounds.Height - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Calcule automatiquement si le texte doit être clair ou sombre
        /// pour contraster avec la couleur de fond donnée.
        /// </summary>
        public static Color ContrastingForeColor(Color background)
        {
            // Luminance perceptuelle (formule W3C)
            double luminance = (0.299 * background.R + 0.587 * background.G + 0.114 * background.B) / 255;
            return luminance > 0.5 ? Color.FromArgb(20, 20, 30) : Color.FromArgb(230, 230, 240);
        }

        /// <summary>
        /// Recharge les polices (utile si FontSizeBase a été changé à l'exécution).
        /// </summary>
        public static void RefreshFonts()
        {
            _mainFont = new Font(MainFont.FontFamily, FontSizeBase, FontStyleBase, GraphicsUnit.Point);
            _smallFont = new Font(MainFont.FontFamily, FontSizeSmall, FontStyleBase, GraphicsUnit.Point);
            _largeFont = new Font(MainFont.FontFamily, FontSizeLarge, FontStyleBase, GraphicsUnit.Point);
        }
    }
}