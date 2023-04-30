using chessAPI.dataAccess.common;
namespace chessAPI.dataAccess.models;

public sealed class clsPieceEntityModel<TI, TC> : relationalEntity<TI, TC>
        where TC : struct
        where TI : struct, IEquatable<TI>
{
    public clsPieceEntityModel()
    {
        name = "";
    }

    public TI id { get; set; }
    public string name { get; set; }
    public override TI key { get => id; set => id = value; }
}