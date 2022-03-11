using Office.Helper;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Office.Forms.CustomControls;

internal class CustomDateTimePicker : DateTimePicker
{
    private Color skinColor = Color.MediumSlateBlue;
    private Color textColor = Color.White;
    private Color borderColor = Color.PaleVioletRed;
    private int borderSize = 0;
    private bool droppedDown = false;
    private readonly Image calendarIcon = BitmapHelper.ResizeImage(Properties.Resources.calendar_black, 16, 16);
    private RectangleF iconButtonArea;
    private const int calendarIconWidth = 34;
    private const int arrowIconWidth = 17;

    public Color SkinColor
    {
        get { return skinColor; }
        set
        {
            skinColor = value;
            Invalidate();
        }
    }
    public Color TextColor
    {
        get { return textColor; }
        set
        {
            textColor = value;
            Invalidate();
        }
    }
    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            borderColor = value;
            Invalidate();
        }
    }
    public int BorderSize
    {
        get { return borderSize; }
        set
        {
            borderSize = value;
            Invalidate();
        }
    }

    public CustomDateTimePicker()
    {
        SetStyle(ControlStyles.UserPaint, true);
        MinimumSize = new Size(0, 35);
        Font = new Font(this.Font.Name, 9.5F);
    }

    protected override void OnDropDown(EventArgs eventargs)
    {
        base.OnDropDown(eventargs);
        droppedDown = true;
    }

    protected override void OnCloseUp(EventArgs eventargs)
    {
        base.OnCloseUp(eventargs);
        droppedDown = false;
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);
        e.Handled = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        using Graphics graphics = CreateGraphics();
        using Pen penBorder = new(borderColor, borderSize);
        using SolidBrush skinBrush = new(skinColor);
        using SolidBrush openIconBrush = new(Color.FromArgb(50, 64, 64, 64));
        using SolidBrush textBrush = new(textColor);
        using StringFormat textFormat = new();
        RectangleF clientArea = new(0, 0, Width - 0.5F, Height - 0.5F);
        RectangleF iconArea = new(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
        penBorder.Alignment = PenAlignment.Inset;
        textFormat.LineAlignment = StringAlignment.Center;

        graphics.FillRectangle(skinBrush, clientArea);

        graphics.DrawString("   " + Text, Font, textBrush, clientArea, textFormat);

        if (droppedDown == true)
            graphics.FillRectangle(openIconBrush, iconArea);

        if (borderSize >= 1)
            graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);

        graphics.DrawImage(calendarIcon, Width - calendarIcon.Width - 9, (Height - calendarIcon.Height) / 2);
    }
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        int iconWidth = GetIconButtonWidth();
        iconButtonArea = new RectangleF(Width - iconWidth, 0, iconWidth, Height);
    }
    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        Cursor = iconButtonArea.Contains(e.Location)
            ? Cursors.Hand
            : Cursors.Default;
    }

    private int GetIconButtonWidth()
    {
        int textWidh = TextRenderer.MeasureText(Text, Font).Width;
        return textWidh <= Width - (calendarIconWidth + 20)
            ? calendarIconWidth
            : arrowIconWidth;
    }
}