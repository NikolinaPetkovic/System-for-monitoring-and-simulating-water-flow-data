using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkService.Model
{
    public class EntityType : ValidationBase
    {
        public string name { get; set; }
        public string picturePath { get; set; }

        public EntityType(string name, string picturePath)
        {
            this.name = name;
            this.picturePath = picturePath;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string PicturePath
        {
            get { return picturePath; }
            set
            {
                if (picturePath != value)
                {
                    picturePath = value;
                    OnPropertyChanged("PicturePath");
                }
            }
        }

        public EntityType()
        {
        }

        protected override void ValidateSelf()
        {
            if (this.Name == null)
            {
                this.ValidationErrors["Name"] = "Type must be selected.";
            }
        }
    }
}
