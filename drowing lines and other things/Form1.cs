using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace drowing_lines_and_other_things
{
    public partial class mainForm : Form
    {

        //graphics things
        private Graphics g;
        private Bitmap bmp;
        private Point firstState;
        private int mode_index = 0;
        private string mouseMode = "line";
        private List<string> modes = new List<string>() { "line", "ellipse", "point", "rectangle" };
        
        //graphics figures
        private List<GraphicsObject> drawnObjects = new List<GraphicsObject>();

        // paint things
        Brush mainBrush = new SolidBrush(Color.Aqua);//color aqua -- default
        Pen   mainPen   = new Pen(Color.Aqua, 3);
        Brush fillBrush = new SolidBrush(Color.Aqua);
        //color change dialog
        private FormColorChange form2;
        public mainForm()
        {
            InitializeComponent();
            bmp = new Bitmap(paper.Width, paper.Height);
            g = Graphics.FromImage(bmp);
        }

        private bool drawingSomething = false;
        private void paper_MouseDown(object sender, MouseEventArgs e)
        {

            if (form2 != null)
            {
                mainBrush = new SolidBrush(form2.GetColor());
                mainPen = new Pen(form2.GetColor(), form2.GetPenWidth());
            }

            if (e.Button == MouseButtons.Right)
            {
                firstState = e.Location;
            }

            if (e.Button != MouseButtons.Left) return;

            if (mouseMode == "point")
            {
                g.FillEllipse(mainBrush, e.X, e.Y, 5, 5);
                paper.Image = bmp;
                drawnObjects.Add(new GraphicsObject(mainBrush,e.X,e.Y));
                return;
            }

            drawingSomething = true;
            firstState = e.Location;
        }

        void redrawWithoutLast()
        {
            for(int i = 0;i < drawnObjects.Count-1;i++)
            {
                drawnObjects[i].draw(g);
            }
        }
        private void paper_MauseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GraphicsObject lastDrawn = drawnObjects[drawnObjects.Count - 1];
                
                float xscale = 0.1f + Math.Abs(e.X - firstState.X) / (float)lastDrawn.getWidth(); 
                float yscale = 0.1f + Math.Abs(e.Y - firstState.Y) / (float)lastDrawn.getHeight();
                lastDrawn.scale(xscale,yscale);

                g.Clear(Color.Black);
                redrawWithoutLast();
                lastDrawn.draw(g);
                paper.Image = bmp;
            }
            if (!drawingSomething) return;

            if (mouseMode == "line")
            {
                g.DrawLine(mainPen, firstState, e.Location);
                drawnObjects.Add(new GraphicsObject(mainPen,"line",firstState,e.Location));
                drawingSomething = false;
                paper.Image = bmp;
                return;
            }

            int width = e.Location.X - firstState.X;
            int height = e.Location.Y - firstState.Y;
            Point endPoint = new Point(firstState.X + width,firstState.Y + height);
            if (mouseMode == "ellipse")
            {
                g.DrawEllipse(mainPen, firstState.X, firstState.Y,width,height);
                drawnObjects.Add(new GraphicsObject(mainPen,"ellipse",firstState,endPoint));
            }
            else
            {
                g.DrawRectangle(mainPen, firstState.X, firstState.Y, width, height);
                drawnObjects.Add(new GraphicsObject(mainPen, "rect", firstState, endPoint));
            }
            drawingSomething = false;
            paper.Image = bmp;
        }

       

        private void Load_Click(object sender, EventArgs e)
        {
            //todo
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (opendialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                Image image = new Bitmap(opendialog.FileName);
                paper.Size = image.Size;
                paper.BackgroundImage = image;
                paper.Invalidate();
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("UPS something gone wrong",
                    "i hate windows becose of massegeBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void click_ChangeModeButton(object sender, EventArgs e)
        {
            mode_index++;
            mouseMode = modes[mode_index % modes.Count];
            changeModeButton.Text = "Mode: " + mouseMode;
        }

        private void save_Click(object sender, EventArgs e)
        {

            if (paper.Image == null) return;

            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.CheckPathExists = true;
            savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";

            savedialog.OverwritePrompt = true;
            savedialog.Title = "Saving Image";
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    paper.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("UPS something gone wrong", "i hate windows because of massegeBox",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void change_brush_butt_Click(object sender, EventArgs e)
        {
            form2 = new FormColorChange();
            form2.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //delete
        }

        private void resizebutt_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                GraphicsObject lastDrawn = drawnObjects[drawnObjects.Count - 1];
                lastDrawn.rotate(5);
                g.Clear(Color.Black);
                redrawWithoutLast();
                lastDrawn.draw(g);
                paper.Image = bmp;
            }
            else if (e.KeyCode == Keys.D)
            {
                GraphicsObject lastDrawn = drawnObjects[drawnObjects.Count - 1];
                lastDrawn.rotate(-5);
                g.Clear(Color.Black);
                redrawWithoutLast();
                lastDrawn.draw(g);
                paper.Image = bmp;
            }
        }
    }

    public  class GraphicsObject
    {
        private string type;
        private Pen pen;
        private Brush brush;
        private Point beginPoint;
        private Point endPoint;
        private float angle = 0;
        private Point centerPoint;
        public GraphicsObject(Brush brush, int x, int y)
        {
            type = "point";
            this.brush = brush;
            beginPoint.X = x;
            beginPoint.Y = y;
        }

        public GraphicsObject(Pen pen,string type, Point beginPoint, Point endPoint)
        {
            this.type = type;
            this.pen  = pen;
            
            this.beginPoint.X = Math.Min(beginPoint.X, endPoint.X);
            this.beginPoint.Y = Math.Min(beginPoint.Y, endPoint.Y);

            this.endPoint.X   = Math.Max(beginPoint.X,endPoint.X);
            this.endPoint.Y   = Math.Max(beginPoint.Y,endPoint.Y);
             centerPoint = new Point((int)(beginPoint.X + endPoint.X) / 2,(int)(beginPoint.Y + endPoint.Y) / 2);
        }
        public void draw(Graphics g)
        {
            if (type == "point")
            {
                g.FillEllipse(brush,beginPoint.X,beginPoint.Y,5,5);
                return;
            }

            Matrix rotate = new Matrix(1f, 0f, 0f, 1f, 0f, 0f);
            rotate.RotateAt(this.angle, centerPoint);
            g.Transform = rotate;

            if (type == "line")
            {
                g.DrawLine(pen,beginPoint,endPoint);
            }
            else if (type == "ellipse")
            {
                g.DrawEllipse(pen, beginPoint.X, beginPoint.Y, getWidth(), getHeight());
            }
            else if (type == "rect" || type == "rectangle")
            {
                g.DrawRectangle(pen, beginPoint.X, beginPoint.Y, getWidth(), getHeight());
            }
            g.Transform = new Matrix(1,0,0,1,0,0);
        }

        public void setAngle(float angle)
        {
            this.angle = angle;
        }

        public void rotate(float angle)
        {
            this.angle += angle;
        }
        public void scale(float xscale, float yscale)
        {
            if(type == "point") return;

            int xCenter = centerPoint.X;
            int yCenter = centerPoint.Y;
            beginPoint.X = xCenter - (int)((xCenter - beginPoint.X) * xscale);
            beginPoint.Y = yCenter - (int)((yCenter - beginPoint.Y) * yscale);
            endPoint.X   = xCenter + (int)((endPoint.X - xCenter) * xscale);
            endPoint.Y   = yCenter + (int)((endPoint.Y - yCenter) * yscale);
        }

        public Point getCenter()
        {
            return this.centerPoint;
        }

        public int getWidth()
        {
            return endPoint.X - beginPoint.X;
        }

        public int getHeight()
        {
            return endPoint.Y - beginPoint.Y;
        }
    }

};
