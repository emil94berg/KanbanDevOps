using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FirstRiderWebApp.wwwroot.lib.Model;
[Table("Kanban")]
public class Kanban : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    [Column("user_id")]
    public int User_Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("created_at")]
    public DateTime Created_At { get; set; }
}