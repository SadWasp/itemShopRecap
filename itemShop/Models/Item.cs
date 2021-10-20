using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace itemShop.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Required")]
        public int Price { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Required")]
        public int Quantity { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "Required")]
        public string ImageId { get; set; }
    }
    public void InitImageManagement()
    {
        ImageReference = new ImageGUIDReference(@"/ImagesData/Items/", @"no_Item.png");
        ImageReference.MaxSize = 512;
        ImageReference.HasThumbnail = false;
    }
    public Item()
    {
        InitImageManagement();
    }
    
    public String GetImageURL()
    {
        return ImageReference.GetURL(ImageId, false);
    }
    public void SaveImage()
    {
        ImageId = ImageReference.SaveImage(ImageData, ImageId);
    }
    public void RemoveImage()
    {
        ImageReference.Remove(ImageId);
    }
}
