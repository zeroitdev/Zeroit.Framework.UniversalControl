// ***********************************************************************
// Assembly         : Zeroit.Framework.UniversalControl
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="UniversalControl.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Universal control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using Zeroit.Framework.UniversalControl.Editors.Brushes;
using Zeroit.Framework.UniversalControl.Editors.PenPainter;
using Zeroit.Framework.UniversalControl.Editors.PolyEditor;
using Zeroit.Framework.UniversalControl.ThemeManagers;


namespace Zeroit.Framework.UniversalControl
{
    /// <summary>
    /// Class ZeroitUniversalControl.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.UniversalControl.ThemeManagers.ThemeControl" />
    public class ZeroitUniversalControl : ThemeControl
    {

        #region Public ENUM

        /// <summary>
        /// Enum ControlTypes
        /// </summary>
        public enum ControlTypes
        {
            /// <summary>
            /// The polygon
            /// </summary>
            Polygon,
            /// <summary>
            /// The rectangle
            /// </summary>
            Rectangle
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// The fill
        /// </summary>
        private BrushPainter fill = new BrushPainter(90f,Color.AliceBlue,Color.Lime);

        /// <summary>
        /// The border
        /// </summary>
        private PenPainter border = new PenPainter(Color.Black, 1f);

        /// <summary>
        /// The state
        /// </summary>
        private MouseState State = MouseState.None;

        /// <summary>
        /// The curves
        /// </summary>
        private Curves curves = new Curves();

        /// <summary>
        /// The polygon
        /// </summary>
        private Polygon polygon = new Polygon(new PointF[]
        {
            new Point(0,0),
            new Point(50,50),
            new Point(0, 100),
            new Point(0,0)
        });

        /// <summary>
        /// The control type
        /// </summary>
        private ControlTypes controlType = ControlTypes.Rectangle;


        #endregion

        #region Public Properties


        #region Smoothing Mode

        /// <summary>
        /// The smoothing
        /// </summary>
        private SmoothingMode smoothing = SmoothingMode.HighQuality;

        /// <summary>
        /// Gets or sets the smoothing.
        /// </summary>
        /// <value>The smoothing.</value>
        public SmoothingMode Smoothing
        {
            get { return smoothing; }
            set
            {
                smoothing = value;
                Invalidate();
            }
        }

        #endregion


        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = textrendering;
        #endregion

        /// <summary>
        /// The textrendering
        /// </summary>
        TextRenderingHint textrendering = TextRenderingHint.AntiAlias;

        /// <summary>
        /// Gets or sets the text rendering.
        /// </summary>
        /// <value>The text rendering.</value>
        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the fill.
        /// </summary>
        /// <value>The fill.</value>
        public BrushPainter Fill
        {
            get { return fill; }
            set
            {
                fill = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        /// <value>The border.</value>
        public PenPainter Border
        {
            get { return border; }
            set
            {
                border = value;
                Invalidate();
            }
        }



        #endregion

        /// <summary>
        /// Gets or sets the curves.
        /// </summary>
        /// <value>The curves.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Curves Curves
        {
            get { return curves; }
            set
            {
                curves = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the polygon.
        /// </summary>
        /// <value>The polygon.</value>
        public Polygon Polygon
        {
            get { return polygon; }
            set
            {
                polygon = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the type of the control.
        /// </summary>
        /// <value>The type of the control.</value>
        public ControlTypes ControlType
        {
            get { return controlType; }
            set
            {
                controlType = value;
                Invalidate();
            }
        }





        #region Image Designer

        #region Include in paint method

        ///////////////////////////////////////////////////////////////////////////////////////////////// 
        //                                                                                             //                                                                     
        //         ------------------------Add this to the Paint Method ------------------------       //
        //                                                                                             //
        // Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          //
        //                                                                                             //
        // PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);                   //
        //                                                                                             //
        // if ((Image == null))                                                                        //
        //     {                                                                                       //
        //         G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat           //
        //             {                                                                               //
        //                 Alignment = _TextAlignment,                                                 //
        //                 LineAlignment = StringAlignment.Center                                      //
        //             });                                                                             //
        //      }                                                                                      //
        // else                                                                                        //
        //      {                                                                                      //
        //         G.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);              //
        //          G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat          //
        //             {                                                                               //
        //                 Alignment = _TextAlignment,                                                 //
        //                 LineAlignment = StringAlignment.Center                                      //
        //             });                                                                             //
        //      }                                                                                      //
        //                                                                                             //
        /////////////////////////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Include in Private Fields
        /// <summary>
        /// The image
        /// </summary>
        private Image _Image;
        /// <summary>
        /// The image size
        /// </summary>
        private Size _ImageSize;
        /// <summary>
        /// The image align
        /// </summary>
        private ContentAlignment _ImageAlign = ContentAlignment.MiddleCenter;
        /// <summary>
        /// The text alignment
        /// </summary>
        private StringAlignment _TextAlignment = StringAlignment.Center;
        /// <summary>
        /// The show text
        /// </summary>
        private bool showText = true;
        #endregion

        #region Include in Public Properties
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        public Image Image
        {
            get { return _Image; }
            set
            {
                if (value == null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets the size of the image.
        /// </summary>
        /// <value>The size of the image.</value>
        public Size ImageSize
        {
            get { return _ImageSize; }
            set
            {
                _ImageSize = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the image align.
        /// </summary>
        /// <value>The image align.</value>
        public ContentAlignment ImageAlign
        {
            get { return _ImageAlign; }
            set
            {
                _ImageAlign = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show text].
        /// </summary>
        /// <value><c>true</c> if [show text]; otherwise, <c>false</c>.</value>
        public bool ShowText
        {
            get { return showText; }
            set
            {
                showText = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the text align.
        /// </summary>
        /// <value>The text align.</value>
        public StringAlignment TextAlign
        {
            get { return _TextAlignment; }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }


        #endregion

        #region Include in Private Methods
        /// <summary>
        /// Images the location.
        /// </summary>
        /// <param name="SF">The sf.</param>
        /// <param name="Area">The area.</param>
        /// <param name="ImageArea">The image area.</param>
        /// <returns>PointF.</returns>
        private static PointF ImageLocation(StringFormat SF, SizeF Area, SizeF ImageArea)
        {
            PointF MyPoint = default(PointF);
            switch (SF.Alignment)
            {
                case StringAlignment.Center:
                    MyPoint.X = Convert.ToSingle((Area.Width - ImageArea.Width) / 2);
                    break;
                case StringAlignment.Near:
                    MyPoint.X = 2;
                    break;
                case StringAlignment.Far:
                    MyPoint.X = Area.Width - ImageArea.Width - 2;
                    break;
            }

            switch (SF.LineAlignment)
            {
                case StringAlignment.Center:
                    MyPoint.Y = Convert.ToSingle((Area.Height - ImageArea.Height) / 2);
                    break;
                case StringAlignment.Near:
                    MyPoint.Y = 2;
                    break;
                case StringAlignment.Far:
                    MyPoint.Y = Area.Height - ImageArea.Height - 2;
                    break;
            }
            return MyPoint;
        }

        /// <summary>
        /// Gets the string format.
        /// </summary>
        /// <param name="_ContentAlignment">The content alignment.</param>
        /// <returns>StringFormat.</returns>
        private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
        {
            StringFormat SF = new StringFormat();
            switch (_ContentAlignment)
            {
                case ContentAlignment.MiddleCenter:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleLeft:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleRight:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.TopCenter:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.TopLeft:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.BottomRight:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Far;
                    break;
            }
            return SF;
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="R1">The r1.</param>
        private void DrawImage(Graphics G, Rectangle R1)
        {
            //Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          
            G.SmoothingMode = SmoothingMode.HighQuality;

            PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);

            if ((Image == null))
            {
                if (ShowText)
                    G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                    {
                        Alignment = _TextAlignment,
                        LineAlignment = StringAlignment.Center

                    });
            }
            else
            {
                G.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);

                if (ShowText)
                    G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                    {
                        Alignment = _TextAlignment,
                        LineAlignment = StringAlignment.Center
                    });
            }

        }


        #endregion
        #endregion





        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitUniversalControl"/> class.
        /// </summary>
        public ZeroitUniversalControl()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            locate = new Point(Location.X, Location.Y);
            ClickTimer.Tick += ClickTimer_Tick;
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {

        }

        #region Hatch Animation

        /// <summary>
        /// The enable hatch animation
        /// </summary>
        private bool enableHatchAnimation = true;

        /// <summary>
        /// Gets or sets a value indicating whether [enable hatch animation].
        /// </summary>
        /// <value><c>true</c> if [enable hatch animation]; otherwise, <c>false</c>.</value>
        public bool EnableHatchAnimation
        {
            get { return enableHatchAnimation; }
            set { enableHatchAnimation = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the hatch speed.
        /// </summary>
        /// <value>The hatch speed.</value>
        public int HatchSpeed
        {
            get { return hatchSpeed; }
            set
            {
                hatchSpeed = value;
                Invalidate();
            }
        }



        //---------------------------Include in Paint--------------------//
        //                                                               //
        //        G.RenderingOrigin = new Point(reactorOFS, 0);          //
        //                                                               //
        //---------------------------Include in Paint--------------------//

        /// <summary>
        /// The reactor ofs
        /// </summary>
        private int reactorOFS = 20;
        /// <summary>
        /// The hatch speed
        /// </summary>
        private int hatchSpeed = 50;

        /// <summary>
        /// Reactors the create handle.
        /// </summary>
        private void ReactorCreateHandle()
        {
            
            if (EnableHatchAnimation)
            {
                // Dim tmr As New Timer With {.Interval = hatchSpeed}
                // AddHandler tmr.Tick, AddressOf ReactorAnimate
                // tmr.Start()
                System.Threading.Thread T = new System.Threading.Thread(ReactorAnimate);
                T.IsBackground = true;
                T.Start();
            }
            
        }

        /// <summary>
        /// Reactors the animate.
        /// </summary>
        public void ReactorAnimate()
        {
            while (true)
            {
                if (reactorOFS <= Width)
                {
                    reactorOFS += 1;
                }
                else
                {
                    reactorOFS = 0;
                }
                Invalidate();
                System.Threading.Thread.Sleep(hatchSpeed);
            }
        }


        #endregion




        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs" /> instance containing the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void PaintHook(PaintEventArgs e)
        {

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;

            G.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0 + Convert.ToInt32(Border.Width), 0 + Convert.ToInt32(Border.Width), Width - Convert.ToInt32(Border.Width) * 2, Height - Convert.ToInt32(Border.Width) * 2);
            
            GraphicsPath shape = Draw.RoundRect(rect, Curves.UpperLeft, Curves.UpperRight, Curves.DownLeft, Curves.DownRight);

            if (EnableHatchAnimation)
            {
                G.RenderingOrigin = new Point(reactorOFS, 0);
            }

            switch (ControlType)
            {
                case ControlTypes.Polygon:
                    G.FillPolygon(Fill.GetBrush(rect), Polygon.Points);
                    G.DrawPolygon(Border.GetPen(), Polygon.Points);
                    break;
                case ControlTypes.Rectangle:
                    G.FillPath(Fill.GetBrush(rect), shape);
                    G.FillPath(Fill.GetBrush(rect), shape);
                    G.DrawPath(Border.GetPen(), shape);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }



            //if (TextShadow)
            //{
            //    CenterString(G, Text, Font, Color.Black, rect);
            //}

            //CenterString(G, Text, Font, ForeColor, new Rectangle(2 + Convert.ToInt32(Border.Width), 2 + Convert.ToInt32(Border.Width), Width - 4 - Convert.ToInt32(Border.Width) * 2, Height - 4 - Convert.ToInt32(Border.Width) * 2));

            DrawImage(G, ClientRectangle);

            e.Graphics.DrawImage(B, 0, 0);
            G.Dispose();
            B.Dispose();
        }

        /// <summary>
        /// Creates a handle for the control.
        /// </summary>
        protected override void CreateHandle()
        {
            base.CreateHandle();

            ReactorCreateHandle();
        }





        #region Click Animation
        //--------------------------------Include in Constructor---------------------------//
        //locate = new Point(Location.X, Location.Y);
        //AnimationTimer.Tick += new EventHandler(AnimationTick);
        //ClickTimer.Tick += ClickTimer_Tick;
        //--------------------------------Include in Constructor---------------------------//

        #region Fields
        /// <summary>
        /// The xx
        /// </summary>
        int xx;
        /// <summary>
        /// The yy
        /// </summary>
        int yy;
        /// <summary>
        /// The locate
        /// </summary>
        private Point locate;
        /// <summary>
        /// The click timer
        /// </summary>
        Timer ClickTimer = new Timer();
        /// <summary>
        /// The allow click animation
        /// </summary>
        private bool allowClickAnimation = true;
        /// <summary>
        /// The clickinterval
        /// </summary>
        private int clickinterval = 10;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the click speed.
        /// </summary>
        /// <value>The click speed.</value>
        public int ClickSpeed
        {
            get { return clickinterval; }
            set
            {
                ClickTimer.Interval = value;
                clickinterval = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [allow click animation].
        /// </summary>
        /// <value><c>true</c> if [allow click animation]; otherwise, <c>false</c>.</value>
        public bool AllowClickAnimation
        {
            get { return allowClickAnimation; }
            set { allowClickAnimation = value; }
        }



        #endregion

        #region Events

        /// <summary>
        /// Handles the Tick event of the ClickTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClickTimer_Tick(object sender, EventArgs e)
        {

            if (State == MouseState.Down)
            {
                this.Location = new Point(Location.X, Location.Y + 1);
                //this.Location = new Point(Location.X, Location.Y - 10);
            }
            else
            {
                this.Location = locate;
            }

            if (Location.Y > locate.Y + 10)
            {
                this.Location = locate;
                ClickTimer.Stop();
            }

            Invalidate();

        }


        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            State = MouseState.Down;

            locate = new Point(Location.X, Location.Y);
            
            xx = e.X;
            yy = e.Y;
            

            ClickTimer.Start();


            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            State = MouseState.None;

            
            if (allowClickAnimation)
            {
                ClickTimer.Start();
            }

            Invalidate();
        }

        #endregion

        #endregion


        /// <summary>
        /// Center String
        /// </summary>
        /// <param name="G">Set Graphics</param>
        /// <param name="T">Set string</param>
        /// <param name="F">Set Font</param>
        /// <param name="C">Set color</param>
        /// <param name="R">Set rectangle</param>
        public static void CenterString(System.Drawing.Graphics G, string T, Font F, Color C, Rectangle R)
        {
            SizeF TS = G.MeasureString(T, F);

            using (SolidBrush B = new SolidBrush(C))
            {
                G.DrawString(T, F, B, new Point((int)(R.Width / 2 - (TS.Width / 2)), (int)(R.Height / 2 - (TS.Height / 2))));
            }
        }



    }

    /// <summary>
    /// Class Curves.
    /// </summary>
    public class Curves
    {
        /// <summary>
        /// The upper left
        /// </summary>
        private int upperLeft = 10;
        /// <summary>
        /// The upper right
        /// </summary>
        private int upperRight = 10;
        /// <summary>
        /// Down left
        /// </summary>
        private int downLeft = 10;
        /// <summary>
        /// Down right
        /// </summary>
        private int downRight = 10;
        /// <summary>
        /// Gets or sets the upper left.
        /// </summary>
        /// <value>The upper left.</value>
        [DefaultValue(10)]
        public int UpperLeft
        {
            get { return upperLeft;}
            set
            {
                upperLeft = value;
            }
        }

        /// <summary>
        /// Gets or sets the upper right.
        /// </summary>
        /// <value>The upper right.</value>
        [DefaultValue(10)]
        public int UpperRight
        {
            get { return upperRight; }
            set
            {
                upperRight = value;
            }
        }

        /// <summary>
        /// Gets or sets down left.
        /// </summary>
        /// <value>Down left.</value>
        [DefaultValue(10)]
        public int DownLeft
        {
            get { return downLeft; }
            set
            {
                downLeft = value;
            }
        }

        /// <summary>
        /// Gets or sets down right.
        /// </summary>
        /// <value>Down right.</value>
        [DefaultValue(10)]
        public int DownRight
        {
            get { return downRight; }
            set
            {
                downRight = value;
            }
        }
    }
}
