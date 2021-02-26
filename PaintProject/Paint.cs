using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintProject
{
    public partial class Paint : Form
    {
        int pixelSize = 10, Rows, Columns, firstClickX, firstClickY, secondClickX, secondClickY, offsetX = 0, offsetY = 0, doubleClickState = 1;
        int autoIncID = 0;
        Pen gridPen = new Pen(Color.Black), colorPen = new Pen(Color.Red);
        SolidBrush brush = new SolidBrush(Color.Red);
        bool printPixel = false, showGrid = false, drawScreen = true;
        Graphics pixelGraphics;
        Pixel[,] pixelMatrix, tempMatrix;
        string selectedGroupId = "";
        public Paint()
        {
            InitializeComponent();
            pixelGraphics = drawingPanel.CreateGraphics();
            UpdateGridValues();
            colorPictureBox.BackColor = colorPen.Color;
        }

        private void Paint_Load(object sender, EventArgs e)
        {
        }

        private void UpdateGridValues()
        {
            int drawingWidth = 930, drawingHeight = 600;
            Columns = Convert.ToInt32(numericWidth.Value);
            Rows = Convert.ToInt32(numericHeight.Value);
            if (drawingHeight < (Rows * pixelSize))
            {
                drawingPanel.Height = drawingHeight - (drawingHeight % pixelSize);
                vScrollBar.Maximum = Rows - (drawingPanel.Height / pixelSize);
            }
            else
            {
                drawingPanel.Height = (Rows * pixelSize);
                vScrollBar.Maximum = 0;
            }
            if (drawingWidth < (Columns * pixelSize))
            {
                drawingPanel.Width = drawingWidth - (drawingWidth % pixelSize);
                hScrollBar.Maximum = Columns - (drawingPanel.Width / pixelSize);
            }
            else
            {
                drawingPanel.Width = (Columns * pixelSize);
                hScrollBar.Maximum = 0;
            }

            labelCanva.Text = String.Format("[ {0} , {1} ] to [ {2} , {3} ]", offsetX, offsetY, Columns - hScrollBar.Maximum + offsetX, Rows - vScrollBar.Maximum + offsetY);

            if (pixelMatrix != null)
            {
                tempMatrix = pixelMatrix;
            }

            pixelMatrix = new Pixel[Columns, Rows];
            if (tempMatrix != null)
            {
                for (int row = 0; row < pixelMatrix.GetLength(0); row++)
                {
                    for (int column = 0; column < pixelMatrix.GetLength(1); column++)
                    {
                        if (tempMatrix.GetLength(0) > row && tempMatrix.GetLength(1) > column && tempMatrix[row, column] != null)
                        {
                            pixelMatrix[row, column] = tempMatrix[row, column];
                        }
                    }
                }
            }
        }

        private void CreateGrid()
        {
            pixelGraphics.Clear(Color.White);
            restoreDrawing();
            if (showGrid)
            {
                float x = 0f, y = 0f;
                for (int i = 0; i <= Columns; i++)
                {
                    pixelGraphics.DrawLine(gridPen, x, y, x, drawingPanel.Height);
                    x += pixelSize;
                }
                x = 0f;
                for (int i = 0; i <= Rows; i++)
                {
                    pixelGraphics.DrawLine(gridPen, x, y, drawingPanel.Width, y);
                    y += pixelSize;
                }
            }
        }

        private void restoreDrawing()
        {
            if (drawScreen)
            {
                Pen tempPen = new Pen(Color.Black);
                SolidBrush tempBrush = new SolidBrush(Color.Red);
                for (int row = offsetX; row < pixelMatrix.GetLength(0); row++)
                {
                    for (int column = offsetY; column < pixelMatrix.GetLength(1); column++)
                    {
                        if (pixelMatrix[row, column] != null)
                        {
                            Rectangle rect = new Rectangle((pixelMatrix[row, column].x - offsetX) * pixelSize, (pixelMatrix[row, column].y - offsetY) * pixelSize, pixelSize, pixelSize);
                            tempPen.Color = pixelMatrix[row, column].color;
                            tempBrush.Color = pixelMatrix[row, column].color;
                            pixelGraphics.DrawRectangle(tempPen, rect);
                            pixelGraphics.FillRectangle(tempBrush, rect);
                        }
                    }
                }
            }

        }

        private void refreshScreen()
        {
            UpdateGridValues();
            CreateGrid();
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drawingPanel_Resize(object sender, EventArgs e)
        {
            drawingPanel.Invalidate();      //Delete All Graphics From Panel
            drawingPanel.Controls.Clear();  //Delete All Controls from Panel
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {

            if (buttonPaint.Checked)
            {
                printPixel = true;
            }
            if (buttonFill.Checked)
            {
                int fixX = (e.X / pixelSize) + offsetX, fixY = (e.Y / pixelSize) + offsetY;
                if (pixelMatrix[fixX, fixY] == null)
                {
                    floodFillAlgorithm(fixX, fixY, colorPictureBox.BackColor, Color.Empty);
                }
                else
                {
                    floodFillAlgorithm(fixX, fixY, colorPictureBox.BackColor, pixelMatrix[fixX, fixY].color);
                }

            }
            if (transformButton.Checked)
            {
                int fixX = (e.X / pixelSize) + offsetX, fixY = (e.Y / pixelSize) + offsetY;
                if (pixelMatrix[fixX, fixY] != null)
                {
                    selectedGroupId = pixelMatrix[fixX, fixY].groupId;
                    if (selectedGroupId != null)
                    {
                        transformationGroup.Enabled = true;
                    }
                }
            }

        }


        private void transformButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!transformButton.Checked)
            {
                selectedGroupId = null;
                transformationGroup.Enabled = false;
            }
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (buttonPaint.Checked)
            {
                printPixel = false;
            }
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (printPixel && buttonPaint.Checked)
            {
                int fixX = e.X / pixelSize, fixY = e.Y / pixelSize;
                drawPixel(fixX, fixY, null);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pixelMatrix = new Pixel[Columns, Rows];
            CreateGrid();
        }

        private void pixelNumeric_ValueChanged(object sender, EventArgs e)
        {
            pixelSize = Convert.ToInt32(trackBarPixel.Value);
            refreshScreen();
        }
        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            refreshScreen();
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            offsetX = hScrollBar.Value;
            refreshScreen();
        }

        private void vScrollBar_ValueChanged(object sender, EventArgs e)
        {
            offsetY = vScrollBar.Value;
            refreshScreen();
        }
        private void colorPictureBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.ShowHelp = true;
            colorDialog.AllowFullOpen = true;
            colorDialog.Color = colorPictureBox.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorPictureBox.BackColor = colorDialog.Color;
                colorPen.Color = colorDialog.Color;
                brush.Color = colorDialog.Color;
            }
        }

        private void drawingPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (doubleButton.Checked)
            {
                int fixX = e.X / pixelSize, fixY = e.Y / pixelSize;

                switch (doubleClickState)
                {
                    case 1:
                        doubleClickState = 2;
                        firstClickX = fixX;
                        firstClickY = fixY;
                        doubleClickLabel.Text = "Waiting for 2nd Click";
                        doubleClickLabel.BackColor = Color.DarkOrange;
                        break;
                    case 2:
                        if (buttonEllipse.Checked)
                        {
                            doubleClickState = 3;
                            secondClickX = fixX;
                            secondClickY = fixY;
                            doubleClickLabel.Text = "Waiting for 3rd Click";
                            doubleClickLabel.BackColor = Color.DarkRed;
                            algorithmBox.Enabled = false;
                        }
                        else
                        {
                            drawAlgorithm(firstClickX, firstClickY, fixX, fixY);
                            doubleClickState = 1;
                            doubleClickLabel.Text = "Waiting for 1st Click";
                            doubleClickLabel.BackColor = Color.Transparent;
                        }
                        break;
                    case 3:
                        drawEllipse(firstClickX, firstClickY, secondClickX, secondClickY, fixX, fixY);
                        doubleClickState = 1;
                        doubleClickLabel.Text = "Waiting for 1st Click";
                        doubleClickLabel.BackColor = Color.Transparent;
                        algorithmBox.Enabled = true;
                        break;

                }
            }
        }
        private void trackBarPixel_Scroll(object sender, EventArgs e)
        {
            drawScreen = false;
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            if (selectedGroupId == null) { return; }
            Stack<Pixel> tempList = new Stack<Pixel>();
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    if (pixelMatrix[x, y] != null && pixelMatrix[x, y].groupId != null && pixelMatrix[x, y].groupId == selectedGroupId)
                    {
                        tempList.Push(pixelMatrix[x, y]);
                        erasePixel(x, y);
                    }
                }
            }
            int dx = (tempList.Last().x + tempList.Peek().x) / 2;
            int dy = (tempList.Last().y + tempList.Peek().y) / 2;
            double scale = Convert.ToDouble(numericScale.Value);
            while (tempList.Count > 0)
            {
                Pixel p = tempList.Pop();
                int x = Convert.ToInt32(Math.Floor((p.x - dx) * scale)) + dx, y = Convert.ToInt32(Math.Floor((p.y - dy) * scale)) + dy;
                drawPixel(x, y, p.groupId, p.color);
                if (scale > 1)
                {
                    for (int i = 1; i < scale; i++)
                    {
                        drawPixel(x + i, y, p.groupId, p.color);
                        drawPixel(x, y + i, p.groupId, p.color);
                        for (int j = 1; j < scale; j++)
                        {
                            drawPixel(x + i, y + j, p.groupId, p.color);
                        }
                    }
                }

            }
        }

        private void disableDrawScreen(object sender, ScrollEventArgs e)
        {
            drawScreen = false;
        }
        private void enableDrawScreen(object sender, EventArgs e)
        {
            drawScreen = true;
            restoreDrawing();
        }

        private void traslationButton_Click(object sender, EventArgs e)
        {
            //⮝⮟⮜⮞
            if (selectedGroupId == null) { return; }
            List<Pixel> tempList = new List<Pixel>();
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    if (pixelMatrix[x, y] != null && pixelMatrix[x, y].groupId != null && pixelMatrix[x, y].groupId == selectedGroupId)
                    {
                        tempList.Add(pixelMatrix[x, y]);
                        erasePixel(x - offsetX, y - offsetY);
                    }
                }
            }

            int distance = Convert.ToInt32(numericTraslation.Value);
            foreach (Pixel p in tempList)
            {
                switch (comboDirecction.SelectedIndex)
                {
                    case 0://Up
                        drawPixel(p.x - offsetX, p.y - distance - offsetY, p.groupId, p.color);
                        break;
                    case 1://Down
                        drawPixel(p.x - offsetX, p.y + distance - offsetY, p.groupId, p.color);
                        break;
                    case 2://Left
                        drawPixel(p.x - distance - offsetX, p.y - offsetY, p.groupId, p.color);
                        break;
                    case 3://Right
                        drawPixel(p.x + distance - offsetX, p.y - offsetY, p.groupId, p.color);
                        break;
                }
            }
        }

        private void rotate(double degree)
        {
            Stack<Pixel> tempList = new Stack<Pixel>();
            int dx = 0, dy = 0;
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Columns; x++)
                {
                    if (pixelMatrix[x, y] != null && pixelMatrix[x, y].groupId != null && pixelMatrix[x, y].groupId == selectedGroupId)
                    {
                        tempList.Push(pixelMatrix[x, y]);
                        erasePixel(x, y);
                    }
                }
            }

            double angle = (degree / 360) * (2 * Math.PI);
            dx = (tempList.Peek().x + tempList.Last().x) / 2;
            dy = (tempList.Peek().y + tempList.Last().y) / 2;

            while (tempList.Count > 0)
            {
                Pixel p = tempList.Pop();
                int px = Convert.ToInt32(((p.x - dx) * Math.Cos(angle)) - ((p.y - dy) * Math.Sin(angle)));
                int py = Convert.ToInt32(((p.x - dx) * Math.Sin(angle)) + ((p.y - dy) * Math.Cos(angle)));
                drawPixel(px + dx, py + dy, p.groupId, p.color);
            }
        }
        private void rotateLButton_Click(object sender, EventArgs e)
        {
            rotate(-90);
        }

        private void rotateRButton_Click(object sender, EventArgs e)
        {
            rotate(90);
        }

        private int getautoIncID()
        {
            autoIncID++;
            return autoIncID;
        }

        private void drawAlgorithm(int xa, int ya, int xb, int yb)
        {
            if (buttonDDA.Checked)
            {
                lineDDA(xa, ya, xb, yb);
            }
            if (buttonBresenham.Checked)
            {
                lineBresenham(xa, ya, xb, yb);
            }
            if (buttonCircle.Checked)
            {
                circleMidpoint(xa, ya, xb, yb);
            }
        }

        private void lineBresenham(int xa, int ya, int xb, int yb)
        {
            int w = xb - xa;
            int h = yb - ya;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;
            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);
            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            string generatedID = "BL-" + getautoIncID();
            for (int i = 0; i <= longest; i++)
            {
                drawPixel(xa, ya, generatedID);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    xa += dx1;
                    ya += dy1;
                }
                else
                {
                    xa += dx2;
                    ya += dy2;
                }
            }
        }

        private void circleMidpoint(int xa, int ya, int xb, int yb)
        {
            string generatedID = "C-" + getautoIncID();
            int radius = Convert.ToInt32(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)));
            int x = 0;
            int y = radius;
            int p = 1 - radius;
            simetricPlotPoints(xa, ya, x, y, generatedID);
            simetricPlotPoints(xa, ya, y, x, generatedID);
            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                simetricPlotPoints(xa, ya, x, y, generatedID);
                simetricPlotPoints(xa, ya, y, x, generatedID);
            }

        }

        private void drawEllipse(int xa, int ya, int xb, int yb, int xc, int yc)
        {
            string generatedID = "E-" + getautoIncID();
            int dxb = Math.Abs(xb - xa), dxc = Math.Abs(xc - xa);
            int dyb = Math.Abs(yb - ya), dyc = Math.Abs(yc - ya);
            int rx = Convert.ToInt32(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)));
            int ry = Convert.ToInt32(Math.Sqrt(Math.Pow(xc - xa, 2) + Math.Pow(yc - ya, 2)));

            if (dxb < dxc)
            {
                int temp = rx;
                rx = ry;
                ry = temp;
            }

            int rx2 = rx * rx;
            int ry2 = ry * ry;
            int twoRx2 = 2 * rx2;
            int twoRy2 = 2 * ry2;
            int p, x = 0, y = ry, px = 0, py = twoRx2 * y;
            simetricPlotPoints(xa, ya, x, y, generatedID);
            p = Convert.ToInt32(ry2 - (rx2 * ry) + (0.25 * rx2));
            while (px < py)
            {
                x++;
                px += twoRy2;
                if (p < 0)
                {
                    p += ry2 + px;
                }
                else
                {
                    y--;
                    py -= twoRx2;
                    p += ry2 + px - py;
                }
                simetricPlotPoints(xa, ya, x, y, generatedID);
            }
            p = Convert.ToInt32(ry2 * (x + 0.5) * (x + 0.5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2);
            while (y > 0)
            {
                y--;
                py -= twoRx2;
                if (p > 0)
                {
                    p += rx2 - py;
                }
                else
                {
                    x++;
                    px += twoRy2;
                    p += rx2 - py + px;
                }
                simetricPlotPoints(xa, ya, x, y, generatedID);
            }
        }

        private void simetricPlotPoints(int xa, int ya, int x, int y, string generatedID)
        {
            drawPixel(xa + x, ya + y, generatedID);
            drawPixel(xa - x, ya + y, generatedID);
            drawPixel(xa + x, ya - y, generatedID);
            drawPixel(xa - x, ya - y, generatedID);
        }

        private void floodFillAlgorithm(int x, int y, Color newColor, Color oldColor)
        {
            Stack<Point> stack = new Stack<Point>();
            Stack<Point> visited = new Stack<Point>();
            stack.Push(new Point(x, y));
            visited.Push(new Point(x, y));
            string generatedID = "FF-" + getautoIncID();
            while (stack.Count > 0)
            {
                bool checkNeighbors = false;
                Point p = stack.Pop();
                int px = p.X, py = p.Y;
                if (px < Columns && py < Rows && px >= 0 && py >= 0)
                {
                    if ((oldColor == Color.Empty && (pixelMatrix[px, py] == null)) || (pixelMatrix[px, py] != null && pixelMatrix[px, py].color == oldColor && newColor != oldColor))
                    {
                        drawPixel(px - offsetX, py - offsetY, generatedID);
                        checkNeighbors = true;
                    }
                    if (checkNeighbors)
                    {
                        Point a1 = new Point(px + 1, py);
                        Point a2 = new Point(px - 1, py);
                        Point a3 = new Point(px, py + 1);
                        Point a4 = new Point(px, py - 1);
                        if (!(visited.Contains(a4)))
                        {
                            stack.Push(new Point(px, py - 1));
                            visited.Push(new Point(px, py - 1));
                        }
                        if (!(visited.Contains(a1)))
                        {
                            stack.Push(new Point(px + 1, py));
                            visited.Push(new Point(px + 1, py));
                        }
                        if (!(visited.Contains(a2)))
                        {
                            stack.Push(new Point(px - 1, py));
                            visited.Push(new Point(px - 1, py));
                        }
                        if (!(visited.Contains(a3)))
                        {
                            stack.Push(new Point(px, py + 1));
                            visited.Push(new Point(px, py + 1));
                        }
                    }
                }
            }
        }

        private void lineDDA(int xa, int ya, int xb, int yb)
        {
            int dx = xb - xa, dy = yb - ya, steps, fixX, fixY;
            float xIncrement, yIncrement, x = xa, y = ya;
            string generatedID = "LD-" + getautoIncID();
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }
            else
            {
                steps = Math.Abs(dy);
            }
            xIncrement = dx / (float)steps;
            yIncrement = dy / (float)steps;
            drawPixel(xa, ya, generatedID);
            for (int i = 0; i < steps; i++)
            {
                x += xIncrement;
                y += yIncrement;
                fixX = Convert.ToInt32(Math.Floor(x + 0.5));
                fixY = Convert.ToInt32(Math.Floor(y + 0.5));
                drawPixel(fixX, fixY, generatedID);
            }
        }

        private void gridButton_Click(object sender, EventArgs e)
        {
            showGrid = !showGrid;
            CreateGrid();
        }

        private void drawPixel(int xd, int yd, string groupId)
        {
            int x = xd + offsetX, y = yd + offsetY;
            if (x >= 0 && y >= 0 && x < Columns && y < Rows)
            {
                try
                {
                    Pixel pixel = new Pixel(x, y, brush.Color, groupId);
                    if (pixelMatrix[x, y] != pixel)
                    {
                        pixelMatrix[x, y] = pixel;
                        if (xd < (Columns + offsetX - hScrollBar.Maximum) && yd < (Rows + offsetY - vScrollBar.Maximum))
                        {
                            Rectangle rect = new Rectangle(xd * pixelSize, yd * pixelSize, pixelSize, pixelSize);
                            pixelGraphics.DrawRectangle(colorPen, rect);
                            pixelGraphics.FillRectangle(brush, rect);
                        }
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("You are drawing outside of the area");
                }
            }
        }

        private void drawPixel(int xd, int yd, string groupId, Color color)
        {
            Pen tempPen = new Pen(color);
            SolidBrush tempBrush = new SolidBrush(color);
            int x = xd + offsetX, y = yd + offsetY;
            if (x >= 0 && y >= 0 && x < Columns && y < Rows)
            {
                try
                {
                    Pixel pixel = new Pixel(x, y, color, groupId);
                    if (pixelMatrix[x, y] != pixel)
                    {
                        pixelMatrix[x, y] = pixel;

                        if (xd < (Columns + offsetX - hScrollBar.Maximum) && yd < (Rows + offsetY - vScrollBar.Maximum))
                        {
                            Rectangle rect = new Rectangle(xd * pixelSize, yd * pixelSize, pixelSize, pixelSize);
                            pixelGraphics.DrawRectangle(tempPen, rect);
                            pixelGraphics.FillRectangle(tempBrush, rect);
                        }
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine("You are drawing outside of the area");
                }
            }
        }

        private void erasePixel(int xd, int yd)
        {
            try
            {
                int x = xd + offsetX, y = yd + offsetY;
                if (pixelMatrix[x, y] != null)
                {
                    pixelMatrix[x, y] = null;
                    if (xd < (Columns + offsetX - hScrollBar.Maximum) && yd < (Rows + offsetY - vScrollBar.Maximum))
                    {
                        Rectangle rect = new Rectangle(xd * pixelSize, yd * pixelSize, pixelSize, pixelSize);
                        pixelGraphics.DrawRectangle(new Pen(Color.White), rect);
                        pixelGraphics.FillRectangle(new SolidBrush(Color.White), rect);
                    }
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Erasing out of the area");
            }
        }
    }

    class Pixel
    {
        public Pixel(int x, int y, Color color, string groupId)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.groupId = groupId;
        }
        public int x { set; get; }
        public int y { set; get; }
        public Color color { set; get; }
        public string groupId { set; get; }
    }
}
