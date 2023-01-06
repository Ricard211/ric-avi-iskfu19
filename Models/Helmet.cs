using System.ComponentModel.DataAnnotations;
namespace ric_avi_iskfu19.Models;

public class Helmet{
    public Helmet(){

    }

    public Helmet(HelmetMaker helmetMaker)
    {

    }
[Key]
public int helmetid {get; set;}

public string helmettmaker {get; set;} = default!;
public string helmetname {get; set;} = default!;
public DateTime helmetproductionyear {get; set;}
public int helmetprice {get; set;}

}