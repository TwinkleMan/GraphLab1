using System.Windows.Forms;

namespace llab1
{
    partial class Form1
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
            this.openglControl1 = new SharpGL.OpenGLControl();
            this.label1 = new System.Windows.Forms.Label();
            this.z_btn = new System.Windows.Forms.Button();
            this.y_btn = new System.Windows.Forms.Button();
            this.x_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.angle_textbox = new System.Windows.Forms.TextBox();
            this.draw_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openglControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // openglControl1
            // 
            this.openglControl1.DrawFPS = true;
            this.openglControl1.FrameRate = 35;
            this.openglControl1.Location = new System.Drawing.Point(0, 0);
            this.openglControl1.Name = "openglControl1";
            this.openglControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openglControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openglControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openglControl1.Size = new System.Drawing.Size(686, 390);
            this.openglControl1.TabIndex = 0;
            this.openglControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openglControl1_OpenGLDraw);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ось поворота";
            // 
            // z_btn
            // 
            this.z_btn.Location = new System.Drawing.Point(713, 82);
            this.z_btn.Name = "z_btn";
            this.z_btn.Size = new System.Drawing.Size(71, 20);
            this.z_btn.TabIndex = 3;
            this.z_btn.Text = "Z";
            this.z_btn.UseVisualStyleBackColor = true;
            this.z_btn.Click += new System.EventHandler(this.z_btn_Click);
            // 
            // y_btn
            // 
            this.y_btn.Location = new System.Drawing.Point(713, 57);
            this.y_btn.Name = "y_btn";
            this.y_btn.Size = new System.Drawing.Size(71, 20);
            this.y_btn.TabIndex = 2;
            this.y_btn.Text = "Y";
            this.y_btn.UseVisualStyleBackColor = true;
            this.y_btn.Click += new System.EventHandler(this.y_btn_Click);
            // 
            // x_btn
            // 
            this.x_btn.Location = new System.Drawing.Point(713, 32);
            this.x_btn.Name = "x_btn";
            this.x_btn.Size = new System.Drawing.Size(71, 20);
            this.x_btn.TabIndex = 1;
            this.x_btn.Text = "X";
            this.x_btn.UseVisualStyleBackColor = true;
            this.x_btn.Click += new System.EventHandler(this.x_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Угол поворота";
            // 
            // angle_textbox
            // 
            this.angle_textbox.Location = new System.Drawing.Point(713, 194);
            this.angle_textbox.Name = "angle_textbox";
            this.angle_textbox.Size = new System.Drawing.Size(76, 20);
            this.angle_textbox.TabIndex = 6;
            // 
            // draw_btn
            // 
            this.draw_btn.Location = new System.Drawing.Point(692, 336);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(113, 43);
            this.draw_btn.TabIndex = 7;
            this.draw_btn.Text = "Вперед";
            this.draw_btn.UseVisualStyleBackColor = true;
            this.draw_btn.Click += new System.EventHandler(this.draw_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 390);
            this.Controls.Add(this.draw_btn);
            this.Controls.Add(this.angle_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.z_btn);
            this.Controls.Add(this.y_btn);
            this.Controls.Add(this.x_btn);
            this.Controls.Add(this.openglControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openglControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openglControl1;
        private Label label1;
        private Button z_btn;
        private Button y_btn;
        private Button x_btn;
        private Label label2;
        private TextBox angle_textbox;
        private Button draw_btn;
    }
}