using System.ComponentModel.DataAnnotations;

namespace MVCViewProject.ViewModels;

public class Index
{
    [RangeAttribute(minimum: 1, maximum: 6)]
    public byte FirstFavoredFace { get; set; }

    [RangeAttribute(minimum: 1, maximum: 5)]
    public byte FirstFavorFactor { get; set; }


    [RangeAttribute(minimum: 1, maximum: 6)]
    public byte SecondFavoredFace { get; set; }

    [RangeAttribute(minimum: 1, maximum: 5)]
    public byte SecondFavorFactor { get; set; }


    [RangeAttribute(minimum: 1, maximum: 255)]
    public byte NumberOfTimesToRoll { get; set; }
}