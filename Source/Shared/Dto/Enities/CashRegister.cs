namespace Shared.Dto.Enities;

public class CashRegister
{
    public decimal CashOnRegister { get; }

    public CashRegister() { }

    public CashRegister(decimal cashOnRegister)
    {
        CashOnRegister = cashOnRegister;
    }
}