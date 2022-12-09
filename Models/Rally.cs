using System.ComponentModel.DataAnnotations;
namespace WebAPI;
[Microsoft.EntityFrameworkCore.Keyless]

public class Rally
{
    private string _name = default!;
    private int _quantity = default!;
    public Rally()
    {
    }

    public Rally(RallyDrivers rallyDrivers)
    {
        TeamID = 0;
        Team_Name = rallyDrivers.Driver_Name;
        Country = rallyDrivers.Driver_Team;
        //Established_In = rallyDrivers.Codriver_Name;
        Acting_Team_Principal = rallyDrivers.Driver_Birthplace;
    }

        [Key]
    public int TeamID { get; set; }

    public string? Team_Name { get; set; }

    public string? Country { get; set; }

    public int Established_In { get; set; }

    public string? Acting_Team_Principal { get; set; }

}