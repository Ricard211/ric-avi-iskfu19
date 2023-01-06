namespace ric_avi_iskfu19.Models;


public class Helmet{

    public Helmet(HelmetMaker helmetMaker){
        
        //will
        /*Id = Guid.NewGuid();
        Maker = helmetMake.Maker;
        Name = helmetMake.Name;
        ProductionYear = helmetMake.ProductionYear;
        Price = helmetMake.Price;*/

    }

public int HelmetId {get; set; }
public string HelmetMaker {get; set; } = default!;
public string HelmetName {get; set; } = default!;
public DateTime HelmetProductionYear {get; set; }
public int HelmetPrice {get; set; }

}