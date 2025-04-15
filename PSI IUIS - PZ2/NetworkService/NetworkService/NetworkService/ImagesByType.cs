using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkService
{
    public class ImagesByType
    {
        public string EntyType { get; set; }
        public ObservableCollection<Image> Images { get; set; }

        public ImagesByType()
        {
            Images = new ObservableCollection<Image>();
        }
    }
}
