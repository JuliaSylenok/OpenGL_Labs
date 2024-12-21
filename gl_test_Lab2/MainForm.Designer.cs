
namespace gl_test_Lab2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            
            //!!!!!!!!!!!!!!!!!!
            
            this.renderControl1 = new gl_test_Lab2.RenderControl(checkBox_Fill, checkBox_Line, checkBox_Point, NumUD_horizontal, NumUD_Vertical);
            
            
            this.NumUD_horizontal = new System.Windows.Forms.NumericUpDown();
            this.NumUD_Vertical = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Fill = new System.Windows.Forms.CheckBox();
            this.checkBox_Line = new System.Windows.Forms.CheckBox();
            this.checkBox_Point = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_horizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Vertical)).BeginInit();
            this.SuspendLayout();
            // 
            // renderControl1
            // 
            this.renderControl1.BackColor = System.Drawing.Color.SlateGray;
            this.renderControl1.ForeColor = System.Drawing.Color.White;
            this.renderControl1.Location = new System.Drawing.Point(12, 27);
            this.renderControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.renderControl1.Name = "renderControl1";
            this.renderControl1.Size = new System.Drawing.Size(600, 375);
            this.renderControl1.TabIndex = 0;
            this.renderControl1.TextCodePage = 65001;
            // 
            // NumUD_horizontal
            // 
            this.NumUD_horizontal.Location = new System.Drawing.Point(634, 48);
            this.NumUD_horizontal.Name = "NumUD_horizontal";
            this.NumUD_horizontal.Size = new System.Drawing.Size(150, 27);
            this.NumUD_horizontal.TabIndex = 1;
            // 
            // NumUD_Vertical
            // 
            this.NumUD_Vertical.Location = new System.Drawing.Point(634, 90);
            this.NumUD_Vertical.Name = "NumUD_Vertical";
            this.NumUD_Vertical.Size = new System.Drawing.Size(150, 27);
            this.NumUD_Vertical.TabIndex = 2;
            // 
            // checkBox_Fill
            // 
            this.checkBox_Fill.AutoSize = true;
            this.checkBox_Fill.Location = new System.Drawing.Point(636, 217);
            this.checkBox_Fill.Name = "checkBox_Fill";
            this.checkBox_Fill.Size = new System.Drawing.Size(118, 24);
            this.checkBox_Fill.TabIndex = 3;
            this.checkBox_Fill.Text = "checkBox_Fill";
            this.checkBox_Fill.UseVisualStyleBackColor = true;
            // 
            // checkBox_Line
            // 
            this.checkBox_Line.AutoSize = true;
            this.checkBox_Line.Location = new System.Drawing.Point(634, 253);
            this.checkBox_Line.Name = "checkBox_Line";
            this.checkBox_Line.Size = new System.Drawing.Size(126, 24);
            this.checkBox_Line.TabIndex = 4;
            this.checkBox_Line.Text = "checkBox_Line";
            this.checkBox_Line.UseVisualStyleBackColor = true;
            // 
            // checkBox_Point
            // 
            this.checkBox_Point.AutoSize = true;
            this.checkBox_Point.Location = new System.Drawing.Point(633, 283);
            this.checkBox_Point.Name = "checkBox_Point";
            this.checkBox_Point.Size = new System.Drawing.Size(132, 24);
            this.checkBox_Point.TabIndex = 5;
            this.checkBox_Point.Text = "checkBox_Point";
            this.checkBox_Point.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 432);
            this.Controls.Add(this.checkBox_Point);
            this.Controls.Add(this.checkBox_Line);
            this.Controls.Add(this.checkBox_Fill);
            this.Controls.Add(this.NumUD_Vertical);
            this.Controls.Add(this.NumUD_horizontal);
            this.Controls.Add(this.renderControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_horizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Vertical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.NumericUpDown NumUD_horizontal;
        private System.Windows.Forms.NumericUpDown NumUD_Vertical;
        private System.Windows.Forms.CheckBox checkBox_Fill;
        private System.Windows.Forms.CheckBox checkBox_Line;
        private System.Windows.Forms.CheckBox checkBox_Point;
    }
}

