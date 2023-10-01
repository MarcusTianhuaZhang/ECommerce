using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EStore.Data.Enums
{
    public enum ProductCategory
    {
        GPU,
        CPU,
        Memory,
        [Display(Name = "Hard Drive")]
        HardDrive,
        [Display(Name = "Hard Drive")]
        VideoWall,
        [Display(Name = "Encoders & Decoders")]
        EncodersAndDecoders,



    }
}
