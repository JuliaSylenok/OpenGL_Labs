using System.Windows.Forms;
using static gl_test_Lab2.OpenGL;


namespace gl_test_Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Ініціалізація значень за замовчуванням
            checkBox_Fill.Checked = true;  // Встановити чекбокс Fill за замовчуванням
            NumUD_horizontal.Value = 1;  // Встановити початкове значення 1
            NumUD_Vertical.Value = 1;    // Встановити початкове значення 1

            renderControl1 = new RenderControl(checkBox_Fill, checkBox_Line, checkBox_Point, NumUD_horizontal, NumUD_Vertical);
            Controls.Add(renderControl1);
            renderControl1.Dock = DockStyle.Fill;

            // Event handlers for numeric controls
            NumUD_horizontal.ValueChanged += (s, e) => renderControl1.Invalidate();
            NumUD_Vertical.ValueChanged += (s, e) => renderControl1.Invalidate();

            // Event handlers for checkboxes
            checkBox_Fill.CheckedChanged += (s, e) => renderControl1.Invalidate();
            checkBox_Line.CheckedChanged += (s, e) => renderControl1.Invalidate();
            checkBox_Point.CheckedChanged += (s, e) => renderControl1.Invalidate();
        }
        //в мене вони вже є на формі
        //private RenderControl renderControl1;
        //public NumericUpDown NumUD_horizontal = new NumericUpDown() { Minimum = 1, Maximum = 10, Value = 1 };
        //public NumericUpDown NumUD_Vertical = new NumericUpDown() { Minimum = 1, Maximum = 10, Value = 1 };
        //public CheckBox checkBox_Fill = new CheckBox() { Text = "Fill Mode", Checked = true };
        //public CheckBox checkBox_Line = new CheckBox() { Text = "Line Mode" };
        //public CheckBox checkBox_Point = new CheckBox() { Text = "Point Mode" };


    }
}
