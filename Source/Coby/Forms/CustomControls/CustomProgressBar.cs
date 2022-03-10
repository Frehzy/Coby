using System;
using System.Drawing;
using System.Windows.Forms;

namespace Coby.Forms.CustomControls;

public partial class CustomProgressBar : UserControl
{
    private readonly int _progressBarStartLeft;

    public CustomProgressBar()
    {
        InitializeComponent();
        _progressBarStartLeft = ProgressBar.Left;
    }

    public void SetColor(Color color)
    {
        var dark_color = Color.FromArgb((int)(color.R * 0.7), (int)(color.G * 0.7), (int)(color.B * 0.7));
        ProgressBar.BackColor = dark_color;
    }

    public void StartProgressBar()
    {
        Timer.Enabled = true;
        Timer.Start();
    }

    public void StopProgressBar()
    {
        Timer.Enabled = false;
        Timer.Stop();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        ProgressBar.Left += 2;
        if (ProgressBar.Left >= BackPanel.Width)
            ProgressBar.Left = _progressBarStartLeft;
    }
}