using MoneyManager.SaraivaDev.API.Interfaces.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyManager.SaraivaDev.API.Models.Domain
{
    public class BaseModel : IModel
    {
        private string id = string.Empty;
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column(TypeName="varchar")]
        public string Id
        {
            get
            {
                if (string.IsNullOrWhiteSpace(id))
                    id = Guid.NewGuid().ToString();
                return id;
            }
            set { id = value; }
        }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
