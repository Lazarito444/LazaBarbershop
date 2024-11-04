namespace LazaBarbershop.Core.Domain.Common;

/// <summary>
/// The base class for all the non-identity entities in the app.
/// </summary>
public abstract class AppEntity
{
    /// <summary>
    /// The primary key ID of the entity.
    /// </summary>
    public int Id { get; set; }
}