using System;

namespace MoneyManager.SaraivaDev.API.Interfaces.Model
{
    public interface IModel
    {
        string Id { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
