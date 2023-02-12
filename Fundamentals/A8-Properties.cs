using System;
namespace Basics;

class Phone
{
    string brand;
    public string Brand
    {
        get
        {
            return brand;
        }

        set
        {
            if (value.Length > 1)
            {
                brand = value;
            }
        }
    }
    string model;

    DateTime releaseDate;
    public DateTime ReleaseDate
    {
        get
        {
            return releaseDate;
        }
        set
        {
            if (value < DateTime.Now)
            {
                releaseDate = value;
            }
        }
    }


    // Auto Implemented Property
    public string Model { get; set; }

    // Read-only property
    public string ChipManuFacturer { get; }

    // 
    public string Storage { get; private set; }


}