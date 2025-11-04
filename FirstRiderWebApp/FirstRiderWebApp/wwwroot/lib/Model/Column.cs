using System.Runtime.InteropServices.JavaScript;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FirstRiderWebApp.wwwroot.lib.Model;
[Table("Column")]
public class Column : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("kanban_id")]
    public int Kanban_Id { get; set; }
    [Column("created_at")]
    public DateTime Created_At { get; set; }
}