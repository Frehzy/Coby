namespace Storage.Entities.Interface;

public interface IPayment : IPaymentType
{
    decimal Sum { get; }
}