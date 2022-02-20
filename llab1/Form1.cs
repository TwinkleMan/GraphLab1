using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph.Assets;
using GlmNet;

namespace llab1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// <param name="axis">Если axis = 0, то выбран поворот относительно оси X. 1 - Y; 2 - Z</param>
        /// </summary>
        private int axis = -1;
        private float angle = 0;
        float[,] cube = new float[,] { { 0, 1, 1, 1 }, { 0, 1, 0, 1 }, { 1, 1, 0, 1 }, { 1, 1, 1, 1 }, { 0, 0, 1, 1 }, { 0, 0, 0, 1 }, { 1, 0, 0, 1 }, { 1, 0, 1, 1 } };
        OpenGL gl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            gl = this.openglControl1.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            float cosphi = (float)Math.Cos(angle);
            float sinphi = (float)Math.Sin(angle);
            double[,] transform;
            float[,] result;
            float[,] temp = { { 1, 0, 0, 1 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };

            mat4 transform1;
            if (axis == 0)
            {
                transform = new double[,] { { 1, 0, 0, 1 }, { 0, cosphi, sinphi, 0 }, { 0, -sinphi, cosphi, 0 }, { 0, 0, 0, 1 } };
                transform1 = new mat4(new vec4(1, 0, 0, 1), new vec4(0, cosphi, sinphi, 0), new vec4(0, -sinphi, cosphi, 0), new vec4(0, 0, 0, 1));
            }
            if (axis == 1)
            {
                transform = new double[,] { { cosphi, 0, -sinphi, 0 }, { 0, 1, 0, 0 }, { sinphi, 0, cosphi, 0 }, { 0, 0, 0, 1 } };
                transform1 = new mat4(new vec4(cosphi, 0, -sinphi, 0), new vec4(0, 1, 0, 0), new vec4(sinphi, 0, cosphi, 0), new vec4(0, 0, 0, 1));
            }
            if (axis == 2)
            {
                transform = new double[,] { { cosphi, sinphi, 0, 0 }, { -sinphi, cosphi, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
                transform1 = new mat4(new vec4(cosphi, sinphi, 0, 0), new vec4(-sinphi, cosphi, 0, 0), new vec4(0, 0, 1, 0), new vec4(0, 0, 0, 1));
            }



        }

        private void x_btn_Click(object sender, EventArgs e)
        {
            axis = 0;
            y_btn.Enabled = false;
            z_btn.Enabled = false;
        }

        private void y_btn_Click(object sender, EventArgs e)
        {
            axis = 1;
            x_btn.Enabled = false;
            z_btn.Enabled = false;
        }

        private void z_btn_Click(object sender, EventArgs e)
        {
            axis = 2;
            x_btn.Enabled = false;
            y_btn.Enabled = false;
        }

        private void draw_btn_Click(object sender, EventArgs e)
        {
            if (axis == -1) throw new Exception("Error! Rotation axis is not selected");
            angle = float.Parse(angle_textbox.Text);
            Draw();
        }

        private float[] getVertexCoords(float[,] figure, int row)
        {
            float[] coords = new float[4];

            coords[0] = figure[row, 0];
            coords[1] = figure[row, 1];
            coords[2] = figure[row, 2];
            coords[3] = figure[row, 3];

            return coords;
        }

        float rquad = 0;
        private void openglControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            gl = this.openglControl1.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(-0.4f, -0.3f, -4.0f);

            gl.Rotate(rquad, 1.0f, 1.0f, 1.0f);

            gl.Begin(OpenGL.GL_QUADS);

            //top, green    OK
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(getVertexCoords(cube, 0));
            gl.Vertex(getVertexCoords(cube, 1));
            gl.Vertex(getVertexCoords(cube, 2));
            gl.Vertex(getVertexCoords(cube, 3));

            //bottom, orange    OK
            gl.Color(1.0f, 0.5f, 0.0f);
            gl.Vertex(getVertexCoords(cube, 4));
            gl.Vertex(getVertexCoords(cube, 5));
            gl.Vertex(getVertexCoords(cube, 6));
            gl.Vertex(getVertexCoords(cube, 7));

            //front, red
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(getVertexCoords(cube, 3));
            gl.Vertex(getVertexCoords(cube, 0));
            gl.Vertex(getVertexCoords(cube, 4));
            gl.Vertex(getVertexCoords(cube, 7));

            //back, yellow
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(getVertexCoords(cube, 2));
            gl.Vertex(getVertexCoords(cube, 1));
            gl.Vertex(getVertexCoords(cube, 5));
            gl.Vertex(getVertexCoords(cube, 6));

            //left, blue
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(getVertexCoords(cube, 1));
            gl.Vertex(getVertexCoords(cube, 0));
            gl.Vertex(getVertexCoords(cube, 4));
            gl.Vertex(getVertexCoords(cube, 5));

            //right, violet
            gl.Color(1.0f, 0.0f, 1.0f);
            gl.Vertex(getVertexCoords(cube, 3));
            gl.Vertex(getVertexCoords(cube, 2));
            gl.Vertex(getVertexCoords(cube, 6));
            gl.Vertex(getVertexCoords(cube, 7));

            gl.End();
            gl.Flush();

            rquad -= 3.0f;
        }

        /// <summary>
        /// ВНИМАНИЕ! Работает только для матриц размером 8х4 и 4х4.
        /// </summary>
        /// <param name="matrix">Матрица с координатами фигуры, которую необходимо умножить</param>
        /// <param name="transformMatrix">Матрица преобразований</param>
        /// <returns></returns>
        private float[,] matrixMultiply(float[,] matrix, float[,] transformMatrix)
        {
            float[] temp = new float[32];
            float[] input1, input2;

            float[,] result = new float[8, 4];
            int M = 8, N = 4;

            //convert input to line array
            input1 = new float[32];
            for (int i = 0; i < M; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    input1[i * N + j] = matrix[i, j];
                }
            }
            input2 = new float[16];
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    input2[i * N + j] = transformMatrix[i, j];
                }
            }

            for (int i = 0; i < M; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    temp[i * N + j] = 0;
                    for (int k = 0; k < N; ++k)
                        temp[i * N + j] += input1[i * N + k] * input2[k * N + j];
                }
            }

            for (int i = 0; i < M; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    result[i, j] = temp[i * N + j];
                }
            }

            return result;
        }
    }
}