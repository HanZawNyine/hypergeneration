using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FlatUI
{
    public class FlatAlertBox : Control
    {
        /// <summary>
        /// How to use: FlatAlertBox.ShowControl(Kind, String, Interval)
        /// </summary>
        /// <remarks></remarks>

        private int W;
        private int H;
        private _Kind K;
        private string _Text;
        private MouseState State = MouseState.None;
        private int X;
        private Timer withEventsField_T;
        private Timer T
        {
            get { return withEventsField_T; }
            set
            {
                if (withEventsField_T != null)
                {
                    withEventsField_T.Tick -= T_Tick;
                }
                withEventsField_T = value;
                if (withEventsField_T != null)
                {
                    withEventsField_T.Tick += T_Tick;
                }
            }

        }

        [Flags()]
        public enum _Kind
        {
            Success,
            Error,
            Info
        }

        [Category("Options")]
        public _Kind kind
        {
            get { return K; }
            set { K = value; }
        }

        [Category("Options")]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                if (_Text != null)
                {
                    _Text = value;
                }
            }
        }

        [Category("Options")]
        public new bool Visible
        {
            get { return base.Visible == false; }
            set { base.Visible = value; }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 42;
        }

        public void ShowControl(_Kind Kind, string Str, int Interval)
        {
            K = Kind;
            Text = Str;
            this.Visible = true;
            T = new Timer();
            T.Interval = Interval;
            T.Enabled = true;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
            T.Enabled = false;
            T.Dispose();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            X = e.X;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.Visible = false;
        }

        private Color SuccessColor = Color.FromArgb(60, 85, 79);
        private Color SuccessText = Color.FromArgb(35, 169, 110);
        private Color ErrorColor = Color.FromArgb(87, 71, 71);
        private Color ErrorText = Color.FromArgb(254, 142, 122);
        private Color InfoColor = Color.FromArgb(70, 91, 94);
        private Color InfoText = Color.FromArgb(97, 185, 186);

        public FlatAlertBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.FromArgb(60, 70, 73);
            Size = new Size(576, 42);
            Location = new Point(10, 61);
            Font = new Font("Segoe UI", 10);
            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            Rectangle Base = new Rectangle(0, 0, W, H);

            var _with14 = G;
            _with14.SmoothingMode = SmoothingMode.HighQuality;
            _with14.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with14.Clear(BackColor);

            switch (K)
            {
                case _Kind.Success:
                    //-- Base
                    _with14.FillRectangle(new SolidBrush(SuccessColor), Base);

                    //-- Ellipse
                    _with14.FillEllipse(new SolidBrush(SuccessText), new Rectangle(8, 9, 24, 24));
                    _with14.FillEllipse(new SolidBrush(SuccessColor), new Rectangle(10, 11, 20, 20));

                    //-- Checked Sign
                    _with14.DrawString("ü", new Font("Wingdings", 22), new SolidBrush(SuccessText), new Rectangle(7, 7, W, H), Helpers.NearSF);
                    _with14.DrawString(Text, Font, new SolidBrush(SuccessText), new Rectangle(48, 12, W, H), Helpers.NearSF);

                    //-- X button
                    _with14.FillEllipse(new SolidBrush(Color.FromArgb(35, Color.Black)), new Rectangle(W - 30, H - 29, 17, 17));
                    _with14.DrawString("r", new Font("Marlett", 8), new SolidBrush(SuccessColor), new Rectangle(W - 28, 16, W, H), Helpers.NearSF);

                    switch (State)
                    {
                        // -- Mouse Over
                        case MouseState.Over:
                            _with14.DrawString("r", new Font("Marlett", 8), new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(W - 28, 16, W, H), Helpers.NearSF);
                            break;
                    }

                    break;
                case _Kind.Error:
                    //-- Base
                    _with14.FillRectangle(new SolidBrush(ErrorColor), Base);

                    //-- Ellipse
                    _with14.FillEllipse(new SolidBrush(ErrorText), new Rectangle(8, 9, 24, 24));
                    _with14.FillEllipse(new SolidBrush(ErrorColor), new Rectangle(10, 11, 20, 20));

                    //-- X Sign
                    _with14.DrawString("r", new Font("Marlett", 16), new SolidBrush(ErrorText), new Rectangle(6, 11, W, H), Helpers.NearSF);
                    _with14.DrawString(Text, Font, new SolidBrush(ErrorText), new Rectangle(48, 12, W, H), Helpers.NearSF);

                    //-- X button
                    _with14.FillEllipse(new SolidBrush(Color.FromArgb(35, Color.Black)), new Rectangle(W - 32, H - 29, 17, 17));
                    _with14.DrawString("r", new Font("Marlett", 8), new SolidBrush(ErrorColor), new Rectangle(W - 30, 17, W, H), Helpers.NearSF);

                    switch (State)
                    {
                        case MouseState.Over:
                            // -- Mouse Over
                            _with14.DrawString("r", new Font("Marlett", 8), new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(W - 30, 15, W, H), Helpers.NearSF);
                            break;
                    }

                    break;
                case _Kind.Info:
                    //-- Base
                    _with14.FillRectangle(new SolidBrush(InfoColor), Base);

                    //-- Ellipse
                    _with14.FillEllipse(new SolidBrush(InfoText), new Rectangle(8, 9, 24, 24));
                    _with14.FillEllipse(new SolidBrush(InfoColor), new Rectangle(10, 11, 20, 20));

                    //-- Info Sign
                    _with14.DrawString("¡", new Font("Segoe UI", 20, FontStyle.Bold), new SolidBrush(InfoText), new Rectangle(12, -4, W, H), Helpers.NearSF);
                    _with14.DrawString(Text, Font, new SolidBrush(InfoText), new Rectangle(48, 12, W, H), Helpers.NearSF);

                    //-- X button
                    _with14.FillEllipse(new SolidBrush(Color.FromArgb(35, Color.Black)), new Rectangle(W - 32, H - 29, 17, 17));
                    _with14.DrawString("r", new Font("Marlett", 8), new SolidBrush(InfoColor), new Rectangle(W - 30, 17, W, H), Helpers.NearSF);

                    switch (State)
                    {
                        case MouseState.Over:
                            // -- Mouse Over
                            _with14.DrawString("r", new Font("Marlett", 8), new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(W - 30, 17, W, H), Helpers.NearSF);
                            break;
                    }
                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}
namespace FlatUI
{
    public class FlatButton : Control
    {
        private int W;
        private int H;
        private bool _Rounded = false;
        private MouseState State = MouseState.None;

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        [Category("Options")]
        public bool Rounded
        {
            get { return _Rounded; }
            set { _Rounded = value; }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        private Color _BaseColor = Helpers.FlatColor;
        private Color _TextColor = Color.FromArgb(243, 243, 243);

        public FlatButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(106, 32);
            BackColor = Color.Transparent;
            Font = new Font("Segoe UI", 12);
            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            GraphicsPath GP = new GraphicsPath();
            Rectangle Base = new Rectangle(0, 0, W, H);

            var _with8 = G;
            _with8.SmoothingMode = SmoothingMode.HighQuality;
            _with8.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with8.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with8.Clear(BackColor);

            switch (State)
            {
                case MouseState.None:
                    if (Rounded)
                    {
                        //-- Base
                        GP = Helpers.RoundRec(Base, 6);
                        _with8.FillPath(new SolidBrush(_BaseColor), GP);

                        //-- Text
                        _with8.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    else
                    {
                        //-- Base
                        _with8.FillRectangle(new SolidBrush(_BaseColor), Base);

                        //-- Text
                        _with8.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    break;
                case MouseState.Over:
                    if (Rounded)
                    {
                        //-- Base
                        GP = Helpers.RoundRec(Base, 6);
                        _with8.FillPath(new SolidBrush(_BaseColor), GP);
                        _with8.FillPath(new SolidBrush(Color.FromArgb(20, Color.White)), GP);

                        //-- Text
                        _with8.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    else
                    {
                        //-- Base
                        _with8.FillRectangle(new SolidBrush(_BaseColor), Base);
                        _with8.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), Base);

                        //-- Text
                        _with8.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    break;
                case MouseState.Down:
                    if (Rounded)
                    {
                        //-- Base
                        GP = Helpers.RoundRec(Base, 6);
                        _with8.FillPath(new SolidBrush(_BaseColor), GP);
                        _with8.FillPath(new SolidBrush(Color.FromArgb(20, Color.Black)), GP);

                        //-- Text
                        _with8.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    else
                    {
                        //-- Base
                        _with8.FillRectangle(new SolidBrush(_BaseColor), Base);
                        _with8.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Black)), Base);

                        //-- Text
                        _with8.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _BaseColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    [DefaultEvent("CheckedChanged")]
    public class FlatCheckBox : Control
    {
        private int W;
        private int H;
        private MouseState State = MouseState.None;
        private _Options O;
        private bool _Checked;

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        public bool Checked
        {
            get { return _Checked; }
            set
            {
                _Checked = value;
                Invalidate();
            }
        }

        public event CheckedChangedEventHandler CheckedChanged;
        public delegate void CheckedChangedEventHandler(object sender);
        protected override void OnClick(System.EventArgs e)
        {
            _Checked = !_Checked;
            if (CheckedChanged != null)
            {
                CheckedChanged(this);
            }
            base.OnClick(e);
        }

        [Flags()]
        public enum _Options
        {
            Style1,
            Style2
        }

        [Category("Options")]
        public _Options Options
        {
            get { return O; }
            set { O = value; }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 22;
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color BorderColor
        {
            get { return _BorderColor; }
            set { _BorderColor = value; }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _TextColor = Color.FromArgb(243, 243, 243);
        private Color _BorderColor = Helpers.FlatColor;

        public FlatCheckBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.FromArgb(60, 70, 73);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10);
            Size = new Size(112, 22);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            Rectangle Base = new Rectangle(0, 2, Height - 5, Height - 5);

            var _with11 = G;
            _with11.SmoothingMode = SmoothingMode.HighQuality;
            _with11.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with11.Clear(BackColor);
            switch (O)
            {
                case _Options.Style1:
                    //-- Style 1
                    //-- Base
                    _with11.FillRectangle(new SolidBrush(_BaseColor), Base);

                    switch (State)
                    {
                        case MouseState.Over:
                            //-- Base
                            _with11.DrawRectangle(new Pen(_BorderColor), Base);
                            break;
                        case MouseState.Down:
                            //-- Base
                            _with11.DrawRectangle(new Pen(_BorderColor), Base);
                            break;
                    }

                    //-- If Checked
                    if (Checked)
                    {
                        _with11.DrawString("ü", new Font("Wingdings", 18), new SolidBrush(_BorderColor), new Rectangle(5, 7, H - 9, H - 9), Helpers.CenterSF);
                    }

                    //-- If Enabled
                    if (this.Enabled == false)
                    {
                        _with11.FillRectangle(new SolidBrush(Color.FromArgb(54, 58, 61)), Base);
                        _with11.DrawString(Text, Font, new SolidBrush(Color.FromArgb(140, 142, 143)), new Rectangle(20, 2, W, H), Helpers.NearSF);
                    }

                    //-- Text
                    _with11.DrawString(Text, Font, new SolidBrush(_TextColor), new Rectangle(20, 2, W, H), Helpers.NearSF);
                    break;
                case _Options.Style2:
                    //-- Style 2
                    //-- Base
                    _with11.FillRectangle(new SolidBrush(_BaseColor), Base);

                    switch (State)
                    {
                        case MouseState.Over:
                            //-- Base
                            _with11.DrawRectangle(new Pen(_BorderColor), Base);
                            _with11.FillRectangle(new SolidBrush(Color.FromArgb(118, 213, 170)), Base);
                            break;
                        case MouseState.Down:
                            //-- Base
                            _with11.DrawRectangle(new Pen(_BorderColor), Base);
                            _with11.FillRectangle(new SolidBrush(Color.FromArgb(118, 213, 170)), Base);
                            break;
                    }

                    //-- If Checked
                    if (Checked)
                    {
                        _with11.DrawString("ü", new Font("Wingdings", 18), new SolidBrush(_BorderColor), new Rectangle(5, 7, H - 9, H - 9), Helpers.CenterSF);
                    }

                    //-- If Enabled
                    if (this.Enabled == false)
                    {
                        _with11.FillRectangle(new SolidBrush(Color.FromArgb(54, 58, 61)), Base);
                        _with11.DrawString(Text, Font, new SolidBrush(Color.FromArgb(48, 119, 91)), new Rectangle(20, 2, W, H), Helpers.NearSF);
                    }

                    //-- Text
                    _with11.DrawString(Text, Font, new SolidBrush(_TextColor), new Rectangle(20, 2, W, H), Helpers.NearSF);
                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _BorderColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    public class FlatClose : Control
    {
        private MouseState State = MouseState.None;
        private int x;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            x = e.X;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Environment.Exit(0);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(18, 18);
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        private Color _BaseColor = Color.FromArgb(168, 35, 35);
        private Color _TextColor = Color.FromArgb(243, 243, 243);

        public FlatClose()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.White;
            Size = new Size(18, 18);
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Font = new Font("Marlett", 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            Rectangle Base = new Rectangle(0, 0, Width, Height);

            var _with3 = G;
            _with3.SmoothingMode = SmoothingMode.HighQuality;
            _with3.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with3.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with3.Clear(BackColor);

            //-- Base
            _with3.FillRectangle(new SolidBrush(_BaseColor), Base);

            //-- X
            _with3.DrawString("r", Font, new SolidBrush(TextColor), new Rectangle(0, 0, Width, Height), Helpers.CenterSF);

            //-- Hover/down
            switch (State)
            {
                case MouseState.Over:
                    _with3.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.White)), Base);
                    break;
                case MouseState.Down:
                    _with3.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), Base);
                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}
namespace FlatUI
{
    public class FlatColorPalette : Control
    {
        private int W;
        private int H;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Width = 180;
            Height = 80;
        }

        [Category("Colors")]
        public Color Red
        {
            get { return _Red; }
            set { _Red = value; }
        }

        [Category("Colors")]
        public Color Cyan
        {
            get { return _Cyan; }
            set { _Cyan = value; }
        }

        [Category("Colors")]
        public Color Blue
        {
            get { return _Blue; }
            set { _Blue = value; }
        }

        [Category("Colors")]
        public Color LimeGreen
        {
            get { return _LimeGreen; }
            set { _LimeGreen = value; }
        }

        [Category("Colors")]
        public Color Orange
        {
            get { return _Orange; }
            set { _Orange = value; }
        }

        [Category("Colors")]
        public Color Purple
        {
            get { return _Purple; }
            set { _Purple = value; }
        }

        [Category("Colors")]
        public Color Black
        {
            get { return _Black; }
            set { _Black = value; }
        }

        [Category("Colors")]
        public Color Gray
        {
            get { return _Gray; }
            set { _Gray = value; }
        }

        [Category("Colors")]
        public Color White
        {
            get { return _White; }
            set { _White = value; }
        }

        private Color _Red = Color.FromArgb(220, 85, 96);
        private Color _Cyan = Color.FromArgb(10, 154, 157);
        private Color _Blue = Color.FromArgb(0, 128, 255);
        private Color _LimeGreen = Color.FromArgb(35, 168, 109);
        private Color _Orange = Color.FromArgb(253, 181, 63);
        private Color _Purple = Color.FromArgb(155, 88, 181);
        private Color _Black = Color.FromArgb(45, 47, 49);
        private Color _Gray = Color.FromArgb(63, 70, 73);
        private Color _White = Color.FromArgb(243, 243, 243);

        public FlatColorPalette()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.FromArgb(60, 70, 73);
            Size = new Size(160, 80);
            Font = new Font("Segoe UI", 12);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            var _with6 = G;
            _with6.SmoothingMode = SmoothingMode.HighQuality;
            _with6.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with6.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with6.Clear(BackColor);

            //-- Colors 
            _with6.FillRectangle(new SolidBrush(_Red), new Rectangle(0, 0, 20, 40));
            _with6.FillRectangle(new SolidBrush(_Cyan), new Rectangle(20, 0, 20, 40));
            _with6.FillRectangle(new SolidBrush(_Blue), new Rectangle(40, 0, 20, 40));
            _with6.FillRectangle(new SolidBrush(_LimeGreen), new Rectangle(60, 0, 20, 40));
            _with6.FillRectangle(new SolidBrush(_Orange), new Rectangle(80, 0, 20, 40));
            _with6.FillRectangle(new SolidBrush(_Purple), new Rectangle(100, 0, 20, 40));
            _with6.FillRectangle(new SolidBrush(_Black), new Rectangle(120, 0, 20, 40));
            _with6.FillRectangle(new SolidBrush(_Gray), new Rectangle(140, 0, 20, 40));
            _with6.FillRectangle(new SolidBrush(_White), new Rectangle(160, 0, 20, 40));

            //-- Text
            _with6.DrawString("Color Palette", Font, new SolidBrush(_White), new Rectangle(0, 22, W, H), Helpers.CenterSF);

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}
namespace FlatUI
{
    public class FlatColors
    {
        public Color Flat = Helpers.FlatColor;
    }
}
namespace FlatUI
{
    public class FlatComboBox : ComboBox
    {
        private int W;
        private int H;
        private int _StartIndex = 0;
        private int x;
        private int y;

        private MouseState State = MouseState.None;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            x = e.Location.X;
            y = e.Location.Y;
            Invalidate();
            if (e.X < Width - 41)
                Cursor = Cursors.IBeam;
            else
                Cursor = Cursors.Hand;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            Invalidate();
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                Invalidate();
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Invalidate();
        }

        [Category("Colors")]
        public Color HoverColor
        {
            get { return _HoverColor; }
            set { _HoverColor = value; }
        }

        private int StartIndex
        {
            get { return _StartIndex; }
            set
            {
                _StartIndex = value;
                try
                {
                    base.SelectedIndex = value;
                }
                catch
                {
                }
                Invalidate();
            }
        }

        public void DrawItem_(System.Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            e.DrawBackground();
            e.DrawFocusRectangle();

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                //-- Selected item
                e.Graphics.FillRectangle(new SolidBrush(_HoverColor), e.Bounds);
            }
            else
            {
                //-- Not Selected
                e.Graphics.FillRectangle(new SolidBrush(_BaseColor), e.Bounds);
            }

            //-- Text
            e.Graphics.DrawString(base.GetItemText(base.Items[e.Index]), new Font("Segoe UI", 8), Brushes.White, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height));


            e.Graphics.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 18;
        }

        private Color _BaseColor = Color.FromArgb(25, 27, 29);
        private Color _BGColor = Color.FromArgb(45, 47, 49);
        private Color _HoverColor = Color.FromArgb(35, 168, 109);

        public FlatComboBox()
        {
            DrawItem += DrawItem_;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;

            DrawMode = DrawMode.OwnerDrawFixed;
            BackColor = Color.FromArgb(45, 45, 48);
            ForeColor = Color.White;
            DropDownStyle = ComboBoxStyle.DropDownList;
            Cursor = Cursors.Hand;
            StartIndex = 0;
            ItemHeight = 18;
            Font = new Font("Segoe UI", 8, FontStyle.Regular);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width;
            H = Height;

            Rectangle Base = new Rectangle(0, 0, W, H);
            Rectangle Button = new Rectangle(Convert.ToInt32(W - 40), 0, W, H);
            GraphicsPath GP = new GraphicsPath();
            GraphicsPath GP2 = new GraphicsPath();

            var _with16 = G;
            _with16.Clear(Color.FromArgb(45, 45, 48));
            _with16.SmoothingMode = SmoothingMode.HighQuality;
            _with16.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with16.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            //-- Base
            _with16.FillRectangle(new SolidBrush(_BGColor), Base);

            //-- Button
            GP.Reset();
            GP.AddRectangle(Button);
            _with16.SetClip(GP);
            _with16.FillRectangle(new SolidBrush(_BaseColor), Button);
            _with16.ResetClip();

            //-- Lines
            _with16.DrawLine(Pens.White, W - 10, 6, W - 30, 6);
            _with16.DrawLine(Pens.White, W - 10, 12, W - 30, 12);
            _with16.DrawLine(Pens.White, W - 10, 18, W - 30, 18);

            //-- Text
            _with16.DrawString(Text, Font, Brushes.White, new Point(4, 6), Helpers.NearSF);

            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}
namespace FlatUI
{
    public class FlatContextMenuStrip : ContextMenuStrip
    {
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        public FlatContextMenuStrip()
            : base()
        {
            Renderer = new ToolStripProfessionalRenderer(new TColorTable());
            ShowImageMargin = false;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 8);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        }

        public class TColorTable : ProfessionalColorTable
        {
            [Category("Colors")]
            public Color _BackColor
            {
                get { return BackColor; }
                set { BackColor = value; }
            }

            [Category("Colors")]
            public Color _CheckedColor
            {
                get { return CheckedColor; }
                set { CheckedColor = value; }
            }

            [Category("Colors")]
            public Color _BorderColor
            {
                get { return BorderColor; }
                set { BorderColor = value; }
            }

            private Color BackColor = Color.FromArgb(45, 47, 49);
            private Color CheckedColor = Helpers.FlatColor;
            private Color BorderColor = Color.FromArgb(53, 58, 60);

            public override Color ButtonSelectedBorder
            {
                get { return BackColor; }
            }

            public override Color CheckBackground
            {
                get { return CheckedColor; }
            }

            public override Color CheckPressedBackground
            {
                get { return CheckedColor; }
            }

            public override Color CheckSelectedBackground
            {
                get { return CheckedColor; }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return CheckedColor; }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return CheckedColor; }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return CheckedColor; }
            }

            public override Color MenuBorder
            {
                get { return BorderColor; }
            }

            public override Color MenuItemBorder
            {
                get { return BorderColor; }
            }

            public override Color MenuItemSelected
            {
                get { return CheckedColor; }
            }

            public override Color SeparatorDark
            {
                get { return BorderColor; }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return BackColor; }
            }
        }
    }
}
namespace FlatUI
{
    public class FlatGroupBox : ContainerControl
    {
        private int W;
        private int H;
        private bool _ShowText = true;

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        public bool ShowText
        {
            get { return _ShowText; }
            set { _ShowText = value; }
        }

        private Color _BaseColor = Color.FromArgb(60, 70, 73);
        private Color _TextColor = Helpers.FlatColor;

        public FlatGroupBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            BackColor = Color.Transparent;
            Size = new Size(240, 180);
            Font = new Font("Segoe ui", 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            GraphicsPath GP = new GraphicsPath();
            GraphicsPath GP2 = new GraphicsPath();
            GraphicsPath GP3 = new GraphicsPath();
            Rectangle Base = new Rectangle(8, 8, W - 16, H - 16);

            var _with7 = G;
            _with7.SmoothingMode = SmoothingMode.HighQuality;
            _with7.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with7.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with7.Clear(BackColor);

            //-- Base
            GP = Helpers.RoundRec(Base, 8);
            _with7.FillPath(new SolidBrush(_BaseColor), GP);

            //-- Arrows
            GP2 = Helpers.DrawArrow(28, 2, false);
            _with7.FillPath(new SolidBrush(_BaseColor), GP2);
            GP3 = Helpers.DrawArrow(28, 8, true);
            _with7.FillPath(new SolidBrush(Color.FromArgb(60, 70, 73)), GP3);

            //-- if ShowText
            if (ShowText)
            {
                _with7.DrawString(Text, Font, new SolidBrush(_TextColor), new Rectangle(16, 16, W, H), Helpers.NearSF);
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _TextColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    public class FlatLabel : Label
    {
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        public FlatLabel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Font = new Font("Segoe UI", 8);
            ForeColor = Color.White;
            BackColor = Color.Transparent;
            Text = Text;
        }
    }
}
namespace FlatUI
{
    public class FlatListBox : Control
    {
        private ListBox withEventsField_ListBx = new ListBox();
        private ListBox ListBx
        {
            get { return withEventsField_ListBx; }
            set
            {
                if (withEventsField_ListBx != null)
                {
                    withEventsField_ListBx.DrawItem -= Drawitem;
                }
                withEventsField_ListBx = value;
                if (withEventsField_ListBx != null)
                {
                    withEventsField_ListBx.DrawItem += Drawitem;
                }
            }
        }

        private string[] _items = { "" };

        [Category("Options")]
        public string[] items
        {
            get { return _items; }
            set
            {
                _items = value;
                ListBx.Items.Clear();
                ListBx.Items.AddRange(value);
                Invalidate();
            }
        }

        [Category("Colors")]
        public Color SelectedColor
        {
            get { return _SelectedColor; }
            set { _SelectedColor = value; }
        }

        public string SelectedItem
        {
            get { return ListBx.SelectedItem.ToString(); }
        }

        public int SelectedIndex
        {
            get
            {
                int functionReturnValue = 0;
                return ListBx.SelectedIndex;
                if (ListBx.SelectedIndex < 0)
                    return functionReturnValue;
                return functionReturnValue;
            }
        }

        public void Clear()
        {
            ListBx.Items.Clear();
        }

        public void ClearSelected()
        {
            for (int i = (ListBx.SelectedItems.Count - 1); i >= 0; i += -1)
            {
                ListBx.Items.Remove(ListBx.SelectedItems[i]);
            }
        }

        public void Drawitem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            e.DrawBackground();
            e.DrawFocusRectangle();

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            //-- if selected
            if (e.State.ToString().IndexOf("Selected,") >= 0)
            {
                //-- Base
                e.Graphics.FillRectangle(new SolidBrush(_SelectedColor), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

                //-- Text
                e.Graphics.DrawString(" " + ListBx.Items[e.Index].ToString(), new Font("Segoe UI", 8), Brushes.White, e.Bounds.X, e.Bounds.Y + 2);
            }
            else
            {
                //-- Base
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(51, 53, 55)), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

                //-- Text 
                e.Graphics.DrawString(" " + ListBx.Items[e.Index].ToString(), new Font("Segoe UI", 8), Brushes.White, e.Bounds.X, e.Bounds.Y + 2);
            }

            e.Graphics.Dispose();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (!Controls.Contains(ListBx))
            {
                Controls.Add(ListBx);
            }
        }

        public void AddRange(object[] items)
        {
            ListBx.Items.Remove("");
            ListBx.Items.AddRange(items);
        }

        public void AddItem(object item)
        {
            ListBx.Items.Remove("");
            ListBx.Items.Add(item);
        }

        private Color BaseColor = Color.FromArgb(45, 47, 49);
        private Color _SelectedColor = Helpers.FlatColor;

        public FlatListBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;

            ListBx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            ListBx.ScrollAlwaysVisible = false;
            ListBx.HorizontalScrollbar = false;
            ListBx.BorderStyle = BorderStyle.None;
            ListBx.BackColor = BaseColor;
            ListBx.ForeColor = Color.White;
            ListBx.Location = new Point(3, 3);
            ListBx.Font = new Font("Segoe UI", 8);
            ListBx.ItemHeight = 20;
            ListBx.Items.Clear();
            ListBx.IntegralHeight = false;

            Size = new Size(131, 101);
            BackColor = BaseColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            Rectangle Base = new Rectangle(0, 0, Width, Height);

            var _with19 = G;
            _with19.SmoothingMode = SmoothingMode.HighQuality;
            _with19.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with19.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with19.Clear(BackColor);

            //-- Size
            ListBx.Size = new Size(Width - 6, Height - 2);

            //-- Base
            _with19.FillRectangle(new SolidBrush(BaseColor), Base);

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _SelectedColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    public class FlatMax : Control
    {
        private MouseState State = MouseState.None;
        private int x;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            x = e.X;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            switch (FindForm().WindowState)
            {
                case FormWindowState.Maximized:
                    FindForm().WindowState = FormWindowState.Normal;
                    break;
                case FormWindowState.Normal:
                    FindForm().WindowState = FormWindowState.Maximized;
                    break;
            }
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(18, 18);
        }

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _TextColor = Color.FromArgb(243, 243, 243);

        public FlatMax()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.White;
            Size = new Size(18, 18);
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Font = new Font("Marlett", 12);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            Rectangle Base = new Rectangle(0, 0, Width, Height);

            var _with4 = G;
            _with4.SmoothingMode = SmoothingMode.HighQuality;
            _with4.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with4.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with4.Clear(BackColor);

            //-- Base
            _with4.FillRectangle(new SolidBrush(_BaseColor), Base);

            //-- Maximize
            if (FindForm().WindowState == FormWindowState.Maximized)
            {
                _with4.DrawString("1", Font, new SolidBrush(TextColor), new Rectangle(1, 1, Width, Height), Helpers.CenterSF);
            }
            else if (FindForm().WindowState == FormWindowState.Normal)
            {
                _with4.DrawString("2", Font, new SolidBrush(TextColor), new Rectangle(1, 1, Width, Height), Helpers.CenterSF);
            }

            //-- Hover/down
            switch (State)
            {
                case MouseState.Over:
                    _with4.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.White)), Base);
                    break;
                case MouseState.Down:
                    _with4.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), Base);
                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}
namespace FlatUI
{
    public class FlatMini : Control
    {
        private MouseState State = MouseState.None;
        private int x;

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            x = e.X;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            switch (FindForm().WindowState)
            {
                case FormWindowState.Normal:
                    FindForm().WindowState = FormWindowState.Minimized;
                    break;
                case FormWindowState.Maximized:
                    FindForm().WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(18, 18);
        }

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _TextColor = Color.FromArgb(243, 243, 243);

        public FlatMini()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.White;
            Size = new Size(18, 18);
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Font = new Font("Marlett", 12);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            Rectangle Base = new Rectangle(0, 0, Width, Height);

            var _with5 = G;
            _with5.SmoothingMode = SmoothingMode.HighQuality;
            _with5.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with5.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with5.Clear(BackColor);

            //-- Base
            _with5.FillRectangle(new SolidBrush(_BaseColor), Base);

            //-- Minimize
            _with5.DrawString("0", Font, new SolidBrush(TextColor), new Rectangle(2, 1, Width, Height), Helpers.CenterSF);

            //-- Hover/down
            switch (State)
            {
                case MouseState.Over:
                    _with5.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.White)), Base);
                    break;
                case MouseState.Down:
                    _with5.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), Base);
                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}
namespace FlatUI
{
    public class FlatNumeric : Control
    {
        private int W;
        private int H;
        private MouseState State = MouseState.None;
        private int x;
        private int y;
        private long _Value;
        private long _Min;
        private long _Max;
        private bool Bool;

        public long Value
        {
            get { return _Value; }
            set
            {
                if (value <= _Max & value >= _Min)
                    _Value = value;
                Invalidate();
            }
        }

        public long Maximum
        {
            get { return _Max; }
            set
            {
                if (value > _Min)
                    _Max = value;
                if (_Value > _Max)
                    _Value = _Max;
                Invalidate();
            }
        }

        public long Minimum
        {
            get { return _Min; }
            set
            {
                if (value < _Max)
                    _Min = value;
                if (_Value < _Min)
                    _Value = Minimum;
                Invalidate();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            x = e.Location.X;
            y = e.Location.Y;
            Invalidate();
            if (e.X < Width - 23)
                Cursor = Cursors.IBeam;
            else
                Cursor = Cursors.Hand;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (x > Width - 21 && x < Width - 3)
            {
                if (y < 15)
                {
                    if ((Value + 1) <= _Max)
                        _Value += 1;
                }
                else
                {
                    if ((Value - 1) >= _Min)
                        _Value -= 1;
                }
            }
            else
            {
                Bool = !Bool;
                Focus();
            }
            Invalidate();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            try
            {
                if (Bool)
                    _Value = Convert.ToInt64(_Value.ToString() + e.KeyChar.ToString());
                if (_Value > _Max)
                    _Value = _Max;
                Invalidate();
            }
            catch
            {
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Back)
            {
                Value = 0;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 30;
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color ButtonColor
        {
            get { return _ButtonColor; }
            set { _ButtonColor = value; }
        }

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _ButtonColor = Helpers.FlatColor;

        public FlatNumeric()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10);
            BackColor = Color.FromArgb(60, 70, 73);
            ForeColor = Color.White;
            _Min = 0;
            _Max = 9999999;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width;
            H = Height;

            Rectangle Base = new Rectangle(0, 0, W, H);

            var _with18 = G;
            _with18.SmoothingMode = SmoothingMode.HighQuality;
            _with18.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with18.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with18.Clear(BackColor);

            //-- Base
            _with18.FillRectangle(new SolidBrush(_BaseColor), Base);
            _with18.FillRectangle(new SolidBrush(_ButtonColor), new Rectangle(Width - 24, 0, 24, H));

            //-- Add
            _with18.DrawString("+", new Font("Segoe UI", 12), Brushes.White, new Point(Width - 12, 8), Helpers.CenterSF);
            //-- Subtract
            _with18.DrawString("-", new Font("Segoe UI", 10, FontStyle.Bold), Brushes.White, new Point(Width - 12, 22), Helpers.CenterSF);

            //-- Text
            _with18.DrawString(Value.ToString(), Font, Brushes.White, new Rectangle(5, 1, W, H), new StringFormat { LineAlignment = StringAlignment.Center });

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _ButtonColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    public class FlatProgressBar : Control
    {
        private int W;
        private int H;
        private int _Value = 0;
        private int _Maximum = 100;
        private bool _Pattern = true;
        private bool _ShowBalloon = true;
        private bool _PercentSign = false;

        [Category("Control")]
        public int Maximum
        {
            get { return _Maximum; }
            set
            {
                if (value < _Value)
                    _Value = value;
                _Maximum = value;
                Invalidate();
            }
        }

        [Category("Control")]
        public int Value
        {
            get
            {
                return _Value;
                /*
                switch (_Value)
                {
                    case 0:
                        return 0;
                        Invalidate();
                        break;
                    default:
                        return _Value;
                        Invalidate();
                        break;
                }
                */
            }
            set
            {
                if (value > _Maximum)
                {
                    value = _Maximum;
                    Invalidate();
                }

                _Value = value;
                Invalidate();
            }
        }

        public bool Pattern
        {
            get { return _Pattern; }
            set { _Pattern = value; }
        }

        public bool ShowBalloon
        {
            get { return _ShowBalloon; }
            set { _ShowBalloon = value; }
        }

        public bool PercentSign
        {
            get { return _PercentSign; }
            set { _PercentSign = value; }
        }

        [Category("Colors")]
        public Color ProgressColor
        {
            get { return _ProgressColor; }
            set { _ProgressColor = value; }
        }

        [Category("Colors")]
        public Color DarkerProgress
        {
            get { return _DarkerProgress; }
            set { _DarkerProgress = value; }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 42;
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
            Height = 42;
        }

        public void Increment(int Amount)
        {
            Value += Amount;
        }

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _ProgressColor = Helpers.FlatColor;
        private Color _DarkerProgress = Color.FromArgb(23, 148, 92);

        public FlatProgressBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.FromArgb(60, 70, 73);
            Height = 42;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            Rectangle Base = new Rectangle(0, 24, W, H);
            GraphicsPath GP = new GraphicsPath();
            GraphicsPath GP2 = new GraphicsPath();
            GraphicsPath GP3 = new GraphicsPath();

            var _with15 = G;
            _with15.SmoothingMode = SmoothingMode.HighQuality;
            _with15.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with15.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with15.Clear(BackColor);

            //-- Progress Value
            //int iValue = Convert.ToInt32(((float)_Value) / ((float)(_Maximum * Width)));
            float percent = ((float)_Value) / ((float)_Maximum);
            int iValue = (int)(percent * ((float)Width));

            switch (Value)
            {
                case 0:
                    //-- Base
                    _with15.FillRectangle(new SolidBrush(_BaseColor), Base);
                    //--Progress
                    _with15.FillRectangle(new SolidBrush(_ProgressColor), new Rectangle(0, 24, iValue - 1, H - 1));
                    break;
                case 100:
                    //-- Base
                    _with15.FillRectangle(new SolidBrush(_BaseColor), Base);
                    //--Progress
                    _with15.FillRectangle(new SolidBrush(_ProgressColor), new Rectangle(0, 24, iValue - 1, H - 1));
                    break;
                default:
                    //-- Base
                    _with15.FillRectangle(new SolidBrush(_BaseColor), Base);

                    //--Progress
                    GP.AddRectangle(new Rectangle(0, 24, iValue - 1, H - 1));
                    _with15.FillPath(new SolidBrush(_ProgressColor), GP);

                    if (_Pattern)
                    {
                        //-- Hatch Brush
                        HatchBrush HB = new HatchBrush(HatchStyle.Plaid, _DarkerProgress, _ProgressColor);
                        _with15.FillRectangle(HB, new Rectangle(0, 24, iValue - 1, H - 1));
                    }

                    if (_ShowBalloon)
                    {
                        //-- Balloon
                        Rectangle Balloon = new Rectangle(iValue - 18, 0, 34, 16);
                        GP2 = Helpers.RoundRec(Balloon, 4);
                        _with15.FillPath(new SolidBrush(_BaseColor), GP2);

                        //-- Arrow
                        GP3 = Helpers.DrawArrow(iValue - 9, 16, true);
                        _with15.FillPath(new SolidBrush(_BaseColor), GP3);

                        //-- Value > You can add "%" > value & "%"
                        string text = (_PercentSign ? Value.ToString() + "%" : Value.ToString());
                        int wOffset = (_PercentSign ? iValue - 15 : iValue - 11);
                        _with15.DrawString(text, new Font("Segoe UI", 10), new SolidBrush(_ProgressColor), new Rectangle(wOffset, -2, W, H), Helpers.NearSF);
                    }

                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _ProgressColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    [DefaultEvent("CheckedChanged")]
    public class FlatRadioButton : Control
    {
        private MouseState State = MouseState.None;
        private int W;
        private int H;
        private _Options O;

        private bool _Checked;
        public bool Checked
        {
            get { return _Checked; }
            set
            {
                _Checked = value;
                InvalidateControls();
                if (CheckedChanged != null)
                {
                    CheckedChanged(this);
                }
                Invalidate();
            }
        }

        public event CheckedChangedEventHandler CheckedChanged;
        public delegate void CheckedChangedEventHandler(object sender);

        protected override void OnClick(EventArgs e)
        {
            if (!_Checked)
                Checked = true;
            base.OnClick(e);
        }

        private void InvalidateControls()
        {
            if (!IsHandleCreated || !_Checked)
                return;
            foreach (Control C in Parent.Controls)
            {
                if (!object.ReferenceEquals(C, this) && C is FlatRadioButton)
                {
                    ((FlatRadioButton)C).Checked = false;
                    Invalidate();
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            InvalidateControls();
        }

        [Flags()]
        public enum _Options
        {
            Style1,
            Style2
        }

        [Category("Options")]
        public _Options Options
        {
            get { return O; }
            set { O = value; }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 22;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _BorderColor = Helpers.FlatColor;
        private Color _TextColor = Color.FromArgb(243, 243, 243);

        public FlatRadioButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Cursor = Cursors.Hand;
            Size = new Size(100, 22);
            BackColor = Color.FromArgb(60, 70, 73);
            Font = new Font("Segoe UI", 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            Rectangle Base = new Rectangle(0, 2, Height - 5, Height - 5);
            Rectangle Dot = new Rectangle(4, 6, H - 12, H - 12);

            var _with10 = G;
            _with10.SmoothingMode = SmoothingMode.HighQuality;
            _with10.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with10.Clear(BackColor);

            switch (O)
            {
                case _Options.Style1:
                    //-- Base
                    _with10.FillEllipse(new SolidBrush(_BaseColor), Base);

                    switch (State)
                    {
                        case MouseState.Over:
                            _with10.DrawEllipse(new Pen(_BorderColor), Base);
                            break;
                        case MouseState.Down:
                            _with10.DrawEllipse(new Pen(_BorderColor), Base);
                            break;
                    }

                    //-- If Checked 
                    if (Checked)
                    {
                        _with10.FillEllipse(new SolidBrush(_BorderColor), Dot);
                    }
                    break;
                case _Options.Style2:
                    //-- Base
                    _with10.FillEllipse(new SolidBrush(_BaseColor), Base);

                    switch (State)
                    {
                        case MouseState.Over:
                            //-- Base
                            _with10.DrawEllipse(new Pen(_BorderColor), Base);
                            _with10.FillEllipse(new SolidBrush(Color.FromArgb(118, 213, 170)), Base);
                            break;
                        case MouseState.Down:
                            //-- Base
                            _with10.DrawEllipse(new Pen(_BorderColor), Base);
                            _with10.FillEllipse(new SolidBrush(Color.FromArgb(118, 213, 170)), Base);
                            break;
                    }

                    //-- If Checked
                    if (Checked)
                    {
                        //-- Base
                        _with10.FillEllipse(new SolidBrush(_BorderColor), Dot);
                    }
                    break;
            }

            _with10.DrawString(Text, Font, new SolidBrush(_TextColor), new Rectangle(20, 2, W, H), Helpers.NearSF);

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _BorderColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    public class FlatStatusBar : Control
    {
        private int W;
        private int H;
        private bool _ShowTimeDate = false;

        protected override void CreateHandle()
        {
            base.CreateHandle();
            Dock = DockStyle.Bottom;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        [Category("Colors")]
        public Color RectColor
        {
            get { return _RectColor; }
            set { _RectColor = value; }
        }

        public bool ShowTimeDate
        {
            get { return _ShowTimeDate; }
            set { _ShowTimeDate = value; }
        }

        public string GetTimeDate()
        {
            return DateTime.Now.Date + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
        }

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _TextColor = Color.White;
        private Color _RectColor = Helpers.FlatColor;

        public FlatStatusBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 8);
            ForeColor = Color.White;
            Size = new Size(Width, 20);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width;
            H = Height;

            Rectangle Base = new Rectangle(0, 0, W, H);

            var _with21 = G;
            _with21.SmoothingMode = SmoothingMode.HighQuality;
            _with21.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with21.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with21.Clear(BaseColor);

            //-- Base
            _with21.FillRectangle(new SolidBrush(BaseColor), Base);

            //-- Text
            _with21.DrawString(Text, Font, Brushes.White, new Rectangle(10, 4, W, H), Helpers.NearSF);

            //-- Rectangle
            _with21.FillRectangle(new SolidBrush(_RectColor), new Rectangle(4, 4, 4, 14));

            //-- TimeDate
            if (ShowTimeDate)
            {
                _with21.DrawString(GetTimeDate(), Font, new SolidBrush(_TextColor), new Rectangle(-4, 2, W, H), new StringFormat
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Center
                });
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _RectColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    public class FlatStickyButton : Control
    {
        private int W;
        private int H;
        private MouseState State = MouseState.None;
        private bool _Rounded = false;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        private bool[] GetConnectedSides()
        {
            bool[] Bool = new bool[4] { false, false, false, false };

            foreach (Control B in Parent.Controls)
            {
                if (B is FlatStickyButton)
                {
                    if (object.ReferenceEquals(B, this) || !Rect.IntersectsWith(Rect))
                        continue;
                    double A = (Math.Atan2(Left - B.Left, Top - B.Top) * 2 / Math.PI);
                    if (A / 1 == A)
                        Bool[(int)A + 1] = true;
                }
            }

            return Bool;
        }

        private Rectangle Rect
        {
            get { return new Rectangle(Left, Top, Width, Height); }
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        [Category("Options")]
        public bool Rounded
        {
            get { return _Rounded; }
            set { _Rounded = value; }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //Height = 32
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            //Size = New Size(112, 32)
        }

        private Color _BaseColor = Helpers.FlatColor;
        private Color _TextColor = Color.FromArgb(243, 243, 243);

        public FlatStickyButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(106, 32);
            BackColor = Color.Transparent;
            Font = new Font("Segoe UI", 12);
            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width;
            H = Height;

            GraphicsPath GP = new GraphicsPath();

            bool[] GCS = GetConnectedSides();
            // dynamic RoundedBase = Helpers.RoundRect(0, 0, W, H, ???, !(GCS(2) | GCS(1)), !(GCS(1) | GCS(0)), !(GCS(3) | GCS(0)), !(GCS(3) | GCS(2)));
            GraphicsPath RoundedBase = Helpers.RoundRect(0, 0, W, H, 0.3, !(GCS[2] || GCS[1]), !(GCS[1] || GCS[0]), !(GCS[3] || GCS[0]), !(GCS[3] || GCS[2]));
            Rectangle Base = new Rectangle(0, 0, W, H);

            var _with17 = G;
            _with17.SmoothingMode = SmoothingMode.HighQuality;
            _with17.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with17.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with17.Clear(BackColor);

            switch (State)
            {
                case MouseState.None:
                    if (Rounded)
                    {
                        //-- Base
                        GP = RoundedBase;
                        _with17.FillPath(new SolidBrush(_BaseColor), GP);

                        //-- Text
                        _with17.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    else
                    {
                        //-- Base
                        _with17.FillRectangle(new SolidBrush(_BaseColor), Base);

                        //-- Text
                        _with17.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    break;
                case MouseState.Over:
                    if (Rounded)
                    {
                        //-- Base
                        GP = RoundedBase;
                        _with17.FillPath(new SolidBrush(_BaseColor), GP);
                        _with17.FillPath(new SolidBrush(Color.FromArgb(20, Color.White)), GP);

                        //-- Text
                        _with17.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    else
                    {
                        //-- Base
                        _with17.FillRectangle(new SolidBrush(_BaseColor), Base);
                        _with17.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), Base);

                        //-- Text
                        _with17.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    break;
                case MouseState.Down:
                    if (Rounded)
                    {
                        //-- Base
                        GP = RoundedBase;
                        _with17.FillPath(new SolidBrush(_BaseColor), GP);
                        _with17.FillPath(new SolidBrush(Color.FromArgb(20, Color.Black)), GP);

                        //-- Text
                        _with17.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    else
                    {
                        //-- Base
                        _with17.FillRectangle(new SolidBrush(_BaseColor), Base);
                        _with17.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Black)), Base);

                        //-- Text
                        _with17.DrawString(Text, Font, new SolidBrush(_TextColor), Base, Helpers.CenterSF);
                    }
                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _BaseColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    public class FlatTabControl : TabControl
    {
        private int W;
        private int H;

        protected override void CreateHandle()
        {
            base.CreateHandle();
            Alignment = TabAlignment.Top;
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color ActiveColor
        {
            get { return _ActiveColor; }
            set { _ActiveColor = value; }
        }

        private Color BGColor = Color.FromArgb(60, 70, 73);
        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _ActiveColor = Helpers.FlatColor;

        public FlatTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.FromArgb(60, 70, 73);

            Font = new Font("Segoe UI", 10);
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(120, 40);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            var _with13 = G;
            _with13.SmoothingMode = SmoothingMode.HighQuality;
            _with13.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with13.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with13.Clear(_BaseColor);

            try
            {
                SelectedTab.BackColor = BGColor;
            }
            catch
            {
            }

            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle Base = new Rectangle(new Point(GetTabRect(i).Location.X + 2, GetTabRect(i).Location.Y), new Size(GetTabRect(i).Width, GetTabRect(i).Height));
                Rectangle BaseSize = new Rectangle(Base.Location, new Size(Base.Width, Base.Height));

                if (i == SelectedIndex)
                {
                    //-- Base
                    _with13.FillRectangle(new SolidBrush(_BaseColor), BaseSize);

                    //-- Gradiant
                    //.fill
                    _with13.FillRectangle(new SolidBrush(_ActiveColor), BaseSize);

                    //-- ImageList
                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                //-- Image
                                _with13.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(BaseSize.Location.X + 8, BaseSize.Location.Y + 6));
                                //-- Text
                                _with13.DrawString("      " + TabPages[i].Text, Font, Brushes.White, BaseSize, Helpers.CenterSF);
                            }
                            else
                            {
                                //-- Text
                                _with13.DrawString(TabPages[i].Text, Font, Brushes.White, BaseSize, Helpers.CenterSF);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        //-- Text
                        _with13.DrawString(TabPages[i].Text, Font, Brushes.White, BaseSize, Helpers.CenterSF);
                    }
                }
                else
                {
                    //-- Base
                    _with13.FillRectangle(new SolidBrush(_BaseColor), BaseSize);

                    //-- ImageList
                    if (ImageList != null)
                    {
                        try
                        {
                            if (ImageList.Images[TabPages[i].ImageIndex] != null)
                            {
                                //-- Image
                                _with13.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(BaseSize.Location.X + 8, BaseSize.Location.Y + 6));
                                //-- Text
                                _with13.DrawString("      " + TabPages[i].Text, Font, new SolidBrush(Color.White), BaseSize, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                            else
                            {
                                //-- Text
                                _with13.DrawString(TabPages[i].Text, Font, new SolidBrush(Color.White), BaseSize, new StringFormat
                                {
                                    LineAlignment = StringAlignment.Center,
                                    Alignment = StringAlignment.Center
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        //-- Text
                        _with13.DrawString(TabPages[i].Text, Font, new SolidBrush(Color.White), BaseSize, new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Center
                        });
                    }
                }
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _ActiveColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    [DefaultEvent("TextChanged")]
    public class FlatTextBox : Control
    {
        private int W;
        private int H;
        private MouseState State = MouseState.None;
        private System.Windows.Forms.TextBox TB;

        private HorizontalAlignment _TextAlign = HorizontalAlignment.Left;
        [Category("Options")]
        public HorizontalAlignment TextAlign
        {
            get { return _TextAlign; }
            set
            {
                _TextAlign = value;
                if (TB != null)
                {
                    TB.TextAlign = value;
                }
            }
        }

        private int _MaxLength = 32767;
        [Category("Options")]
        public int MaxLength
        {
            get { return _MaxLength; }
            set
            {
                _MaxLength = value;
                if (TB != null)
                {
                    TB.MaxLength = value;
                }
            }
        }

        private bool _ReadOnly;
        [Category("Options")]
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set
            {
                _ReadOnly = value;
                if (TB != null)
                {
                    TB.ReadOnly = value;
                }
            }
        }

        private bool _UseSystemPasswordChar;
        [Category("Options")]
        public bool UseSystemPasswordChar
        {
            get { return _UseSystemPasswordChar; }
            set
            {
                _UseSystemPasswordChar = value;
                if (TB != null)
                {
                    TB.UseSystemPasswordChar = value;
                }
            }
        }

        private bool _Multiline;
        [Category("Options")]
        public bool Multiline
        {
            get { return _Multiline; }
            set
            {
                _Multiline = value;
                if (TB != null)
                {
                    TB.Multiline = value;

                    if (value)
                    {
                        TB.Height = Height - 11;
                    }
                    else
                    {
                        Height = TB.Height + 11;
                    }

                }
            }
        }

        private bool _FocusOnHover = false;
        [Category("Options")]
        public bool FocusOnHover
        {
            get { return _FocusOnHover; }
            set { _FocusOnHover = value; }
        }

        [Category("Options")]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                if (TB != null)
                {
                    TB.Text = value;
                }
            }
        }

        [Category("Options")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                if (TB != null)
                {
                    TB.Font = value;
                    TB.Location = new Point(3, 5);
                    TB.Width = Width - 6;

                    if (!_Multiline)
                    {
                        Height = TB.Height + 11;
                    }
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (!Controls.Contains(TB))
            {
                Controls.Add(TB);
            }
        }

        private void OnBaseTextChanged(object s, EventArgs e)
        {
            Text = TB.Text;
        }

        private void OnBaseKeyDown(object s, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                TB.SelectAll();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                TB.Copy();
                e.SuppressKeyPress = true;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            TB.Location = new Point(5, 5);
            TB.Width = Width - 10;

            if (_Multiline)
            {
                TB.Height = Height - 11;
            }
            else
            {
                Height = TB.Height + 11;
            }

            base.OnResize(e);
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        public override Color ForeColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            TB.Focus();
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            if (FocusOnHover) TB.Focus();
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _TextColor = Color.FromArgb(192, 192, 192);
        private Color _BorderColor = Helpers.FlatColor;

        public FlatTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;

            BackColor = Color.Transparent;

            TB = new System.Windows.Forms.TextBox();
            TB.Font = new Font("Segoe UI", 10);
            TB.Text = Text;
            TB.BackColor = _BaseColor;
            TB.ForeColor = _TextColor;
            TB.MaxLength = _MaxLength;
            TB.Multiline = _Multiline;
            TB.ReadOnly = _ReadOnly;
            TB.UseSystemPasswordChar = _UseSystemPasswordChar;
            TB.BorderStyle = BorderStyle.None;
            TB.Location = new Point(5, 5);
            TB.Width = Width - 10;

            TB.Cursor = Cursors.IBeam;

            if (_Multiline)
            {
                TB.Height = Height - 11;
            }
            else
            {
                Height = TB.Height + 11;
            }

            TB.TextChanged += OnBaseTextChanged;
            TB.KeyDown += OnBaseKeyDown;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            Rectangle Base = new Rectangle(0, 0, W, H);

            var _with12 = G;
            _with12.SmoothingMode = SmoothingMode.HighQuality;
            _with12.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with12.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with12.Clear(BackColor);

            //-- Colors
            TB.BackColor = _BaseColor;
            TB.ForeColor = _TextColor;

            //-- Base
            _with12.FillRectangle(new SolidBrush(_BaseColor), Base);

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _BorderColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    [DefaultEvent("CheckedChanged")]
    public class FlatToggle : Control
    {
        private int W;
        private int H;
        private _Options O;
        private bool _Checked = false;
        private MouseState State = MouseState.None;

        public event CheckedChangedEventHandler CheckedChanged;
        public delegate void CheckedChangedEventHandler(object sender);

        [Flags()]
        public enum _Options
        {
            Style1,
            Style2,
            Style3,
            Style4,
            //-- TODO: New Style
            Style5
            //-- TODO: New Style
        }

        [Category("Options")]
        public _Options Options
        {
            get { return O; }
            set { O = value; }
        }

        [Category("Options")]
        public bool Checked
        {
            get { return _Checked; }
            set { _Checked = value; }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Width = 76;
            Height = 33;
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }
        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _Checked = !_Checked;
            if (CheckedChanged != null)
            {
                CheckedChanged(this);
            }
        }

        private Color BaseColor = Helpers.FlatColor;
        private Color BaseColorRed = Color.FromArgb(220, 85, 96);
        private Color BGColor = Color.FromArgb(84, 85, 86);
        private Color ToggleColor = Color.FromArgb(45, 47, 49);
        private Color TextColor = Color.FromArgb(243, 243, 243);

        public FlatToggle()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            BackColor = Color.Transparent;
            Size = new Size(44, Height + 1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10);
            Size = new Size(76, 33);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            GraphicsPath GP = new GraphicsPath();
            GraphicsPath GP2 = new GraphicsPath();
            Rectangle Base = new Rectangle(0, 0, W, H);
            Rectangle Toggle = new Rectangle(Convert.ToInt32(W / 2), 0, 38, H);

            var _with9 = G;
            _with9.SmoothingMode = SmoothingMode.HighQuality;
            _with9.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with9.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with9.Clear(BackColor);

            switch (O)
            {
                case _Options.Style1:
                    //-- Style 1
                    //-- Base
                    GP = Helpers.RoundRec(Base, 6);
                    GP2 = Helpers.RoundRec(Toggle, 6);
                    _with9.FillPath(new SolidBrush(BGColor), GP);
                    _with9.FillPath(new SolidBrush(ToggleColor), GP2);

                    //-- Text
                    _with9.DrawString("OFF", Font, new SolidBrush(BGColor), new Rectangle(19, 1, W, H), Helpers.CenterSF);

                    if (Checked)
                    {
                        //-- Base
                        GP = Helpers.RoundRec(Base, 6);
                        GP2 = Helpers.RoundRec(new Rectangle(Convert.ToInt32(W / 2), 0, 38, H), 6);
                        _with9.FillPath(new SolidBrush(ToggleColor), GP);
                        _with9.FillPath(new SolidBrush(BaseColor), GP2);

                        //-- Text
                        _with9.DrawString("ON", Font, new SolidBrush(BaseColor), new Rectangle(8, 7, W, H), Helpers.NearSF);
                    }
                    break;
                case _Options.Style2:
                    //-- Style 2
                    //-- Base
                    GP = Helpers.RoundRec(Base, 6);
                    Toggle = new Rectangle(4, 4, 36, H - 8);
                    GP2 = Helpers.RoundRec(Toggle, 4);
                    _with9.FillPath(new SolidBrush(BaseColorRed), GP);
                    _with9.FillPath(new SolidBrush(ToggleColor), GP2);

                    //-- Lines
                    _with9.DrawLine(new Pen(BGColor), 18, 20, 18, 12);
                    _with9.DrawLine(new Pen(BGColor), 22, 20, 22, 12);
                    _with9.DrawLine(new Pen(BGColor), 26, 20, 26, 12);

                    //-- Text
                    _with9.DrawString("r", new Font("Marlett", 8), new SolidBrush(TextColor), new Rectangle(19, 2, Width, Height), Helpers.CenterSF);

                    if (Checked)
                    {
                        GP = Helpers.RoundRec(Base, 6);
                        Toggle = new Rectangle(Convert.ToInt32(W / 2) - 2, 4, 36, H - 8);
                        GP2 = Helpers.RoundRec(Toggle, 4);
                        _with9.FillPath(new SolidBrush(BaseColor), GP);
                        _with9.FillPath(new SolidBrush(ToggleColor), GP2);

                        //-- Lines
                        _with9.DrawLine(new Pen(BGColor), Convert.ToInt32(W / 2) + 12, 20, Convert.ToInt32(W / 2) + 12, 12);
                        _with9.DrawLine(new Pen(BGColor), Convert.ToInt32(W / 2) + 16, 20, Convert.ToInt32(W / 2) + 16, 12);
                        _with9.DrawLine(new Pen(BGColor), Convert.ToInt32(W / 2) + 20, 20, Convert.ToInt32(W / 2) + 20, 12);

                        //-- Text
                        _with9.DrawString("ü", new Font("Wingdings", 14), new SolidBrush(TextColor), new Rectangle(8, 7, Width, Height), Helpers.NearSF);
                    }
                    break;
                case _Options.Style3:
                    //-- Style 3
                    //-- Base
                    GP = Helpers.RoundRec(Base, 16);
                    Toggle = new Rectangle(W - 28, 4, 22, H - 8);
                    GP2.AddEllipse(Toggle);
                    _with9.FillPath(new SolidBrush(ToggleColor), GP);
                    _with9.FillPath(new SolidBrush(BaseColorRed), GP2);

                    //-- Text
                    _with9.DrawString("OFF", Font, new SolidBrush(BaseColorRed), new Rectangle(-12, 2, W, H), Helpers.CenterSF);

                    if (Checked)
                    {
                        //-- Base
                        GP = Helpers.RoundRec(Base, 16);
                        Toggle = new Rectangle(6, 4, 22, H - 8);
                        GP2.Reset();
                        GP2.AddEllipse(Toggle);
                        _with9.FillPath(new SolidBrush(ToggleColor), GP);
                        _with9.FillPath(new SolidBrush(BaseColor), GP2);

                        //-- Text
                        _with9.DrawString("ON", Font, new SolidBrush(BaseColor), new Rectangle(12, 2, W, H), Helpers.CenterSF);
                    }
                    break;
                case _Options.Style4:
                    //-- TODO: New Styles
                    if (Checked)
                    {
                        //--
                    }
                    break;
                case _Options.Style5:
                    //-- TODO: New Styles
                    if (Checked)
                    {
                        //--
                    }
                    break;
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            BaseColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    [DefaultEvent("Scroll")]
    public class FlatTrackBar : Control
    {
        private int W;
        private int H;
        private int Val;
        private bool Bool;
        private Rectangle Track;
        private Rectangle Knob;
        private _Style Style_;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Val = Convert.ToInt32((float)(_Value - _Minimum) / (float)(_Maximum - _Minimum) * (float)(Width - 11));
                Track = new Rectangle(Val, 0, 10, 20);

                Bool = Track.Contains(e.Location);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Bool && e.X > -1 && e.X < (Width + 1))
            {
                Value = _Minimum + Convert.ToInt32((float)(_Maximum - _Minimum) * ((float)e.X / (float)Width));
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Bool = false;
        }

        [Flags()]
        public enum _Style
        {
            Slider,
            Knob
        }

        public _Style Style
        {
            get { return Style_; }
            set { Style_ = value; }
        }

        [Category("Colors")]
        public Color TrackColor
        {
            get { return _TrackColor; }
            set { _TrackColor = value; }
        }

        [Category("Colors")]
        public Color HatchColor
        {
            get { return _HatchColor; }
            set { _HatchColor = value; }
        }

        public event ScrollEventHandler Scroll;
        public delegate void ScrollEventHandler(object sender);

        private int _Minimum;
        public int Minimum
        {
            get
            {
                int functionReturnValue = 0;
                return functionReturnValue;
                return functionReturnValue;
            }
            set
            {
                if (value < 0)
                {
                }

                _Minimum = value;

                if (value > _Value)
                    _Value = value;
                if (value > _Maximum)
                    _Maximum = value;
                Invalidate();
            }
        }

        private int _Maximum = 10;
        public int Maximum
        {
            get { return _Maximum; }
            set
            {
                if (value < 0)
                {
                }

                _Maximum = value;
                if (value < _Value)
                    _Value = value;
                if (value < _Minimum)
                    _Minimum = value;
                Invalidate();
            }
        }

        private int _Value;
        public int Value
        {
            get { return _Value; }
            set
            {
                if (value == _Value)
                    return;

                if (value > _Maximum || value < _Minimum)
                {
                }

                _Value = value;
                Invalidate();
                if (Scroll != null)
                {
                    Scroll(this);
                }
            }
        }

        private bool _ShowValue = false;
        public bool ShowValue
        {
            get { return _ShowValue; }
            set { _ShowValue = value; }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Subtract)
            {
                if (Value == 0)
                    return;
                Value -= 1;
            }
            else if (e.KeyCode == Keys.Add)
            {
                if (Value == _Maximum)
                    return;
                Value += 1;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 23;
        }

        private Color BaseColor = Color.FromArgb(45, 47, 49);
        private Color _TrackColor = Helpers.FlatColor;
        private Color SliderColor = Color.FromArgb(25, 27, 29);
        private Color _HatchColor = Color.FromArgb(23, 148, 92);

        public FlatTrackBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Height = 18;

            BackColor = Color.FromArgb(60, 70, 73);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.UpdateColors();

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            Rectangle Base = new Rectangle(1, 6, W - 2, 8);
            GraphicsPath GP = new GraphicsPath();
            GraphicsPath GP2 = new GraphicsPath();

            var _with20 = G;
            _with20.SmoothingMode = SmoothingMode.HighQuality;
            _with20.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with20.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with20.Clear(BackColor);

            //-- Value
            Val = Convert.ToInt32((float)(_Value - _Minimum) / (float)(_Maximum - _Minimum) * (float)(W - 10));
            Track = new Rectangle(Val, 0, 10, 20);
            Knob = new Rectangle(Val, 4, 11, 14);

            //-- Base
            GP.AddRectangle(Base);
            _with20.SetClip(GP);
            _with20.FillRectangle(new SolidBrush(BaseColor), new Rectangle(0, 7, W, 8));
            _with20.FillRectangle(new SolidBrush(_TrackColor), new Rectangle(0, 7, Track.X + Track.Width, 8));
            _with20.ResetClip();

            //-- Hatch Brush
            HatchBrush HB = new HatchBrush(HatchStyle.Plaid, HatchColor, _TrackColor);
            _with20.FillRectangle(HB, new Rectangle(-10, 7, Track.X + Track.Width, 8));

            //-- Slider/Knob
            switch (Style)
            {
                case _Style.Slider:
                    GP2.AddRectangle(Track);
                    _with20.FillPath(new SolidBrush(SliderColor), GP2);
                    break;
                case _Style.Knob:
                    GP2.AddEllipse(Knob);
                    _with20.FillPath(new SolidBrush(SliderColor), GP2);
                    break;
            }

            //-- Show the value 
            if (ShowValue)
            {
                _with20.DrawString(Value.ToString(), new Font("Segoe UI", 8), Brushes.White, new Rectangle(1, 6, W, H), new StringFormat
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Far
                });
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }

        private void UpdateColors()
        {
            FlatColors colors = Helpers.GetColors(this);

            _TrackColor = colors.Flat;
        }
    }
}
namespace FlatUI
{
    public class FlatTreeView : TreeView
    {
        private TreeNodeStates State;

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            try
            {
                Rectangle Bounds = new Rectangle(e.Bounds.Location.X, e.Bounds.Location.Y, e.Bounds.Width, e.Bounds.Height);
                //e.Node.Nodes.Item.
                switch (State)
                {
                    case TreeNodeStates.Default:
                        e.Graphics.FillRectangle(Brushes.Red, Bounds);
                        e.Graphics.DrawString(e.Node.Text, new Font("Segoe UI", 8), Brushes.LimeGreen, new Rectangle(Bounds.X + 2, Bounds.Y + 2, Bounds.Width, Bounds.Height), Helpers.NearSF);
                        Invalidate();
                        break;
                    case TreeNodeStates.Checked:
                        e.Graphics.FillRectangle(Brushes.Green, Bounds);
                        e.Graphics.DrawString(e.Node.Text, new Font("Segoe UI", 8), Brushes.Black, new Rectangle(Bounds.X + 2, Bounds.Y + 2, Bounds.Width, Bounds.Height), Helpers.NearSF);
                        Invalidate();
                        break;
                    case TreeNodeStates.Selected:
                        e.Graphics.FillRectangle(Brushes.Green, Bounds);
                        e.Graphics.DrawString(e.Node.Text, new Font("Segoe UI", 8), Brushes.Black, new Rectangle(Bounds.X + 2, Bounds.Y + 2, Bounds.Width, Bounds.Height), Helpers.NearSF);
                        Invalidate();
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            base.OnDrawNode(e);
        }

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _LineColor = Color.FromArgb(25, 27, 29);

        public FlatTreeView()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;

            BackColor = _BaseColor;
            ForeColor = Color.White;
            LineColor = _LineColor;
            DrawMode = TreeViewDrawMode.OwnerDrawAll;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            Rectangle Base = new Rectangle(0, 0, Width, Height);

            var _with22 = G;
            _with22.SmoothingMode = SmoothingMode.HighQuality;
            _with22.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with22.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with22.Clear(BackColor);

            _with22.FillRectangle(new SolidBrush(_BaseColor), Base);
            _with22.DrawString(Text, new Font("Segoe UI", 8), Brushes.Black, new Rectangle(Bounds.X + 2, Bounds.Y + 2, Bounds.Width, Bounds.Height), Helpers.NearSF);


            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}
namespace FlatUI
{
    public class FormSkin : ContainerControl
    {
        private int W;
        private int H;
        private bool Cap = false;
        private bool _HeaderMaximize = false;
        private Point MousePoint = new Point(0, 0);
        private int MoveHeight = 50;

        [Category("Colors")]
        public Color HeaderColor
        {
            get { return _HeaderColor; }
            set { _HeaderColor = value; }
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color BorderColor
        {
            get { return _BorderColor; }
            set { _BorderColor = value; }
        }

        [Category("Colors")]
        public Color FlatColor
        {
            // get { return Helpers.FlatColor; }
            // set { Helpers.FlatColor = value; }
            get { return _FlatColor; }
            set { _FlatColor = value; }
        }

        [Category("Options")]
        public bool HeaderMaximize
        {
            get { return _HeaderMaximize; }
            set { _HeaderMaximize = value; }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left & new Rectangle(0, 0, Width, MoveHeight).Contains(e.Location))
            {
                Cap = true;
                MousePoint = e.Location;
            }
        }

        private void FormSkin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (HeaderMaximize)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left & new Rectangle(0, 0, Width, MoveHeight).Contains(e.Location))
                {
                    if (FindForm().WindowState == FormWindowState.Normal)
                    {
                        FindForm().WindowState = FormWindowState.Maximized;
                        FindForm().Refresh();
                    }
                    else if (FindForm().WindowState == FormWindowState.Maximized)
                    {
                        FindForm().WindowState = FormWindowState.Normal;
                        FindForm().Refresh();
                    }
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Cap = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Cap)
            {
                // Parent.Location = MousePosition - MousePoint;
                Parent.Location = new Point(
                    MousePosition.X - MousePoint.X,
                    MousePosition.Y - MousePoint.Y
                );
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ParentForm.FormBorderStyle = FormBorderStyle.None;
            ParentForm.AllowTransparency = false;
            ParentForm.TransparencyKey = Color.Fuchsia;
            ParentForm.FindForm().StartPosition = FormStartPosition.CenterScreen;
            Dock = DockStyle.Fill;
            Invalidate();
        }

        private Color _HeaderColor = Color.FromArgb(45, 47, 49);
        private Color _BaseColor = Color.FromArgb(60, 70, 73);
        private Color _BorderColor = Color.FromArgb(53, 58, 60);
        private Color _FlatColor = Helpers.FlatColor;
        private Color TextColor = Color.FromArgb(234, 234, 234);

        private Color _HeaderLight = Color.FromArgb(171, 171, 172);
        private Color _BaseLight = Color.FromArgb(196, 199, 200);
        public Color TextLight = Color.FromArgb(45, 47, 49);

        public FormSkin()
        {
            MouseDoubleClick += FormSkin_MouseDoubleClick;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 12);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width;
            H = Height;

            Rectangle Base = new Rectangle(0, 0, W, H);
            Rectangle Header = new Rectangle(0, 0, W, 50);

            var _with2 = G;
            _with2.SmoothingMode = SmoothingMode.HighQuality;
            _with2.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with2.Clear(BackColor);

            //-- Base
            _with2.FillRectangle(new SolidBrush(_BaseColor), Base);

            //-- Header
            _with2.FillRectangle(new SolidBrush(_HeaderColor), Header);

            //-- Logo
            _with2.FillRectangle(new SolidBrush(Color.FromArgb(243, 243, 243)), new Rectangle(8, 16, 4, 18));
            _with2.FillRectangle(new SolidBrush(FlatColor), 16, 16, 4, 18);
            _with2.DrawString(Text, Font, new SolidBrush(TextColor), new Rectangle(26, 15, W, H), Helpers.NearSF);

            //-- Border
            _with2.DrawRectangle(new Pen(_BorderColor), Base);

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}
namespace FlatUI
{
    public static class Helpers
    {
        public static Color FlatColor = Color.FromArgb(35, 168, 109);

        public static readonly StringFormat NearSF = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Near
        };

        public static readonly StringFormat CenterSF = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        public static GraphicsPath RoundRec(Rectangle Rectangle, int Curve)
        {
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }

        public static GraphicsPath RoundRect(float x, float y, float w, float h, double r = 0.3,
            bool TL = true, bool TR = true, bool BR = true, bool BL = true)
        {
            GraphicsPath functionReturnValue = null;
            float d = Math.Min(w, h) * (float)r;
            float xw = x + w;
            float yh = y + h;
            functionReturnValue = new GraphicsPath();

            var _with1 = functionReturnValue;
            if (TL)
                _with1.AddArc(x, y, d, d, 180, 90);
            else
                _with1.AddLine(x, y, x, y);
            if (TR)
                _with1.AddArc(xw - d, y, d, d, 270, 90);
            else
                _with1.AddLine(xw, y, xw, y);
            if (BR)
                _with1.AddArc(xw - d, yh - d, d, d, 0, 90);
            else
                _with1.AddLine(xw, yh, xw, yh);
            if (BL)
                _with1.AddArc(x, yh - d, d, d, 90, 90);
            else
                _with1.AddLine(x, yh, x, yh);

            _with1.CloseFigure();
            return functionReturnValue;
        }

        //-- Credit: AeonHack
        public static GraphicsPath DrawArrow(int x, int y, bool flip)
        {
            GraphicsPath GP = new GraphicsPath();

            int W = 12;
            int H = 6;

            if (flip)
            {
                GP.AddLine(x + 1, y, x + W + 1, y);
                GP.AddLine(x + W, y, x + H, y + H - 1);
            }
            else
            {
                GP.AddLine(x, y + H, x + W, y + H);
                GP.AddLine(x + W, y + H, x + H, y);
            }

            GP.CloseFigure();
            return GP;
        }

        /// <summary>
        /// Get the colorscheme of a Control from a parent FormSkin.
        /// </summary>
        /// <param name="control">Control</param>
        /// <returns>Colors</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static FlatColors GetColors(Control control)
        {
            if (control == null)
                throw new ArgumentNullException();

            FlatColors colors = new FlatColors();

            while (control != null && (control.GetType() != typeof(FormSkin)))
            {
                control = control.Parent;
            }

            if (control != null)
            {
                FormSkin skin = (FormSkin)control;
                colors.Flat = skin.FlatColor;
            }

            return colors;
        }
    }
}
namespace FlatUI
{
    public enum MouseState : byte
    {
        None = 0,
        Over = 1,
        Down = 2,
        Block = 3
    }
}