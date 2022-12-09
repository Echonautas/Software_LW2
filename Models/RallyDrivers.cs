namespace WebAPI;
[Microsoft.EntityFrameworkCore.Keyless]
public class RallyDrivers
{
    public Guid DriverID { get; set; }

    public string? Driver_Name { get; set; }

    public string? Driver_Team { get; set; }

    public string? Codriver_Name { get; set; }

    public string? Driver_Birthplace { get; set; }
}