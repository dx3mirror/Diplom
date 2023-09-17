using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface IImageService
    {
        Image LoadImageFromBytes(byte[] imageData);
    }
}
