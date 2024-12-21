using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;


namespace gl_test_Lab2
{
    public partial class RenderControl : OpenGL
    {
        private CheckBox checkBox_Fill;
        private CheckBox checkBox_Line;
        private CheckBox checkBox_Point;
        private NumericUpDown NumUD_horizontal;
        private NumericUpDown NumUD_Vertical;

        // Конструктор для передачі елементів керування з MainForm
        public RenderControl(CheckBox fill, CheckBox line, CheckBox point, NumericUpDown horizontal, NumericUpDown vertical)
        {
            InitializeComponent();
            this.checkBox_Fill = fill;
            this.checkBox_Line = line;
            this.checkBox_Point = point;
            this.NumUD_horizontal = horizontal;
            this.NumUD_Vertical = vertical;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            OnRender();
        }

        private void SetPolygonMode()
        {
            // Перевіряємо чи елементи керування не null перед використанням
            if (checkBox_Fill != null && checkBox_Fill.Checked)
            {
                glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
            }
            else if (checkBox_Line != null && checkBox_Line.Checked)
            {
                glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
            }
            else if (checkBox_Point != null && checkBox_Point.Checked)
            {
                glPolygonMode(GL_FRONT_AND_BACK, GL_POINT);
            }
        }

        private void DrawHexagon(float sideLength)
        {
            float radius = sideLength;
            glBegin(GL_POLYGON);
            for (int i = 0; i < 6; i++)
            {
                double angle = Math.PI / 3 * i;  // 60 degrees per side
                float x = radius * (float)Math.Cos(angle);
                float y = radius * (float)Math.Sin(angle);
                glVertex2f(x, y);
            }
            glEnd();
        }

        private void DrawTessellatedArea()
        {
            SetPolygonMode();  // Викликаємо вибір режиму відображення
            int horizontalCount = (int)NumUD_horizontal.Value;
            int verticalCount = (int)NumUD_Vertical.Value;
            float sideLength = 0.15f;

            for (int i = 0; i < verticalCount; i++)
            {
                for (int j = 0; j < horizontalCount; j++)
                {
                    glPushMatrix();
                    glTranslatef(j * 1.5f * sideLength, i * 1.732f * sideLength, 0); // Adjust hexagon spacing
                    DrawHexagon(sideLength);
                    glPopMatrix();
                }
            }
        }

        private void OnRender()
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            gluOrtho2D(-1.1, +1.1, -1.1, +1.1);  // Set up the coordinate system
            DrawTessellatedArea();
            glFlush();
        }
    }
}

