using Microsoft.EntityFrameworkCore;
using ric_avi_iskfu19.DataModels;
using ric_avi_iskfu19.Models;

namespace ric_avi_iskfu19.Services;
public class HelmetService{

    private readonly HelmetContext _dbContext;

    public HelmetService(HelmetContext dbContext){
        _dbContext = dbContext;
    }

    public async Task <List<Helmet>> GetHelmet(){
        var helmet = await _dbContext.Helmets.ToListAsync();
        return helmet;
    }

    public async Task <HelmetMaker> Create(HelmetMaker helmetMaker){
        var helmets = new Helmet(helmetMaker);
        await _dbContext.Helmets.AddAsync(helmets);
        await _dbContext.SaveChangesAsync();
        return helmetMaker;
    }

    public async Task <Helmet> GetHelmetId(int id){
        var helmets = await _dbContext.Helmets.Where(x => x.helmetid == id).FirstOrDefaultAsync();

        return helmets;

    }

    public async Task <Helmet> ChangeHelmets(int id, Helmet helmet){
        var helmets = await _dbContext.Helmets.Where(x => x.helmetid == id).FirstOrDefaultAsync();

         helmets.helmettmaker = helmet.helmettmaker;
         helmets.helmetname = helmet.helmetname;
         helmets.helmetproductionyear = helmet.helmetproductionyear;
         helmets.helmetprice = helmet.helmetprice;

        Task<int> task = _dbContext.SaveChangesAsync();
         
       return helmets;
    }

    public async Task <Helmet> DeleteHelmet(int id){
       var helmets = await _dbContext.Helmets.Where(x => x.helmetid == id).FirstOrDefaultAsync();
       
       _dbContext.Helmets.Remove(helmets);
        await _dbContext.SaveChangesAsync();
        await _dbContext.Helmets.ToListAsync();
        return helmets;
    }
}