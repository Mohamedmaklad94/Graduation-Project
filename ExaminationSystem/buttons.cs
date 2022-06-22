using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace ExaminationSystem
{
    public class buttons : Button
    {
        //fields
        private int bordersize = 0;
        private int borderradius = 40;
        private Color bordercolor = Color.PaleVioletRed;

        public int Bordersize
        {
            get
            {
                return bordersize;

            }
            set
            {
                bordersize = value;
                this.Invalidate();

            }
        }
        public int Borderradius 
        { 
            get
            {
                return borderradius;
            }
            set
            {
                borderradius = value;
                this.Invalidate();
            }
        
        
        }
        public Color Bordercolor
        {
            get
            {
                return bordercolor;
            }
            set
            {
                bordercolor = value;
                this.Invalidate();
            }

        }

        public Color backgroundColor
        {

            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;

            }
        }

        public Color TextColor
        {

            get
            {
                return this.ForeColor;
            }
            set
            {
                this.ForeColor = value;

            }
        }
        //constructors
        public buttons()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        //methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180,90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270,90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0,90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectsurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectborder = new RectangleF(1, 1, this.Width-0.8f, this.Height-1);

            if(borderradius > 2)  //rounded button
            {
                using (GraphicsPath pathsurface = GetFigurePath(rectsurface, borderradius))
                using (GraphicsPath pathborder = GetFigurePath(rectborder, borderradius - 1f))
                using (Pen pensurface=new Pen(this.Parent.BackColor,2))
                using (Pen penBorder=new Pen(bordercolor, bordersize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //button surface
                    this.Region = new Region(pathsurface);
                    //draw surface border for hd result
                    pevent.Graphics.DrawPath(pensurface, pathsurface);

                    //button border
                    if (bordersize >= 1)

                        //draw control border
                        pevent.Graphics.DrawPath(penBorder, pathborder);
                }

            }
            else // normal button
            {
                //button surface
                this.Region = new Region(rectsurface);
                //button border
                if (bordersize >= 1)
                {
                    using (Pen penBorder=new Pen(bordercolor, bordersize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width-1, this.Height-1);
                    }

                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_backColorChanged);
        }
        private void Container_backColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();

        }
    }

}
