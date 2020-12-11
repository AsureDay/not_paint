using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drowing_lines_and_other_things
{



    public partial class mainForm : Form
    {

        //graphics things
        private Graphics g;
        private Bitmap bmp;
        private Point firstState;
        private List<string> modes = new List<string>() { "line", "ellipse", "point", "rectangle" };
        private int mode_index = 0;
        private string mouseMode = "line";
        //graphics figures
        private List<GraphicsPoint> points = new List<GraphicsPoint>();
        private List<GraphicsLine> lines = new List<GraphicsLine>();
        private List<GraphicsRect> rects = new List<GraphicsRect>();
        private List<GraphicsRect> ellipses = new List<GraphicsRect>();


        // paint things
        Brush mainBrush = new SolidBrush(Color.Aqua);
        Pen mainPen = new Pen(Color.Aqua, 3);
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
                points.Add(new GraphicsPoint(e.X, e.Y, mainBrush));
            }

            drawingSomething = true;
            firstState = e.Location;
        }

        private void paper_MauseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {   
                
            }
            if (!drawingSomething) return;

            if (mouseMode == "line")
            {
                g.DrawLine(mainPen, firstState, e.Location);
                lines.Add(new GraphicsLine(firstState, e.Location, mainPen));
            }
            else if (mouseMode == "ellipse")
            {
                g.DrawEllipse(mainPen, firstState.X, firstState.Y, e.Location.X - firstState.X,
                    e.Location.Y - firstState.Y);
                ellipses.Add(new GraphicsRect(firstState.X, firstState.Y, e.Location.X - firstState.X, e.Location.Y - firstState.Y, mainPen));
            }
            else
            {
                g.DrawRectangle(mainPen, firstState.X, firstState.Y, e.Location.X - firstState.X,
                    e.Location.Y - firstState.Y);
                rects.Add(new GraphicsRect(firstState.X, firstState.Y, e.Location.X - firstState.X,
                    e.Location.Y - firstState.Y, mainPen));
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
            //todo
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
    }
    public class GraphicsPoint
    {
        public Pen pen;
        public int x;
        public int y;
        public Brush brush;
        public GraphicsPoint(int x, int y, Pen pen)
        {
            this.x = x;
            this.y = y;
            this.pen = pen;
        }
        public GraphicsPoint(int x, int y, Brush brush)
        {
            this.x = x;
            this.y = y;
            this.brush = brush;
        }
    }

    public class GraphicsLine
    {
        public Pen pen;
        public Point beginPoint;
        public Point endPoint;

        public GraphicsLine(Point beginPoint, Point endPoint, Pen pen)
        {
            this.pen = pen;
            this.beginPoint = beginPoint;
            this.endPoint = endPoint;
        }
    }

    public class GraphicsRect : GraphicsPoint
    {
        public int width;
        public int height;
        public GraphicsRect(int x, int y, int width, int height, Pen pen) : base(x, y, pen)
        {
            this.width = width;
            this.height = height;
        }

    }
};
