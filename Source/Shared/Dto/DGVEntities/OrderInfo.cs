using Shared.Dto.Enities;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Shared.Dto.DGVEntities;

public class OrderInfo : INotifyPropertyChanged
{
    private Guid _guestId;
    private string _guestName;
    private int _rank;
    private Guid _productId;
    private string _productName;
    private decimal? _productPrice;

    [Browsable(false)]
    public Guid GuestId
    {
        get => _guestId;
        private set => _guestId = value;
    }

    [DisplayName("Guest name")]
    public string GuestName
    {
        get => _guestName;
        set
        {
            _guestName = value;
            OnPropertyChanged();
        }
    }

    [Browsable(false)]
    public int Rank
    {
        get => _rank;
        private set => _rank = value;
    }

    [Browsable(false)]
    public Guid ProductId
    {
        get => _productId;
        private set => _productId = value;
    }

    [DisplayName("Product name")]
    public string ProductName
    {
        get => _productName;
        set
        {
            _productName = value;
            OnPropertyChanged();
        }
    }

    [DisplayName("Product price")]
    public decimal? ProductPrice
    {
        get => _productPrice;
        set
        {
            _productPrice = value;
            OnPropertyChanged();
        }
    }

    public OrderInfo(Guest guest)
    {
        GuestId = guest.Id;
        GuestName = guest.Name;
        ProductPrice = default;
    }

    public OrderInfo(Guest guest, int rank, Product product)
    {
        GuestId = guest.Id;
        GuestName = string.Empty;
        Rank = rank;
        ProductId = product.Id;
        ProductName = product.ProductName;
        ProductPrice = product.Price;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}