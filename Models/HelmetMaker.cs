using System.ComponentModel.DataAnnotations;
namespace ric_avi_iskfu19.Models;

public class HelmetMaker{
    [Key]
    public Guid makeid { get; set; }

    public string makername { get; set; } = default!;

    public int makersafetyrank { get; set; }

    public int makeropenyear { get; set; }

}