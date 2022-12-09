using Microsoft.EntityFrameworkCore;


using WebAPI;

public class RallyService
{
    private readonly RallyContext _dbContext;

    public RallyService(RallyContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Rally>> GetRally()
    {
        var Drivers = await _dbContext.Rally.ToListAsync();
        return Drivers;
    }

    public async Task<RallyDrivers> Create(RallyDrivers rallyDrivers)
    {
        var rallys = new Rally(rallyDrivers);
        var rally = await _dbContext.Rally.AddAsync(rallys);
        await _dbContext.SaveChangesAsync();
        return rallyDrivers;
    }

    public async Task<Rally> GetRallyID(int id)
    {
        var rallys = await _dbContext.Rally.Where(x => x.TeamID == id).FirstOrDefaultAsync();
        return rallys;
    }

      public async Task<Rally> EditData(int id, Rally rally)
    {
       var rallys = await _dbContext.Rally.Where(x => x.TeamID == id).FirstOrDefaultAsync();
       if(rallys != null)
       {
        rallys.Team_Name = rally.Team_Name;
        rallys.Country = rally.Country;
        rallys.Established_In = rally.Established_In;
        _dbContext.SaveChangesAsync();
       }

       return rallys;
    }

     public async Task<Rally> Delete(int id)
    {
       var rallys = await _dbContext.Rally.Where(x => x.TeamID == id).FirstOrDefaultAsync();
       
       _dbContext.Rally.Remove(rallys);
        await _dbContext.SaveChangesAsync();
          await _dbContext.Rally.ToListAsync();
        return rallys;
    }

}