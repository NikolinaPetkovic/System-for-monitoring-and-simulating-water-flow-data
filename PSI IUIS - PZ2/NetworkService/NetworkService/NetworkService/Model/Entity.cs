using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static NetworkService.Model.Entity;

namespace NetworkService.Model
{
    public class Entity : ValidationBase
    {
        private string textId;
        private int id;
        private string name;
        private EntityType type;
        private double value;
        private double invalidValue;


        public string TextId
        {
            get { return textId; }
            set
            {
                if (textId != value)
                {
                    textId = value;
                    OnPropertyChanged("TextId");
                }
            }
        }
        public int Id
        {
            get { return id; }
            set
            {
                if(this.id != value)
                {
                    this.id = value;
                    OnPropertyChanged(nameof(Type));
                }
            }

        }

        public string Name
        {
            get { return name; }
            set
            {
                if(this.name != value)
                {
                    this.name = value;
                    OnPropertyChanged(nameof(Type));
                }
            }
        }
        public double InvalidValue
        {
            get { return invalidValue; }
            set
            {
                if (this.invalidValue != value)
                {
                    this.invalidValue = value;
                    OnPropertyChanged(nameof(InvalidValue));
                }
            }
        }

        public double Value
        {
            get { return value; }
            set
            {
                if(this.value != value)
                {
                    this.value = value;
                    OnPropertyChanged(nameof(Value));
                }
            }
        }

        public EntityType Type
        {
            get { return type; }
            set
            {
                if(this.type != value)
                {
                    this.type = value;
                    OnPropertyChanged(nameof(Type));
                }
            }
        }

        #region ISPIS
        public override string ToString()
        {
            return $"{Id}. {Name}";
        }
        #endregion

        #region VALIDACIJA
        protected override void ValidateSelf()
        {
            int parsedId;
            bool canParse = int.TryParse(this.textId, out parsedId);

            if (!canParse)
            {
                this.ValidationErrors["Id"] = "Id must be an number.";
            }
            else if (parsedId < 0)
            {
                this.ValidationErrors["Id"] = "Id must be a positive number.";
            }
            if (this.IdExists)
            {
                this.ValidationErrors["Id"] = "Id already exists.";
            }
            if (string.IsNullOrEmpty(this.textId))
            {
                this.ValidationErrors["Id"] = "Id is requiered.";
            }
            if (string.IsNullOrEmpty(this.Name))
            {
                this.ValidationErrors["Name"] = "Name is requiered.";
            }
        }

        public bool IsValueValidForType()
        {
            bool isValid = true;

            if (Value > 735)
            {
                isValid = false;
            }
            else if (Value < 670)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }
        #endregion
    }
 }

