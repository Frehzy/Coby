using Coby.Forms.CustomControls.CardView.Anim;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Coby.Forms.CustomControls.CardView;

internal class CustomCardView : Control
{
    private Animation _animCurtain;
    private float _curtainHeight;
    private bool _mouseEntered = false;
    private Font _fontHeader = new("Verdana", 9F, FontStyle.Regular);
    private Font _fontDescrition = new("Verdana", 9F, FontStyle.Regular);
    private Color _textColorHeader;
    private Color _textColorDescrition;
    private Color _backColorCurtain;
    private Color _strokeColor;

    public string TextHeader { get; set; } = "Header";

    public string TextDescrition { get; set; } = "Your description text for this control";

    public int CurtainHeight => (int)_animCurtain.Value;

    public CustomCardView()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw
                | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.UserPaint,
                true);
        DoubleBuffered = true;

        Size = new Size(250, 200);
        _curtainHeight = Height - 60;

        Font = new Font("Verdana", 9F, FontStyle.Regular);
        BackColor = Color.White;

        _animCurtain = new();
        _animCurtain.Value = _curtainHeight;
    }

    public void SetColorAndFont(Color backColor, Font font)
    {
        BackColor = GetColor(0.85);
        ForeColor = Color.Gray;
        _backColorCurtain = GetColor(1.15);
        _textColorHeader = Color.White;
        _textColorDescrition = Color.LightSlateGray;
        _strokeColor = Color.Gray;

        Font = new Font(font.Name, font.Size);
        _fontHeader = new Font(font.Name, ChangeFontSize(30));
        _fontDescrition = new Font(font.Name, ChangeFontSize(15));

        float ChangeFontSize(int percent) => font.Size + (font.Size * percent / 100);

        Color GetColor(double coefficient)
        {
            return Color.FromArgb(GetTone(backColor.R, coefficient),
                                  GetTone(backColor.G, coefficient),
                                  GetTone(backColor.B, coefficient));

            int GetTone(int tone, double coefficient) => (int)(tone * coefficient) > 255 ? 255 : (int)(tone * coefficient);
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics graph = e.Graphics;
        graph.SmoothingMode = SmoothingMode.HighQuality;

        graph.Clear(Parent.BackColor);

        Rectangle rect = new(0, 0, Width - 1, Height - 1);
        Rectangle rectCurtain = new(0, 0, Width - 1, (int)_animCurtain.Value);

        //Фон
        graph.FillRectangle(new SolidBrush(BackColor), rect);

        //Шторка
        graph.DrawRectangle(new Pen(_backColorCurtain), rectCurtain);
        graph.FillRectangle(new SolidBrush(_backColorCurtain), rectCurtain);

        //Обводка
        graph.DrawRectangle(new Pen(_strokeColor), rect);

        if (_animCurtain.Value == 50)
        {
            graph.DrawString(TextDescrition, _fontDescrition, new SolidBrush(_textColorDescrition),
            new Rectangle(15, 70, Width - 15, Height - 70));
        }

        graph.DrawString(Text, Font, new SolidBrush(ForeColor), 15, Height - 37);
        graph.DrawString(TextHeader, _fontHeader, new SolidBrush(_textColorHeader),
            new Rectangle(15, 15, rectCurtain.Width, rectCurtain.Height));
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);

        if (Height <= 100)
            Height = 100;
        if (Width <= 100)
            Width = 100;

        _curtainHeight = Height - 60;

        _animCurtain = new();
        _animCurtain.Value = _curtainHeight;

        Invalidate();
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        base.OnMouseClick(e);
        _mouseEntered = !_mouseEntered;
        DoCurtainAnimation(_mouseEntered);

        void DoCurtainAnimation(bool mouseEntered)
        {
            _animCurtain = mouseEntered is true
                ? new Animation("Curtain_" + Handle, Invalidate, _animCurtain.Value, 50)
                : new Animation("Curtain_" + Handle, Invalidate, _animCurtain.Value, _curtainHeight);

            Animator.Request(_animCurtain, true);
        }
    }
}