using System.Runtime.Serialization;

namespace Ecommerce.Domain;

public enum ProductStatus
{
    [EnumMember(Value = "Producto Inativo")]
    Inativo,
    [EnumMember(Value = "Producto Activo")]
    Activo

}