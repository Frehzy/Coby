using System;

namespace Coby.Forms.CustomControls.CardView.Anim;

internal class Animation
{
    private float _targetValue;
    private readonly float _percent15;
    private readonly float _percent30;
    private readonly float _percent70;
    private readonly float _percent85;
    private readonly ControlMethod _invalidateControl;

    public string Id { get; set; }

    public float Value;

    public float StartValue;

    public float TargetValue
    {
        get => _targetValue;
        set
        {
            _targetValue = value;
            Reverse = value < Value;
        }
    }

    public float Volume;

    public bool Reverse = false;

    public AnimationStatus Status { get; set; }

    public delegate void ControlMethod();

    public Animation() { }

    public Animation(string id, ControlMethod invalidateControl, float value, float targetValue)
    {
        Id = id;

        _invalidateControl = invalidateControl;

        Value = value;
        TargetValue = targetValue;

        StartValue = value;
        Volume = targetValue - value;

        _percent15 = ValueByPercent(15);
        _percent30 = ValueByPercent(30);
        _percent70 = ValueByPercent(70);
        _percent85 = ValueByPercent(85);
    }

    private float Step()
    {
        float basicStep = Math.Abs(Volume) / 11; // Math.Abs - превращает числа 0< в >0
        float resultStep = 0;

        if (Reverse == false)
        {
            if (Value <= _percent15 || Value >= _percent85)
                resultStep = basicStep / 3.5f;

            else if (Value <= _percent30 || Value >= _percent70)
                resultStep = basicStep / 2f;

            else if (Value > _percent30 && Value < _percent70)
                resultStep = basicStep;
        }
        else
        {
            if (Value >= _percent15 || Value <= _percent85)
                resultStep = basicStep / 3.5f;

            else if (Value >= _percent30 || Value <= _percent70)
                resultStep = basicStep / 2f;

            else if (Value < _percent30 && Value > _percent70)
                resultStep = basicStep;

        }
        return Math.Abs(resultStep);
    }

    private float ValueByPercent(float Percent)
    {
        float COEFF = Percent / 100;
        float VolumeInPercent = Volume * COEFF;
        float ValueInPercent = StartValue + VolumeInPercent;

        return ValueInPercent;
    }

    public void UpdateFrame()
    {
        Status = AnimationStatus.Active;

        if (Reverse == false)
        {
            if (Value <= _targetValue)
            {
                Value += Step();

                if (Value >= _targetValue)
                {
                    Value = _targetValue;
                    Status = AnimationStatus.Completed;
                }
            }
        }
        else
        {
            if (Value >= _targetValue)
            {
                Value -= Step();

                if (Value <= _targetValue)
                {
                    Value = _targetValue;
                    Status = AnimationStatus.Completed;
                }
            }
        }

        _invalidateControl.Invoke();
    }
}