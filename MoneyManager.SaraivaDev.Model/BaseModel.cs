using System.ComponentModel.DataAnnotations;

namespace MoneyManager.SaraivaDev.Model
{
    public class BaseModel<T> : BaseEntity, IEntity<T>
    {
        public T ID { get; set; }
    }
}
