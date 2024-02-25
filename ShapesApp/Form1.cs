using static System.Windows.Forms.LinkLabel;
using System.Drawing.Drawing2D;
using System.Drawing;
using Timer = System.Windows.Forms.Timer;


namespace ShapesApp
{
    public partial class Form1 : Form
    {
        private Shape currentShape;
        private List<PositionedShape> positionedShapes = new List<PositionedShape>();
        private List<Shape> insertedShapes = new List<Shape>();
        private List<String> uniqueInsertedShapes = new List<String>();
        private List<ShapeInfo> shapeInfoList = new List<ShapeInfo>();





        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            Square = new PictureBox();
            Triangle = new PictureBox();
            Rectangle = new PictureBox();
            Circle = new PictureBox();
            Line = new PictureBox();
            splitContainer2 = new SplitContainer();
            RefreshStatusLabel = new Label();
            refresh_button = new Button();
            info_button = new Button();
            draw_button = new Button();
            infoList = new ListBox();
            listBoxShapes = new ListBox();
            richTextBox1 = new RichTextBox();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Square).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Triangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Circle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Line).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(Square);
            splitContainer1.Panel1.Controls.Add(Triangle);
            splitContainer1.Panel1.Controls.Add(Rectangle);
            splitContainer1.Panel1.Controls.Add(Circle);
            splitContainer1.Panel1.Controls.Add(Line);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1311, 569);
            splitContainer1.SplitterDistance = 242;
            splitContainer1.TabIndex = 0;
            // 
            // Square
            // 
            Square.Image = Properties.Resources.square;
            Square.Location = new Point(12, 248);
            Square.Name = "Square";
            Square.Size = new Size(84, 83);
            Square.SizeMode = PictureBoxSizeMode.StretchImage;
            Square.TabIndex = 4;
            Square.TabStop = false;
            Square.Click += sq_click;
            // 
            // Triangle
            // 
            Triangle.Image = Properties.Resources.triangle;
            Triangle.Location = new Point(102, 144);
            Triangle.Name = "Triangle";
            Triangle.Size = new Size(97, 81);
            Triangle.SizeMode = PictureBoxSizeMode.StretchImage;
            Triangle.TabIndex = 3;
            Triangle.TabStop = false;
            Triangle.Click += tr_click;
            // 
            // Rectangle
            // 
            Rectangle.Image = Properties.Resources.rectangle;
            Rectangle.Location = new Point(12, 144);
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(84, 81);
            Rectangle.SizeMode = PictureBoxSizeMode.StretchImage;
            Rectangle.TabIndex = 2;
            Rectangle.TabStop = false;
            Rectangle.Click += rect_click;
            // 
            // Circle
            // 
            Circle.Image = Properties.Resources.circle;
            Circle.Location = new Point(102, 41);
            Circle.Name = "Circle";
            Circle.Size = new Size(97, 82);
            Circle.SizeMode = PictureBoxSizeMode.StretchImage;
            Circle.TabIndex = 1;
            Circle.TabStop = false;
            Circle.Click += circle_click;
            // 
            // Line
            // 
            Line.Image = Properties.Resources.line;
            Line.Location = new Point(12, 41);
            Line.Name = "Line";
            Line.Size = new Size(84, 82);
            Line.SizeMode = PictureBoxSizeMode.StretchImage;
            Line.TabIndex = 0;
            Line.TabStop = false;
            Line.Click += line_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = SystemColors.ControlLightLight;
            splitContainer2.Panel1.Controls.Add(RefreshStatusLabel);
            splitContainer2.Panel1.Controls.Add(refresh_button);
            splitContainer2.Panel1.Controls.Add(info_button);
            splitContainer2.Panel1.Controls.Add(draw_button);
            splitContainer2.Panel1.Controls.Add(infoList);
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listBoxShapes);
            splitContainer2.Panel2.Controls.Add(richTextBox1);
            splitContainer2.Panel2.Paint += splitContainer2_Panel2_Paint;
            splitContainer2.Size = new Size(1065, 569);
            splitContainer2.SplitterDistance = 841;
            splitContainer2.TabIndex = 0;
            // 
            // RefreshStatusLabel
            // 
            RefreshStatusLabel.AutoSize = true;
            RefreshStatusLabel.Location = new Point(210, 155);
            RefreshStatusLabel.Name = "RefreshStatusLabel";
            RefreshStatusLabel.Size = new Size(88, 20);
            RefreshStatusLabel.TabIndex = 6;
            RefreshStatusLabel.Text = "Refreshing...";
            RefreshStatusLabel.Visible = false;
            RefreshStatusLabel.Click += label1_Click;
            // 
            // refresh_button
            // 
            refresh_button.BackColor = SystemColors.ButtonShadow;
            refresh_button.Location = new Point(414, 0);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(120, 43);
            refresh_button.TabIndex = 5;
            refresh_button.Text = "Refresh";
            refresh_button.UseVisualStyleBackColor = false;
            refresh_button.Visible = false;
            refresh_button.Click += refresh_button_Click;
            // 
            // info_button
            // 
            info_button.BackColor = SystemColors.GradientInactiveCaption;
            info_button.Location = new Point(118, 3);
            info_button.Name = "info_button";
            info_button.Size = new Size(106, 40);
            info_button.TabIndex = 3;
            info_button.Text = "Info Mode";
            info_button.UseVisualStyleBackColor = false;
            info_button.Click += button2_Click;
            // 
            // draw_button
            // 
            draw_button.BackColor = SystemColors.GradientActiveCaption;
            draw_button.Location = new Point(3, 3);
            draw_button.Name = "draw_button";
            draw_button.Size = new Size(109, 40);
            draw_button.TabIndex = 2;
            draw_button.Text = "Draw Mode";
            draw_button.UseVisualStyleBackColor = false;
            draw_button.Click += button1_Click;
            // 
            // infoList
            // 
            infoList.FormattingEnabled = true;
            infoList.Location = new Point(3, 41);
            infoList.Name = "infoList";
            infoList.Size = new Size(835, 504);
            infoList.TabIndex = 1;
            infoList.Visible = false;
            infoList.SelectedIndexChanged += infoList_SelectedIndexChanged;
            // 
            // listBoxShapes
            // 
            listBoxShapes.FormattingEnabled = true;
            listBoxShapes.Location = new Point(13, 118);
            listBoxShapes.Name = "listBoxShapes";
            listBoxShapes.Size = new Size(150, 444);
            listBoxShapes.TabIndex = 1;
            listBoxShapes.SelectedIndexChanged += listBoxShapes_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("Segoe UI", 19F);
            richTextBox1.Location = new Point(13, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(150, 58);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "  Shapes";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "line.png");
            imageList1.Images.SetKeyName(1, "circle.png");
            imageList1.Images.SetKeyName(2, "rect.png");
            imageList1.Images.SetKeyName(3, "tr.png");
            imageList1.Images.SetKeyName(4, "sq.png");
            // 
            // Form1
            // 
            ClientSize = new Size(1311, 569);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Load += Form1_Load_1;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Square).EndInit();
            ((System.ComponentModel.ISupportInitialize)Triangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rectangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Circle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Line).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void line_Click(object sender, EventArgs e)
        {
            DrawShape("Line");
        }

        private void circle_click(object sender, EventArgs e)
        {
            DrawShape("Circle");
        }

        private void rect_click(object sender, EventArgs e)
        {
            DrawShape("Rectangle");
        }

        private void tr_click(object sender, EventArgs e)
        {
            DrawShape("Triangle");
        }

        private void sq_click(object sender, EventArgs e)
        {
            DrawShape("Square");
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                foreach (var positionedShape in positionedShapes)
                {
                    // Get the shape and its position
                    var shape = positionedShape.Shape;
                    var x = positionedShape.X;
                    var y = positionedShape.Y;

                    // Draw the shape based on its type
                    if (shape is Line line)
                    {
                        g.DrawLine(Pens.Black, (float)line.StartX, (float)line.StartY, (float)line.EndX, (float)line.EndY);
                    }
                    else if (shape is Circle circle)
                    {
                        g.DrawEllipse(Pens.Black, x, y, circle.getRadius() * 2, circle.getRadius() * 2);
                    }
                    else if (shape is Rectangle rect)
                    {
                        g.DrawRectangle(Pens.Black, x, y, rect.GetWidth(), rect.getHeight());
                    }
                    else if (shape is Triangle tr)
                    {
                        Point[] points = { new Point(x, y), new Point(x + tr.getBase(), y + tr.getHeight()), new Point(x - tr.getBase(), y + tr.getHeight()) };
                        g.DrawPolygon(Pens.Black, points);
                    }
                    else if (shape is Square sq)
                    {
                        g.DrawRectangle(Pens.Black, x, y, sq.getSideLength(), sq.getSideLength());
                    }
                }
            }
        }



        private void AddShape(Shape shape, int x, int y, int width, int height)
        {
            // Add the shape to the list with the unique name
            insertedShapes.Add(shape);

            // Generate a unique name for the shape
            string uniqueName = createUniqueNames(shape.GetName());

            uniqueInsertedShapes.Add(uniqueName);

            // Create a ShapeInfo object for the shape and add it to the list
            ShapeInfo shapeInfo;

            if (shape is Square sq)
            {
                shapeInfo = new ShapeInfo(uniqueName, x, y, width, height, sq.getSideLength());
            }
            else if (shape is Circle circle)
            {
                shapeInfo = new ShapeInfo(uniqueName, x, y, width, height, circle.getRadius(), true);
            }
            else if (shape is Line line)
            {
                int length = (int)Math.Sqrt(Math.Pow(line.EndX - line.StartX, 2) + Math.Pow(line.EndY - line.StartY, 2));
                shapeInfo = new ShapeInfo(uniqueName, x, y, width, height, length, 0);
            }
            else
            {
                shapeInfo = new ShapeInfo(uniqueName, x, y, width, height);
            }

            shapeInfoList.Add(shapeInfo);

            // Update the shape list
            updateListOfShapes();


        }

        private void updateListOfShapes()
        {
            // Clear existing items
            listBoxShapes.Items.Clear();

            // Add names of inserted shapes to the ListBox
            foreach (String shape in uniqueInsertedShapes)

            {
                listBoxShapes.Items.Add(shape);


                // Populate the list box with shape info
                infoList.Items.Clear();
                foreach (ShapeInfo info in shapeInfoList)
                {
                    infoList.Items.Add(info.ToString());
                }

            }
        }

        private string createUniqueNames(string baseName)
        {
            // Find the maximum count for the baseName
            int maxCount = insertedShapes.Count(shape => shape.GetName().StartsWith(baseName));

            // Append a unique number to the baseName
            string uniqueName = $"{baseName} {maxCount}";

            return uniqueName;
        }


        private void DrawShape(string shapeName)

        {

            Random dimensions = new Random();
            int Width = dimensions.Next(40, 101);
            int Height = dimensions.Next(40, 101);
            // Determine which shape was clicked
            switch (shapeName)

            {
                case "Line":
                    // Create an instance of Line shape
                    currentShape = new Line(100, 200, Width, Height, "Line");
                    break;
                case "Circle":
                    // Create an instance of Circle shape with a random radius between 40 and 100

                    currentShape = new Circle(Width, "Circle");
                    break;
                case "Rectangle":
                    // Create an instance of Rectangle shape with random width and height between 40 and 100

                    currentShape = new Rectangle(Width, Height, "Rectangle");
                    break;
                case "Triangle":
                    // Create an instance of Triangle shape with a random base and height between 40 and 100

                    currentShape = new Triangle(Width, Height, "Triangle");
                    break;
                case "Square":
                    // Create an instance of Square shape with a random side length between 40 and 100

                    currentShape = new Square(Width, "Square");
                    break;
                default:
                    // Handle unknown shape
                    MessageBox.Show("Unknown shape!");
                    return;
            }

            // Generate random position
            Random rand = new Random();
            int x = rand.Next(splitContainer2.Panel1.Width - 100); // Subtracting shape width to ensure it stays within panel boundaries
            int y = rand.Next(splitContainer2.Panel1.Height - 100); // Subtracting shape height to ensure it stays within panel boundaries

            // Add the shape and its position to the list
            positionedShapes.Add(new PositionedShape(currentShape, x, y));
            AddShape(currentShape, x, y, Width, Height);


            // Redraw the panel to show the selected shape
            splitContainer2.Panel1.Refresh();
        }



        private void listBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxShapes.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < insertedShapes.Count)
            {
                HighlightShape(selectedIndex);
            }
        }




        private int selectedShapeIndex = -1; // Initially no shape is selected

        private void HighlightShape(int selectedIndex)
        {
            // Update the selected shape index
            selectedShapeIndex = selectedIndex;

            // Redraw all shapes to reflect the change
            RedrawShapes();
        }
        private void RedrawShapes()
        {
            // Redraw all shapes
            using (Graphics g = splitContainer2.Panel1.CreateGraphics())
            {
                g.Clear(Color.White); // Clear the panel first

                for (int i = 0; i < positionedShapes.Count; i++)
                {
                    // Get the shape and its position
                    var positionedShape = positionedShapes[i];
                    var shape = positionedShape.Shape;
                    var x = positionedShape.X;
                    var y = positionedShape.Y;

                    // Draw the shape based on its type
                    if (shape is Line line)
                    {
                        g.DrawLine(Pens.Black, (float)line.StartX, (float)line.StartY, (float)line.EndX, (float)line.EndY);
                    }
                    else if (shape is Circle circle)
                    {
                        g.DrawEllipse(Pens.Black, x, y, circle.getRadius() * 2, circle.getRadius() * 2);
                    }
                    else if (shape is Rectangle rect)
                    {
                        g.DrawRectangle(Pens.Black, x, y, rect.GetWidth(), rect.getHeight());
                    }
                    else if (shape is Triangle tr)
                    {
                        Point[] points = { new Point(x, y), new Point(x + tr.getBase(), y + tr.getHeight()), new Point(x - tr.getBase(), y + tr.getHeight()) };
                        g.DrawPolygon(Pens.Black, points);
                    }
                    else if (shape is Square sq)
                    {
                        g.DrawRectangle(Pens.Black, x, y, sq.getSideLength(), sq.getSideLength());
                    }

                    // Highlight the selected shape in red
                    if (i == selectedShapeIndex)
                    {
                        using (Pen redPen = new Pen(Color.Red, 2))
                        {
                            // Draw the border around the shape in red
                            if (shape is Line linee)
                            {
                                // For lines, draw the line itself in red
                                g.DrawLine(redPen, (float)linee.StartX, (float)linee.StartY, (float)linee.EndX, (float)linee.EndY);
                            }
                            else if (shape is Circle circle)
                            {
                                // For circles, draw the circle with the same radius in red
                                g.DrawEllipse(redPen, x, y, circle.getRadius() * 2, circle.getRadius() * 2);
                            }
                            else if (shape is Rectangle rect)
                            {
                                // For rects, draw the rect with the same dimensions in red
                                g.DrawRectangle(redPen, x, y, rect.GetWidth(), rect.getHeight());
                            }
                            else if (shape is Triangle tr)
                            {
                                // For trs, draw the tr with the same vertices in red
                                Point[] points = { new Point(x, y), new Point(x + tr.getBase(), y + tr.getHeight()), new Point(x - tr.getBase(), y + tr.getHeight()) };
                                g.DrawPolygon(redPen, points);
                            }
                            else if (shape is Square sq)
                            {
                                // For sqs, draw the sq with the same side length in red
                                g.DrawRectangle(redPen, x, y, sq.getSideLength(), sq.getSideLength());
                            }
                        }
                    }
                }
            }
        }

        private void infoList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show splitContainer1.Panel2 and splitContainer2.Panel1
            splitContainer2.Panel1.Visible = true;

            // Hide the list box containing shape info if it exists
            if (infoList != null)
            {
                refresh_button.Visible = false;
                infoList.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show the list box containing shape info
            refresh_button.Visible = true;
            infoList.Visible = true;

        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            infoList.Items.Clear();
            // Display "Refreshing" for a second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            RefreshStatusLabel.Visible = true;
            timer.Tick += (s, _) =>
            {
                timer.Stop();
                timer.Dispose();

                // Call the update method
                updateListOfShapes();
                RefreshStatusLabel.Visible = false;

            };
            timer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
