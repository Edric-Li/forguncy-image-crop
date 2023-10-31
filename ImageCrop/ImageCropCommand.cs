using GrapeCity.Forguncy.Commands;
using GrapeCity.Forguncy.Plugin;
using System;
using System.ComponentModel;

namespace ImageCrop
{
    [Icon("pack://application:,,,/ImageCrop;component/Resources/Icon.png")]
    [Designer("ImageCrop.Designer.ImageCropCommandDesigner, ImageCrop")]
    public class ImageCropCommand : Command
    {
        [DisplayName("命令属性")]
        [FormulaProperty]
        public object MyProperty { get; set; }

        public override string ToString()
        {
            return "图片裁剪命令";
        }
    }
}
