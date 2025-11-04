using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FirstRiderWebApp.wwwroot.lib.Model;
[Table("Card")]
public class Card : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("column_id")]
    public int Column_Id { get; set; }
    [Column("created_at")]
    public DateTime Created_At { get; set; }
    
}